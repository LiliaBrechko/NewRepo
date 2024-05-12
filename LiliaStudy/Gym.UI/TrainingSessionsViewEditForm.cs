﻿using GYM.Interface.Services.Body;
using GYM.Interface.Services.Body.Dto;
using GYM.Interface.Services.Exercises;
using GYM.Interface.Services.Exercises.Dto;
using GYM.Interface.Services.Sets;
using GYM.Interface.Services.Sets.Dto;
using GYM.Interface.Services.TrainingSessions;
using GYM.Interface.Services.TrainingSessions.Dto;
using GYM.Models;
using GYM.Repositories;
using GYM.Services;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Gym.UI
{
    public partial class TrainingSessionsViewEditForm : Form
    {
        private readonly ITrainingSessionService trainingSessionService = new TrainingSessionService(new TrainingSessionRepository(), new SetService(new Repository<Set>()));
        private readonly ISetService setService = new SetService(new Repository<Set>());
        private readonly IExerciseService exerciseService = new ExerciseService(new Repository<Exercise>(), new Repository<TrainingSession>());
        private readonly IBodyWeightService bodyWeightService = new BodyWeightService(new Repository<BodyWeight>());

        public TrainingSessionsViewEditForm()
        {
            InitializeComponent();
        }

        private void RefreshExerciseCombobox()
        {
            try
            {
                IEnumerable<ExerciseLastDateDto> exercises = exerciseService.GetAllExercisesWithLastDates().Where(e => e.ProfileId == Profile.Current).OrderByDescending(x => x.IsActive).ThenBy(d => d.LastDateTime).ToList();

                ExerciseCombobox.DataSource = exercises;

                ExerciseCombobox.DrawMode = DrawMode.OwnerDrawFixed; // Set the DrawMode
                ExerciseCombobox.DrawItem += ExerciseCombobox_DrawItem;
                ExerciseCombobox.Format += ExerciseCombobox_Format;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ExerciseCombobox_Format(object? sender, ListControlConvertEventArgs e)
        {
            try
            {
                ExerciseLastDateDto item = (ExerciseLastDateDto)e.ListItem!;
                var lastDate = item.LastDateTime;

                if (lastDate == null || lastDate == default(DateTimeOffset) || !item.IsActive)
                {
                    e.Value = $"{item.Name}";

                    if (lastDate == null || lastDate == default(DateTimeOffset))
                    {
                        e.Value += " (no attempts)";
                    }

                    if (!item.IsActive)
                    {
                        e.Value += " (not active)";
                    }
                }
                else
                {
                    var date = lastDate.Value.Date;
                    var today = DateTime.Today.Date;

                    TimeSpan difference = today.Subtract(date);

                    e.Value = $"{item.Name} - {difference.Days} days";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TrainingSessionsViewEditForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshExerciseCombobox();

                RefreshTrainingSessionListBoxDatesView();

                TrainingSessionListBoxDatesView.SelectedIndex = TrainingSessionListBoxDatesView.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void RefreshTrainingSessionListBoxDatesView(bool remove = false)
        {
            try
            {
                var selectedItemIndex = TrainingSessionListBoxDatesView.SelectedIndex;

                var sessions = trainingSessionService.GetAllTrainingSessions().Where(t => t.ProfileId == Profile.Current).OrderBy(s => s.DateTime).ToList();

                TrainingSessionListBoxDatesView.DataSource = sessions;

                TrainingSessionListBoxDatesView.Format += TrainingSessionListBoxDatesView_Format;

                if (selectedItemIndex != -1 && !remove)
                {
                    TrainingSessionListBoxDatesView.SelectedIndex = selectedItemIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void RefreshTrainingSessionListBoxView(IEnumerable<SetCard> cards, int? selectedIndex = null)
        {
            try
            {
                var selectedItemIndex = selectedIndex ?? TrainingSessionListBoxView.SelectedIndex;

                TrainingSessionListBoxView.DataSource = cards.ToList();

                TrainingSessionListBoxView.Format += TrainingSessionListBoxView_Format;

                if (selectedItemIndex != -1)
                {
                    TrainingSessionListBoxView.SelectedIndex = selectedItemIndex;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TrainingSessionListBoxDatesView_Format(object? sender, ListControlConvertEventArgs e)
        {
            try
            {
                TrainingSessionCard item = (TrainingSessionCard)e.ListItem!;

                e.Value = item.DateTime.DateTime.ToLongDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TrainingSessionListBoxDatesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var card = (TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem;

                var session = trainingSessionService.GetAllTrainingSessions().First(s => s.Id == card.Id);

                TrainingSessionDateTimePicker.Value = card.DateTime.DateTime;

                TrainingSessionListBoxView.DataSource = session.Sets.ToList();
                TrainingSessionListBoxView.Format += TrainingSessionListBoxView_Format;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ExerciseCombobox_DrawItem(object? sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index < 0) return;

                ExerciseLastDateDto item = (ExerciseLastDateDto)ExerciseCombobox.Items[e.Index]!;

                PointF drawPoint = new PointF(e.Bounds.X, e.Bounds.Y);

                e.DrawBackground();

                var lastDate = item.LastDateTime;

                if (lastDate == null || lastDate == default(DateTimeOffset) || !item.IsActive)
                {
                    var val = $"{item.Name}";

                    if (lastDate == null || lastDate == default(DateTimeOffset))
                    {
                        val += " (no attempts)";
                    }

                    if (!item.IsActive)
                    {
                        val += " (not active)";
                    }

                    using (Brush textBrush = new SolidBrush(Color.Black))
                    {
                        e.Graphics.DrawString(val, e.Font!, textBrush, e.Bounds);
                    }
                }
                else
                {
                    var date = lastDate.Value.Date;
                    var today = DateTime.Today.Date;

                    TimeSpan difference = today.Subtract(date);

                    var parts = new[] { $"{item.Name} ", $"{difference.Days} days" };

                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        for (int i = 0; i < parts.Length; i++)
                        {
                            using (Font boldFont = new Font(e.Font!, FontStyle.Bold))
                            {
                                Font currentFont = e.Font!;
                                // Set the brush to the current part's color
                                if (i > 0)
                                {
                                    brush.Color = difference.Days > 8
                                        ? Color.Green
                                        : difference.Days > 6
                                            ? Color.DarkOrange
                                            : Color.Red;

                                    //brush.Color = difference.Days > 6
                                    //    ? Color.Red
                                    //    : difference.Days > 3
                                    //        ? Color.Goldenrod
                                    //        : Color.Green;
                                    currentFont = boldFont;
                                }

                                // Measure the part of the string to calculate the next starting point
                                SizeF stringSize = e.Graphics.MeasureString(parts[i], currentFont);

                                // Draw the string part
                                e.Graphics.DrawString(parts[i], currentFont, brush, drawPoint);

                                // Move the draw point to the end of the last drawn part
                                drawPoint.X += stringSize.Width;
                            }
                        }
                    }
                }

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TrainingSessionListBoxView_Format(object? sender, ListControlConvertEventArgs e)
        {
            try
            {
                SetCard item = (SetCard)e.ListItem!;

                e.Value = $"{item.ExerciseName} - Weight: {item.Weight} - Reps: {item.Reps}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TrainingSessionDateUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var date = TrainingSessionDateTimePicker.Value;

                var sessionId = ((TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem)?.Id ?? throw new ApplicationException("Nothing to update");

                trainingSessionService.UpdateTrainingSession(sessionId, Profile.Current, null, date);

                RefreshTrainingSessionListBoxDatesView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TrainingSessionListBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var card = (SetCard)TrainingSessionListBoxView.SelectedItem;

                ExerciseWeightTextBox.Text = card.Weight.ToString();
                ExerciseRepsTextBox.Text = card.Reps.ToString();
                ExerciseCombobox.SelectedItem = ExerciseCombobox.Items.Cast<ExerciseLastDateDto>().FirstOrDefault(item => item.Name == card.ExerciseName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void SetAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var updateSets = (((IEnumerable<SetCard>?)TrainingSessionListBoxView.DataSource) ?? throw new ApplicationException("No training selected.")).Select(s => new CreateSetDto
                {
                    Reps = s.Reps,
                    Weight = s.Weight,
                    ExerciseId = s.ExerciseId,
                    TrainingSessionId = s.TrainingSessionId,
                }).ToList();

                updateSets.Add(new CreateSetDto
                {
                    Reps = int.Parse(ExerciseRepsTextBox.Text),
                    Weight = double.Parse(ExerciseWeightTextBox.Text),
                    ExerciseId = ((ExerciseLastDateDto?)ExerciseCombobox.SelectedItem)?.Id ?? throw new ApplicationException("No exercise selected"),
                    TrainingSessionId = ((TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem).Id,
                });

                trainingSessionService.UpdateTrainingSession(((TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem).Id, Profile.Current, updateSets);

                var sets = setService.GetAllSets().Where(s => s.TrainingSessionId == ((TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem).Id).ToList();

                RefreshExerciseCombobox();

                RefreshTrainingSessionListBoxView(sets, sets.Count - 1);
            }
            catch (System.FormatException ex)
            {
                var message = ex.Message;
                message += "\nPlease check that Reps are set as integer number and Weight is set as decimal number";

                MessageBox.Show(message, "Error!");
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
                var newSelectedItemIndex = TrainingSessionListBoxView.SelectedIndex - 1;

                var itemToRemove = (SetCard)TrainingSessionListBoxView.SelectedItem ?? throw new ApplicationException("Nothing to remove");

                var updateSets = ((IEnumerable<SetCard>)TrainingSessionListBoxView.DataSource).Where(item => item.Id != itemToRemove.Id).Select(s => new CreateSetDto
                {
                    Reps = s.Reps,
                    Weight = s.Weight,
                    ExerciseId = s.ExerciseId,
                    TrainingSessionId = s.TrainingSessionId,
                }).ToList();

                trainingSessionService.UpdateTrainingSession(((TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem).Id, Profile.Current, updateSets);

                var sets = setService.GetAllSets().Where(s => s.TrainingSessionId == ((TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem).Id).ToList();

                RefreshExerciseCombobox();

                RefreshTrainingSessionListBoxView(sets, newSelectedItemIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ExerciseUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (SetCard)TrainingSessionListBoxView.SelectedItem ?? throw new ApplicationException("Nothing to update");

                var newExerciseId = ((ExerciseLastDateDto?)ExerciseCombobox.SelectedItem)?.Id ?? throw new ApplicationException("No exercise selected");

                var newWeight = double.Parse(ExerciseWeightTextBox.Text);

                var newReps = int.Parse(ExerciseRepsTextBox.Text);

                var set = setService.GetSet(item.Id);

                setService.UpdateSet(set.Id, new CreateSetDto
                {
                    Weight = newWeight,
                    Reps = newReps,
                    ExerciseId = newExerciseId,
                    TrainingSessionId = set.TrainingSessionId
                });

                var sets = setService.GetAllSets().Where(s => s.TrainingSessionId == ((TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem).Id).ToList();

                RefreshTrainingSessionListBoxView(sets);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void buttonAddTrainingSession_Click(object sender, EventArgs e)
        {
            try
            {
                if (trainingSessionService.GetAllTrainingSessions().Where(s => s.ProfileId == Profile.Current).Any(s => s.DateTime.Date == DateTime.Now.Date))
                {
                    throw new ApplicationException("Training session for this date already exists.");
                }

                trainingSessionService.AddTrainingSession(Profile.Current);

                RefreshTrainingSessionListBoxDatesView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void buttonRemoveTrainingSession_Click(object sender, EventArgs e)
        {
            try
            {
                var card = (TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem ?? throw new ApplicationException("Nothing to Remove"); ;

                trainingSessionService.DeleteTrainingSession(card.Id);

                RefreshTrainingSessionListBoxDatesView(remove: true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void buttonViewPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                var exerciseId = ((ExerciseLastDateDto?)ExerciseCombobox.SelectedItem)?.Id ?? throw new ApplicationException("No exercise selected");
                var currentDateTime = ((TrainingSessionCard)TrainingSessionListBoxDatesView.SelectedItem)?.DateTime ?? throw new ApplicationException("Nothing to compare with");

                var dateInfos = setService.GetSetDateInfos().Where(s => s.ExerciseId == exerciseId).GroupBy(s => s.TrainingSessionDate).OrderBy(s => s.Key);

                var currentDateInfos = dateInfos.LastOrDefault(s => s.Key == currentDateTime)?.Select(element => element);

                var previousDateInfos = dateInfos.LastOrDefault(s => s.Key < currentDateTime)?.Select(element => element);

                var currentInfo = string.Empty;

                if (currentDateInfos != null && currentDateInfos.Any())
                {
                    currentInfo += $"Current: {currentDateTime.Date.ToShortDateString()}";
                    foreach (var currentDateInfo in currentDateInfos)
                    {
                        currentInfo += Environment.NewLine;
                        currentInfo += $"{currentDateInfo.ExerciseName} - Weight: {currentDateInfo.Weight} - Reps: {currentDateInfo.Reps}";
                    }
                    currentInfo += Environment.NewLine;
                }

                if (previousDateInfos != null && previousDateInfos.Any())
                {
                    currentInfo += $"Previous: {previousDateInfos.First().TrainingSessionDate.Date.ToShortDateString()}";
                    foreach (var previousDateInfo in previousDateInfos)
                    {
                        currentInfo += Environment.NewLine;
                        currentInfo += $"{previousDateInfo.ExerciseName} - Weight: {previousDateInfo.Weight} - Reps: {previousDateInfo.Reps}";
                    }
                }

                MessageBox.Show(!String.IsNullOrEmpty(currentInfo) ? currentInfo : throw new ApplicationException("Nothing to compare with"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            try
            {
                var exerciseId = ((ExerciseLastDateDto?)ExerciseCombobox.SelectedItem)?.Id ?? throw new ApplicationException("No exercise selected");
                var description = exerciseService.GetExercise(exerciseId).Description;


                MessageBox.Show(description);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void buttonExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                var exercise = ((ExerciseLastDateDto?)ExerciseCombobox.SelectedItem) ?? throw new ApplicationException("No exercise selected");
                var exerciseId = exercise.Id;
                var exerciseName = exercise.Name;

                var weights = bodyWeightService.GetAllBodyWeights().Where(x => x.ProfileId == Profile.Current).ToDictionary(x => x.DateTime.Date, x => x.Weight);

                var sets = setService.GetSetDateInfos().Where(s => s.ExerciseId == exerciseId).ToLookup(x => x.TrainingSessionDate.Date, x => new { x.Weight, x.Reps });

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"{exerciseName} Results");

                    var i = 1;
                    foreach (var set in sets)
                    {
                        // Set headers.
                        var date = set.Key;

                        if (!weights.ContainsKey(date))
                        {
                            continue;
                        }

                        var weight = weights[date];

                        worksheet.Cells[1, i].Value = date.ToShortDateString();
                        worksheet.Cells[2, i].Value = weight;
                        worksheet.Column(i).Width = 20;

                        var row = 3;

                        foreach (var s in set)
                        {
                            worksheet.Cells[row, i].Value = $"Weight: {s.Weight}, Reps: {s.Reps}";
                            row++;
                        }

                        i++;
                    }

                    FileInfo excelFile = new FileInfo("output.xlsx");
                    package.SaveAs(excelFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}