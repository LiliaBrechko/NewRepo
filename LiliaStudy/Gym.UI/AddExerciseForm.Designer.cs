namespace Gym.UI
{
    partial class AddExerciseForm
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
            this.AddExerciseNameTextBox = new System.Windows.Forms.TextBox();
            this.AddExerciseDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddExerciseButton = new System.Windows.Forms.Button();
            this.ExerciseComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateExerciseButton = new System.Windows.Forms.Button();
            this.RemoveExerciseButton = new System.Windows.Forms.Button();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddExerciseNameTextBox
            // 
            this.AddExerciseNameTextBox.Location = new System.Drawing.Point(226, 12);
            this.AddExerciseNameTextBox.Name = "AddExerciseNameTextBox";
            this.AddExerciseNameTextBox.PlaceholderText = "Exercise Name";
            this.AddExerciseNameTextBox.Size = new System.Drawing.Size(211, 23);
            this.AddExerciseNameTextBox.TabIndex = 0;
            // 
            // AddExerciseDescriptionTextBox
            // 
            this.AddExerciseDescriptionTextBox.Location = new System.Drawing.Point(226, 41);
            this.AddExerciseDescriptionTextBox.Multiline = true;
            this.AddExerciseDescriptionTextBox.Name = "AddExerciseDescriptionTextBox";
            this.AddExerciseDescriptionTextBox.PlaceholderText = "Exercise Description";
            this.AddExerciseDescriptionTextBox.Size = new System.Drawing.Size(211, 81);
            this.AddExerciseDescriptionTextBox.TabIndex = 1;
            // 
            // AddExerciseButton
            // 
            this.AddExerciseButton.Location = new System.Drawing.Point(12, 99);
            this.AddExerciseButton.Name = "AddExerciseButton";
            this.AddExerciseButton.Size = new System.Drawing.Size(208, 23);
            this.AddExerciseButton.TabIndex = 2;
            this.AddExerciseButton.Text = "Add";
            this.AddExerciseButton.UseVisualStyleBackColor = true;
            this.AddExerciseButton.Click += new System.EventHandler(this.AddExerciseButton_Click);
            // 
            // ExerciseComboBox
            // 
            this.ExerciseComboBox.FormattingEnabled = true;
            this.ExerciseComboBox.Location = new System.Drawing.Point(12, 12);
            this.ExerciseComboBox.Name = "ExerciseComboBox";
            this.ExerciseComboBox.Size = new System.Drawing.Size(208, 23);
            this.ExerciseComboBox.TabIndex = 3;
            this.ExerciseComboBox.SelectedIndexChanged += new System.EventHandler(this.ExerciseComboBox_SelectedIndexChanged);
            // 
            // UpdateExerciseButton
            // 
            this.UpdateExerciseButton.Location = new System.Drawing.Point(12, 41);
            this.UpdateExerciseButton.Name = "UpdateExerciseButton";
            this.UpdateExerciseButton.Size = new System.Drawing.Size(208, 23);
            this.UpdateExerciseButton.TabIndex = 4;
            this.UpdateExerciseButton.Text = "Update";
            this.UpdateExerciseButton.UseVisualStyleBackColor = true;
            this.UpdateExerciseButton.Click += new System.EventHandler(this.UpdateExerciseButton_Click);
            // 
            // RemoveExerciseButton
            // 
            this.RemoveExerciseButton.Location = new System.Drawing.Point(12, 70);
            this.RemoveExerciseButton.Name = "RemoveExerciseButton";
            this.RemoveExerciseButton.Size = new System.Drawing.Size(208, 23);
            this.RemoveExerciseButton.TabIndex = 5;
            this.RemoveExerciseButton.Text = "Remove";
            this.RemoveExerciseButton.UseVisualStyleBackColor = true;
            this.RemoveExerciseButton.Click += new System.EventHandler(this.RemoveExerciseButton_Click);
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Location = new System.Drawing.Point(443, 16);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(67, 19);
            this.checkBoxIsActive.TabIndex = 6;
            this.checkBoxIsActive.Text = "isActive";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // AddExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 137);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.RemoveExerciseButton);
            this.Controls.Add(this.UpdateExerciseButton);
            this.Controls.Add(this.ExerciseComboBox);
            this.Controls.Add(this.AddExerciseButton);
            this.Controls.Add(this.AddExerciseDescriptionTextBox);
            this.Controls.Add(this.AddExerciseNameTextBox);
            this.Name = "AddExerciseForm";
            this.Text = "Add Exercise";
            this.Load += new System.EventHandler(this.AddExerciseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox AddExerciseNameTextBox;
        private TextBox AddExerciseDescriptionTextBox;
        private Button AddExerciseButton;
        private ComboBox ExerciseComboBox;
        private Button UpdateExerciseButton;
        private Button RemoveExerciseButton;
        private CheckBox checkBoxIsActive;
    }
}