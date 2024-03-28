namespace Gym.UI
{
    partial class MainForm
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
            this.AddExerciseFormOpenButton = new System.Windows.Forms.Button();
            this.ViewEditTrainingSessionButton = new System.Windows.Forms.Button();
            this.ManageBodyWeightButton = new System.Windows.Forms.Button();
            this.buttonManageProfiles = new System.Windows.Forms.Button();
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddExerciseFormOpenButton
            // 
            this.AddExerciseFormOpenButton.Location = new System.Drawing.Point(83, 84);
            this.AddExerciseFormOpenButton.Name = "AddExerciseFormOpenButton";
            this.AddExerciseFormOpenButton.Size = new System.Drawing.Size(134, 23);
            this.AddExerciseFormOpenButton.TabIndex = 0;
            this.AddExerciseFormOpenButton.Text = "Manage Execises";
            this.AddExerciseFormOpenButton.UseVisualStyleBackColor = true;
            this.AddExerciseFormOpenButton.Click += new System.EventHandler(this.AddExerciseFormOpenButton_Click);
            // 
            // ViewEditTrainingSessionButton
            // 
            this.ViewEditTrainingSessionButton.Location = new System.Drawing.Point(83, 113);
            this.ViewEditTrainingSessionButton.Name = "ViewEditTrainingSessionButton";
            this.ViewEditTrainingSessionButton.Size = new System.Drawing.Size(134, 23);
            this.ViewEditTrainingSessionButton.TabIndex = 2;
            this.ViewEditTrainingSessionButton.Text = "Manage Workouts";
            this.ViewEditTrainingSessionButton.UseVisualStyleBackColor = true;
            this.ViewEditTrainingSessionButton.Click += new System.EventHandler(this.ViewEditTrainingSessionButton_Click);
            // 
            // ManageBodyWeightButton
            // 
            this.ManageBodyWeightButton.Location = new System.Drawing.Point(83, 142);
            this.ManageBodyWeightButton.Name = "ManageBodyWeightButton";
            this.ManageBodyWeightButton.Size = new System.Drawing.Size(134, 23);
            this.ManageBodyWeightButton.TabIndex = 3;
            this.ManageBodyWeightButton.Text = "Manage Body Weight";
            this.ManageBodyWeightButton.UseVisualStyleBackColor = true;
            this.ManageBodyWeightButton.Click += new System.EventHandler(this.ManageBodyWeightButton_Click);
            // 
            // buttonManageProfiles
            // 
            this.buttonManageProfiles.Location = new System.Drawing.Point(83, 55);
            this.buttonManageProfiles.Name = "buttonManageProfiles";
            this.buttonManageProfiles.Size = new System.Drawing.Size(134, 23);
            this.buttonManageProfiles.TabIndex = 4;
            this.buttonManageProfiles.Text = "Manage Profiles";
            this.buttonManageProfiles.UseVisualStyleBackColor = true;
            this.buttonManageProfiles.Click += new System.EventHandler(this.buttonManageProfiles_Click);
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Location = new System.Drawing.Point(83, 26);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(134, 23);
            this.comboBoxProfile.TabIndex = 5;
            this.comboBoxProfile.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfile_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 197);
            this.Controls.Add(this.comboBoxProfile);
            this.Controls.Add(this.buttonManageProfiles);
            this.Controls.Add(this.ManageBodyWeightButton);
            this.Controls.Add(this.ViewEditTrainingSessionButton);
            this.Controls.Add(this.AddExerciseFormOpenButton);
            this.Name = "MainForm";
            this.Text = "GYM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddExerciseFormOpenButton;
        private Button ViewEditTrainingSessionButton;
        private Button ManageBodyWeightButton;
        private Button buttonManageProfiles;
        private ComboBox comboBoxProfile;
    }
}