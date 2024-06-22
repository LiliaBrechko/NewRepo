using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Interface.Services.DTO
{
    public class UpdateAppointmentDTO
    {

        public DateTime AppointmentDate { get; set; }
        public string? Reason { get; set; }
        public string? Recomendation { get; set; }
    }
}
