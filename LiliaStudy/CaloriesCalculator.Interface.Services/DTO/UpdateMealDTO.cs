using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class UpdateMealDTO
    {
        public DateTime DateTime { get; set; }
        public IDictionary<int, double>? Portions { get; set; }
    }
}
