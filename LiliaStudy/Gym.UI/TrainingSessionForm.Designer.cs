namespace Gym.UI
{
    partial class TrainingSessionForm
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
            this.ExerciseCombobox = new System.Windows.Forms.ComboBox();
            this.ExerciseWeightTextBox = new System.Windows.Forms.TextBox();
            this.ExerciseRepsTextBox = new System.Windows.Forms.TextBox();
            this.SetAddButton = new System.Windows.Forms.Button();
            this.TrainingSessionListBox = new System.Windows.Forms.ListBox();
            this.SetRemoveButton = new System.Windows.Forms.Button();
            this.SetClearButton = new System.Windows.Forms.Button();
            this.FinishTrainingSessionButton = new System.Windows.Forms.Button();
            this.SetUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExerciseCombobox
            // 
            this.ExerciseCombobox.FormattingEnabled = true;
            this.ExerciseCombobox.Location = new System.Drawing.Point(12, 12);
            this.ExerciseCombobox.Name = "ExerciseCombobox";
            this.ExerciseCombobox.Size = new System.Drawing.Size(221, 23);
            this.ExerciseCombobox.TabIndex = 0;
            // 
            // ExerciseWeightTextBox
            // 
            this.ExerciseWeightTextBox.Location = new System.Drawing.Point(239, 12);
            this.ExerciseWeightTextBox.Name = "ExerciseWeightTextBox";
            this.ExerciseWeightTextBox.PlaceholderText = "Enter weight";
            this.ExerciseWeightTextBox.Size = new System.Drawing.Size(153, 23);
            this.ExerciseWeightTextBox.TabIndex = 1;
            // 
            // ExerciseRepsTextBox
            // 
            this.ExerciseRepsTextBox.Location = new System.Drawing.Point(398, 12);
            this.ExerciseRepsTextBox.Name = "ExerciseRepsTextBox";
            this.ExerciseRepsTextBox.PlaceholderText = "Enter Reps Number";
            this.ExerciseRepsTextBox.Size = new System.Drawing.Size(190, 23);
            this.ExerciseRepsTextBox.TabIndex = 2;
            // 
            // SetAddButton
            // 
            this.SetAddButton.Location = new System.Drawing.Point(594, 11);
            this.SetAddButton.Name = "SetAddButton";
            this.SetAddButton.Size = new System.Drawing.Size(139, 23);
            this.SetAddButton.TabIndex = 3;
            this.SetAddButton.Text = "Add";
            this.SetAddButton.UseVisualStyleBackColor = true;
            this.SetAddButton.Click += new System.EventHandler(this.SetAddButton_Click);
            // 
            // TrainingSessionListBox
            // 
            this.TrainingSessionListBox.FormattingEnabled = true;
            this.TrainingSessionListBox.ItemHeight = 15;
            this.TrainingSessionListBox.Location = new System.Drawing.Point(12, 41);
            this.TrainingSessionListBox.Name = "TrainingSessionListBox";
            this.TrainingSessionListBox.Size = new System.Drawing.Size(576, 439);
            this.TrainingSessionListBox.TabIndex = 4;
            this.TrainingSessionListBox.SelectedIndexChanged += new System.EventHandler(this.TrainingSessionListBox_SelectedIndexChanged);
            // 
            // SetRemoveButton
            // 
            this.SetRemoveButton.Location = new System.Drawing.Point(594, 70);
            this.SetRemoveButton.Name = "SetRemoveButton";
            this.SetRemoveButton.Size = new System.Drawing.Size(139, 23);
            this.SetRemoveButton.TabIndex = 5;
            this.SetRemoveButton.Text = "Remove";
            this.SetRemoveButton.UseVisualStyleBackColor = true;
            this.SetRemoveButton.Click += new System.EventHandler(this.SetRemoveButton_Click);
            // 
            // SetClearButton
            // 
            this.SetClearButton.Location = new System.Drawing.Point(594, 99);
            this.SetClearButton.Name = "SetClearButton";
            this.SetClearButton.Size = new System.Drawing.Size(139, 23);
            this.SetClearButton.TabIndex = 6;
            this.SetClearButton.Text = "Clear";
            this.SetClearButton.UseVisualStyleBackColor = true;
            this.SetClearButton.Click += new System.EventHandler(this.SetClearButton_Click);
            // 
            // FinishTrainingSessionButton
            // 
            this.FinishTrainingSessionButton.Location = new System.Drawing.Point(594, 128);
            this.FinishTrainingSessionButton.Name = "FinishTrainingSessionButton";
            this.FinishTrainingSessionButton.Size = new System.Drawing.Size(139, 23);
            this.FinishTrainingSessionButton.TabIndex = 7;
            this.FinishTrainingSessionButton.Text = "Finish";
            this.FinishTrainingSessionButton.UseVisualStyleBackColor = true;
            this.FinishTrainingSessionButton.Click += new System.EventHandler(this.FinishTrainingSessionButton_Click);
            // 
            // SetUpdateButton
            // 
            this.SetUpdateButton.Location = new System.Drawing.Point(594, 41);
            this.SetUpdateButton.Name = "SetUpdateButton";
            this.SetUpdateButton.Size = new System.Drawing.Size(139, 23);
            this.SetUpdateButton.TabIndex = 8;
            this.SetUpdateButton.Text = "Update";
            this.SetUpdateButton.UseVisualStyleBackColor = true;
            this.SetUpdateButton.Click += new System.EventHandler(this.SetUpdateButton_Click);
            // 
            // TrainingSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 489);
            this.Controls.Add(this.SetUpdateButton);
            this.Controls.Add(this.FinishTrainingSessionButton);
            this.Controls.Add(this.SetClearButton);
            this.Controls.Add(this.SetRemoveButton);
            this.Controls.Add(this.TrainingSessionListBox);
            this.Controls.Add(this.SetAddButton);
            this.Controls.Add(this.ExerciseRepsTextBox);
            this.Controls.Add(this.ExerciseWeightTextBox);
            this.Controls.Add(this.ExerciseCombobox);
            this.Name = "TrainingSessionForm";
            this.Text = "TrainingSession";
            this.Load += new System.EventHandler(this.TrainingSessionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ExerciseCombobox;
        private TextBox ExerciseWeightTextBox;
        private TextBox ExerciseRepsTextBox;
        private Button SetAddButton;
        private ListBox TrainingSessionListBox;
        private Button SetRemoveButton;
        private Button SetClearButton;
        private Button FinishTrainingSessionButton;
        private Button SetUpdateButton;
    }
}