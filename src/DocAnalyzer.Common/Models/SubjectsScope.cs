namespace DocAnalyzer.Common.Models;

public class SubjectsScope
{
    public SubjectsScope(SubjectType type)
    {
        SubjectType = type;
    }
    public SubjectType SubjectType { get;}
    public IList<Subject> Subjects { get; set; }
    public TotalSubjectsScope TotalSubjectsScope { get; set; }
}