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
                var exercise = new CreateExerciseDto
                {
                    Name = AddExerciseNameTextBox.Text,
                    Description = AddExerciseDescriptionTextBox.Text,
                    IsActive = checkBoxIsActive.Checked
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
                var newIndex = index ?? ExerciseComboBox.SelectedIndex;
                exercisesCache = exerciseService.GetAllExercises().ToDictionary(k => k.Name, v => v.Id);

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
            var index = ExerciseComboBox.SelectedIndex;

            exerciseService.DeleteExercise(exercisesCache[ExerciseComboBox.SelectedItem.ToString()!]);

            RefreshExercisesCache(index - 1);
        }

        private void UpdateExerciseButton_Click(object sender, EventArgs e)
        {
            exerciseService.UpdateExercise(exercisesCache[ExerciseComboBox.SelectedItem.ToString()!], new CreateExerciseDto
            {
                Name = AddExerciseNameTextBox.Text,
                Description = AddExerciseDescriptionTextBox.Text,
                IsActive = checkBoxIsActive.Checked
            });

            RefreshExercisesCache();
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
