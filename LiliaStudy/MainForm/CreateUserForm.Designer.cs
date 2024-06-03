namespace MainForm
{
    partial class CreateUserForm
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
            textBoxName = new TextBox();
            buttonCreate = new Button();
            label1 = new Label();
            textBoxAge = new TextBox();
            label3 = new Label();
            comboBoxGender = new ComboBox();
            label2 = new Label();
            textBoxWeight = new TextBox();
            textBoxHeight = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxActivityLevel = new ComboBox();
            comboBoxGoal = new ComboBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 0;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(12, 394);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(12, 99);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(125, 27);
            textBoxAge.TabIndex = 4;
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female" });
            comboBoxGender.Location = new Point(214, 39);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(151, 28);
            comboBoxGender.TabIndex = 7;
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 17);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 8;
            label2.Text = "Gender";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(12, 153);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(125, 27);
            textBoxWeight.TabIndex = 9;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(12, 225);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(125, 27);
            textBoxHeight.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 130);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 11;
            label4.Text = "Goal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 202);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 12;
            label5.Text = "Height";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 76);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 13;
            label6.Text = "ActivityLevel";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 130);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 14;
            label7.Text = "Weight";
            // 
            // comboBoxActivityLevel
            // 
            comboBoxActivityLevel.FormattingEnabled = true;
            comboBoxActivityLevel.Items.AddRange(new object[] { " Sedentary", " Lightly", " Moderately", " High" });
            comboBoxActivityLevel.Location = new Point(214, 99);
            comboBoxActivityLevel.Name = "comboBoxActivityLevel";
            comboBoxActivityLevel.Size = new Size(151, 28);
            comboBoxActivityLevel.TabIndex = 15;
            // 
            // comboBoxGoal
            // 
            comboBoxGoal.FormattingEnabled = true;
            comboBoxGoal.Items.AddRange(new object[] { " Cut", " Keep", " Bulk" });
            comboBoxGoal.Location = new Point(214, 153);
            comboBoxGoal.Name = "comboBoxGoal";
            comboBoxGoal.Size = new Size(151, 28);
            comboBoxGoal.TabIndex = 16;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxGoal);
            Controls.Add(comboBoxActivityLevel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWeight);
            Controls.Add(label2);
            Controls.Add(comboBoxGender);
            Controls.Add(label3);
            Controls.Add(textBoxAge);
            Controls.Add(label1);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxName);
            Name = "CreateUserForm";
            Text = "CreateUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Button buttonCreate;
        private Label label1;
        private TextBox textBoxAge;
        private Label label3;
        private ComboBox comboBoxGender;
        private Label label2;
        private TextBox textBoxWeight;
        private TextBox textBoxHeight;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxActivityLevel;
        private ComboBox comboBoxGoal;
    }
}