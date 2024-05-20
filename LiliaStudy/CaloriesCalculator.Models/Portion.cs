using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Models
{
    public class Portion
    {
        public int MealId {  get; set; }
        public int ProductId { get; set; }
        public double Ammount { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        [ForeignKey("MealId")]
        public Meal? Meal { get; set; }
    }
}
