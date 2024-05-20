using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaloriesCalculator.Models;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class CreateUserDTO 
    {
        public CreateUserDTO(string? name, int age, Gender gender, double weight, double growth, ActivityLevel activityLevel, Goals goals)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
            Growth = growth;
            ActivityLevel = activityLevel;
            Goals = goals;
        }

        public string? Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public double Weight { get; set; }
        public double Growth { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public Goals Goals { get; set; }
    }
}
