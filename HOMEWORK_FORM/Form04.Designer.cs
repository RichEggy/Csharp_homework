namespace HOMEWORK_FORM
{
    partial class Frm04
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
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHighLow = new System.Windows.Forms.Button();
            this.labChi = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labShow1 = new System.Windows.Forms.Label();
            this.labShow2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(37, 72);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(82, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 11F);
            this.btnSave.Location = new System.Drawing.Point(41, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 48);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("宋体", 11F);
            this.btnShow.Location = new System.Drawing.Point(267, 531);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(165, 48);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "顯示儲存内容";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnHighLow
            // 
            this.btnHighLow.Font = new System.Drawing.Font("宋体", 11F);
            this.btnHighLow.Location = new System.Drawing.Point(699, 531);
            this.btnHighLow.Name = "btnHighLow";
            this.btnHighLow.Size = new System.Drawing.Size(225, 48);
            this.btnHighLow.TabIndex = 13;
            this.btnHighLow.Text = "最高分/最低分科目";
            this.btnHighLow.UseVisualStyleBackColor = true;
            this.btnHighLow.Click += new System.EventHandler(this.btnHighLow_Click);
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labChi.Location = new System.Drawing.Point(37, 191);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(82, 24);
            this.labChi.TabIndex = 14;
            this.labChi.Text = "國文：";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labEng.Location = new System.Drawing.Point(37, 317);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(82, 24);
            this.labEng.TabIndex = 15;
            this.labEng.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMath.Location = new System.Drawing.Point(37, 435);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(82, 24);
            this.labMath.TabIndex = 16;
            this.labMath.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(267, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 35);
            this.txtName.TabIndex = 17;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("宋体", 12F);
            this.txtChi.Location = new System.Drawing.Point(267, 188);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(165, 35);
            this.txtChi.TabIndex = 18;
            this.txtChi.Text = "0";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("宋体", 12F);
            this.txtEng.Location = new System.Drawing.Point(267, 314);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(165, 35);
            this.txtEng.TabIndex = 19;
            this.txtEng.Text = "0";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMath.Location = new System.Drawing.Point(267, 432);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(165, 35);
            this.txtMath.TabIndex = 20;
            this.txtMath.Text = "0";
            // 
            // labShow1
            // 
            this.labShow1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labShow1.Font = new System.Drawing.Font("宋体", 12F);
            this.labShow1.Location = new System.Drawing.Point(20, 38);
            this.labShow1.Name = "labShow1";
            this.labShow1.Size = new System.Drawing.Size(378, 270);
            this.labShow1.TabIndex = 21;
           
            // 
            // labShow2
            // 
            this.labShow2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labShow2.Font = new System.Drawing.Font("宋体", 12F);
            this.labShow2.Location = new System.Drawing.Point(20, 321);
            this.labShow2.Name = "labShow2";
            this.labShow2.Size = new System.Drawing.Size(378, 115);
            this.labShow2.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labShow2);
            this.groupBox1.Controls.Add(this.labShow1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(526, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 446);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // Frm04
            // 
            this.ClientSize = new System.Drawing.Size(964, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.btnHighLow);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labName);
            this.Name = "Frm04";
            this.Text = "Student StructForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHighLow;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labShow1;
        private System.Windows.Forms.Label labShow2;



        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
    }
}


