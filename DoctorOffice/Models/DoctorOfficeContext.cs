using Microsoft.EntityFrameworkCore;

namespace DoctorOffice.Models
{
  public class DoctorOfficeContext : DbContext
  {
    public virtual DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<DoctorPatient> DoctorPatient {get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<DoctorSpecialty> DoctorSpecialty { get; set; }

    public DoctorOfficeContext(DbContextOptions options) : base(options) { }
  }
}