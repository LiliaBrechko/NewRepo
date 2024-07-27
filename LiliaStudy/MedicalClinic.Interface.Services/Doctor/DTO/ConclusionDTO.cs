using MedicalClinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Interface.Services.DTO
{
    public class ConclusionDTO
    {
        public int Id { get; set; }
       public AppointmentDTO? Appoinment { get; set; }
        public string? Recomendation { get; set; }
    }
}
