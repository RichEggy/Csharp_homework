using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  HOMEWORK_FORM
{
    public partial class Form09 : Form
    {
        public Form09()
        {
            InitializeComponent();
        }
        bool isX=true;
        int turnCount = 0;
        bool WinorLose=false;

        void Winner()
        {

            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                MessageBox.Show("X Win！");
                WinorLose = true;
            }

            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X") 
            {
                MessageBox.Show("X Win！");
                WinorLose = true;
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X") 
            {
                MessageBox.Show("X Win！");
                WinorLose = true;
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X") 
            {
                MessageBox.Show("X Win！");
                WinorLose = true;
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X") 
            {
                MessageBox.Show("X Win！");
                WinorLose = true;
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X") 
            {
                MessageBox.Show("X Win！");
                WinorLose = true;
            }
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("X Win！");
                WinorLose = true;
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X") 
            {
                MessageBox.Show("X Win！");
                WinorLose = true;
            }

            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O") 
            {
                MessageBox.Show("O Win！");
                WinorLose = true;
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O") 
            {
                MessageBox.Show("O Win！");
                WinorLose = true;
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("O Win！");
                WinorLose = true;
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O") 
            {
                MessageBox.Show("O Win！");
                WinorLose = true;
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                MessageBox.Show("O Win！");
                WinorLose = true;
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O") 
            {
                MessageBox.Show("O Win！");
                WinorLose = true;
            }
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("O Win！");
                WinorLose = true;
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O") 
            {
                MessageBox.Show("O Win！");
                WinorLose = true;
            }
            if (turnCount == 9) { NewGame(); }
            if(WinorLose) { Reset();WinorLose = false; }
        }
        void NewGame()
        {
         MessageBox.Show("平手！請按確認重新開始","下次一定！", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        Reset();
        }
        void Reset()
        {
            turnCount = 0;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form09_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 82) { Reset(); }
            if (e.KeyValue == 27) { this.Close(); }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn1.Text = "X";
                isX = false;
            }
            else
            {
                btn1.Text = "O";
                isX = true;
            }
            btn1.Enabled = false;
            turnCount++;
                Winner();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn2.Text = "X";
                isX = false;
            }
            else
            {
                btn2.Text = "O";
                isX = true;
            }
            btn2.Enabled = false;
            turnCount++;
                Winner();
         
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn3.Text = "X";
                isX = false;
            }
            else
            {
                btn3.Text = "O";
                isX = true;
            }
            btn3.Enabled = false;
            turnCount++;
                Winner();
      
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn4.Text = "X";
                isX = false;
            }
            else
            {
                btn4.Text = "O";
                isX = true;
            }
            btn4.Enabled = false;
            turnCount++;

                Winner();
         
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn5.Text = "X";
                isX = false;
            }
            else
            {
                btn5.Text = "O";
                isX = true;
            }
            btn5.Enabled = false;
            turnCount++;

                Winner();
        
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn6.Text = "X";
                isX = false;
            }
            else
            {
                btn6.Text = "O";
                isX = true;
            }
            btn6.Enabled = false;
            turnCount++;

                Winner();
      
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn7.Text = "X";
                isX = false;
            }
            else
            {
                btn7.Text = "O";
                isX = true;
            }
            btn7.Enabled = false;
            turnCount++;

                Winner();
              
     
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn8.Text = "X";
                isX = false;
            }
            else
            {
                btn8.Text = "O";
                isX = true;
            }
            btn8.Enabled = false;
            turnCount++;
                Winner();
     
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isX == true)
            {
                btn9.Text = "X";
                isX = false;
            }
            else
            {
                btn9.Text = "O";
                isX = true;
            }
            btn9.Enabled = false;
            turnCount++;
                Winner();
          
        }
    }
}
