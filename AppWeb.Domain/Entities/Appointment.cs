using AppWeb.Domain.Enums;
namespace AppWeb.Domain.Entities;

public class Appointment
{
    public int Id {get; set; }
    public string Title {get;set;} = "";
    public string RequestedBy {get;set;} = "";
    public DateOnly RequestDate {get;set;}
    public TimeOnly StartTime {get;set;}
    public TimeOnly EndTime {get;set;}
    public AppointmentStatus Status {get;set;} = AppointmentStatus.Draft;

    //1(brach)-N(appointment) relationship 
    public int BranchId {get;set;} //foreign key
    public Branch Branch {get;set;} = default!; //navigation property
    // default! --> nullability warning suppressor (nullable olamaz demek için)
    


}