namespace MainForm
{
    partial class CreateMealForm
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
            comboBoxUsers = new ComboBox();
            label1 = new Label();
            listBoxMeals = new ListBox();
            listBoxPortions = new ListBox();
            buttonCreateMeal = new Button();
            comboBoxProducts = new ComboBox();
            label2 = new Label();
            textBoxAmmount = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(23, 31);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(151, 28);
            comboBoxUsers.TabIndex = 0;
            comboBoxUsers.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Choose User";
            // 
            // listBoxMeals
            // 
            listBoxMeals.FormattingEnabled = true;
            listBoxMeals.Location = new Point(928, 12);
            listBoxMeals.Name = "listBoxMeals";
            listBoxMeals.Size = new Size(256, 244);
            listBoxMeals.TabIndex = 2;
            listBoxMeals.SelectedIndexChanged += listBoxMeals_SelectedIndexChanged;
            // 
            // listBoxPortions
            // 
            listBoxPortions.FormattingEnabled = true;
            listBoxPortions.Location = new Point(928, 262);
            listBoxPortions.Name = "listBoxPortions";
            listBoxPortions.Size = new Size(256, 244);
            listBoxPortions.TabIndex = 3;
            listBoxPortions.SelectedIndexChanged += listBoxPortions_SelectedIndexChanged;
            // 
            // buttonCreateMeal
            // 
            buttonCreateMeal.Location = new Point(23, 108);
            buttonCreateMeal.Name = "buttonCreateMeal";
            buttonCreateMeal.Size = new Size(151, 42);
            buttonCreateMeal.TabIndex = 4;
            buttonCreateMeal.Text = "Create";
            buttonCreateMeal.UseVisualStyleBackColor = true;
            buttonCreateMeal.Click += buttonCreateMeal_Click;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(23, 196);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(151, 28);
            comboBoxProducts.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 173);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 6;
            label2.Text = "Product";
            // 
            // textBoxAmmount
            // 
            textBoxAmmount.Location = new Point(23, 284);
            textBoxAmmount.Name = "textBoxAmmount";
            textBoxAmmount.Size = new Size(151, 27);
            textBoxAmmount.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 261);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 8;
            label3.Text = "Ammount";
            // 
            // CreateMealForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 695);
            Controls.Add(label3);
            Controls.Add(textBoxAmmount);
            Controls.Add(label2);
            Controls.Add(comboBoxProducts);
            Controls.Add(buttonCreateMeal);
            Controls.Add(listBoxPortions);
            Controls.Add(listBoxMeals);
            Controls.Add(label1);
            Controls.Add(comboBoxUsers);
            Name = "CreateMealForm";
            Text = "CreateMealForm";
            Load += CreateMealForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUsers;
        private Label label1;
        private ListBox listBoxMeals;
        private ListBox listBoxPortions;
        private Button buttonCreateMeal;
        private ComboBox comboBoxProducts;
        private Label label2;
        private TextBox textBoxAmmount;
        private Label label3;
    }
}