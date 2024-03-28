using GYM.Interface.Services.Profile;
using GYM.Interface.Services.Profile.Dto;
using GYM.Interface.Services.Sets.Dto;
using GYM.Models;
using GYM.Repositories;
using GYM.Services;

namespace Gym.UI
{
    public partial class MainForm : Form
    {
        private readonly IProfileService profileService = new ProfileService(new Repository<Profile>());

        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshProfilesCache(int? index = null)
        {
            try
            {
                comboBoxProfile.Text = String.Empty;
                var newIndex = index ?? comboBoxProfile.SelectedIndex;
                var profilesCache = profileService.GetAllProfiles().Where(s => s.IsActive).ToList();

                comboBoxProfile.DataSource = profilesCache;
                comboBoxProfile.Format += ComboBoxProfile_Format;

                if (newIndex != -1 && comboBoxProfile.Items != null && comboBoxProfile.Items.Count > 0)
                {
                    comboBoxProfile.SelectedIndex = newIndex;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ComboBoxProfile_Format(object? sender, ListControlConvertEventArgs e)
        {
            try
            {
                ProfileCard item = (ProfileCard)e.ListItem!;

                e.Value = $"{item.Name}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void AddExerciseFormOpenButton_Click(object sender, EventArgs e)
        {
            CheckProfileIsSet(() =>
            {
                AddExerciseForm addExerciseForm = new AddExerciseForm();
                addExerciseForm.ShowDialog();
            });
        }

        private void CheckProfileIsSet(Action act)
        {
            try
            {
                var currentProfileCheck = Profile.Current;
                act();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewEditTrainingSessionButton_Click(object sender, EventArgs e)
        {
            CheckProfileIsSet(() =>
            {
                TrainingSessionsViewEditForm trainingSessionsViewEditForm = new TrainingSessionsViewEditForm();
                trainingSessionsViewEditForm.ShowDialog();
            });
        }

        private void ManageBodyWeightButton_Click(object sender, EventArgs e)
        {
            CheckProfileIsSet(() =>
            {
                BodyWeightMonitorForm bodyWeightMonitorForm = new BodyWeightMonitorForm();
                bodyWeightMonitorForm.ShowDialog();
            });
        }

        private void buttonManageProfiles_Click(object sender, EventArgs e)
        {
            ManageProfilesForm manageProfilesForm = new ManageProfilesForm(RefreshProfilesCache);
            manageProfilesForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshProfilesCache();
        }

        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var card = (ProfileCard)comboBoxProfile.SelectedItem;

                Profile.Current = card.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
