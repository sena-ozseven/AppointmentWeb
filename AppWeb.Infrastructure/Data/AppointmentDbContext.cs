using Microsoft.EntityFrameworkCore;
using AppWeb.Domain.Entities;

namespace AppWeb.Infrastructure.Data;
public class AppointmentDbContext : DbContext //DbContext: EF Core'dan INHERIT olan sınıf. Db ile konuşan SERVICE; ORM SESSION
{
    //DB CONFIGURATION
    //constructor --> EF Core'u bağlar, migration yapar, DI
    public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) 
        : base(options) //java'da --> super(config) parent'a config gönderiyoruz.
    {
    }


//database'de tablo oluşturma satırları:
    public DbSet<Appointment> Appointments => Set<Appointment>();
    public DbSet<Branch> Branches => Set<Branch>();
    public DbSet<AppointmentStatusHistory> AppointmentStatusHistories => Set<AppointmentStatusHistory>();
}