namespace HOMEWORK_FORM
{
    partial class Form05
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
            this.labName = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("宋体", 12F);
            this.labName.Location = new System.Drawing.Point(12, 90);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(82, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("宋体", 12F);
            this.labChinese.Location = new System.Drawing.Point(12, 160);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(82, 24);
            this.labChinese.TabIndex = 1;
            this.labChinese.Text = "國文：";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("宋体", 12F);
            this.labEnglish.Location = new System.Drawing.Point(12, 230);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(82, 24);
            this.labEnglish.TabIndex = 2;
            this.labEnglish.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("宋体", 12F);
            this.labMath.Location = new System.Drawing.Point(12, 300);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(82, 24);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學：";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(131, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 35);
            this.txtName.TabIndex = 4;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("宋体", 12F);
            this.txtChinese.Location = new System.Drawing.Point(131, 160);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(160, 35);
            this.txtChinese.TabIndex = 5;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("宋体", 12F);
            this.txtEnglish.Location = new System.Drawing.Point(131, 230);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(160, 35);
            this.txtEnglish.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMath.Location = new System.Drawing.Point(131, 300);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(160, 35);
            this.txtMath.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 12F);
            this.btnAdd.Location = new System.Drawing.Point(113, 440);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSave.Location = new System.Drawing.Point(113, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "隨機儲存資料";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSub
            // 
            this.btnSub.Enabled = false;
            this.btnSub.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSub.Location = new System.Drawing.Point(113, 593);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(178, 39);
            this.btnSub.TabIndex = 10;
            this.btnSub.Text = "各科統計";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click_1);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("宋体", 12F);
            this.btnClean.Location = new System.Drawing.Point(113, 673);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(178, 37);
            this.btnClean.TabIndex = 11;
            this.btnClean.Text = "重設所有資料";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("宋体", 12F);
            this.btnRandom.Location = new System.Drawing.Point(113, 743);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(178, 39);
            this.btnRandom.TabIndex = 12;
            this.btnRandom.Text = "隨機加入20筆";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click_1);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("宋体", 9F);
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(366, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(887, 533);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(366, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(886, 136);
            this.label1.TabIndex = 18;
            // 
            // Form05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 848);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form05";
            this.Text = "Myhomework0709";
            this.Load += new System.EventHandler(this.Form05_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}

