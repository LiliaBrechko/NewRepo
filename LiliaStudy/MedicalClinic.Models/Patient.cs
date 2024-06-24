using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Models
{
    public class Patient : IEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public IEnumerable<Appointment>? Appointments { get; set; }
    }
}
