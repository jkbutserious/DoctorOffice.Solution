namespace DoctorOffice.Models
{
  public class DoctorSpecialty
  {
    public int DoctorPatientId { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public Patient Patient { get; set; }
    public Doctor Doctor { get; set;}
  }
}