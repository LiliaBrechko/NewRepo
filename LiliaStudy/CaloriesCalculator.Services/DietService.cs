using CaloriesCalculator.Interface.Services;
using CaloriesCalculator.Interface.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaloriesCalculator.Interface.Repository;
using CaloriesCalculator.Models;

namespace CaloriesCalculator.Services
{

    public class DietService : IDietService
    {
        private readonly IEntityRepository<Meal> _mealsrepository;
        private readonly IValueRepository<Portion> _portionrepository;
        private readonly IEntityRepository<Product> _productrepository;
        private readonly IEntityRepository<User> _userrepository;

        public DietService(IEntityRepository<Meal> mealsrepository, IValueRepository<Portion> portionrepository, IEntityRepository<Product> productrepository, IEntityRepository<User> userrepository)
        {
            _mealsrepository = mealsrepository;
            _portionrepository = portionrepository;
            _productrepository = productrepository;
            _userrepository = userrepository;
        }

        

        public int Create(CreateMealDTO createProductDTO)
        {
            var meal = new Meal
            {
                UserID = createProductDTO.UserID,
                DateTime = DateTime.Now
            };
            var mealid = _mealsrepository.Create(meal);

            foreach (var p in createProductDTO.Portions)
            {
                var portion = new Portion
                {
                    MealId = mealid,
                    ProductId = p.Key,
                    Ammount = p.Value,
                };
                _portionrepository.Create(portion);
            }
            return mealid;
        }

        public void Delete(int id)
        {
            _mealsrepository.Delete(id);
        }

        public MealCardDTO Get(int id)
        {
            var meal = _mealsrepository.Get(id);
            var card = new MealCardDTO
            {
                DateTime = meal.DateTime,
                UserName = _userrepository.Get(meal.UserID).Name,
                Portions = _portionrepository.GetAll().Where(p => p.MealId == id).Select(p => new PortionDTO
                {
                    Ammount = p.Ammount,
                    ProductName = _productrepository.Get(p.ProductId).Name
                })


            };
            return card;
        }

        public IEnumerable<MealCardDTO> GetAll()
        {
            return _mealsrepository.GetAll().Select(meal => new MealCardDTO
            {
                DateTime = meal.DateTime,
                UserName = _userrepository.Get(meal.UserID).Name,
                Portions = _portionrepository.GetAll().Where(portion => portion.MealId == meal.Id).
                Select(portion => new PortionDTO
                {
                    Ammount = portion.Ammount,
                    ProductName = _productrepository.Get(portion.ProductId).Name
                })
            });
        }

        public void Update(int id, UpdateMealDTO updateMealDTO)
        {
            var existingportions = _portionrepository.GetAll().Where(i => i.MealId == id);
            _portionrepository.Delete(existingportions.ToArray());

            foreach (var portion in updateMealDTO.Portions)
            {
                var newportion = new Portion
                {
                    MealId = id,
                    ProductId = portion.Key,
                    Ammount = portion.Value,
                };
                _portionrepository.Create(newportion);
            }


            var meal = _mealsrepository.Get(id);
            meal.DateTime = updateMealDTO.DateTime;
            _mealsrepository.Update(id, meal);
        }
    }
}
