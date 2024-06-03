using CaloriesCalculator.Infrastructure.Migrations;
using CaloriesCalculator.Interface.Repository;
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
    public partial class CreateUserForm : Form
    {
        private readonly IUserService userService;

        public CreateUserForm()
        {
            userService = new UserServise(new EntityRepository<User>(), new EntityRepository<Meal>(),
                 new ValueRepository<Portion>(), new EntityRepository<Product>());
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var gender = comboBoxGender.SelectedItem.ToString();
            var genderenum = (Gender)Enum.Parse(typeof(Gender), gender);

            var activitylevel = comboBoxActivityLevel.SelectedItem.ToString();
            var activitylevelenum = (ActivityLevel)Enum.Parse(typeof(ActivityLevel), activitylevel);

            var goal = comboBoxGoal.SelectedItem.ToString();
            var goalenum = (Goals)Enum.Parse(typeof(Goals), goal);
            var user = new CreateUserDTO(textBoxName.Text, int.Parse(textBoxAge.Text), genderenum, double.Parse(textBoxWeight.Text),
                double.Parse(textBoxHeight.Text), activitylevelenum, goalenum );

            userService.Create(user);
        }

      

      

     
    }
}
