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
    }
}
