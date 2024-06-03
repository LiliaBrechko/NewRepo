namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            var createUserForm = new CreateUserForm();
            createUserForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var createProductForm = new CreateProductForm();
            createProductForm.ShowDialog();
        }

        private void buttonCreateMeal_Click(object sender, EventArgs e)
        {
            var createMealForm = new CreateMealForm();
            createMealForm.ShowDialog();
        }
    }
}
