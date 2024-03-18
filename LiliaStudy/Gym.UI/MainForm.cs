using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddExerciseFormOpenButton_Click(object sender, EventArgs e)
        {
            AddExerciseForm addExerciseForm = new AddExerciseForm();
            addExerciseForm.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewEditTrainingSessionButton_Click(object sender, EventArgs e)
        {
            TrainingSessionsViewEditForm trainingSessionsViewEditForm = new TrainingSessionsViewEditForm();
            trainingSessionsViewEditForm.Show();
        }

        private void ManageBodyWeightButton_Click(object sender, EventArgs e)
        {
            BodyWeightMonitorForm bodyWeightMonitorForm = new BodyWeightMonitorForm();
            bodyWeightMonitorForm.Show();
        }
    }
}
