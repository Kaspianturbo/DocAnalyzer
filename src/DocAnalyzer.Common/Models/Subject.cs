namespace DocAnalyzer.Common.Models;

public class Subject
{
    public string Number { get; set; }
    public string Name { get; set; }
    public DistributionBySemesters DistributionBySemesters { get; set; }
    public int CreditsEcts { get; set; }
    public CountOfHours CountOfHours { get; set; }
    public IList<DistributionByCourse> DistributionByCourses { get; set; }
    public string CathedraName { get; set; }

}