using System;

namespace AppWeb.Application.DTOs;

public class CreateAppointmentDto
{
    public int BranchId { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
}
