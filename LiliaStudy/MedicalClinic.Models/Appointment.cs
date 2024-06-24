using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Models
{
    public class Appointment : IEntity
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        
        public int DoctorId { get; set; }
        
        public DateTime AppointmentDate { get; set; }
        public string? Reason { get; set; }

        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }
    }
}
