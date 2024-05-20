using CaloriesCalculator.Interface.Services.DTO;
using CaloriesCalculator.Models;
using CaloriesCalculator.Repository;
using CaloriesCalculator.Services;

var userRepository = new EntityRepository<User>();
var mealRepository = new EntityRepository<Meal>();
var portionRepository = new ValueRepository<Portion>();
var productRepository = new EntityRepository<Product>();
var userService = new UserServise(userRepository, mealRepository, portionRepository, productRepository);
//var LiliaID = userService.Create(new CreateUserDTO("Lilia", 32, Gender.Female, 75, 175, ActivityLevel.High, Goals.Keep));
//var lilia = userService.Get(LiliaID);
//Console.WriteLine(lilia.DailyCalorie);
//var Person2ID = userService.Create(new CreateUserDTO("Jonh", 25, Gender.Male,120, 189, ActivityLevel.Lightly, Goals.Cut));
//var Person3ID = userService.Create(new CreateUserDTO("Mike", 40, Gender.Male, 90, 192, ActivityLevel.High, Goals.Keep));
//var Person4ID = userService.Create(new CreateUserDTO("Maria", 25, Gender.Female, 44, 162, ActivityLevel.Sedentary, Goals.Bulk));




var productService = new ProductService(productRepository);

/*var Product1 = productService.Create(new CreateProductDTO("Chiken Breast", 165, 3.6, 31, 0));
var Product2 = productService.Create(new CreateProductDTO("Apple", 52, 0.2, 0.3, 14));
var Product3 = productService.Create(new CreateProductDTO("Banana", 96, 0.3, 1.3, 27));
var Product4 = productService.Create(new CreateProductDTO("Potato", 77, 0.1, 2, 17));
var Product5 = productService.Create(new CreateProductDTO("Salmon", 208, 13, 20, 0));
var Product6 = productService.Create(new CreateProductDTO("Avocado", 160, 15, 2, 9));
var Product7 = productService.Create(new CreateProductDTO("Milk", 42, 1, 3.4, 5));
var Product8 = productService.Create(new CreateProductDTO("Yogurt", 59, 0.4, 10, 3.6));

var Product9 = productService.Create(new CreateProductDTO("Cheese", 402, 33, 25, 1.3));
var Product10 = productService.Create(new CreateProductDTO("Bread", 265, 3.2, 9, 49));
var Product11 = productService.Create(new CreateProductDTO("Buckwheat", 343, 3.4, 13.3, 72.6));
var Product12 = productService.Create(new CreateProductDTO("Rice", 130, 0.3, 2.7, 28));
var Product13  = productService.Create(new CreateProductDTO("Strawberry", 32, 0.3, 0.7, 7.7));
var Product14 = productService.Create(new CreateProductDTO("Chocolate", 546, 31, 7.7, 61));
var Product15 = productService.Create(new CreateProductDTO("Olive oil", 885, 100, 0, 0));
var Product16 = productService.Create(new CreateProductDTO("Pasta", 158, 1.1, 5.8, 30));*/




var dietService = new DietService(mealRepository, portionRepository, productRepository, userRepository);
var user3Id = userRepository.GetAll().Where(x => x.Name == "Kate").First().Id;

//dietService.Create(new CreateMealDTO(user3Id, DateTime.Today, new Dictionary<int, double>
//{
//    { 16, 200 },
//    { 1, 200 }
//}
//));

//dietService.Create(new CreateMealDTO(user3Id, DateTime.Today, new Dictionary<int, double>
//{
//    { 9, 50 },
//    { 10, 100 }
//}
//));

Console.WriteLine(userService.GetCalorieToEat(user3Id, DateTime.Today));
