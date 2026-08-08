using System.ComponentModel.DataAnnotations;

namespace CampusConnect2.Models;

public class Meeting
{
    public int Id { get; set; }

    [Required] 
    public string Topic { get; set; } = string.Empty;
    
    [Required]
    public DateTime MeetingDate { get; set; }

    public MeetingStatus Status { get; set; } = MeetingStatus.Scheduled;
    
    public string? Resources { get; set; }
    
    public string? Notes { get; set; }
    
    public int StudentId { get; set; }

    public Student Student { get; set; } = null!;

}