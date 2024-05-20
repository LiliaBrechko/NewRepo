using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class UpdateProductDTO
    {
        public string? Name { get; set; }
        public double CaloriePer100Gram { get; set; }
        public double FatPer100Gram { get; set; }
        public double ProteinPer100Gram { get; set; }
        public double CarbohydratesPer100Gram { get; set; }
    }
}
