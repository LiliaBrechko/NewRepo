namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCreateUser = new Button();
            button1 = new Button();
            buttonCreateMeal = new Button();
            SuspendLayout();
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(12, 24);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(94, 29);
            buttonCreateUser.TabIndex = 0;
            buttonCreateUser.Text = "Create User";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 87);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 1;
            button1.Text = "Create Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonCreateMeal
            // 
            buttonCreateMeal.Location = new Point(12, 173);
            buttonCreateMeal.Name = "buttonCreateMeal";
            buttonCreateMeal.Size = new Size(135, 29);
            buttonCreateMeal.TabIndex = 2;
            buttonCreateMeal.Text = "Create Meal";
            buttonCreateMeal.UseVisualStyleBackColor = true;
            buttonCreateMeal.Click += buttonCreateMeal_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreateMeal);
            Controls.Add(button1);
            Controls.Add(buttonCreateUser);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreateUser;
        private Button button1;
        private Button buttonCreateMeal;
    }
}
