using CaloriesCalculator.Interface.Services;
using CaloriesCalculator.Interface.Services.DTO;
using CaloriesCalculator.Models;
using CaloriesCalculator.Repository;
using CaloriesCalculator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class CreateMealForm : Form
    {
        private readonly IUserService _userService;
        private readonly IDietService _dietService;
        private readonly IProductService _productService;
        public CreateMealForm()
        {
            var userRepository = new EntityRepository<User>();
            var mealRepository = new EntityRepository<Meal>();
            var productRepository = new EntityRepository<Product>();
            var portionRepository = new ValueRepository<Portion>();

            _userService = new UserServise(userRepository, mealRepository,
                portionRepository, productRepository);

            _dietService = new DietService(mealRepository, portionRepository,
               productRepository, userRepository);
            InitializeComponent();

            _productService = new ProductService(productRepository);
        }

        private void CreateMealForm_Load(object sender, EventArgs e)
        {
            var allusers = _userService.GetAll().ToList();
            comboBoxUsers.DataSource = allusers;
            comboBoxUsers.Format += Combobox_UsersFormat;

            var allproducts = _productService.GetAll().ToList();
            comboBoxProducts.DataSource = allproducts;
            comboBoxProducts.Format += Combobox_ProductsFormat;
        }

        private void Combobox_UsersFormat(object? sender, ListControlConvertEventArgs e)
        {

            UserCardDTO item = (UserCardDTO)e.ListItem!;

            e.Value = $"{item.Name}";

        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userName = ((UserCardDTO)comboBoxUsers.SelectedItem).Name;
            var meals = _dietService.GetAll().Where(meal => meal.UserName == userName).ToArray();
            listBoxMeals.DataSource = meals;
            listBoxMeals.Format += Listbox_MealsFormat;
        }

        private void Listbox_MealsFormat(object? sender, ListControlConvertEventArgs e)
        {

            MealCardDTO item = (MealCardDTO)e.ListItem!;

            e.Value = $"{item.DateTime.ToShortDateString()} {item.DateTime.ToLongTimeString()}";

        }

        private void listBoxMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userName = ((UserCardDTO)comboBoxUsers.SelectedItem).Name;
            var meals = _dietService.GetAll().Where(meal => meal.UserName == userName).ToArray();
            listBoxPortions.DataSource = meals.FirstOrDefault(meal => meal.DateTime == ((MealCardDTO)listBoxMeals.SelectedItem).DateTime).Portions.ToList();
            listBoxPortions.Format += Listbox_PortionsFormat;

        }

        private void Listbox_PortionsFormat(object? sender, ListControlConvertEventArgs e)
        {

            PortionDTO item = (PortionDTO)e.ListItem!;

            e.Value = $"{item.ProductName} {item.Ammount} gramm";

        }

        private void Combobox_ProductsFormat(object? sender, ListControlConvertEventArgs e)
        {

            ProductCardDTO item = (ProductCardDTO)e.ListItem!;

            e.Value = $"{item.Name}";

        }

        private void listBoxPortions_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortionDTO portion = (PortionDTO)listBoxPortions.SelectedItem;
            textBoxAmmount.Text = portion.Ammount.ToString();

            foreach (ProductCardDTO item in comboBoxProducts.Items)
            {
                if (item.Name == portion.ProductName)
                {
                    comboBoxProducts.SelectedIndex = comboBoxProducts.Items.IndexOf(item);

                }
            }

        }

        private void buttonCreateMeal_Click(object sender, EventArgs e)
        {
           UserCardDTO currentUser = (UserCardDTO)comboBoxUsers.SelectedItem;
            var ammount = double.Parse(textBoxAmmount.Text);
            var productId = ((ProductCardDTO)comboBoxProducts.SelectedItem).Id;
            var portions = new Dictionary<int, double>();
            portions.Add(productId, ammount);
            var newMeal = new CreateMealDTO(currentUser.Id, DateTime.Now, portions);
            _dietService.Create(newMeal);
        }
    }
}
