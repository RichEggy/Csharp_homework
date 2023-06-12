namespace HOMEWORK_FORM
{
    partial class Frm02_Money
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lab貸款金額 = new System.Windows.Forms.Label();
            this.lab期限 = new System.Windows.Forms.Label();
            this.lab利率 = new System.Windows.Forms.Label();
            this.lab頭期款 = new System.Windows.Forms.Label();
            this.txtLoanMoney = new System.Windows.Forms.TextBox();
            this.txt期限 = new System.Windows.Forms.TextBox();
            this.txt利率 = new System.Windows.Forms.TextBox();
            this.txt頭期款 = new System.Windows.Forms.TextBox();
            this.btnMonthPay = new System.Windows.Forms.Button();
            this.btnTotalPay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab貸款金額
            // 
            this.lab貸款金額.AutoSize = true;
            this.lab貸款金額.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab貸款金額.Location = new System.Drawing.Point(95, 69);
            this.lab貸款金額.Name = "lab貸款金額";
            this.lab貸款金額.Size = new System.Drawing.Size(94, 21);
            this.lab貸款金額.TabIndex = 0;
            this.lab貸款金額.Text = "貸款金額";
            this.lab貸款金額.Click += new System.EventHandler(this.lab貸款金額_Click);
            // 
            // lab期限
            // 
            this.lab期限.AutoSize = true;
            this.lab期限.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab期限.Location = new System.Drawing.Point(95, 142);
            this.lab期限.Name = "lab期限";
            this.lab期限.Size = new System.Drawing.Size(115, 21);
            this.lab期限.TabIndex = 1;
            this.lab期限.Text = "期限（年）";
            // 
            // lab利率
            // 
            this.lab利率.AutoSize = true;
            this.lab利率.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab利率.Location = new System.Drawing.Point(95, 224);
            this.lab利率.Name = "lab利率";
            this.lab利率.Size = new System.Drawing.Size(105, 21);
            this.lab利率.TabIndex = 2;
            this.lab利率.Text = "利率（%）";
            // 
            // lab頭期款
            // 
            this.lab頭期款.AutoSize = true;
            this.lab頭期款.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab頭期款.Location = new System.Drawing.Point(95, 304);
            this.lab頭期款.Name = "lab頭期款";
            this.lab頭期款.Size = new System.Drawing.Size(73, 21);
            this.lab頭期款.TabIndex = 3;
            this.lab頭期款.Text = "頭期款";
            // 
            // txtLoanMoney
            // 
            this.txtLoanMoney.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoanMoney.Location = new System.Drawing.Point(455, 58);
            this.txtLoanMoney.Name = "txtLoanMoney";
            this.txtLoanMoney.Size = new System.Drawing.Size(100, 31);
            this.txtLoanMoney.TabIndex = 4;
            this.txtLoanMoney.Text = "10000";
            this.txtLoanMoney.TextChanged += new System.EventHandler(this.txtLoanMoney_TextChanged);
            // 
            // txt期限
            // 
            this.txt期限.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt期限.Location = new System.Drawing.Point(455, 132);
            this.txt期限.Name = "txt期限";
            this.txt期限.Size = new System.Drawing.Size(100, 31);
            this.txt期限.TabIndex = 5;
            this.txt期限.Text = "2";
            this.txt期限.TextChanged += new System.EventHandler(this.txt期限_TextChanged);
            // 
            // txt利率
            // 
            this.txt利率.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt利率.Location = new System.Drawing.Point(455, 214);
            this.txt利率.Name = "txt利率";
            this.txt利率.Size = new System.Drawing.Size(100, 31);
            this.txt利率.TabIndex = 6;
            this.txt利率.Text = "10";
            this.txt利率.TextChanged += new System.EventHandler(this.txt利率_TextChanged);
            // 
            // txt頭期款
            // 
            this.txt頭期款.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt頭期款.Location = new System.Drawing.Point(455, 301);
            this.txt頭期款.Name = "txt頭期款";
            this.txt頭期款.Size = new System.Drawing.Size(100, 31);
            this.txt頭期款.TabIndex = 7;
            this.txt頭期款.Text = "0";
            this.txt頭期款.TextChanged += new System.EventHandler(this.txt頭期款_TextChanged);
            // 
            // btnMonthPay
            // 
            this.btnMonthPay.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMonthPay.Location = new System.Drawing.Point(60, 376);
            this.btnMonthPay.Name = "btnMonthPay";
            this.btnMonthPay.Size = new System.Drawing.Size(161, 31);
            this.btnMonthPay.TabIndex = 8;
            this.btnMonthPay.Text = "PMT(月付）";
            this.btnMonthPay.UseVisualStyleBackColor = true;
            this.btnMonthPay.Click += new System.EventHandler(this.btnMonthPay_Click);
            // 
            // btnTotalPay
            // 
            this.btnTotalPay.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTotalPay.Location = new System.Drawing.Point(324, 376);
            this.btnTotalPay.Name = "btnTotalPay";
            this.btnTotalPay.Size = new System.Drawing.Size(161, 31);
            this.btnTotalPay.TabIndex = 9;
            this.btnTotalPay.Text = "總付款";
            this.btnTotalPay.UseVisualStyleBackColor = true;
            this.btnTotalPay.Click += new System.EventHandler(this.btnTotalPay_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReport.Location = new System.Drawing.Point(564, 376);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(161, 31);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Frm02_Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPay);
            this.Controls.Add(this.btnMonthPay);
            this.Controls.Add(this.txt頭期款);
            this.Controls.Add(this.txt利率);
            this.Controls.Add(this.txt期限);
            this.Controls.Add(this.txtLoanMoney);
            this.Controls.Add(this.lab頭期款);
            this.Controls.Add(this.lab利率);
            this.Controls.Add(this.lab期限);
            this.Controls.Add(this.lab貸款金額);
            this.Name = "Frm02_Money";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab貸款金額;
        private System.Windows.Forms.Label lab期限;
        private System.Windows.Forms.Label lab利率;
        private System.Windows.Forms.Label lab頭期款;
        private System.Windows.Forms.TextBox txtLoanMoney;
        private System.Windows.Forms.TextBox txt期限;
        private System.Windows.Forms.TextBox txt利率;
        private System.Windows.Forms.TextBox txt頭期款;
        private System.Windows.Forms.Button btnMonthPay;
        private System.Windows.Forms.Button btnTotalPay;
        private System.Windows.Forms.Button btnReport;
    }
}

