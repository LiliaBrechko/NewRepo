using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Interface.Services.DTO
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public int PatientId { get; set; }        
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? Reason { get; set; }
      
    }
}
