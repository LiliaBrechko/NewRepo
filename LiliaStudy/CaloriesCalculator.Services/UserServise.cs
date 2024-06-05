using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaloriesCalculator.Interface.Repository;
using CaloriesCalculator.Interface.Services;
using CaloriesCalculator.Interface.Services.DTO;
using CaloriesCalculator.Models;

namespace CaloriesCalculator.Services
{
    public class UserServise : IUserService
    {
        private readonly IEntityRepository<User> _userRepository;
        private readonly IEntityRepository<Meal> _mealsrepository;
        private readonly IValueRepository<Portion> _portionrepository;
        private readonly IEntityRepository<Product> _productRepository;

        public UserServise(IEntityRepository<User> userRepository, IEntityRepository<Meal> mealRepository, IValueRepository<Portion> portionrepository, IEntityRepository<Product> productRepository)
        {
            _userRepository = userRepository;
            _mealsrepository = mealRepository;
            _portionrepository = portionrepository;
            _productRepository = productRepository;
        }

        public int Create(CreateUserDTO createUserDTO)
        {
            var user = new User
            { Name = createUserDTO.Name, 
              ActivityLevel = createUserDTO.ActivityLevel,
              Age = createUserDTO.Age,
              Gender = createUserDTO.Gender,
              Goals = createUserDTO.Goals,
              Growth = createUserDTO.Growth,
              Weight = createUserDTO.Weight,
              DailyCalorie = CalculateCalories(createUserDTO.Gender, createUserDTO.Weight, createUserDTO.Growth, createUserDTO.Age,
              createUserDTO.ActivityLevel, createUserDTO.Goals)
              
            };
            return _userRepository.Create(user);
           
        }

        public void Delete(int id)
        {
             _userRepository.Delete(id);
            
        }

        public UserCardDTO Get(int id)
        {
            var user = _userRepository.Get(id);
            var cardtoreturn = new UserCardDTO()
            {
                Id = user.Id,
                Name = user.Name,
                Age = user.Age,
                Gender = user.Gender,
                DailyCalorie = user.DailyCalorie
            };
            return cardtoreturn;
        }

        public IEnumerable<UserCardDTO> GetAll()
        {
            return _userRepository.GetAll().Select(x => new UserCardDTO()
            {
                Id = x.Id,
                Name = x.Name,
                Age = x.Age,
                Gender = x.Gender,
                DailyCalorie = x.DailyCalorie
            });
        }

        public double GetCalorieToEat(int userId, DateTime dateTime)
        {
            var dailyCalorie = _userRepository.Get(userId).DailyCalorie;
           
            var dailyMealIds = _mealsrepository.GetAll().Where(x => x.UserID == userId && x.DateTime.Date == dateTime.Date).
                Select(x => x.Id).ToList();
            var portions = _portionrepository.GetAll().Where(x => dailyMealIds.Contains(x.MealId)).
                Select(x => new { x.ProductId, x.Ammount }).ToArray();
            var productCalorieMap = _productRepository.GetAll().Where(x => portions.Select(y => y.ProductId).Contains(x.Id)).
                ToDictionary(key => key.Id, value => value.CaloriePer100Gram);


            return dailyCalorie - portions.Select(portion => (portion.Ammount / 100) * productCalorieMap[portion.ProductId]).Sum();

          

        }

        public void Update(int id, UpdateUserDTO updateUserDTO)
        {
            var usertoupdate = _userRepository.Get(id);

            

            if ((usertoupdate.Weight != updateUserDTO.Weight) || (usertoupdate.Age != updateUserDTO.Age) ||
                (usertoupdate.ActivityLevel != updateUserDTO.ActivityLevel) || (usertoupdate.Goals != updateUserDTO.Goals))
            {
                usertoupdate.DailyCalorie = CalculateCalories(usertoupdate.Gender, updateUserDTO.Weight, usertoupdate.Growth, updateUserDTO.Age,
                              updateUserDTO.ActivityLevel, updateUserDTO.Goals);
            }

            usertoupdate.Age = updateUserDTO.Age;
            usertoupdate.Weight = updateUserDTO.Weight;
            usertoupdate.ActivityLevel = updateUserDTO.ActivityLevel;
            usertoupdate.Goals = updateUserDTO.Goals;

            _userRepository.Update(id, usertoupdate);

        }

        private  double CalculateCalories(Gender gender, double weight, double height, int age, ActivityLevel activityLevel, Goals goal)
        {
            double bmr; 
            if (gender == Gender.Male)
            {
                bmr = 88.36 + (13.4 * weight) + (4.8 * height) - (5.7 * age);
            }
            else
            {
                bmr = 447.6 + (9.2 * weight) + (3.1 * height) - (4.3 * age);
            }

            switch (activityLevel)
            {
                case ActivityLevel.Sedentary:
                    bmr = bmr * 1.2;
                    break;
                case ActivityLevel.Lightly:
                    bmr = bmr * 1.375;
                    break;
                case ActivityLevel.Moderately:
                    bmr = bmr * 1.55;
                    break;
                case ActivityLevel.High:
                    bmr = bmr * 1.725;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            switch (goal)
            {
                case Goals.Cut:
                    return bmr - 500; 
                case Goals.Keep:
                    return bmr; 
                case Goals.Bulk:
                    return bmr + 500; 
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

    }
}
