namespace StudyTracker.DataAccess.Models;

public class Activity
{
    public int Id { get; set; }
    public DateTime ActivityDate { get; set; }
    public double TotalHours { get; set; }
    public string? Description { get; set; }
}
