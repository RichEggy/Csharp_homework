namespace HOMEWORK_FORM
{
    partial class frmBarPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarPos));
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.labList = new System.Windows.Forms.Label();
            this.grbTotalPrice = new System.Windows.Forms.GroupBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.grbPayWay = new System.Windows.Forms.GroupBox();
            this.labdiscount = new System.Windows.Forms.Label();
            this.grbMenu.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbTotalPrice.SuspendLayout();
            this.grbPayWay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeer
            // 
            this.btnBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeer.BackgroundImage")));
            this.btnBeer.ForeColor = System.Drawing.Color.Cyan;
            this.btnBeer.Location = new System.Drawing.Point(19, 56);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(152, 190);
            this.btnBeer.TabIndex = 0;
            this.btnBeer.Text = "啤酒\r\nBeer\r\nNT$120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTequila.BackgroundImage")));
            this.btnTequila.ForeColor = System.Drawing.Color.Cyan;
            this.btnTequila.Location = new System.Drawing.Point(222, 56);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(152, 190);
            this.btnTequila.TabIndex = 1;
            this.btnTequila.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhisky.BackgroundImage")));
            this.btnWhisky.ForeColor = System.Drawing.Color.Cyan;
            this.btnWhisky.Location = new System.Drawing.Point(19, 280);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(152, 190);
            this.btnWhisky.TabIndex = 2;
            this.btnWhisky.Text = "威士忌\r\nWhiskey\r\nNT$350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnWine
            // 
            this.btnWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWine.BackgroundImage")));
            this.btnWine.ForeColor = System.Drawing.Color.Cyan;
            this.btnWine.Location = new System.Drawing.Point(222, 280);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(152, 190);
            this.btnWine.TabIndex = 3;
            this.btnWine.Text = "紅酒\r\nWine\r\nNT$320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // grbMenu
            // 
            this.grbMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.grbMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbMenu.Controls.Add(this.btnWine);
            this.grbMenu.Controls.Add(this.btnWhisky);
            this.grbMenu.Controls.Add(this.btnTequila);
            this.grbMenu.Controls.Add(this.btnBeer);
            this.grbMenu.Font = new System.Drawing.Font("黑体", 14F);
            this.grbMenu.ForeColor = System.Drawing.Color.Brown;
            this.grbMenu.Location = new System.Drawing.Point(27, 57);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(423, 498);
            this.grbMenu.TabIndex = 4;
            this.grbMenu.TabStop = false;
            this.grbMenu.Text = "菜單 Menu";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BackColor = System.Drawing.Color.PapayaWhip;
            this.labTotalPrice.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTotalPrice.ForeColor = System.Drawing.Color.Brown;
            this.labTotalPrice.Location = new System.Drawing.Point(28, 44);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(235, 58);
            this.labTotalPrice.TabIndex = 5;
            this.labTotalPrice.Text = "0";
            this.labTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grbList
            // 
            this.grbList.BackColor = System.Drawing.Color.SandyBrown;
            this.grbList.Controls.Add(this.btnClean);
            this.grbList.Controls.Add(this.labList);
            this.grbList.Font = new System.Drawing.Font("黑体", 14F);
            this.grbList.ForeColor = System.Drawing.Color.Brown;
            this.grbList.Location = new System.Drawing.Point(752, 57);
            this.grbList.Name = "grbList";
            this.grbList.Size = new System.Drawing.Size(423, 498);
            this.grbList.TabIndex = 5;
            this.grbList.TabStop = false;
            this.grbList.Text = "購物清單 List";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnClean.Location = new System.Drawing.Point(238, 434);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(166, 48);
            this.btnClean.TabIndex = 1;
            this.btnClean.Text = "清除清單";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.Color.PapayaWhip;
            this.labList.Font = new System.Drawing.Font("黑体", 12F);
            this.labList.Location = new System.Drawing.Point(21, 62);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(384, 338);
            this.labList.TabIndex = 0;
            this.labList.Text = "尚未點餐";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grbTotalPrice
            // 
            this.grbTotalPrice.BackColor = System.Drawing.Color.SandyBrown;
            this.grbTotalPrice.Controls.Add(this.labTotalPrice);
            this.grbTotalPrice.Font = new System.Drawing.Font("黑体", 12F);
            this.grbTotalPrice.ForeColor = System.Drawing.Color.Brown;
            this.grbTotalPrice.Location = new System.Drawing.Point(456, 57);
            this.grbTotalPrice.Name = "grbTotalPrice";
            this.grbTotalPrice.Size = new System.Drawing.Size(287, 123);
            this.grbTotalPrice.TabIndex = 6;
            this.grbTotalPrice.TabStop = false;
            this.grbTotalPrice.Text = "總金額 Total Price";
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Moccasin;
            this.btnCash.Font = new System.Drawing.Font("黑体", 12F);
            this.btnCash.Location = new System.Drawing.Point(6, 83);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(129, 50);
            this.btnCash.TabIndex = 7;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.Moccasin;
            this.btnCard.Font = new System.Drawing.Font("黑体", 12F);
            this.btnCard.Location = new System.Drawing.Point(146, 83);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(135, 50);
            this.btnCard.TabIndex = 8;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // grbPayWay
            // 
            this.grbPayWay.BackColor = System.Drawing.Color.SandyBrown;
            this.grbPayWay.Controls.Add(this.labdiscount);
            this.grbPayWay.Controls.Add(this.btnCard);
            this.grbPayWay.Controls.Add(this.btnCash);
            this.grbPayWay.Font = new System.Drawing.Font("黑体", 14F);
            this.grbPayWay.ForeColor = System.Drawing.Color.Brown;
            this.grbPayWay.Location = new System.Drawing.Point(456, 274);
            this.grbPayWay.Name = "grbPayWay";
            this.grbPayWay.Size = new System.Drawing.Size(287, 230);
            this.grbPayWay.TabIndex = 9;
            this.grbPayWay.TabStop = false;
            this.grbPayWay.Text = "付款方式";
            // 
            // labdiscount
            // 
            this.labdiscount.AutoSize = true;
            this.labdiscount.BackColor = System.Drawing.Color.LemonChiffon;
            this.labdiscount.Font = new System.Drawing.Font("黑体", 13F);
            this.labdiscount.Location = new System.Drawing.Point(101, 193);
            this.labdiscount.Name = "labdiscount";
            this.labdiscount.Size = new System.Drawing.Size(181, 26);
            this.labdiscount.TabIndex = 9;
            this.labdiscount.Text = "信用卡享九折!";
            // 
            // frmBarPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1187, 712);
            this.Controls.Add(this.grbPayWay);
            this.Controls.Add(this.grbTotalPrice);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.grbMenu);
            this.Name = "frmBarPos";
            this.Text = "Bar Pos";
            this.grbMenu.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbTotalPrice.ResumeLayout(false);
            this.grbPayWay.ResumeLayout(false);
            this.grbPayWay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.GroupBox grbTotalPrice;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.GroupBox grbPayWay;
        private System.Windows.Forms.Label labdiscount;
    }
}

