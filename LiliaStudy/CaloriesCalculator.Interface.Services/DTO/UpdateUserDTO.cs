using CaloriesCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class UpdateUserDTO
    {
        public UpdateUserDTO(int age, double weight, ActivityLevel activityLevel, Goals goals)
        {
            Age = age;
            Weight = weight;
            ActivityLevel = activityLevel;
            Goals = goals;
        }

        public int Age { get; set; }      
        public double Weight { get; set; }       
        public ActivityLevel ActivityLevel { get; set; }
        public Goals Goals { get; set; }
    }
}
