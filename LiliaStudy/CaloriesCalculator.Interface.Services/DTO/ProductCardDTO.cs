using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class ProductCardDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double CaloriePer100Gram { get; set; }
    }
}
