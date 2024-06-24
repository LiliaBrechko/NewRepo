using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Models
{
    public class Conclusion : IEntity
    {
        public int Id { get; set; }
        
        public int AppoinmentId { get; set; }
        [ForeignKey(nameof(AppoinmentId))]

        public Appointment? Appoinment { get; set; } 
        public string? Recomendation {  get; set; }


    }
}
