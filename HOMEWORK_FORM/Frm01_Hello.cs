using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HOMEWORK_FORM
{
    public partial class Frm01_Hello : Form
    {
        public Frm01_Hello()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string name = txt1.Text;
            string Ename = txt2.Text;
            string sex = txt3.Text;
            string sign = txt4.Text;
            MessageBox.Show("Hi!我是 " + name + "\n" + 
                "英文名字是 " + Ename + "\n" + 
                "性別是 " + sex + "\n" + 
                "星座是 " + sign + "\n"+
                "很高興認識你!");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string name = txt1.Text;
            string Ename = txt2.Text;
            string sex = txt3.Text;
            string sign = txt4.Text;
            MessageBox.Show("Hello!我是 " + name + "\n" +
                "英文名字是 " + Ename + "\n" +
                "性別是 " + sex + "\n" +
                "星座是 " + sign + "\n" +
                "很高興認識你!");
        }

        private void Frm01_Hello_Load(object sender, EventArgs e)
        {

        }
    }
}
