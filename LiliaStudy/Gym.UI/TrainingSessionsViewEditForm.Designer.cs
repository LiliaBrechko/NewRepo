namespace Gym.UI
{
    partial class TrainingSessionsViewEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrainingSessionListBoxView = new System.Windows.Forms.ListBox();
            this.TrainingSessionListBoxDatesView = new System.Windows.Forms.ListBox();
            this.TrainingSessionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TrainingSessionDateUpdateButton = new System.Windows.Forms.Button();
            this.ExerciseRepsTextBox = new System.Windows.Forms.TextBox();
            this.ExerciseWeightTextBox = new System.Windows.Forms.TextBox();
            this.ExerciseCombobox = new System.Windows.Forms.ComboBox();
            this.SetRemoveButton = new System.Windows.Forms.Button();
            this.SetAddButton = new System.Windows.Forms.Button();
            this.ExerciseUpdateButton = new System.Windows.Forms.Button();
            this.buttonAddTrainingSession = new System.Windows.Forms.Button();
            this.buttonRemoveTrainingSession = new System.Windows.Forms.Button();
            this.buttonViewPrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrainingSessionListBoxView
            // 
            this.TrainingSessionListBoxView.FormattingEnabled = true;
            this.TrainingSessionListBoxView.ItemHeight = 15;
            this.TrainingSessionListBoxView.Location = new System.Drawing.Point(311, 100);
            this.TrainingSessionListBoxView.Name = "TrainingSessionListBoxView";
            this.TrainingSessionListBoxView.Size = new System.Drawing.Size(576, 409);
            this.TrainingSessionListBoxView.TabIndex = 5;
            this.TrainingSessionListBoxView.SelectedIndexChanged += new System.EventHandler(this.TrainingSessionListBoxView_SelectedIndexChanged);
            // 
            // TrainingSessionListBoxDatesView
            // 
            this.TrainingSessionListBoxDatesView.FormattingEnabled = true;
            this.TrainingSessionListBoxDatesView.ItemHeight = 15;
            this.TrainingSessionListBoxDatesView.Location = new System.Drawing.Point(12, 130);
            this.TrainingSessionListBoxDatesView.Name = "TrainingSessionListBoxDatesView";
            this.TrainingSessionListBoxDatesView.Size = new System.Drawing.Size(282, 379);
            this.TrainingSessionListBoxDatesView.TabIndex = 6;
            this.TrainingSessionListBoxDatesView.SelectedIndexChanged += new System.EventHandler(this.TrainingSessionListBoxDatesView_SelectedIndexChanged);
            // 
            // TrainingSessionDateTimePicker
            // 
            this.TrainingSessionDateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.TrainingSessionDateTimePicker.MinDate = new System.DateTime(2024, 3, 11, 0, 0, 0, 0);
            this.TrainingSessionDateTimePicker.Name = "TrainingSessionDateTimePicker";
            this.TrainingSessionDateTimePicker.Size = new System.Drawing.Size(282, 23);
            this.TrainingSessionDateTimePicker.TabIndex = 7;
            // 
            // TrainingSessionDateUpdateButton
            // 
            this.TrainingSessionDateUpdateButton.Location = new System.Drawing.Point(12, 41);
            this.TrainingSessionDateUpdateButton.Name = "TrainingSessionDateUpdateButton";
            this.TrainingSessionDateUpdateButton.Size = new System.Drawing.Size(282, 23);
            this.TrainingSessionDateUpdateButton.TabIndex = 8;
            this.TrainingSessionDateUpdateButton.Text = "Update";
            this.TrainingSessionDateUpdateButton.UseVisualStyleBackColor = true;
            this.TrainingSessionDateUpdateButton.Click += new System.EventHandler(this.TrainingSessionDateUpdateButton_Click);
            // 
            // ExerciseRepsTextBox
            // 
            this.ExerciseRepsTextBox.Location = new System.Drawing.Point(311, 70);
            this.ExerciseRepsTextBox.Name = "ExerciseRepsTextBox";
            this.ExerciseRepsTextBox.PlaceholderText = "Enter Reps Number";
            this.ExerciseRepsTextBox.Size = new System.Drawing.Size(221, 23);
            this.ExerciseRepsTextBox.TabIndex = 11;
            // 
            // ExerciseWeightTextBox
            // 
            this.ExerciseWeightTextBox.Location = new System.Drawing.Point(311, 41);
            this.ExerciseWeightTextBox.Name = "ExerciseWeightTextBox";
            this.ExerciseWeightTextBox.PlaceholderText = "Enter weight";
            this.ExerciseWeightTextBox.Size = new System.Drawing.Size(221, 23);
            this.ExerciseWeightTextBox.TabIndex = 10;
            // 
            // ExerciseCombobox
            // 
            this.ExerciseCombobox.FormattingEnabled = true;
            this.ExerciseCombobox.Location = new System.Drawing.Point(311, 12);
            this.ExerciseCombobox.Name = "ExerciseCombobox";
            this.ExerciseCombobox.Size = new System.Drawing.Size(221, 23);
            this.ExerciseCombobox.TabIndex = 9;
            // 
            // SetRemoveButton
            // 
            this.SetRemoveButton.Location = new System.Drawing.Point(538, 69);
            this.SetRemoveButton.Name = "SetRemoveButton";
            this.SetRemoveButton.Size = new System.Drawing.Size(153, 23);
            this.SetRemoveButton.TabIndex = 13;
            this.SetRemoveButton.Text = "Remove";
            this.SetRemoveButton.UseVisualStyleBackColor = true;
            this.SetRemoveButton.Click += new System.EventHandler(this.SetRemoveButton_Click);
            // 
            // SetAddButton
            // 
            this.SetAddButton.Location = new System.Drawing.Point(538, 12);
            this.SetAddButton.Name = "SetAddButton";
            this.SetAddButton.Size = new System.Drawing.Size(153, 23);
            this.SetAddButton.TabIndex = 12;
            this.SetAddButton.Text = "Add";
            this.SetAddButton.UseVisualStyleBackColor = true;
            this.SetAddButton.Click += new System.EventHandler(this.SetAddButton_Click);
            // 
            // ExerciseUpdateButton
            // 
            this.ExerciseUpdateButton.Location = new System.Drawing.Point(538, 40);
            this.ExerciseUpdateButton.Name = "ExerciseUpdateButton";
            this.ExerciseUpdateButton.Size = new System.Drawing.Size(153, 23);
            this.ExerciseUpdateButton.TabIndex = 14;
            this.ExerciseUpdateButton.Text = "Update";
            this.ExerciseUpdateButton.UseVisualStyleBackColor = true;
            this.ExerciseUpdateButton.Click += new System.EventHandler(this.ExerciseUpdateButton_Click);
            // 
            // buttonAddTrainingSession
            // 
            this.buttonAddTrainingSession.Location = new System.Drawing.Point(12, 70);
            this.buttonAddTrainingSession.Name = "buttonAddTrainingSession";
            this.buttonAddTrainingSession.Size = new System.Drawing.Size(282, 23);
            this.buttonAddTrainingSession.TabIndex = 15;
            this.buttonAddTrainingSession.Text = "Add";
            this.buttonAddTrainingSession.UseVisualStyleBackColor = true;
            this.buttonAddTrainingSession.Click += new System.EventHandler(this.buttonAddTrainingSession_Click);
            // 
            // buttonRemoveTrainingSession
            // 
            this.buttonRemoveTrainingSession.Location = new System.Drawing.Point(12, 99);
            this.buttonRemoveTrainingSession.Name = "buttonRemoveTrainingSession";
            this.buttonRemoveTrainingSession.Size = new System.Drawing.Size(282, 23);
            this.buttonRemoveTrainingSession.TabIndex = 16;
            this.buttonRemoveTrainingSession.Text = "Remove";
            this.buttonRemoveTrainingSession.UseVisualStyleBackColor = true;
            this.buttonRemoveTrainingSession.Click += new System.EventHandler(this.buttonRemoveTrainingSession_Click);
            // 
            // buttonViewPrevious
            // 
            this.buttonViewPrevious.Location = new System.Drawing.Point(697, 12);
            this.buttonViewPrevious.Name = "buttonViewPrevious";
            this.buttonViewPrevious.Size = new System.Drawing.Size(184, 23);
            this.buttonViewPrevious.TabIndex = 17;
            this.buttonViewPrevious.Text = "Compare Previous";
            this.buttonViewPrevious.UseVisualStyleBackColor = true;
            this.buttonViewPrevious.Click += new System.EventHandler(this.buttonViewPrevious_Click);
            // 
            // TrainingSessionsViewEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 515);
            this.Controls.Add(this.buttonViewPrevious);
            this.Controls.Add(this.buttonRemoveTrainingSession);
            this.Controls.Add(this.buttonAddTrainingSession);
            this.Controls.Add(this.ExerciseUpdateButton);
            this.Controls.Add(this.SetRemoveButton);
            this.Controls.Add(this.SetAddButton);
            this.Controls.Add(this.ExerciseRepsTextBox);
            this.Controls.Add(this.ExerciseWeightTextBox);
            this.Controls.Add(this.ExerciseCombobox);
            this.Controls.Add(this.TrainingSessionDateUpdateButton);
            this.Controls.Add(this.TrainingSessionDateTimePicker);
            this.Controls.Add(this.TrainingSessionListBoxDatesView);
            this.Controls.Add(this.TrainingSessionListBoxView);
            this.Name = "TrainingSessionsViewEditForm";
            this.Text = "TrainingSessions";
            this.Load += new System.EventHandler(this.TrainingSessionsViewEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox TrainingSessionListBoxView;
        private ListBox TrainingSessionListBoxDatesView;
        private DateTimePicker TrainingSessionDateTimePicker;
        private Button TrainingSessionDateUpdateButton;
        private TextBox ExerciseRepsTextBox;
        private TextBox ExerciseWeightTextBox;
        private ComboBox ExerciseCombobox;
        private Button SetRemoveButton;
        private Button SetAddButton;
        private Button ExerciseUpdateButton;
        private Button buttonAddTrainingSession;
        private Button buttonRemoveTrainingSession;
        private Button buttonViewPrevious;
    }
}