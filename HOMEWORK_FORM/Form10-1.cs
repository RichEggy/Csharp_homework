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
    public partial class Form10_1 : Form
    {
        public Form10_1()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            min = 1;
            max = 100;
        }
        
        public int guess, answer, min, max;
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtGuess.Text = "";
            
        }
       
        public void RandomNumber()
        {
           
            Random rm = new Random();
            Class1.answer = rm.Next(1, 101);
        }
        public void GuessWhat()
        {

            do
            {
                guess = int.Parse(txtGuess.Text);
                if (guess >= min && guess < max)
                {
                    if (guess == Class1.answer)
                    {
                        MessageBox.Show("Congradulations!!!You Got " + guess + "!!!");
                        RandomNumber();
                        labInput.Text = ("Please Input A Number.");
                        break;
                    }
                    else if (guess > Class1.answer)
                    {
                        max = guess;
                        labInput.Text = ("Too Large!!!\nBetween " + min + " and " + guess);

                    }
                    else if (guess < Class1.answer)
                    {
                        min = guess;
                        labInput.Text = ("Too Small!!!\nBetween " + guess + " and " + max);

                    }
                    else { MessageBox.Show("請輸入提示範圍内的整數"); }
                }
            }
            while (false);
        }
             

        private void btnEnter_Click(object sender, EventArgs e)
        {

            bool IsNum = int.TryParse(txtGuess.Text, out guess);
            if (!IsNum)
            {
                MessageBox.Show("請輸入1-100之間的整數");
            }
            else if (int.Parse(txtGuess.Text) > 100) { MessageBox.Show("請輸入1-100之間的整數"); }
            else if (int.Parse(txtGuess.Text) > max || int.Parse(txtGuess.Text) < min)
            {
                MessageBox.Show("請輸入提示範圍内的整數");
            }
            else { GuessWhat(); }
        }
    }
}