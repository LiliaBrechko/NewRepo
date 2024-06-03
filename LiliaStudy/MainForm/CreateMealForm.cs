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
        public CreateMealForm()
        {
            _userService = new UserServise(new EntityRepository<User>(), new EntityRepository<Meal>(), 
                new ValueRepository<Portion>(), new EntityRepository<Product>());
            InitializeComponent();
        }

        private void CreateMealForm_Load(object sender, EventArgs e)
        {
           var allusers =  _userService.GetAll().ToList();  
           comboBoxUsers.DataSource = allusers;
           comboBoxUsers.Format += Combobox_UsersFormat;
        }

        private void Combobox_UsersFormat(object? sender, ListControlConvertEventArgs e)
        {

            UserCardDTO item = (UserCardDTO)e.ListItem!;
            
            e.Value = $"{item.Name}";

        }
    }
}
