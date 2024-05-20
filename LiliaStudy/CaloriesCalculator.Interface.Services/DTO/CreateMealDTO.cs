using CaloriesCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services.DTO
{
    public class CreateMealDTO
    {
        public CreateMealDTO(int userID, DateTime dateTime, IDictionary<int, double>? portions)
        {
            UserID = userID;
            DateTime = dateTime;
            Portions = portions;
        }

        public int UserID { get; set; }
        public DateTime DateTime { get; set; }
        public IDictionary<int, double>? Portions { get; set; }

        
    }
}
