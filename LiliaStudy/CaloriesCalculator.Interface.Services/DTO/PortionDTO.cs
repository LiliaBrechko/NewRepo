using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class PortionDTO
    {
        public int ProductId {  get; set; }
        public string ProductName {  get; set; }
        public double Ammount {  get; set; }
    }
}
