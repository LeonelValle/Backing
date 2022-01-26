namespace Backing
{
    partial class Validate
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Quality = new System.Windows.Forms.TextBox();
            this.txt_Eng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_BakeAt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quality:";
            // 
            // txt_Quality
            // 
            this.txt_Quality.Location = new System.Drawing.Point(76, 36);
            this.txt_Quality.Name = "txt_Quality";
            this.txt_Quality.Size = new System.Drawing.Size(206, 20);
            this.txt_Quality.TabIndex = 1;
            // 
            // txt_Eng
            // 
            this.txt_Eng.Location = new System.Drawing.Point(357, 36);
            this.txt_Eng.Name = "txt_Eng";
            this.txt_Eng.Size = new System.Drawing.Size(206, 20);
            this.txt_Eng.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Engineer:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(273, 240);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(84, 35);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_BakeAt
            // 
            this.txt_BakeAt.Location = new System.Drawing.Point(213, 90);
            this.txt_BakeAt.Name = "txt_BakeAt";
            this.txt_BakeAt.Size = new System.Drawing.Size(206, 20);
            this.txt_BakeAt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bake At:";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(213, 168);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(206, 20);
            this.txt_time.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baking Time:";
            // 
            // Validate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 324);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_BakeAt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Eng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Quality);
            this.Controls.Add(this.label1);
            this.Name = "Validate";
            this.Text = "Validate";
            this.Load += new System.EventHandler(this.Validate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Quality;
        private System.Windows.Forms.TextBox txt_Eng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_BakeAt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label label4;
    }
}