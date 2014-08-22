namespace WMSwithRFID
{
    partial class AddProductForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.weightInput = new System.Windows.Forms.NumericUpDown();
            this.daysToExpireInput = new System.Windows.Forms.NumericUpDown();
            this.unitPriceInput = new System.Windows.Forms.NumericUpDown();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.expireLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.addProductGB = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.weightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysToExpireInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceInput)).BeginInit();
            this.addProductGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(139, 216);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productNameTB
            // 
            this.productNameTB.Location = new System.Drawing.Point(127, 32);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(100, 20);
            this.productNameTB.TabIndex = 1;
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(127, 58);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(120, 20);
            this.weightInput.TabIndex = 2;
            // 
            // daysToExpireInput
            // 
            this.daysToExpireInput.Location = new System.Drawing.Point(127, 84);
            this.daysToExpireInput.Name = "daysToExpireInput";
            this.daysToExpireInput.Size = new System.Drawing.Size(120, 20);
            this.daysToExpireInput.TabIndex = 3;
            // 
            // unitPriceInput
            // 
            this.unitPriceInput.Location = new System.Drawing.Point(127, 110);
            this.unitPriceInput.Name = "unitPriceInput";
            this.unitPriceInput.Size = new System.Drawing.Size(120, 20);
            this.unitPriceInput.TabIndex = 4;
            // 
            // typeCB
            // 
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(127, 136);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(121, 21);
            this.typeCB.TabIndex = 5;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(68, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(68, 60);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 4;
            this.weightLabel.Text = "Weight";
            // 
            // expireLabel
            // 
            this.expireLabel.AutoSize = true;
            this.expireLabel.Location = new System.Drawing.Point(34, 86);
            this.expireLabel.Name = "expireLabel";
            this.expireLabel.Size = new System.Drawing.Size(75, 13);
            this.expireLabel.TabIndex = 4;
            this.expireLabel.Text = "Days to Expire";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(56, 112);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(53, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Unit Price";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(78, 139);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Type";
            // 
            // addProductGB
            // 
            this.addProductGB.Controls.Add(this.productNameTB);
            this.addProductGB.Controls.Add(this.typeLabel);
            this.addProductGB.Controls.Add(this.weightInput);
            this.addProductGB.Controls.Add(this.priceLabel);
            this.addProductGB.Controls.Add(this.daysToExpireInput);
            this.addProductGB.Controls.Add(this.expireLabel);
            this.addProductGB.Controls.Add(this.unitPriceInput);
            this.addProductGB.Controls.Add(this.weightLabel);
            this.addProductGB.Controls.Add(this.typeCB);
            this.addProductGB.Controls.Add(this.nameLabel);
            this.addProductGB.Location = new System.Drawing.Point(12, 12);
            this.addProductGB.Name = "addProductGB";
            this.addProductGB.Size = new System.Drawing.Size(319, 183);
            this.addProductGB.TabIndex = 7;
            this.addProductGB.TabStop = false;
            this.addProductGB.Text = "input the details of the product to be added";
            // 
            // AddProductForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 272);
            this.Controls.Add(this.addProductGB);
            this.Controls.Add(this.addButton);
            this.Name = "AddProductForm";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.weightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysToExpireInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceInput)).EndInit();
            this.addProductGB.ResumeLayout(false);
            this.addProductGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.NumericUpDown weightInput;
        private System.Windows.Forms.NumericUpDown daysToExpireInput;
        private System.Windows.Forms.NumericUpDown unitPriceInput;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label expireLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.GroupBox addProductGB;
    }
}