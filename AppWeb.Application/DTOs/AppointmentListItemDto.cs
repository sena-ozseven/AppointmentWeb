using AppWeb.Domain.Enums;

namespace AppWeb.Application.DTOs;

public class AppointmentListItemDto
{
    public int Id { get; set; }

    public string Title { get; set; } = "";
    public string RequestedBy { get; set; } = "";
    
    public DateOnly RequestDate { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public AppointmentStatus Status { get; set; }

    // navigation data
    public string BranchName { get; set; } = "";
}