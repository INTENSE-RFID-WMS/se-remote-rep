namespace WMSwithRFID
{
    partial class AddProductTypeForm
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
            this.productTypeNameTB = new System.Windows.Forms.TextBox();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.addProductTypeGB = new System.Windows.Forms.GroupBox();
            this.addProductTypeGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(105, 189);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productTypeNameTB
            // 
            this.productTypeNameTB.Location = new System.Drawing.Point(117, 58);
            this.productTypeNameTB.Name = "productTypeNameTB";
            this.productTypeNameTB.Size = new System.Drawing.Size(100, 20);
            this.productTypeNameTB.TabIndex = 1;
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Location = new System.Drawing.Point(37, 61);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(71, 13);
            this.productTypeLabel.TabIndex = 2;
            this.productTypeLabel.Text = "Product Type";
            // 
            // addProductTypeGB
            // 
            this.addProductTypeGB.Controls.Add(this.productTypeNameTB);
            this.addProductTypeGB.Controls.Add(this.productTypeLabel);
            this.addProductTypeGB.Location = new System.Drawing.Point(12, 52);
            this.addProductTypeGB.Name = "addProductTypeGB";
            this.addProductTypeGB.Size = new System.Drawing.Size(268, 131);
            this.addProductTypeGB.TabIndex = 3;
            this.addProductTypeGB.TabStop = false;
            this.addProductTypeGB.Text = "input the name of the product type to be added";
            // 
            // AddProductTypeForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.addProductTypeGB);
            this.Controls.Add(this.addButton);
            this.Name = "AddProductTypeForm";
            this.Text = "Add Product Type";
            this.Load += new System.EventHandler(this.AddProductTypeForm_Load);
            this.addProductTypeGB.ResumeLayout(false);
            this.addProductTypeGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox productTypeNameTB;
        private System.Windows.Forms.Label productTypeLabel;
        private System.Windows.Forms.GroupBox addProductTypeGB;
    }
}

