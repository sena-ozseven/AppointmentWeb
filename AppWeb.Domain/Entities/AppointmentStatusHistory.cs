using AppWeb.Domain.Enums;
namespace AppWeb.Domain.Entities;

//AUDIT TRAIL 

//1-N relationship w/ Appointment - AppointmentStatusHistory
//çünkü bir appointment için birden fazla kayıt olabilir.
//o yüzden AppointmentId --> foreign key
public class AppointmentStatusHistory
{
    public int Id {get;set;}

    public int AppointmentId {get;set;} //FK
    public Appointment Appointment {get;set;} = default!; //navigation property

    public AppointmentStatus FromStatus {get;set;}
    public AppointmentStatus ToStatus {get;set;}

    public DateTime ChangedAtUtc {get;set;}
    public string ChangedBy {get;set;} = "";
    public string? Comment {get;set;} //null olabilir

}
