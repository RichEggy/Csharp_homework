namespace HOMEWORK_FORM
{
    partial class frmhomepage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnScreen = new System.Windows.Forms.Button();
            this.btn09 = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btncalculator = new System.Windows.Forms.Button();
            this.btnstructform = new System.Windows.Forms.Button();
            this.btnpos = new System.Windows.Forms.Button();
            this.btnloan = new System.Windows.Forms.Button();
            this.btnhello = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.IndianRed;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1854, 1355);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# Homework  ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Gold;
            this.splitContainer2.Panel1.Controls.Add(this.btnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.btnDraw);
            this.splitContainer2.Panel1.Controls.Add(this.btnScreen);
            this.splitContainer2.Panel1.Controls.Add(this.btn09);
            this.splitContainer2.Panel1.Controls.Add(this.btnMethod);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btncalculator);
            this.splitContainer2.Panel1.Controls.Add(this.btnstructform);
            this.splitContainer2.Panel1.Controls.Add(this.btnpos);
            this.splitContainer2.Panel1.Controls.Add(this.btnloan);
            this.splitContainer2.Panel1.Controls.Add(this.btnhello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = global::HOMEWORK_FORM.Properties.Resources._1144144;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Size = new System.Drawing.Size(1854, 1202);
            this.splitContainer2.SplitterDistance = 301;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(26, 1044);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(247, 36);
            this.btnDraw.TabIndex = 18;
            this.btnDraw.Text = "10 Painter";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnScreen
            // 
            this.btnScreen.Location = new System.Drawing.Point(26, 930);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(247, 36);
            this.btnScreen.TabIndex = 17;
            this.btnScreen.Text = "09 Screen Saver";
            this.btnScreen.UseVisualStyleBackColor = true;
            this.btnScreen.Click += new System.EventHandler(this.btnScreen_Click);
            // 
            // btn09
            // 
            this.btn09.Location = new System.Drawing.Point(26, 816);
            this.btn09.Name = "btn09";
            this.btn09.Size = new System.Drawing.Size(247, 36);
            this.btn09.TabIndex = 16;
            this.btn09.Text = "08 XOGame";
            this.btn09.UseVisualStyleBackColor = true;
            this.btn09.Click += new System.EventHandler(this.btn09_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(26, 592);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(247, 36);
            this.btnMethod.TabIndex = 15;
            this.btnMethod.Text = "06 For Do While";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "05 Student Grades";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncalculator
            // 
            this.btncalculator.Location = new System.Drawing.Point(26, 706);
            this.btncalculator.Name = "btncalculator";
            this.btncalculator.Size = new System.Drawing.Size(247, 36);
            this.btncalculator.TabIndex = 13;
            this.btncalculator.Text = "07 Calculator";
            this.btncalculator.UseVisualStyleBackColor = true;
            this.btncalculator.Click += new System.EventHandler(this.btncalculator_Click);
            // 
            // btnstructform
            // 
            this.btnstructform.Location = new System.Drawing.Point(26, 361);
            this.btnstructform.Name = "btnstructform";
            this.btnstructform.Size = new System.Drawing.Size(247, 36);
            this.btnstructform.TabIndex = 3;
            this.btnstructform.Text = "04 Student Struct Form";
            this.btnstructform.UseVisualStyleBackColor = true;
            this.btnstructform.Click += new System.EventHandler(this.btnstructform_Click);
            // 
            // btnpos
            // 
            this.btnpos.Location = new System.Drawing.Point(26, 251);
            this.btnpos.Name = "btnpos";
            this.btnpos.Size = new System.Drawing.Size(247, 36);
            this.btnpos.TabIndex = 2;
            this.btnpos.Text = "03 POS";
            this.btnpos.UseVisualStyleBackColor = true;
            this.btnpos.Click += new System.EventHandler(this.btnpos_Click);
            // 
            // btnloan
            // 
            this.btnloan.Location = new System.Drawing.Point(26, 140);
            this.btnloan.Name = "btnloan";
            this.btnloan.Size = new System.Drawing.Size(247, 36);
            this.btnloan.TabIndex = 1;
            this.btnloan.Text = "02 Loan";
            this.btnloan.UseVisualStyleBackColor = true;
            this.btnloan.Click += new System.EventHandler(this.btnloan_Click);
            // 
            // btnhello
            // 
            this.btnhello.Location = new System.Drawing.Point(26, 30);
            this.btnhello.Name = "btnhello";
            this.btnhello.Size = new System.Drawing.Size(247, 36);
            this.btnhello.TabIndex = 0;
            this.btnhello.Text = "01 Hello";
            this.btnhello.UseVisualStyleBackColor = true;
            this.btnhello.Click += new System.EventHandler(this.btnhello_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(26, 1154);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(247, 36);
            this.btnGuess.TabIndex = 19;
            this.btnGuess.Text = "11 Guess Number";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // frmhomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 1355);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmhomepage";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnhello;
        private System.Windows.Forms.Button btnstructform;
        private System.Windows.Forms.Button btnpos;
        private System.Windows.Forms.Button btnloan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalculator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btn09;
        private System.Windows.Forms.Button btnScreen;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnGuess;
    }
}

