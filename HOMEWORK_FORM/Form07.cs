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
    public partial class FrmMethod : Form
    {
        public FrmMethod()
        {
            InitializeComponent();
        }
        int number, sum1, sum2, sum3, A;
        int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        string[] names = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "MotherFacker" };

        private void btnoddoreven_Click(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(txtNumber.Text, out number);

            if (!isInteger)
            {
                MessageBox.Show("請好好輸入整數喲！");

            }

            else if (number % 2 == 0)
            {

                labR.Text = ("輸入的數 " + number + " 為偶數");
            }
            else
            {

                labR.Text = ("輸入的數 " + number + " 為奇數");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labR.Text = "尚未輸入";
        }

        private void btnarrmaxmin_Click(object sender, EventArgs e)
        {

            int max = arr0711[0];
            int min = arr0711[0];

            for (int i = 1; i < arr0711.Length; i++)
            {
                if (arr0711[i] > max)
                {
                    max = arr0711[i];  // 更新最大值
                }
                else if (arr0711[i] < min)
                {
                    min = arr0711[i];  // 更新最小值
                }
            }
            labR.Text = ("int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]" + "\r\n" + "最大值為" + max + "\r\n" + "最小值為" + min);
        }

        private void btnarrmax_Click(object sender, EventArgs e)
        {
            int max = arr0711.Max();
            labR.Text = ("int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]" + "\r\n" + "最大值為" + max);
        }

        private void btnarrmin_Click(object sender, EventArgs e)
        {
            int min = arr0711.Min();
            labR.Text = ("int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]" + "\r\n" + "最小值為" + min);
        }
        int OddCount;
        int EvenCount;
        int ArrSum;
        private void btnarroddeven_Click(object sender, EventArgs e)
        {
            OddCount = 0;
            EvenCount = 0;
            foreach (int num in arr0711)
            {
                if (num % 2 == 0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }

            labR.Text = ("int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]" + "\r\n" + "奇數共" + OddCount + "個"
                + "\r\n" + "偶數共" + EvenCount + "個");
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            ArrSum = 0;
            for (int i = 0; i < arr0711.Length; i++)
            {
                ArrSum += arr0711[i];
            }
            labR.Text = ("int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]加總為" + ArrSum);
        }

        private void btnLongestName_Click(object sender, EventArgs e)
        {
            int maxLength = 0;
            int longestStringIndex = -1;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > maxLength)
                {
                    maxLength = names[i].Length;
                    longestStringIndex = i;
                }
            }
            if (longestStringIndex != -1)
            {
                string longestString = names[longestStringIndex];
                labR.Text = ("陣列arr0711_Str[mother張, emma, 迪克蕭, J40,Candy,Cindy,Coconut,MotherFacker]\n中最长的名字是：" + longestString);
            }
        }

        private void btnCc_Click(object sender, EventArgs e)
        {
            string[] arr = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "MotherFacker" };
            char targetChar = 'C';

            int count = 0;
            foreach (string item in arr)
            {
                if (item.ToLower().Contains(targetChar.ToString().ToLower()))
                {
                    count++;
                }
            }

            labR.Text = ($"陣列arr0711_Str[mother張, emma, 迪克蕭, J40,Candy,Cindy,Coconut,MotherFacker]中\n包含 {targetChar} 或 {char.ToLower(targetChar)} 的名字的數量有{count}個");
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string result = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 9 || j == 0)
                    {
                        result += "1 ";
                    }
                    else { result += "0 "; }
                }
                result += "\r\n";
            }
            labR.Text = result;
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            string result = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 9 || j == 0)
                    {
                        result += "0 ";
                    }
                    else { result += "1 "; }
                }
                result += "\r\n";
            }
            labR.Text = result;
        }
        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100, n2 = 200;
            labR.Text = "換位前n1: " + n1 + " , n2: " + n2 + "\r\n";
            Swap(ref n1, ref n2);
            labR.Text += "換位後n1: " + n1 + " , n2: " + n2;
        }

        private void btn1010_Click(object sender, EventArgs e)
        {
            string result = "";
            int rows = 10;
            int cols = 10;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else { matrix[i, j] = 0; }
                    result += matrix[i, j] + " ";
                }
                result += "\r\n";
            }
            labR.Text = result;
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            bool isInteger = int.TryParse(txtTree.Text, out number);
            if (isInteger)
            {
                string result ="";

                for (int i = 0; i - 1 < number; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        result += "* ";
                    }
                    result +="\r\n";
                }
                labR.Text =result;
            }
            else { MessageBox.Show("請輸入整數"); }
        }

        private void btn99_Click(object sender, EventArgs e)
        {

            string result = "";

            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    result += j + "x" + i + "=" + j * i + " \t ";

                };
                result += "\r\n";
            }

            labR.Text = "九九乘法表" + "\r\n" + result;
        }

        //string result;

        Numberlist NL = new Numberlist();
        List<Numberlist> numbers = new List<Numberlist>();
        private void btnfor_Click(object sender, EventArgs e)
        {
            sum1 = 0;
            IsNumbers();
            for (int i = NL.F; i <= NL.T; i += NL.S)
            {
                if (NL.S > 0)
                {
                    sum1 += i;
                }
                else
                {
                    MessageBox.Show("Step請輸入非0整數");
                    return;
                }
            }
            labR.Text = NL.F + "到" + NL.T + "相隔為" + (NL.S - 1) + "加總為" + sum1;

        }

        private void btn樂透_Click(object sender, EventArgs e)
        {
            string result = "";
            Random random = new Random();
            HashSet<int> numbers = new HashSet<int>();


            while (numbers.Count < 6)
            {
                int randomnumber = random.Next(1, 50);
                numbers.Add(randomnumber);
            }
            foreach (int randomnumber in numbers)
            {
                result += randomnumber.ToString() + " ";
            }
            labR.Text = result;
        }



        private void btnwhile_Click(object sender, EventArgs e)
        {
            sum2 = 0;
            IsNumbers();
            int i = NL.F;
            if (NL.S <= 0)
            {
                MessageBox.Show("Step請輸入非0整數");
                return;
            }
            while (i <= NL.T)
            {
                sum2 += i;
                i += NL.S;

            }
            labR.Text = NL.F + "到" + NL.T + "相隔為" + (NL.S - 1) + "加總為" + sum2;
        }



        private void btn100_Click(object sender, EventArgs e)
        {
            int decimalNumber = 100;
            string binaryNumber = Convert.ToString(decimalNumber, 2);

            labR.Text = binaryNumber;
        }

        private void btndo_Click(object sender, EventArgs e)
        {
            sum3 = 0;
            IsNumbers();
            int i = NL.F;
            if (NL.S <= 0)
            {
                MessageBox.Show("Step請輸入非0整數");
                return;
            }
            do
            {
                sum3 += i;
                i += NL.S;
            }
            while (i <= NL.T);
            labR.Text = NL.F + "到" + NL.T + "相隔為" + (NL.S - 1) + "加總為" + sum3;

        }
        void IsNumbers()
        {
            bool IsNum = int.TryParse(txtfrom.Text, out NL.F);

            if (IsNum == false)
            {
                MessageBox.Show("請輸入整數");
                txtfrom.Clear();
                txtfrom.Focus();
                return;
            }
            bool IsNum1 = int.TryParse(txtto.Text, out NL.T);
            if (IsNum == false)
            {
                MessageBox.Show("請輸入整數");
                txtto.Clear();
                txtto.Focus();
                return;

            }
            bool IsNum2 = int.TryParse(txtstep.Text, out NL.S);
            if (IsNum == false)
            {
                MessageBox.Show("請輸入整數");
                txtstep.Clear();
                txtstep.Focus();
                return;
            }
        }
    }
}



