using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOMEWORK_FORM
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            RandomNumber();
        }
        
        public void RandomNumber()
        {
           
            Random rm = new Random();
            Class1.answer = rm.Next(1, 101);
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            Form10_1 f2= new Form10_1();
            f2.Show();

        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer: " + Class1.answer.ToString());
        }
    }
}
