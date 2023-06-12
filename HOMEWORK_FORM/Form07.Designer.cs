namespace HOMEWORK_FORM
{
    partial class FrmMethod
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
            this.labNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnoddoreven = new System.Windows.Forms.Button();
            this.btnarrmaxmin = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnarrmax = new System.Windows.Forms.Button();
            this.btnarrmin = new System.Windows.Forms.Button();
            this.btnarroddeven = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnLongestName = new System.Windows.Forms.Button();
            this.btnCc = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn1010 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.txtTree = new System.Windows.Forms.TextBox();
            this.btnTree = new System.Windows.Forms.Button();
            this.btn99 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn樂透 = new System.Windows.Forms.Button();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btndo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtstep = new System.Windows.Forms.TextBox();
            this.labR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("宋体", 16F);
            this.labNumber.Location = new System.Drawing.Point(48, 58);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(127, 33);
            this.labNumber.TabIndex = 0;
            this.labNumber.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("宋体", 10F);
            this.txtNumber.Location = new System.Drawing.Point(285, 61);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(218, 30);
            this.txtNumber.TabIndex = 1;
            // 
            // btnoddoreven
            // 
            this.btnoddoreven.Font = new System.Drawing.Font("宋体", 10F);
            this.btnoddoreven.Location = new System.Drawing.Point(46, 137);
            this.btnoddoreven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnoddoreven.Name = "btnoddoreven";
            this.btnoddoreven.Size = new System.Drawing.Size(180, 80);
            this.btnoddoreven.TabIndex = 2;
            this.btnoddoreven.Text = "輸入的數為奇數或偶數？";
            this.btnoddoreven.UseVisualStyleBackColor = true;
            this.btnoddoreven.Click += new System.EventHandler(this.btnoddoreven_Click);
            // 
            // btnarrmaxmin
            // 
            this.btnarrmaxmin.Font = new System.Drawing.Font("宋体", 10F);
            this.btnarrmaxmin.Location = new System.Drawing.Point(46, 254);
            this.btnarrmaxmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnarrmaxmin.Name = "btnarrmaxmin";
            this.btnarrmaxmin.Size = new System.Drawing.Size(180, 78);
            this.btnarrmaxmin.TabIndex = 3;
            this.btnarrmaxmin.Text = "陣列arr0711[]最大/最小值";
            this.btnarrmaxmin.UseVisualStyleBackColor = true;
            this.btnarrmaxmin.Click += new System.EventHandler(this.btnarrmaxmin_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("宋体", 16F);
            this.labResult.Location = new System.Drawing.Point(609, 61);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(127, 33);
            this.labResult.TabIndex = 4;
            this.labResult.Text = "Result:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("宋体", 10F);
            this.btnClear.Location = new System.Drawing.Point(1243, 392);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 56);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnarrmax
            // 
            this.btnarrmax.Font = new System.Drawing.Font("宋体", 10F);
            this.btnarrmax.Location = new System.Drawing.Point(55, 592);
            this.btnarrmax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnarrmax.Name = "btnarrmax";
            this.btnarrmax.Size = new System.Drawing.Size(189, 78);
            this.btnarrmax.TabIndex = 7;
            this.btnarrmax.Text = "Max(陣列arr0711[])";
            this.btnarrmax.UseVisualStyleBackColor = true;
            this.btnarrmax.Click += new System.EventHandler(this.btnarrmax_Click);
            // 
            // btnarrmin
            // 
            this.btnarrmin.Font = new System.Drawing.Font("宋体", 10F);
            this.btnarrmin.Location = new System.Drawing.Point(55, 480);
            this.btnarrmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnarrmin.Name = "btnarrmin";
            this.btnarrmin.Size = new System.Drawing.Size(189, 78);
            this.btnarrmin.TabIndex = 8;
            this.btnarrmin.Text = "Min(陣列arr0711[])";
            this.btnarrmin.UseVisualStyleBackColor = true;
            this.btnarrmin.Click += new System.EventHandler(this.btnarrmin_Click);
            // 
            // btnarroddeven
            // 
            this.btnarroddeven.Font = new System.Drawing.Font("宋体", 10F);
            this.btnarroddeven.Location = new System.Drawing.Point(55, 372);
            this.btnarroddeven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnarroddeven.Name = "btnarroddeven";
            this.btnarroddeven.Size = new System.Drawing.Size(171, 78);
            this.btnarroddeven.TabIndex = 9;
            this.btnarroddeven.Text = "陣列arr0711[]統計奇偶數";
            this.btnarroddeven.UseVisualStyleBackColor = true;
            this.btnarroddeven.Click += new System.EventHandler(this.btnarroddeven_Click);
            // 
            // btnsum
            // 
            this.btnsum.Font = new System.Drawing.Font("宋体", 10F);
            this.btnsum.Location = new System.Drawing.Point(55, 698);
            this.btnsum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(189, 78);
            this.btnsum.TabIndex = 10;
            this.btnsum.Text = "Sum(陣列arr0711[])";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnLongestName
            // 
            this.btnLongestName.Font = new System.Drawing.Font("宋体", 10F);
            this.btnLongestName.Location = new System.Drawing.Point(285, 139);
            this.btnLongestName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLongestName.Name = "btnLongestName";
            this.btnLongestName.Size = new System.Drawing.Size(218, 78);
            this.btnLongestName.TabIndex = 11;
            this.btnLongestName.Text = "陣列arr0711_Str[]最長的名字";
            this.btnLongestName.UseVisualStyleBackColor = true;
            this.btnLongestName.Click += new System.EventHandler(this.btnLongestName_Click);
            // 
            // btnCc
            // 
            this.btnCc.Font = new System.Drawing.Font("宋体", 10F);
            this.btnCc.Location = new System.Drawing.Point(285, 254);
            this.btnCc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCc.Name = "btnCc";
            this.btnCc.Size = new System.Drawing.Size(218, 91);
            this.btnCc.TabIndex = 12;
            this.btnCc.Text = "陣列arr0711_Str[]中\"C\"or\"c\"的字樣有幾個";
            this.btnCc.UseVisualStyleBackColor = true;
            this.btnCc.Click += new System.EventHandler(this.btnCc_Click);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("宋体", 10F);
            this.btn10.Location = new System.Drawing.Point(285, 380);
            this.btn10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(297, 56);
            this.btn10.TabIndex = 13;
            this.btn10.Text = "[10,10]二維陣列-邊1内0";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn01
            // 
            this.btn01.Font = new System.Drawing.Font("宋体", 10F);
            this.btn01.Location = new System.Drawing.Point(285, 480);
            this.btn01.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(297, 46);
            this.btn01.TabIndex = 14;
            this.btn01.Text = "[10,10]二維陣列-邊0内1";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn1010
            // 
            this.btn1010.Font = new System.Drawing.Font("宋体", 10F);
            this.btn1010.Location = new System.Drawing.Point(285, 667);
            this.btn1010.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn1010.Name = "btn1010";
            this.btn1010.Size = new System.Drawing.Size(297, 109);
            this.btn1010.TabIndex = 15;
            this.btn1010.Text = "[10,10]二維陣列\r\n101010\r\n010101\r\n  ...";
            this.btn1010.UseVisualStyleBackColor = true;
            this.btn1010.Click += new System.EventHandler(this.btn1010_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSwap.Location = new System.Drawing.Point(285, 592);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(297, 40);
            this.btnSwap.TabIndex = 16;
            this.btnSwap.Text = "Swap[int,int]";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // txtTree
            // 
            this.txtTree.Font = new System.Drawing.Font("宋体", 10F);
            this.txtTree.Location = new System.Drawing.Point(813, 506);
            this.txtTree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTree.Multiline = true;
            this.txtTree.Name = "txtTree";
            this.txtTree.Size = new System.Drawing.Size(116, 39);
            this.txtTree.TabIndex = 17;
            // 
            // btnTree
            // 
            this.btnTree.BackColor = System.Drawing.Color.GreenYellow;
            this.btnTree.Font = new System.Drawing.Font("宋体", 12F);
            this.btnTree.Location = new System.Drawing.Point(615, 489);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(169, 56);
            this.btnTree.TabIndex = 18;
            this.btnTree.Text = "直角聖誕樹：";
            this.btnTree.UseVisualStyleBackColor = false;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btn99
            // 
            this.btn99.BackColor = System.Drawing.Color.GreenYellow;
            this.btn99.Font = new System.Drawing.Font("宋体", 12F);
            this.btn99.Location = new System.Drawing.Point(1043, 392);
            this.btn99.Name = "btn99";
            this.btn99.Size = new System.Drawing.Size(169, 56);
            this.btn99.TabIndex = 19;
            this.btn99.Text = "九九乘法表";
            this.btn99.UseVisualStyleBackColor = false;
            this.btn99.Click += new System.EventHandler(this.btn99_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.GreenYellow;
            this.btn100.Font = new System.Drawing.Font("宋体", 12F);
            this.btn100.Location = new System.Drawing.Point(615, 394);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(169, 65);
            this.btn100.TabIndex = 21;
            this.btn100.Text = "100的二進位是？";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn樂透
            // 
            this.btn樂透.BackColor = System.Drawing.Color.GreenYellow;
            this.btn樂透.Font = new System.Drawing.Font("宋体", 12F);
            this.btn樂透.Location = new System.Drawing.Point(813, 394);
            this.btn樂透.Name = "btn樂透";
            this.btn樂透.Size = new System.Drawing.Size(199, 56);
            this.btn樂透.TabIndex = 22;
            this.btn樂透.Text = "樂透號碼不重複";
            this.btn樂透.UseVisualStyleBackColor = false;
            this.btn樂透.Click += new System.EventHandler(this.btn樂透_Click);
            // 
            // btnwhile
            // 
            this.btnwhile.BackColor = System.Drawing.Color.GreenYellow;
            this.btnwhile.Font = new System.Drawing.Font("宋体", 12F);
            this.btnwhile.Location = new System.Drawing.Point(888, 643);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(106, 39);
            this.btnwhile.TabIndex = 25;
            this.btnwhile.Text = "while";
            this.btnwhile.UseVisualStyleBackColor = false;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btnfor
            // 
            this.btnfor.BackColor = System.Drawing.Color.GreenYellow;
            this.btnfor.Font = new System.Drawing.Font("宋体", 12F);
            this.btnfor.Location = new System.Drawing.Point(888, 592);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(106, 39);
            this.btnfor.TabIndex = 26;
            this.btnfor.Text = "for";
            this.btnfor.UseVisualStyleBackColor = false;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btndo
            // 
            this.btndo.BackColor = System.Drawing.Color.GreenYellow;
            this.btndo.Font = new System.Drawing.Font("宋体", 12F);
            this.btndo.Location = new System.Drawing.Point(888, 693);
            this.btndo.Name = "btndo";
            this.btndo.Size = new System.Drawing.Size(106, 39);
            this.btndo.TabIndex = 27;
            this.btndo.Text = "do";
            this.btndo.UseVisualStyleBackColor = false;
            this.btndo.Click += new System.EventHandler(this.btndo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(631, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(631, 699);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Step:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(631, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "To:";
            // 
            // txtfrom
            // 
            this.txtfrom.Font = new System.Drawing.Font("宋体", 10F);
            this.txtfrom.Location = new System.Drawing.Point(733, 592);
            this.txtfrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfrom.Multiline = true;
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(116, 39);
            this.txtfrom.TabIndex = 31;
            // 
            // txtto
            // 
            this.txtto.Font = new System.Drawing.Font("宋体", 10F);
            this.txtto.Location = new System.Drawing.Point(733, 643);
            this.txtto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtto.Multiline = true;
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(116, 39);
            this.txtto.TabIndex = 32;
            // 
            // txtstep
            // 
            this.txtstep.Font = new System.Drawing.Font("宋体", 10F);
            this.txtstep.Location = new System.Drawing.Point(733, 693);
            this.txtstep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstep.Multiline = true;
            this.txtstep.Name = "txtstep";
            this.txtstep.Size = new System.Drawing.Size(116, 39);
            this.txtstep.TabIndex = 33;
            // 
            // labR
            // 
            this.labR.AutoSize = true;
            this.labR.BackColor = System.Drawing.Color.LemonChiffon;
            this.labR.Font = new System.Drawing.Font("宋体", 11F);
            this.labR.Location = new System.Drawing.Point(751, 70);
            this.labR.Name = "labR";
            this.labR.Size = new System.Drawing.Size(98, 22);
            this.labR.TabIndex = 34;
            this.labR.Text = "尚未輸入";
            this.labR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1596, 826);
            this.Controls.Add(this.labR);
            this.Controls.Add(this.txtstep);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndo);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.btn樂透);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn99);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.txtTree);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btn1010);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btnCc);
            this.Controls.Add(this.btnLongestName);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btnarroddeven);
            this.Controls.Add(this.btnarrmin);
            this.Controls.Add(this.btnarrmax);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.btnarrmaxmin);
            this.Controls.Add(this.btnoddoreven);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMethod";
            this.Text = "Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnoddoreven;
        private System.Windows.Forms.Button btnarrmaxmin;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnarrmax;
        private System.Windows.Forms.Button btnarrmin;
        private System.Windows.Forms.Button btnarroddeven;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnLongestName;
        private System.Windows.Forms.Button btnCc;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn1010;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.TextBox txtTree;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btn99;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn樂透;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btndo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtstep;
        private System.Windows.Forms.Label labR;
    }
}

