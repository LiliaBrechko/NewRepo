using CaloriesCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class UserCardDTO
    {
        public int Id { get; set; }
        public string? Name {  get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public double DailyCalorie {  get; set; }
        
       
        
    }
}
