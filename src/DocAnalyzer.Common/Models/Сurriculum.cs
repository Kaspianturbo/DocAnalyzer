namespace DocAnalyzer.Common.Models
{
    public class Сurriculum
    {
        public int Id { get; set; }
        public FileInfo File { get; set; }
        public IList<SubjectsScope> SubjectScope { get; set; }
    }
}
