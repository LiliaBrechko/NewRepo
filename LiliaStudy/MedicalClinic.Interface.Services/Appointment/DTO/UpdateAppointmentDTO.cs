using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Interface.Services.DTO
{
    public class UpdateAppointmentDTO
    {
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
       

    }
}
