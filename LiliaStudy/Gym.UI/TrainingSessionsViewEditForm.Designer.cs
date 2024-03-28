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
            TrainingSessionListBoxView = new ListBox();
            TrainingSessionListBoxDatesView = new ListBox();
            TrainingSessionDateTimePicker = new DateTimePicker();
            TrainingSessionDateUpdateButton = new Button();
            ExerciseRepsTextBox = new TextBox();
            ExerciseWeightTextBox = new TextBox();
            ExerciseCombobox = new ComboBox();
            SetRemoveButton = new Button();
            SetAddButton = new Button();
            ExerciseUpdateButton = new Button();
            buttonAddTrainingSession = new Button();
            buttonRemoveTrainingSession = new Button();
            buttonViewPrevious = new Button();
            buttonDetail = new Button();
            SuspendLayout();
            // 
            // TrainingSessionListBoxView
            // 
            TrainingSessionListBoxView.FormattingEnabled = true;
            TrainingSessionListBoxView.ItemHeight = 15;
            TrainingSessionListBoxView.Location = new Point(311, 100);
            TrainingSessionListBoxView.Name = "TrainingSessionListBoxView";
            TrainingSessionListBoxView.Size = new Size(576, 409);
            TrainingSessionListBoxView.TabIndex = 5;
            TrainingSessionListBoxView.SelectedIndexChanged += TrainingSessionListBoxView_SelectedIndexChanged;
            // 
            // TrainingSessionListBoxDatesView
            // 
            TrainingSessionListBoxDatesView.FormattingEnabled = true;
            TrainingSessionListBoxDatesView.ItemHeight = 15;
            TrainingSessionListBoxDatesView.Location = new Point(12, 130);
            TrainingSessionListBoxDatesView.Name = "TrainingSessionListBoxDatesView";
            TrainingSessionListBoxDatesView.Size = new Size(282, 379);
            TrainingSessionListBoxDatesView.TabIndex = 6;
            TrainingSessionListBoxDatesView.SelectedIndexChanged += TrainingSessionListBoxDatesView_SelectedIndexChanged;
            // 
            // TrainingSessionDateTimePicker
            // 
            TrainingSessionDateTimePicker.Location = new Point(12, 12);
            TrainingSessionDateTimePicker.MinDate = new DateTime(2024, 3, 11, 0, 0, 0, 0);
            TrainingSessionDateTimePicker.Name = "TrainingSessionDateTimePicker";
            TrainingSessionDateTimePicker.Size = new Size(282, 23);
            TrainingSessionDateTimePicker.TabIndex = 7;
            // 
            // TrainingSessionDateUpdateButton
            // 
            TrainingSessionDateUpdateButton.Location = new Point(12, 69);
            TrainingSessionDateUpdateButton.Name = "TrainingSessionDateUpdateButton";
            TrainingSessionDateUpdateButton.Size = new Size(282, 23);
            TrainingSessionDateUpdateButton.TabIndex = 8;
            TrainingSessionDateUpdateButton.Text = "Update";
            TrainingSessionDateUpdateButton.UseVisualStyleBackColor = true;
            TrainingSessionDateUpdateButton.Click += TrainingSessionDateUpdateButton_Click;
            // 
            // ExerciseRepsTextBox
            // 
            ExerciseRepsTextBox.Location = new Point(311, 70);
            ExerciseRepsTextBox.Name = "ExerciseRepsTextBox";
            ExerciseRepsTextBox.PlaceholderText = "Enter Reps Number";
            ExerciseRepsTextBox.Size = new Size(221, 23);
            ExerciseRepsTextBox.TabIndex = 11;
            // 
            // ExerciseWeightTextBox
            // 
            ExerciseWeightTextBox.Location = new Point(311, 41);
            ExerciseWeightTextBox.Name = "ExerciseWeightTextBox";
            ExerciseWeightTextBox.PlaceholderText = "Enter weight";
            ExerciseWeightTextBox.Size = new Size(221, 23);
            ExerciseWeightTextBox.TabIndex = 10;
            // 
            // ExerciseCombobox
            // 
            ExerciseCombobox.FormattingEnabled = true;
            ExerciseCombobox.Location = new Point(311, 12);
            ExerciseCombobox.Name = "ExerciseCombobox";
            ExerciseCombobox.Size = new Size(221, 23);
            ExerciseCombobox.TabIndex = 9;
            // 
            // SetRemoveButton
            // 
            SetRemoveButton.Location = new Point(538, 69);
            SetRemoveButton.Name = "SetRemoveButton";
            SetRemoveButton.Size = new Size(153, 23);
            SetRemoveButton.TabIndex = 13;
            SetRemoveButton.Text = "Remove";
            SetRemoveButton.UseVisualStyleBackColor = true;
            SetRemoveButton.Click += SetRemoveButton_Click;
            // 
            // SetAddButton
            // 
            SetAddButton.Location = new Point(538, 12);
            SetAddButton.Name = "SetAddButton";
            SetAddButton.Size = new Size(153, 23);
            SetAddButton.TabIndex = 12;
            SetAddButton.Text = "Add";
            SetAddButton.UseVisualStyleBackColor = true;
            SetAddButton.Click += SetAddButton_Click;
            // 
            // ExerciseUpdateButton
            // 
            ExerciseUpdateButton.Location = new Point(538, 40);
            ExerciseUpdateButton.Name = "ExerciseUpdateButton";
            ExerciseUpdateButton.Size = new Size(153, 23);
            ExerciseUpdateButton.TabIndex = 14;
            ExerciseUpdateButton.Text = "Update";
            ExerciseUpdateButton.UseVisualStyleBackColor = true;
            ExerciseUpdateButton.Click += ExerciseUpdateButton_Click;
            // 
            // buttonAddTrainingSession
            // 
            buttonAddTrainingSession.Location = new Point(12, 40);
            buttonAddTrainingSession.Name = "buttonAddTrainingSession";
            buttonAddTrainingSession.Size = new Size(282, 23);
            buttonAddTrainingSession.TabIndex = 15;
            buttonAddTrainingSession.Text = "Add Training";
            buttonAddTrainingSession.UseVisualStyleBackColor = true;
            buttonAddTrainingSession.Click += buttonAddTrainingSession_Click;
            // 
            // buttonRemoveTrainingSession
            // 
            buttonRemoveTrainingSession.Location = new Point(12, 99);
            buttonRemoveTrainingSession.Name = "buttonRemoveTrainingSession";
            buttonRemoveTrainingSession.Size = new Size(282, 23);
            buttonRemoveTrainingSession.TabIndex = 16;
            buttonRemoveTrainingSession.Text = "Remove";
            buttonRemoveTrainingSession.UseVisualStyleBackColor = true;
            buttonRemoveTrainingSession.Click += buttonRemoveTrainingSession_Click;
            // 
            // buttonViewPrevious
            // 
            buttonViewPrevious.Location = new Point(697, 12);
            buttonViewPrevious.Name = "buttonViewPrevious";
            buttonViewPrevious.Size = new Size(184, 23);
            buttonViewPrevious.TabIndex = 17;
            buttonViewPrevious.Text = "Compare Previous";
            buttonViewPrevious.UseVisualStyleBackColor = true;
            buttonViewPrevious.Click += buttonViewPrevious_Click;
            // 
            // buttonDetail
            // 
            buttonDetail.Location = new Point(697, 40);
            buttonDetail.Name = "buttonDetail";
            buttonDetail.Size = new Size(184, 23);
            buttonDetail.TabIndex = 18;
            buttonDetail.Text = "Detail";
            buttonDetail.UseVisualStyleBackColor = true;
            buttonDetail.Click += buttonDetail_Click;
            // 
            // TrainingSessionsViewEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 515);
            Controls.Add(buttonDetail);
            Controls.Add(buttonViewPrevious);
            Controls.Add(buttonRemoveTrainingSession);
            Controls.Add(buttonAddTrainingSession);
            Controls.Add(ExerciseUpdateButton);
            Controls.Add(SetRemoveButton);
            Controls.Add(SetAddButton);
            Controls.Add(ExerciseRepsTextBox);
            Controls.Add(ExerciseWeightTextBox);
            Controls.Add(ExerciseCombobox);
            Controls.Add(TrainingSessionDateUpdateButton);
            Controls.Add(TrainingSessionDateTimePicker);
            Controls.Add(TrainingSessionListBoxDatesView);
            Controls.Add(TrainingSessionListBoxView);
            Name = "TrainingSessionsViewEditForm";
            Text = "TrainingSessions";
            Load += TrainingSessionsViewEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Button buttonDetail;
    }
}