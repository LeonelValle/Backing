namespace Backing
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_Oven = new System.Windows.Forms.DataGridView();
            this.TakeOut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Pause = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_pkg = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_WO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_LotNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Assy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LotCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PartDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_PartNo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_BakeC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_BakeTime = new System.Windows.Forms.TextBox();
            this.cb_MSL = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Thickness = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Employ = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Llbl_Reports = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Oven)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_Oven
            // 
            this.dg_Oven.AllowUserToAddRows = false;
            this.dg_Oven.AllowUserToDeleteRows = false;
            this.dg_Oven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Oven.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Oven.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Oven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Oven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TakeOut,
            this.Pause});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Oven.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_Oven.Location = new System.Drawing.Point(12, 41);
            this.dg_Oven.Name = "dg_Oven";
            this.dg_Oven.RowHeadersWidth = 51;
            this.dg_Oven.Size = new System.Drawing.Size(1546, 465);
            this.dg_Oven.TabIndex = 0;
            this.dg_Oven.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Oven_CellClick);
            // 
            // TakeOut
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.TakeOut.DefaultCellStyle = dataGridViewCellStyle2;
            this.TakeOut.HeaderText = "Take Out";
            this.TakeOut.MinimumWidth = 6;
            this.TakeOut.Name = "TakeOut";
            this.TakeOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TakeOut.Text = "Take Out";
            this.TakeOut.UseColumnTextForButtonValue = true;
            // 
            // Pause
            // 
            this.Pause.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Pause.DataPropertyName = "Stop";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.DefaultCellStyle = dataGridViewCellStyle3;
            this.Pause.HeaderText = "Stop";
            this.Pause.MinimumWidth = 6;
            this.Pause.Name = "Pause";
            this.Pause.Text = "Stop";
            this.Pause.UseColumnTextForButtonValue = true;
            this.Pause.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lots in Oven:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cb_pkg);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_WO);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_LotNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Assy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_LotCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Qty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_PartDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_PartNo);
            this.groupBox1.Location = new System.Drawing.Point(16, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan Lot To Bake Info";
            // 
            // cb_pkg
            // 
            this.cb_pkg.Enabled = false;
            this.cb_pkg.FormattingEnabled = true;
            this.cb_pkg.Location = new System.Drawing.Point(232, 105);
            this.cb_pkg.Name = "cb_pkg";
            this.cb_pkg.Size = new System.Drawing.Size(173, 21);
            this.cb_pkg.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(425, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "WO:";
            // 
            // txt_WO
            // 
            this.txt_WO.Location = new System.Drawing.Point(428, 105);
            this.txt_WO.Name = "txt_WO";
            this.txt_WO.Size = new System.Drawing.Size(205, 20);
            this.txt_WO.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Lot No / Date Code:";
            // 
            // txt_LotNo
            // 
            this.txt_LotNo.Location = new System.Drawing.Point(232, 162);
            this.txt_LotNo.Name = "txt_LotNo";
            this.txt_LotNo.Size = new System.Drawing.Size(173, 20);
            this.txt_LotNo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Assembly Part#:";
            // 
            // txt_Assy
            // 
            this.txt_Assy.Location = new System.Drawing.Point(428, 51);
            this.txt_Assy.Name = "txt_Assy";
            this.txt_Assy.Size = new System.Drawing.Size(205, 20);
            this.txt_Assy.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Lot Code:";
            // 
            // txt_LotCode
            // 
            this.txt_LotCode.Location = new System.Drawing.Point(6, 51);
            this.txt_LotCode.Name = "txt_LotCode";
            this.txt_LotCode.Size = new System.Drawing.Size(205, 20);
            this.txt_LotCode.TabIndex = 8;
            this.txt_LotCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Wo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Package:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "QTY;";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(232, 51);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(173, 20);
            this.txt_Qty.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Part Desc:";
            // 
            // txt_PartDesc
            // 
            this.txt_PartDesc.Location = new System.Drawing.Point(9, 146);
            this.txt_PartDesc.Multiline = true;
            this.txt_PartDesc.Name = "txt_PartDesc";
            this.txt_PartDesc.ReadOnly = true;
            this.txt_PartDesc.Size = new System.Drawing.Size(205, 36);
            this.txt_PartDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part #:";
            // 
            // cb_PartNo
            // 
            this.cb_PartNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PartNo.FormattingEnabled = true;
            this.cb_PartNo.Location = new System.Drawing.Point(9, 104);
            this.cb_PartNo.Name = "cb_PartNo";
            this.cb_PartNo.Size = new System.Drawing.Size(202, 21);
            this.cb_PartNo.TabIndex = 0;
            this.cb_PartNo.SelectedIndexChanged += new System.EventHandler(this.cb_PartNo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.txt_BakeC);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.btn_Change);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_BakeTime);
            this.groupBox2.Controls.Add(this.cb_MSL);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cb_Thickness);
            this.groupBox2.Location = new System.Drawing.Point(950, 515);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 199);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backing Option";
            // 
            // txt_BakeC
            // 
            this.txt_BakeC.Enabled = false;
            this.txt_BakeC.Location = new System.Drawing.Point(232, 34);
            this.txt_BakeC.Name = "txt_BakeC";
            this.txt_BakeC.Size = new System.Drawing.Size(28, 20);
            this.txt_BakeC.TabIndex = 18;
            this.txt_BakeC.Text = "125";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(301, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Hours";
            // 
            // btn_Change
            // 
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.Location = new System.Drawing.Point(191, 141);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(120, 23);
            this.btn_Change.TabIndex = 16;
            this.btn_Change.Text = "Change Bake/Hours";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Bake at            ⁰C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "MSL:";
            // 
            // txt_BakeTime
            // 
            this.txt_BakeTime.Location = new System.Drawing.Point(191, 55);
            this.txt_BakeTime.Name = "txt_BakeTime";
            this.txt_BakeTime.Size = new System.Drawing.Size(104, 20);
            this.txt_BakeTime.TabIndex = 12;
            // 
            // cb_MSL
            // 
            this.cb_MSL.Enabled = false;
            this.cb_MSL.FormattingEnabled = true;
            this.cb_MSL.Location = new System.Drawing.Point(45, 143);
            this.cb_MSL.Name = "cb_MSL";
            this.cb_MSL.Size = new System.Drawing.Size(111, 21);
            this.cb_MSL.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Thickness:";
            // 
            // cb_Thickness
            // 
            this.cb_Thickness.Enabled = false;
            this.cb_Thickness.FormattingEnabled = true;
            this.cb_Thickness.Location = new System.Drawing.Point(45, 54);
            this.cb_Thickness.Name = "cb_Thickness";
            this.cb_Thickness.Size = new System.Drawing.Size(111, 21);
            this.cb_Thickness.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Scan Employee ID:";
            // 
            // txt_Employ
            // 
            this.txt_Employ.Location = new System.Drawing.Point(20, 54);
            this.txt_Employ.Name = "txt_Employ";
            this.txt_Employ.Size = new System.Drawing.Size(215, 20);
            this.txt_Employ.TabIndex = 12;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(20, 98);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(215, 23);
            this.btn_Start.TabIndex = 14;
            this.btn_Start.Text = "Start Baking";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(20, 139);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(215, 23);
            this.Btn_Clear.TabIndex = 15;
            this.Btn_Clear.Text = "Clear All";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Btn_Clear);
            this.groupBox3.Controls.Add(this.txt_Employ);
            this.groupBox3.Controls.Add(this.btn_Start);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(1310, 515);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 199);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Llbl_Reports
            // 
            this.Llbl_Reports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Llbl_Reports.AutoSize = true;
            this.Llbl_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llbl_Reports.Location = new System.Drawing.Point(1479, 18);
            this.Llbl_Reports.Name = "Llbl_Reports";
            this.Llbl_Reports.Size = new System.Drawing.Size(66, 20);
            this.Llbl_Reports.TabIndex = 17;
            this.Llbl_Reports.TabStop = true;
            this.Llbl_Reports.Text = "Reports";
            this.Llbl_Reports.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Llbl_Reports_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 725);
            this.Controls.Add(this.Llbl_Reports);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Oven);
            this.Name = "Form1";
            this.Text = "Baking Lots";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Oven)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PartDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_PartNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Assy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_LotCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_BakeTime;
        private System.Windows.Forms.ComboBox cb_MSL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Thickness;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Employ;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_LotNo;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewButtonColumn TakeOut;
        private System.Windows.Forms.DataGridViewButtonColumn Pause;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_WO;
        private System.Windows.Forms.DataGridView dg_Oven;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel Llbl_Reports;
        private System.Windows.Forms.TextBox txt_BakeC;
        private System.Windows.Forms.ComboBox cb_pkg;
    }
}

