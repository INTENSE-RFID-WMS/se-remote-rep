namespace WMSwithRFID
{
    partial class Reader
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openConnectionBtn = new System.Windows.Forms.Button();
            this.gbxCommModel = new System.Windows.Forms.GroupBox();
            this.cbxCom = new System.Windows.Forms.ComboBox();
            this.rbnCom = new System.Windows.Forms.RadioButton();
            this.closeConnectionBtn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxBeep = new System.Windows.Forms.CheckBox();
            this.timerUpdateListView = new System.Windows.Forms.Timer(this.components);
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.stopReadingBtn = new System.Windows.Forms.Button();
            this.startReadingBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.productLineCB = new System.Windows.Forms.ComboBox();
            this.productCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.manufacturerCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxCommModel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openConnectionBtn
            // 
            this.openConnectionBtn.Location = new System.Drawing.Point(12, 165);
            this.openConnectionBtn.Name = "openConnectionBtn";
            this.openConnectionBtn.Size = new System.Drawing.Size(96, 25);
            this.openConnectionBtn.TabIndex = 0;
            this.openConnectionBtn.Text = "Connect";
            this.openConnectionBtn.UseVisualStyleBackColor = true;
            this.openConnectionBtn.Click += new System.EventHandler(this.openConnectionBtn_Click);
            // 
            // gbxCommModel
            // 
            this.gbxCommModel.Controls.Add(this.cbxCom);
            this.gbxCommModel.Controls.Add(this.rbnCom);
            this.gbxCommModel.Location = new System.Drawing.Point(12, 12);
            this.gbxCommModel.Name = "gbxCommModel";
            this.gbxCommModel.Size = new System.Drawing.Size(152, 99);
            this.gbxCommModel.TabIndex = 1;
            this.gbxCommModel.TabStop = false;
            this.gbxCommModel.Text = "Connect type";
            // 
            // cbxCom
            // 
            this.cbxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCom.FormattingEnabled = true;
            this.cbxCom.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.cbxCom.Location = new System.Drawing.Point(44, 50);
            this.cbxCom.Name = "cbxCom";
            this.cbxCom.Size = new System.Drawing.Size(102, 21);
            this.cbxCom.TabIndex = 7;
            // 
            // rbnCom
            // 
            this.rbnCom.AutoSize = true;
            this.rbnCom.Location = new System.Drawing.Point(11, 31);
            this.rbnCom.Name = "rbnCom";
            this.rbnCom.Size = new System.Drawing.Size(49, 17);
            this.rbnCom.TabIndex = 1;
            this.rbnCom.TabStop = true;
            this.rbnCom.Text = "COM";
            this.rbnCom.UseVisualStyleBackColor = true;
            // 
            // closeConnectionBtn
            // 
            this.closeConnectionBtn.Location = new System.Drawing.Point(12, 196);
            this.closeConnectionBtn.Name = "closeConnectionBtn";
            this.closeConnectionBtn.Size = new System.Drawing.Size(96, 25);
            this.closeConnectionBtn.TabIndex = 0;
            this.closeConnectionBtn.Text = "Disconnect";
            this.closeConnectionBtn.UseVisualStyleBackColor = true;
            this.closeConnectionBtn.Click += new System.EventHandler(this.btnCloseConn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 529);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxBeep
            // 
            this.cbxBeep.AutoSize = true;
            this.cbxBeep.Location = new System.Drawing.Point(12, 239);
            this.cbxBeep.Name = "cbxBeep";
            this.cbxBeep.Size = new System.Drawing.Size(51, 17);
            this.cbxBeep.TabIndex = 2;
            this.cbxBeep.Text = "Beep";
            this.cbxBeep.UseVisualStyleBackColor = true;
            // 
            // timerUpdateListView
            // 
            this.timerUpdateListView.Enabled = true;
            this.timerUpdateListView.Interval = 200;
            this.timerUpdateListView.Tick += new System.EventHandler(this.timerUpdateListView_Tick);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(12, 363);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(152, 160);
            this.lstResult.TabIndex = 8;
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(12, 333);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(96, 25);
            this.btnClearResult.TabIndex = 9;
            this.btnClearResult.Text = "Clear Result";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // stopReadingBtn
            // 
            this.stopReadingBtn.Location = new System.Drawing.Point(126, 22);
            this.stopReadingBtn.Name = "stopReadingBtn";
            this.stopReadingBtn.Size = new System.Drawing.Size(75, 25);
            this.stopReadingBtn.TabIndex = 3;
            this.stopReadingBtn.Text = "Stop";
            this.stopReadingBtn.UseVisualStyleBackColor = true;
            this.stopReadingBtn.Click += new System.EventHandler(this.btnStopReadCards_Click);
            // 
            // startReadingBtn
            // 
            this.startReadingBtn.Location = new System.Drawing.Point(45, 22);
            this.startReadingBtn.Name = "startReadingBtn";
            this.startReadingBtn.Size = new System.Drawing.Size(75, 25);
            this.startReadingBtn.TabIndex = 3;
            this.startReadingBtn.Text = "Start";
            this.startReadingBtn.UseVisualStyleBackColor = true;
            this.startReadingBtn.Click += new System.EventHandler(this.btnReadCards_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.manufacturerCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.productCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.productLineCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.startReadingBtn);
            this.groupBox1.Controls.Add(this.stopReadingBtn);
            this.groupBox1.Location = new System.Drawing.Point(170, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 525);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read Tag";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 435);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            this.dataGridView1.MouseHover += new System.EventHandler(this.dataGridView1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Production Line No.";
            // 
            // productLineCB
            // 
            this.productLineCB.FormattingEnabled = true;
            this.productLineCB.Location = new System.Drawing.Point(369, 25);
            this.productLineCB.Name = "productLineCB";
            this.productLineCB.Size = new System.Drawing.Size(46, 21);
            this.productLineCB.TabIndex = 8;
            // 
            // productCB
            // 
            this.productCB.FormattingEnabled = true;
            this.productCB.Location = new System.Drawing.Point(508, 25);
            this.productCB.Name = "productCB";
            this.productCB.Size = new System.Drawing.Size(145, 21);
            this.productCB.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product";
            // 
            // manufacturerCB
            // 
            this.manufacturerCB.FormattingEnabled = true;
            this.manufacturerCB.Location = new System.Drawing.Point(791, 25);
            this.manufacturerCB.Name = "manufacturerCB";
            this.manufacturerCB.Size = new System.Drawing.Size(137, 21);
            this.manufacturerCB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Manufacturer";
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 561);
            this.Controls.Add(this.btnClearResult);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxBeep);
            this.Controls.Add(this.gbxCommModel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.closeConnectionBtn);
            this.Controls.Add(this.openConnectionBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# FRID Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.gbxCommModel.ResumeLayout(false);
            this.gbxCommModel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openConnectionBtn;
        private System.Windows.Forms.GroupBox gbxCommModel;
        private System.Windows.Forms.Button closeConnectionBtn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbxBeep;
        private System.Windows.Forms.Timer timerUpdateListView;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.ComboBox cbxCom;
        private System.Windows.Forms.RadioButton rbnCom;
        private System.Windows.Forms.Button stopReadingBtn;
        private System.Windows.Forms.Button startReadingBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox manufacturerCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox productCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productLineCB;
        private System.Windows.Forms.Label label1;
    }
}

