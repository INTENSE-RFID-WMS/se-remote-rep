namespace WMSwithRFID.Add_Forms
{
    partial class AddWarehouseForm
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
            this.addWarehouseGB = new System.Windows.Forms.GroupBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addWarehouseGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWarehouseGB
            // 
            this.addWarehouseGB.Controls.Add(this.addressTB);
            this.addWarehouseGB.Controls.Add(this.nameTB);
            this.addWarehouseGB.Controls.Add(this.addressLabel);
            this.addWarehouseGB.Controls.Add(this.nameLabel);
            this.addWarehouseGB.Location = new System.Drawing.Point(23, 31);
            this.addWarehouseGB.Name = "addWarehouseGB";
            this.addWarehouseGB.Size = new System.Drawing.Size(248, 144);
            this.addWarehouseGB.TabIndex = 0;
            this.addWarehouseGB.TabStop = false;
            this.addWarehouseGB.Text = "input the details of the warehouse to be added";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(86, 91);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(100, 20);
            this.addressTB.TabIndex = 3;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(86, 45);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(33, 91);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(109, 194);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddWarehouseForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addWarehouseGB);
            this.Name = "AddWarehouseForm";
            this.Text = "Add Warehouse";
            this.addWarehouseGB.ResumeLayout(false);
            this.addWarehouseGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addWarehouseGB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addButton;
    }
}