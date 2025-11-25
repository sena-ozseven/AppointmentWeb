namespace AppWeb.Domain.Entities;

//şube/lokasyon
// one to many ilişkisi var appointment ile
public class Branch
{
    public int Id {get; set; }
    public string Name {get; set; } = "";
    public string Location {get; set; } = "";
}