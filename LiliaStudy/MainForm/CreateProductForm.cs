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
    public partial class CreateProductForm : Form
    {
        private IProductService _productService;
        public CreateProductForm()
        {
            _productService = new ProductService(new EntityRepository<Product>());

            InitializeComponent();
        }

        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            var product = new CreateProductDTO(textBoxProductName.Text, double.Parse(textBoxCaloriePer100gram.Text),
                double.Parse(textBoxFatPer100gram.Text), double.Parse(textBoxProteinPer100Gram.Text),
                double.Parse(textBoxCarbohydratesPer100Gram.Text));

            _productService.Create(product);

        }
    }
}
