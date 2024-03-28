namespace Gym.UI
{
    partial class ManageProfilesForm
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
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.TextBoxProfileDescription = new System.Windows.Forms.TextBox();
            this.TextBoxProfileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Checked = true;
            this.checkBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsActive.Location = new System.Drawing.Point(443, 16);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(67, 19);
            this.checkBoxIsActive.TabIndex = 13;
            this.checkBoxIsActive.Text = "isActive";
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(12, 70);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(208, 23);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 41);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(208, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(208, 23);
            this.comboBoxProfile.TabIndex = 10;
            this.comboBoxProfile.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfile_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 99);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(208, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // TextBoxProfileDescription
            // 
            this.TextBoxProfileDescription.Location = new System.Drawing.Point(226, 41);
            this.TextBoxProfileDescription.Multiline = true;
            this.TextBoxProfileDescription.Name = "TextBoxProfileDescription";
            this.TextBoxProfileDescription.PlaceholderText = "Profile Description";
            this.TextBoxProfileDescription.Size = new System.Drawing.Size(211, 81);
            this.TextBoxProfileDescription.TabIndex = 8;
            // 
            // TextBoxProfileName
            // 
            this.TextBoxProfileName.Location = new System.Drawing.Point(226, 12);
            this.TextBoxProfileName.Name = "TextBoxProfileName";
            this.TextBoxProfileName.PlaceholderText = "Profile Name";
            this.TextBoxProfileName.Size = new System.Drawing.Size(211, 23);
            this.TextBoxProfileName.TabIndex = 7;
            // 
            // ManageProfilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 137);
            this.Controls.Add(this.checkBoxIsActive);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxProfile);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.TextBoxProfileDescription);
            this.Controls.Add(this.TextBoxProfileName);
            this.Name = "ManageProfilesForm";
            this.Text = "ManageProfilesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageProfilesForm_FormClosed);
            this.Load += new System.EventHandler(this.ManageProfilesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBoxIsActive;
        private Button buttonRemove;
        private Button buttonUpdate;
        private ComboBox comboBoxProfile;
        private Button buttonAdd;
        private TextBox TextBoxProfileDescription;
        private TextBox TextBoxProfileName;
    }
}