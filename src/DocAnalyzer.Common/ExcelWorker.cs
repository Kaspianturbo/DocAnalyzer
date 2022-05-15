using DocAnalyzer.Common.Extensions;
using OfficeOpenXml;
using DocAnalyzer.Common.Models;

namespace DocAnalyzer.Common
{
    public class ExcelWorker
    {
        private readonly FileInfo _file;
        public ExcelWorker(FileInfo file)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            
            _file = file;
        }


        public string ReadCurriculum()
        {
            ExcelWorksheet sheet;
            using (var package = new ExcelPackage(_file))
            {
                sheet = package.Workbook.Worksheets[1];
            }

            var curriculum = new Сurriculum();
            
            curriculum.Id = 0;
            curriculum.File = _file;
            curriculum.SubjectScope = GetSubjectsScopes(sheet);

            var subject = new Subject();

            return package.Workbook.Worksheets[1].Cells["A7"].Value.ToString();
        }

        private static void GetStartOfTable(ExcelWorksheet sheet, out int startColumn, out int startRow)
        {
            const int maxSearchDepth = 20;
            startColumn = 1;
            startRow = 1;
            for (var c = startColumn; c < maxSearchDepth; c++)
            {
                for (var r = startRow; r < maxSearchDepth; r++)
                {
                    if (sheet.Cells[r, c].Value?.ToNormalizedString() != TableConstants.NumberSymbol.Value ||
                        sheet.Cells[r + 4, c].Value?.ToNormalizedString() != TableConstants.NumberSymbol.Id.ToString()) continue;
                    startColumn = c;
                    startRow = r + 4;
                    return;
                }
            }

            throw new InvalidDataException($"The table is not found. Search depth: {maxSearchDepth}");
        }

        private static IList<SubjectsScope> GetSubjectsScopes(ExcelWorksheet sheet)
        {
            GetStartOfTable(sheet, out var startColumn, out var startRow);

            List<SubjectsScope> resultList = new();

            //SubjectsScope subjectsScope = 
            SubjectsScope subjectsScope = new(GetSubjectType(sheet, startRow, startColumn));
            subjectsScope.Subjects = GetSubjectsScope(sheet, startRow, startColumn);

            subjectsScope1.Subjects = GetSubjectsScope();

            return resultList;
        }

        private static SubjectType GetSubjectType(ExcelWorksheet sheet, int startRow, int startColumn)
        {
            var subjectType1 = sheet.Cells[startRow + 1, startColumn + 1].Value?.ToNormalizedString();
            var subjectType2 = sheet.Cells[startRow + 2, startColumn + 1].Value?.ToNormalizedString();

            if (subjectType1.Equals(TableConstants.Mandatory, StringComparison.CurrentCultureIgnoreCase)
                && subjectType2.Equals(TableConstants.General, StringComparison.CurrentCultureIgnoreCase))
            {
                return SubjectType.GeneralMandatory;
            }

            if (subjectType1.Equals(TableConstants.Selective, StringComparison.CurrentCultureIgnoreCase)
                && subjectType2.Equals(TableConstants.General, StringComparison.CurrentCultureIgnoreCase))
            {
                return SubjectType.GeneralSelective;
            }

            if (subjectType1.Equals(TableConstants.Mandatory, StringComparison.CurrentCultureIgnoreCase)
                && subjectType2.Equals(TableConstants.Professional, StringComparison.CurrentCultureIgnoreCase))
            {
                return SubjectType.ProfessionalMandatory;
            }

            if (subjectType1.Equals(TableConstants.Selective, StringComparison.CurrentCultureIgnoreCase)
                && subjectType2.Equals(TableConstants.Professional, StringComparison.CurrentCultureIgnoreCase))
            {
                return SubjectType.ProfessionalSelective;
            }

            throw new InvalidDataException("Subject type is not found.");
        }

        private static IList<Subject> GetSubjectsScope(ExcelWorksheet sheet, int startRow, int startColumn)
        {
            
        }
    }
}
