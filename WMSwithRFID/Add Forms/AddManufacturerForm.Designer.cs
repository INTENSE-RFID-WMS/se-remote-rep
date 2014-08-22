namespace WMSwithRFID
{
    partial class AddManufacturerForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.manufacturerGB = new System.Windows.Forms.GroupBox();
            this.manufacturerGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(118, 205);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(50, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(106, 43);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 2;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(50, 81);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address";
            // 
            // addressTB
            // 
            this.addressTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTB.Location = new System.Drawing.Point(106, 78);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(100, 20);
            this.addressTB.TabIndex = 2;
            // 
            // manufacturerGB
            // 
            this.manufacturerGB.Controls.Add(this.nameTB);
            this.manufacturerGB.Controls.Add(this.addressTB);
            this.manufacturerGB.Controls.Add(this.nameLabel);
            this.manufacturerGB.Controls.Add(this.addressLabel);
            this.manufacturerGB.Location = new System.Drawing.Point(12, 62);
            this.manufacturerGB.Name = "manufacturerGB";
            this.manufacturerGB.Size = new System.Drawing.Size(268, 137);
            this.manufacturerGB.TabIndex = 3;
            this.manufacturerGB.TabStop = false;
            this.manufacturerGB.Text = "input the manufacturer details to be added";
            // 
            // AddManufacturerForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.manufacturerGB);
            this.Controls.Add(this.addButton);
            this.Name = "AddManufacturerForm";
            this.Text = "Add Manufacturer";
            this.manufacturerGB.ResumeLayout(false);
            this.manufacturerGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.GroupBox manufacturerGB;
    }
}