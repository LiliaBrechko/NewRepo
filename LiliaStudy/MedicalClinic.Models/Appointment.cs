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
        [ForeignKey("PatientId")]
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public DateTime AppointmentDate { get; set; }
        public string? Reason { get; set; }
        public string? Recomendation { get; set; }

        public Patient? Patient { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
