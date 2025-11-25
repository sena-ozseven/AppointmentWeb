namespace AppWeb.Application.DTOs;

public class UpdateAppointmentStatusDto
{
    public int AppointmentId { get; set; }   
    
    public string NewStatus { get; set; } = "";   
    
    public string? RejectionReason { get; set; }  // sadece rejected ise zorunlu
}
