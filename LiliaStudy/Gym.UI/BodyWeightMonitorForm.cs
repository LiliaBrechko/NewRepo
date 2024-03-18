using GYM.Interface.Services.Body;
using GYM.Interface.Services.Body.Dto;
using GYM.Interface.Services.Sets.Dto;
using GYM.Interface.Services.Sets;
using GYM.Interface.Services.TrainingSessions;
using GYM.Interface.Services.TrainingSessions.Dto;
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
using System.IO;

namespace Gym.UI
{
    public partial class BodyWeightMonitorForm : Form
    {
        private readonly IBodyWeightService bodyWeightService = new BodyWeightService(new Repository<BodyWeight>());
        private Dictionary<int, BodyWeightCard> bodyWeightCache = new Dictionary<int, BodyWeightCard>();

        public BodyWeightMonitorForm()
        {
            InitializeComponent();
        }

        private void BodyWeightMonitorForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshWeightCache();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ListBoxViewBodyWeightDates_Format_OLD(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index < 0) return;

                KeyValuePair<int, BodyWeightCard> item = (KeyValuePair<int, BodyWeightCard>)ListBoxViewBodyWeightDates.Items[e.Index]!;
                var previousDateValue = bodyWeightCache.Values.OrderByDescending(v => v.DateTime).FirstOrDefault(v => v.DateTime < item.Value.DateTime);

                var value1 = item.Value.Weight;
                var value2 = previousDateValue?.Weight;

                PointF drawPoint = new PointF(e.Bounds.X, e.Bounds.Y);

                e.DrawBackground();

                if (value2.HasValue)
                {
                    double difference = value1 - value2.Value;
                    double percentageDifference = Math.Round((difference / value2.Value) * 100.0, 2);
                    var percentageInfo = percentageDifference > 0 ? $"+{percentageDifference}%" : $"{percentageDifference}%";

                    var parts = new[] { $"{item.Value.DateTime.DateTime.ToLongDateString()} - Weight: {item.Value.Weight}", $" {percentageInfo}" };

                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        for (int i = 0; i < parts.Length; i++)
                        {
                            using (Font boldFont = new Font(e.Font, FontStyle.Bold))
                            {
                                Font currentFont = e.Font;
                                // Set the brush to the current part's color
                                if (i > 0)
                                {
                                    brush.Color = percentageDifference > 0 ? Color.Red : Color.Goldenrod;
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
                else
                {
                    var val = $"{item.Value.DateTime.DateTime.ToLongDateString()} - Weight: {item.Value.Weight}";

                    using (Brush textBrush = new SolidBrush(Color.Black))
                    {
                        e.Graphics.DrawString(val, e.Font, textBrush, e.Bounds);
                    }
                }

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ListBoxViewBodyWeightDates_Format(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (e.Index < 0) return;

                var summaryDatesAmmount = 7;
                bool isSummaryRow = (e.Index + 1) % summaryDatesAmmount == 0;
                KeyValuePair<int, BodyWeightCard> item = (KeyValuePair<int, BodyWeightCard>)ListBoxViewBodyWeightDates.Items[e.Index]!;
                var previousDateValue = bodyWeightCache.Values.OrderByDescending(v => v.DateTime).FirstOrDefault(v => v.DateTime < item.Value.DateTime)?.Weight;
                //var previousDateValue = bodyWeightCache.Values.OrderBy(v => v.DateTime).Skip(e.Index - 1).FirstOrDefault()?.Weight;
                var lastDateValue = item.Value.Weight;

                PointF drawPoint = new PointF(e.Bounds.X, e.Bounds.Y);

                e.DrawBackground();

                if (previousDateValue.HasValue)
                {
                    double difference = lastDateValue - previousDateValue.Value;
                    double percentageDifference = Math.Round((difference / previousDateValue.Value) * 100.0, 2);
                    var percentageInfo = percentageDifference > 0 ? $"+{percentageDifference}%" : $"{percentageDifference}%";
                    var parts = new[] { $"{item.Value.DateTime.DateTime.ToLongDateString()} - Weight: {item.Value.Weight}", $" {percentageInfo}" };

                    double percentageOverAllDifference = 0;

                    if (isSummaryRow)
                    {
                        var firstDateValueForSummary = bodyWeightCache.Values.OrderBy(v => v.DateTime).Skip(e.Index - summaryDatesAmmount).FirstOrDefault()?.Weight;
                        var lastDateValueForSummary = bodyWeightCache.Values.OrderBy(v => v.DateTime).Skip(e.Index).FirstOrDefault()?.Weight;
                        double differenceOverAll = lastDateValueForSummary.Value - firstDateValueForSummary.Value;
                        percentageOverAllDifference = Math.Round((differenceOverAll / firstDateValueForSummary.Value) * 100.0, 2);
                        var percentageOverAllInfo = percentageOverAllDifference > 0 ? $"+{percentageOverAllDifference}%" : $"{percentageOverAllDifference}%";

                        parts = new[] { $"{item.Value.DateTime.DateTime.ToLongDateString()} - Weight: {item.Value.Weight}", $" {percentageInfo}", $" 7 days: {percentageOverAllInfo} ({lastDateValueForSummary.Value} - {firstDateValueForSummary.Value})" };
                    }

                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        for (int i = 0; i < parts.Length; i++)
                        {
                            using (Font boldFont = new Font(e.Font, FontStyle.Bold))
                            {
                                Font currentFont = e.Font;
                                // Set the brush to the current part's color
                                if (i == 1)
                                {
                                    brush.Color = percentageDifference > 0 ? Color.Red : Color.Green;
                                    currentFont = boldFont;
                                }

                                if (i == 2)
                                {
                                    brush.Color = percentageOverAllDifference > 0 ? Color.Red : Color.Green;
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
                else
                {
                    var val = $"{item.Value.DateTime.DateTime.ToLongDateString()} - Weight: {item.Value.Weight}";

                    using (Brush textBrush = new SolidBrush(Color.Black))
                    {
                        e.Graphics.DrawString(val, e.Font, textBrush, e.Bounds);
                    }
                }

                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void RefreshWeightCache()
        {
            try
            {
                bodyWeightCache = bodyWeightService.GetAllBodyWeights().ToDictionary(k => k.Id, v => v);
                ListBoxViewBodyWeightDates.DataSource = bodyWeightCache.Select(i => i).OrderBy(i => i.Value.DateTime).ToList();

                ListBoxViewBodyWeightDates.DrawMode = DrawMode.OwnerDrawFixed; // Set the DrawMode
                ListBoxViewBodyWeightDates.DrawItem += ListBoxViewBodyWeightDates_Format;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var itemToRemove = (KeyValuePair<int, BodyWeightCard>)ListBoxViewBodyWeightDates.SelectedItem;

                bodyWeightService.DeleteBodyWeight(itemToRemove.Key);

                RefreshWeightCache();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newWeight = bodyWeightService.AddBodyWeight(new CreateBodyWeightDto
                {
                    Weight = double.Parse(TextBoxWeight.Text),
                    DateTime = DateTimePickerWeight.Value
                });

                RefreshWeightCache();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var current = (KeyValuePair<int, BodyWeightCard>)ListBoxViewBodyWeightDates.SelectedItem;

                bodyWeightService.UpdateBodyWeight(current.Key, new CreateBodyWeightDto
                {
                    Weight = double.Parse(TextBoxWeight.Text),
                    DateTime = DateTimePickerWeight.Value
                });

                RefreshWeightCache();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void ListBoxViewBodyWeightDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var card = (KeyValuePair<int, BodyWeightCard>)ListBoxViewBodyWeightDates.SelectedItem;

                TextBoxWeight.Text = card.Value.Weight.ToString();
                DateTimePickerWeight.Value = card.Value.DateTime.DateTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
