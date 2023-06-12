using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOMEWORK_FORM
{
    public partial class frmBarPos : Form
    {
        public frmBarPos()
        {
            InitializeComponent();
            
        }
        int totalprice;

        Menu beer = new Menu()
        {
            Name = "啤酒Beer",
            unitPrice = 120
        };
        Menu tequila = new Menu()
        {
            Name = "龍舌蘭Tequila",
            unitPrice = 180
        };
        Menu whisky = new Menu()
        {
            Name = "威士忌Whisky",
            unitPrice = 350
        };
        Menu wine = new Menu()
        {
            Name = "紅酒Wine",
            unitPrice = 320
        };
        private void btnBeer_Click(object sender, EventArgs e)
        {
           beer.count++;
            ListUpdate();
        }

        private void btnTequila_Click(object sender, EventArgs e)
        {
            tequila.count++;
            ListUpdate();
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            whisky.count++;
            ListUpdate();
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            wine.count++;
            ListUpdate();

        }

        void ListUpdate() 
        {
            totalprice = 0;
            labList.Text = "";

            if(beer.count > 0)
            {
                totalprice += beer.count*beer.unitPrice;
                labList.Text += beer.Name + "x" + beer.count + ",共NT$" + beer.unitPrice * beer.count + "元\n";
            }
            if (tequila.count > 0)
            {
                totalprice += tequila.count * tequila.unitPrice;
                labList.Text += tequila.Name + "x" + tequila.count + ",共NT$" + tequila.unitPrice * tequila.count + "元\n";
            }
            if (whisky.count > 0)
            {
                totalprice +=whisky.count * whisky.unitPrice;
                labList.Text += whisky.Name + "x" + whisky.count + ",共NT$" + whisky.unitPrice * whisky.count + "元\n";
            }
            if (wine.count > 0)
            {
                totalprice += wine.count * wine.unitPrice;
                labList.Text += wine.Name + "x" + wine.count + ",共NT$" + wine.unitPrice * wine.count + "元";
            }
            labTotalPrice.Text = "NT$"+totalprice.ToString();

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (totalprice == 0)
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"總金額：NT$ {totalprice}", "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            if (totalprice == 0)
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"總金額：NT$ {totalprice}\n折扣金額：NT${totalprice*0.9}", "確認付款", MessageBoxButtons.OKCancel);
            }
            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            beer.count = 0;
            tequila.count = 0;
            whisky.count = 0;
            wine.count = 0;
            ListUpdate();
            
        }
      
       
    }
}
