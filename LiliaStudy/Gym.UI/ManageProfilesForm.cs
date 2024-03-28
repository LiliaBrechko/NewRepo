using GYM.Interface.Services.Exercises;
using GYM.Interface.Services.Exercises.Dto;
using GYM.Interface.Services.Profile;
using GYM.Interface.Services.Profile.Dto;
using GYM.Models;
using GYM.Repositories;
using GYM.Services;
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
    public partial class ManageProfilesForm : Form
    {
        private Dictionary<string, int> profilesCache = new Dictionary<string, int>();
        private readonly IProfileService profileService = new ProfileService(new Repository<Profile>());
        private Action<int?> onCloseAction;

        public ManageProfilesForm(Action<int?> onCloseAction)
        {
            this.onCloseAction = onCloseAction;
            InitializeComponent();
        }

        private void RefreshProfilesCache(int? index = null)
        {
            try
            {
                comboBoxProfile.Text = String.Empty;
                var newIndex = index ?? comboBoxProfile.SelectedIndex;
                profilesCache = profileService.GetAllProfiles().ToDictionary(k => k.Name, v => v.Id);

                comboBoxProfile.DataSource = profilesCache.Select(e => e.Key).ToArray();

                if (newIndex != -1)
                {
                    comboBoxProfile.SelectedIndex = newIndex;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TextBoxProfileName.Text.Trim()))
                {
                    throw new ApplicationException("Please enter profile name");
                }

                var profile = new CreateProfileDto
                {
                    Name = TextBoxProfileName.Text,
                    Description = TextBoxProfileDescription.Text,
                    IsActive = checkBoxIsActive.Checked
                };


                profileService.AddProfile(profile);

                RefreshProfilesCache(comboBoxProfile.Items.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ManageProfilesForm_Load(object sender, EventArgs e)
        {
            RefreshProfilesCache();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxProfileName.Text = string.Empty;
                TextBoxProfileDescription.Text = string.Empty;
                checkBoxIsActive.Checked = true;

                var index = comboBoxProfile.SelectedIndex;

                if (index == -1)
                {
                    throw new ApplicationException("Nothing to remove");
                }

                profileService.DeleteProfile(profilesCache[comboBoxProfile.SelectedItem.ToString()!]);

                RefreshProfilesCache(index - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxProfile.SelectedItem == null || comboBoxProfile.SelectedIndex == -1)
                {
                    throw new ApplicationException("Nothing to update");
                }

                profileService.UpdateProfile(profilesCache[comboBoxProfile.SelectedItem.ToString()!], new CreateProfileDto
                {
                    Name = TextBoxProfileName.Text,
                    Description = TextBoxProfileDescription.Text,
                    IsActive = checkBoxIsActive.Checked
                });

                RefreshProfilesCache();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            var profile = profileService.GetProfile(profilesCache[comboBoxProfile.SelectedItem.ToString()!]);

            TextBoxProfileName.Text = profile.Name;
            TextBoxProfileDescription.Text = profile.Description;
            checkBoxIsActive.Checked = profile.IsActive;
        }

        private void ManageProfilesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            onCloseAction(null);
        }
    }
}
