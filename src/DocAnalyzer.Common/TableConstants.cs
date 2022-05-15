namespace DocAnalyzer.Common
{
    public static class TableConstants
    {
        public const string Mandatory = "1. ОБОВ'ЯЗКОВІ КОМПОНЕНТИ ОП";
        public const string Selective = "2. ВИБІРКОВІ КОМПОНЕНТИ ОП за вільним вибором студента";
        public const string General = "Загальні";
        public const string Professional = "Професійні";

        public static ColumnConstant NumberSymbol = new(1, "№");
        public static ColumnConstant SubjectName = new(2, "Назва освітньіх компонентів");
        public static ColumnConstant Exams = new(3, "Екзамени");
        public static ColumnConstant Tests = new(4, "Заліків");
        public static ColumnConstant Projects = new(5, "проекти");
        public static ColumnConstant Works = new(6, "роботи");
        public static ColumnConstant Credits = new(7, "Кількість кредитів ECTS");
        public static ColumnConstant Total = new(8, "Загальний обсяг");
        public static ColumnConstant TotalClass = new(9, "разом");
        public static ColumnConstant Lecture = new(10, "лекції");
        public static ColumnConstant Labs = new(11, "лаб зан");
        public static ColumnConstant Practical = new(12, "пр зан");
        public static ColumnConstant Individual = new(13, "СРС поза ауд.");
    }

    public class ColumnConstant
    {
        public ColumnConstant(int id, string value)
        {
            Id = id;
            Value = value;
        }
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
