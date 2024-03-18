namespace Gym.UI
{
    partial class BodyWeightMonitorForm
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
            this.ListBoxViewBodyWeightDates = new System.Windows.Forms.ListBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.DateTimePickerWeight = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ListBoxViewBodyWeightDates
            // 
            this.ListBoxViewBodyWeightDates.FormattingEnabled = true;
            this.ListBoxViewBodyWeightDates.ItemHeight = 15;
            this.ListBoxViewBodyWeightDates.Location = new System.Drawing.Point(12, 40);
            this.ListBoxViewBodyWeightDates.Name = "ListBoxViewBodyWeightDates";
            this.ListBoxViewBodyWeightDates.Size = new System.Drawing.Size(875, 499);
            this.ListBoxViewBodyWeightDates.TabIndex = 7;
            this.ListBoxViewBodyWeightDates.SelectedIndexChanged += new System.EventHandler(this.ListBoxViewBodyWeightDates_SelectedIndexChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(535, 12);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(62, 23);
            this.UpdateButton.TabIndex = 22;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(603, 12);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 21;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(470, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(59, 23);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Location = new System.Drawing.Point(311, 12);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.PlaceholderText = "Enter weight";
            this.TextBoxWeight.Size = new System.Drawing.Size(153, 23);
            this.TextBoxWeight.TabIndex = 18;
            // 
            // DateTimePickerWeight
            // 
            this.DateTimePickerWeight.Location = new System.Drawing.Point(12, 12);
            this.DateTimePickerWeight.MinDate = new System.DateTime(2024, 3, 11, 0, 0, 0, 0);
            this.DateTimePickerWeight.Name = "DateTimePickerWeight";
            this.DateTimePickerWeight.Size = new System.Drawing.Size(282, 23);
            this.DateTimePickerWeight.TabIndex = 15;
            // 
            // BodyWeightMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 547);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.DateTimePickerWeight);
            this.Controls.Add(this.ListBoxViewBodyWeightDates);
            this.Name = "BodyWeightMonitorForm";
            this.Text = "BodyWeightMonitorForm";
            this.Load += new System.EventHandler(this.BodyWeightMonitorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ListBoxViewBodyWeightDates;
        private Button UpdateButton;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox TextBoxWeight;
        private DateTimePicker DateTimePickerWeight;
    }
}