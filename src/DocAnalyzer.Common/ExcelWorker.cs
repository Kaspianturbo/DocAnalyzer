using OfficeOpenXml;

namespace DocAnalyzer.Common
{
    internal class ExcelWorker
    {
        public ExcelWorker()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var file = new FileInfo(@"C:\Users\Viktor\Desktop\DocAnalyzer\073 МВКД  ДФ 1 курс - акр 2022.xls");

        }
    }
}
