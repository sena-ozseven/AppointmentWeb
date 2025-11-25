namespace AppWeb.Application.DTOs;

public class AppointmentCreateDTO
{
    public int BranchId { get; set; }
    public string? Description { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string RequestedBy { get; set; } = default!;
}

public class AppointmentUpdateDto
{
    public string? Description { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
}

public class AppointmentListItemDto
{
    public int Id { get; set; }
    public string BranchName { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int Status { get; set; }
    public string RequestedBy { get; set; } = default!;
}