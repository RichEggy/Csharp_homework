namespace HOMEWORK_FORM
{
    partial class frmcalculator
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
            this.labnum1 = new System.Windows.Forms.Label();
            this.labnum2 = new System.Windows.Forms.Label();
            this.labanswer = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.labshowanswer = new System.Windows.Forms.Label();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labnum1
            // 
            this.labnum1.AutoSize = true;
            this.labnum1.Font = new System.Drawing.Font("宋体", 12F);
            this.labnum1.Location = new System.Drawing.Point(118, 69);
            this.labnum1.Name = "labnum1";
            this.labnum1.Size = new System.Drawing.Size(70, 24);
            this.labnum1.TabIndex = 0;
            this.labnum1.Text = "Num1:";
            // 
            // labnum2
            // 
            this.labnum2.AutoSize = true;
            this.labnum2.Font = new System.Drawing.Font("宋体", 12F);
            this.labnum2.Location = new System.Drawing.Point(118, 159);
            this.labnum2.Name = "labnum2";
            this.labnum2.Size = new System.Drawing.Size(70, 24);
            this.labnum2.TabIndex = 1;
            this.labnum2.Text = "Num2:";
            // 
            // labanswer
            // 
            this.labanswer.AutoSize = true;
            this.labanswer.Font = new System.Drawing.Font("宋体", 12F);
            this.labanswer.Location = new System.Drawing.Point(118, 300);
            this.labanswer.Name = "labanswer";
            this.labanswer.Size = new System.Drawing.Size(94, 24);
            this.labanswer.TabIndex = 2;
            this.labanswer.Text = "Answer:";
            // 
            // txtnum1
            // 
            this.txtnum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtnum1.Location = new System.Drawing.Point(297, 69);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 35);
            this.txtnum1.TabIndex = 3;
            // 
            // txtnum2
            // 
            this.txtnum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnum2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtnum2.Location = new System.Drawing.Point(297, 149);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 35);
            this.txtnum2.TabIndex = 4;
            // 
            // labshowanswer
            // 
            this.labshowanswer.BackColor = System.Drawing.Color.White;
            this.labshowanswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labshowanswer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labshowanswer.Location = new System.Drawing.Point(294, 290);
            this.labshowanswer.Name = "labshowanswer";
            this.labshowanswer.Size = new System.Drawing.Size(103, 30);
            this.labshowanswer.TabIndex = 5;
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnplus.Location = new System.Drawing.Point(552, 23);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(67, 38);
            this.btnplus.TabIndex = 6;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnminus.Location = new System.Drawing.Point(552, 111);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(67, 38);
            this.btnminus.TabIndex = 7;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnmultiply.Location = new System.Drawing.Point(552, 192);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(67, 38);
            this.btnmultiply.TabIndex = 8;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btndivision
            // 
            this.btndivision.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndivision.Location = new System.Drawing.Point(552, 282);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(67, 38);
            this.btndivision.TabIndex = 9;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(55, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "=================================";
            // 
            // frmcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.labshowanswer);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.labanswer);
            this.Controls.Add(this.labnum2);
            this.Controls.Add(this.labnum1);
            this.Name = "frmcalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labnum1;
        private System.Windows.Forms.Label labnum2;
        private System.Windows.Forms.Label labanswer;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label labshowanswer;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Label label1;
    }
}

