using CaloriesCalculator.Interface.Services.DTO;
using CaloriesCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCalculator.Interface.Services
{
    public interface IDietService
    {
        int Create(CreateMealDTO createProductDTO);
        void Update(int id, UpdateMealDTO updateProductDTO);
        MealCardDTO Get(int id);
        IEnumerable<MealCardDTO> GetAll();
        void Delete(int id);

        



    }
}
