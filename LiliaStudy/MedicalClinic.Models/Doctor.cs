namespace MedicalClinic.Models
{
    public class Doctor : IEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Specialization { get; set; }
        public IEnumerable<Appointment>? Appointments { get; set; }

    }
}
