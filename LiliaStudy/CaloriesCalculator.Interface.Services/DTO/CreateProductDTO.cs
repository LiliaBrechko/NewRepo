using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class CreateProductDTO
    {
        public CreateProductDTO(string? name, double caloriePer100Gram, double fatPer100Gram, double proteinPer100Gram, double carbohydratesPer100Gram)
        {
            Name = name;
            CaloriePer100Gram = caloriePer100Gram;
            FatPer100Gram = fatPer100Gram;
            ProteinPer100Gram = proteinPer100Gram;
            CarbohydratesPer100Gram = carbohydratesPer100Gram;
        }

        public string? Name { get; set; }
        public double CaloriePer100Gram { get; set; }
        public double FatPer100Gram { get; set; }
        public double ProteinPer100Gram { get; set; }
        public double CarbohydratesPer100Gram { get; set; }
    }
}
