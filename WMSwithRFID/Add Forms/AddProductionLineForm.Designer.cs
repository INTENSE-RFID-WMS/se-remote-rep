namespace WMSwithRFID
{
    partial class AddProductionLineForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productProductionLineCB = new System.Windows.Forms.ComboBox();
            this.productionLineNoNumbericDP = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productionLineNoNumbericDP)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(159, 131);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Production Line No.";
            // 
            // productProductionLineCB
            // 
            this.productProductionLineCB.FormattingEnabled = true;
            this.productProductionLineCB.Location = new System.Drawing.Point(159, 85);
            this.productProductionLineCB.Name = "productProductionLineCB";
            this.productProductionLineCB.Size = new System.Drawing.Size(154, 21);
            this.productProductionLineCB.TabIndex = 3;
            // 
            // productionLineNoNumbericDP
            // 
            this.productionLineNoNumbericDP.Location = new System.Drawing.Point(159, 46);
            this.productionLineNoNumbericDP.Name = "productionLineNoNumbericDP";
            this.productionLineNoNumbericDP.Size = new System.Drawing.Size(154, 20);
            this.productionLineNoNumbericDP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Product";
            // 
            // AddProductionLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productionLineNoNumbericDP);
            this.Controls.Add(this.productProductionLineCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Name = "AddProductionLineForm";
            this.Text = "AddProductionLineForm";
            ((System.ComponentModel.ISupportInitialize)(this.productionLineNoNumbericDP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productProductionLineCB;
        private System.Windows.Forms.NumericUpDown productionLineNoNumbericDP;
        private System.Windows.Forms.Label label2;
    }
}