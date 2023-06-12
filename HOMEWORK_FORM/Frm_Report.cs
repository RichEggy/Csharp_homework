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
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
            textBox1.Text =Report.totalloan.ToString();
            textBox2.Text=Report.year.ToString();
            textBox3.Text=Report.rate.ToString();
            textBox4.Text=Report.monthpay.ToString();
            textBox5.Text=Report.totalpay.ToString();
        }
    }
}
