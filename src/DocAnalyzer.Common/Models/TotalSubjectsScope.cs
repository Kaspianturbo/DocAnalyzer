namespace DocAnalyzer.Common.Models;

public class TotalSubjectsScope
{
    public int CreditsEctsTotal { get; set; }
    public int LecturesTotal { get; set; }
    public int LaboratoryTotal { get; set; }
    public int PracticalTotal { get; set; }
    public int IndividualTotal { get; set; }
    public IList<DistributionByCourseTotal> DistributionByCourseTotals { get; set; }
}