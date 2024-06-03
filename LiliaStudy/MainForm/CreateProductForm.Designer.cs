namespace MainForm
{
    partial class CreateProductForm
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
            textBoxProductName = new TextBox();
            textBoxCaloriePer100gram = new TextBox();
            textBoxFatPer100gram = new TextBox();
            textBoxCarbohydratesPer100Gram = new TextBox();
            textBoxProteinPer100Gram = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonCreateProduct = new Button();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(12, 30);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(125, 27);
            textBoxProductName.TabIndex = 0;
            // 
            // textBoxCaloriePer100gram
            // 
            textBoxCaloriePer100gram.Location = new Point(12, 100);
            textBoxCaloriePer100gram.Name = "textBoxCaloriePer100gram";
            textBoxCaloriePer100gram.Size = new Size(125, 27);
            textBoxCaloriePer100gram.TabIndex = 1;
            // 
            // textBoxFatPer100gram
            // 
            textBoxFatPer100gram.Location = new Point(232, 30);
            textBoxFatPer100gram.Name = "textBoxFatPer100gram";
            textBoxFatPer100gram.Size = new Size(125, 27);
            textBoxFatPer100gram.TabIndex = 2;
            // 
            // textBoxCarbohydratesPer100Gram
            // 
            textBoxCarbohydratesPer100Gram.Location = new Point(232, 177);
            textBoxCarbohydratesPer100Gram.Name = "textBoxCarbohydratesPer100Gram";
            textBoxCarbohydratesPer100Gram.Size = new Size(125, 27);
            textBoxCarbohydratesPer100Gram.TabIndex = 3;
            // 
            // textBoxProteinPer100Gram
            // 
            textBoxProteinPer100Gram.Location = new Point(232, 100);
            textBoxProteinPer100Gram.Name = "textBoxProteinPer100Gram";
            textBoxProteinPer100Gram.Size = new Size(125, 27);
            textBoxProteinPer100Gram.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 5;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 6;
            label2.Text = "Calorie Per 100 gram";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 9);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 7;
            label3.Text = "Fat Per 100 Gram";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 77);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 8;
            label4.Text = "Protein Per 100 Gram";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 154);
            label5.Name = "label5";
            label5.Size = new Size(197, 20);
            label5.TabIndex = 9;
            label5.Text = "Carbohydrates Per 100 Gram";
            // 
            // buttonCreateProduct
            // 
            buttonCreateProduct.Location = new Point(651, 359);
            buttonCreateProduct.Name = "buttonCreateProduct";
            buttonCreateProduct.Size = new Size(94, 29);
            buttonCreateProduct.TabIndex = 10;
            buttonCreateProduct.Text = "Create product";
            buttonCreateProduct.UseVisualStyleBackColor = true;
            buttonCreateProduct.Click += buttonCreateProduct_Click;
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCreateProduct);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxProteinPer100Gram);
            Controls.Add(textBoxCarbohydratesPer100Gram);
            Controls.Add(textBoxFatPer100gram);
            Controls.Add(textBoxCaloriePer100gram);
            Controls.Add(textBoxProductName);
            Name = "CreateProductForm";
            Text = "CreateProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductName;
        private TextBox textBoxCaloriePer100gram;
        private TextBox textBoxFatPer100gram;
        private TextBox textBoxCarbohydratesPer100Gram;
        private TextBox textBoxProteinPer100Gram;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonCreateProduct;
    }
}