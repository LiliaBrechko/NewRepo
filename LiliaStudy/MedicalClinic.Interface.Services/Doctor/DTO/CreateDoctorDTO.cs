using MedicalClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Interface.Services.DTO
{
    public class CreateDoctorDTO
    {
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DoctorType Specialization { get; set; }
    }
}
