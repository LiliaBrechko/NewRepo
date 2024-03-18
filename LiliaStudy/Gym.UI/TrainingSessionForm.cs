using GYM.Interface.Services.Exercises;
using GYM.Interface.Services.Sets;
using GYM.Interface.Services.Sets.Dto;
using GYM.Interface.Services.TrainingSessions;
using GYM.Interface.Services.TrainingSessions.Dto;
using GYM.Models;
using GYM.Repositories;
using GYM.Services;
using System.Data;

namespace Gym.UI
{
    public partial class TrainingSessionForm : Form
    {
        private Dictionary<string, int> exercisesCache = new Dictionary<string, int>();
        private readonly IExerciseService exerciseService = new ExerciseService(new Repository<Exercise>(), new Repository<TrainingSession>());
        private readonly ITrainingSessionService trainingSessionService = new TrainingSessionService(new Repository<TrainingSession>(), new SetService(new Repository<Set>()));
        private List<Set> sets = new List<Set>();

        public TrainingSessionForm()
        {
            InitializeComponent();
        }

        private void RefreshExercisesCache()
        {
            try
            {
                exercisesCache = exerciseService.GetAllExercises().ToDictionary(k => k.Name, v => v.Id);

                ExerciseCombobox.Items.Clear();
                ExerciseCombobox.Items.AddRange(exercisesCache.Select(e => e.Key).ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void RefreshTrainingSessionListBox()
        {
            try
            {
                TrainingSessionListBox.DataSource = sets;
                TrainingSessionListBox.Format += TrainingSessionListBox_Format;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TrainingSessionListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            Set item = (Set)e.ListItem!;

            var exerciseName = exercisesCache.FirstOrDefault(e => e.Value == item.ExerciseId).Key;

            e.Value = $"{exerciseName} - Weight: {item.Weight} - Reps: {item.Reps}";
        }

        private void TrainingSessionForm_Load(object sender, EventArgs e)
        {
            sets = new List<Set>();

            RefreshExercisesCache();

            RefreshTrainingSessionListBox();
        }

        private void SetAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var set = new Set
                {
                    Reps = int.Parse(ExerciseRepsTextBox.Text),
                    Weight = double.Parse(ExerciseWeightTextBox.Text),
                    ExerciseId = exercisesCache[ExerciseCombobox.SelectedItem?.ToString() ?? throw new ApplicationException("No exercise selected")]
                };

                sets.Add(set);

                RefreshTrainingSessionListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void SetClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                sets.Clear();
                RefreshTrainingSessionListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void SetRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newSelectedItemIndex = TrainingSessionListBox.SelectedIndex - 1;

                var itemToRemove = (Set)TrainingSessionListBox.SelectedItem;

                sets.Remove(itemToRemove);

                RefreshTrainingSessionListBox();

                if (newSelectedItemIndex < sets.Count)
                {
                    TrainingSessionListBox.SelectedIndex = newSelectedItemIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void FinishTrainingSessionButton_Click(object sender, EventArgs e)
        {
            try
            {
                var sessionId = trainingSessionService.AddTrainingSession(sets.Select(set => new CreateSetDto
                {
                    ExerciseId = set.ExerciseId,
                    Reps = set.Reps,
                    TrainingSessionId = 0,
                    Weight = set.Weight
                }));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void SetUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (Set)TrainingSessionListBox.SelectedItem;

                item.Reps = int.Parse(ExerciseRepsTextBox.Text);
                item.Weight = double.Parse(ExerciseWeightTextBox.Text);
                item.ExerciseId = exercisesCache[ExerciseCombobox.SelectedItem?.ToString() ?? throw new ApplicationException("No exercise selected")];

                RefreshTrainingSessionListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TrainingSessionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var card = (Set)TrainingSessionListBox.SelectedItem;

                ExerciseWeightTextBox.Text = card.Weight.ToString();
                ExerciseRepsTextBox.Text = card.Reps.ToString();
                ExerciseCombobox.SelectedItem = ExerciseCombobox.Items.Cast<string>().FirstOrDefault(item => item == exercisesCache.FirstOrDefault(e => e.Value == card.ExerciseId).Key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
