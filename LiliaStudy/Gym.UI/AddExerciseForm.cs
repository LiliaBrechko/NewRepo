using GYM.Interface.Services.Exercises;
using GYM.Interface.Services.Exercises.Dto;
using GYM.Models;
using GYM.Repositories;
using GYM.Services;

namespace Gym.UI
{
    public partial class AddExerciseForm : Form
    {
        private Dictionary<string, int> exercisesCache = new Dictionary<string, int>();
        private readonly IExerciseService exerciseService = new ExerciseService(new Repository<Exercise>(), new Repository<TrainingSession>());

        public AddExerciseForm()
        {
            InitializeComponent();
        }

        private void AddExerciseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(AddExerciseNameTextBox.Text.Trim()))
                {
                    throw new ApplicationException("Please enter exercise name");
                }

                var exercise = new CreateExerciseDto
                {
                    Name = AddExerciseNameTextBox.Text,
                    Description = AddExerciseDescriptionTextBox.Text,
                    IsActive = checkBoxIsActive.Checked,
                    ProfileId = Profile.Current
                };

                var exerciseService = new ExerciseService(new Repository<Exercise>(), new Repository<TrainingSession>());

                exerciseService.AddExercise(exercise);

                RefreshExercisesCache(ExerciseComboBox.Items.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void AddExerciseForm_Load(object sender, EventArgs e)
        {
            RefreshExercisesCache();
        }

        private void RefreshExercisesCache(int? index = null)
        {
            try
            {
                ExerciseComboBox.Text = String.Empty;
                var newIndex = index ?? ExerciseComboBox.SelectedIndex;
                exercisesCache = exerciseService.GetAllExercises().Where(e => e.ProfileId == Profile.Current).ToDictionary(k => k.Name, v => v.Id);

                ExerciseComboBox.DataSource = exercisesCache.Select(e => e.Key).ToArray();

                if (newIndex != -1)
                {
                    ExerciseComboBox.SelectedIndex = newIndex;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void RemoveExerciseButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddExerciseNameTextBox.Text = string.Empty;
                AddExerciseDescriptionTextBox.Text = string.Empty;
                checkBoxIsActive.Checked = true;

                var index = ExerciseComboBox.SelectedIndex;

                if (index == -1)
                {
                    throw new ApplicationException("Nothing to remove");
                }

                exerciseService.DeleteExercise(exercisesCache[ExerciseComboBox.SelectedItem.ToString()!]);

                RefreshExercisesCache(index - 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void UpdateExerciseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExerciseComboBox.SelectedItem == null || ExerciseComboBox.SelectedIndex == -1)
                {
                    throw new ApplicationException("Nothing to update");
                }

                exerciseService.UpdateExercise(exercisesCache[ExerciseComboBox.SelectedItem.ToString()!], new CreateExerciseDto
                {
                    Name = AddExerciseNameTextBox.Text,
                    Description = AddExerciseDescriptionTextBox.Text,
                    IsActive = checkBoxIsActive.Checked,
                    ProfileId = Profile.Current
                });

                RefreshExercisesCache();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ExerciseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var exercise = exerciseService.GetExercise(exercisesCache[ExerciseComboBox.SelectedItem.ToString()!]);

            AddExerciseNameTextBox.Text = exercise.Name;
            AddExerciseDescriptionTextBox.Text = exercise.Description;
            checkBoxIsActive.Checked = exercise.IsActive;
        }
    }
}
