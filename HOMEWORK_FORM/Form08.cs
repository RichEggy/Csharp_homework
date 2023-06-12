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
    public partial class frmcalculator : Form
    {
        public frmcalculator()
        {
            InitializeComponent();
        }
        double number1, number2,result;
        private void btnplus_Click(object sender, EventArgs e) 
        {
        
            number1= Convert.ToDouble(txtnum1.Text);
            number2 = Convert.ToDouble(txtnum2.Text);
            result=number1+number2;
            labshowanswer.Text = result.ToString();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtnum1.Text);
            number2 = Convert.ToDouble(txtnum2.Text);
            result = number1 - number2;
            labshowanswer.Text = result.ToString();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtnum1.Text);
            number2 = Convert.ToDouble(txtnum2.Text);
            result = number1 * number2;
            labshowanswer.Text = result.ToString();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtnum1.Text);
            number2 = Convert.ToDouble(txtnum2.Text);
            if (number2 == 0)
            {
                MessageBox.Show("除數不能為0", "能不能乖乖", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
               
                result = number1 / number2;
                labshowanswer.Text = result.ToString();
            }
        }
    }
}
