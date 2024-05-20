using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Models
{
    public class Meal : IEntity
    {
        public int Id { get; set; }
        public int UserID {  get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<Portion>? Portions { get; set; }

        [ForeignKey("UserID")]
        public User? User { get; set; }
    }
}
