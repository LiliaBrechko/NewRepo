using CaloriesCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class MealCardDTO
    {
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public IEnumerable<PortionDTO>? Portions { get; set; }
    }
}
