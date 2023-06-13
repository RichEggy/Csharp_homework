namespace HOMEWORK_FORM
{
    partial class Form12
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
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Crimson;
            this.txtTime.Location = new System.Drawing.Point(328, 151);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(504, 36);
            this.txtTime.TabIndex = 0;
            this.txtTime.TabStop = false;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("宋体", 15F);
            this.txtHour.Location = new System.Drawing.Point(278, 99);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(41, 42);
            this.txtHour.TabIndex = 1;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("宋体", 15F);
            this.txtMin.Location = new System.Drawing.Point(413, 99);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(41, 42);
            this.txtMin.TabIndex = 2;
            // 
            // txtSec
            // 
            this.txtSec.Font = new System.Drawing.Font("宋体", 15F);
            this.txtSec.Location = new System.Drawing.Point(548, 99);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(41, 42);
            this.txtSec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(345, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(482, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(630, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(37, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alarm Time ：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSec);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.txtHour);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(204, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 279);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(278, 215);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 34);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Set Alarm";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1147, 760);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTime);
            this.Name = "Form12";
            this.Text = "Alarm Clock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
    }
}