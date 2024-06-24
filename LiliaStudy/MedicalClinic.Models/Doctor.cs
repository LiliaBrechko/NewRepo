namespace MedicalClinic.Models
{
    public class Doctor : IEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DoctorType Specialization { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }
        

    }
}
