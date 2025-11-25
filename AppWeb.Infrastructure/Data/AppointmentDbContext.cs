using Microsoft.EntityFrameworkCore;
using AppWeb.Domain.Entities;

namespace AppWeb.Infrastructure.Data;
public class AppointmentDbContext : DbContext
{
    public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) 
        : base(options)
    {
    }

    public DbSet<Appointment> Appointments => Set<Appointment>();
    public DbSet<Branch> Branches => Set<Branch>();
    public DbSet<AppointmentStatusHistory> AppointmentStatusHistories => Set<AppointmentStatusHistory>();
}