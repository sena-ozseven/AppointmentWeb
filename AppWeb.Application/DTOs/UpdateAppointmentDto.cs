namespace AppWeb.Application.DTOs;
public class UpdateAppointmentDto
{
    public string Title { get; set; } = "";
    public string RequestedBy { get; set; } = "";
    
    public DateOnly RequestDate { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public int BranchId { get; set; } // kullanıcı randevuyu başka şubeye taşıyabilir
}
