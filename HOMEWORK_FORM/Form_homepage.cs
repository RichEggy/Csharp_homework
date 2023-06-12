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
    public partial class frmhomepage : Form
    {
        public frmhomepage()
        {
            InitializeComponent();
        }

        private void btnhello_Click(object sender, EventArgs e)
        {
            // close other opening form
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();

            Frm01_Hello frm01 = new Frm01_Hello();

            //非最上層
            frm01.TopLevel = false;

            //顯示From，要加上去才會顯示Form
            frm01.Visible = true;

            //設定From位置
            frm01.Top = 0;
            frm01.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm01);
        }

        private void btnloan_Click(object sender, EventArgs e)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();
            Frm02_Money frm02 = new Frm02_Money();
            frm02.TopLevel = false;
            frm02.Visible = true;
            frm02.Top = 0;
            frm02.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm02);
        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();
            frmBarPos frm03 = new frmBarPos();
            frm03.TopLevel = false;
            frm03.Visible = true;
            frm03.Top = 0;
            frm03.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm03);
        }

        private void btnstructform_Click(object sender, EventArgs e)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();
            Frm04 frm04 = new Frm04();
            frm04.TopLevel = false;
            frm04.Visible = true;
            frm04.Top = 0;
            frm04.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm04);
        }

        private void btncalculator_Click(object sender, EventArgs e)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();
            frmcalculator frmca=new frmcalculator();
            frmca.TopLevel = false;
            frmca.Visible = true;
            frmca.Top = 0;
            frmca.Left = 0;

            splitContainer2.Panel2.Controls.Add(frmca);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();
            Form05 frm05 = new Form05();
            frm05.TopLevel = false;
            frm05.Visible = true;
            frm05.Top = 0;
            frm05.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm05);
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();
            FrmMethod frm07= new FrmMethod();
            frm07.TopLevel = false;
            frm07.Visible = true;
            frm07.Top = 0;
            frm07.Left = 0;

            splitContainer2.Panel2.Controls.Add(frm07);
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();
            Form09 frm09 = new Form09();
            frm09.TopLevel = false;
            frm09.Visible = true;
            frm09.Top = 0;
            frm09.Left = 0;
            splitContainer2.Panel2.Controls.Add(frm09);
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();
            FrmScreen frms = new FrmScreen();
            frms.Show();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            while (splitContainer2.Panel2.Controls.Count > 0)
                splitContainer2.Panel2.Controls[0].Dispose();
            FrmDraw fd= new FrmDraw();
            fd.TopLevel = false;
            fd.Visible = true;
            fd.Top = 0;
            fd.Left = 0;
            splitContainer2.Panel2.Controls.Add(fd);
        }
    }
}
