using System;
using System.Windows.Forms;

namespace HOMEWORK_FORM
{
    public partial class Frm02_Money : Form
    {
        double TotalLoan, year, rate, downpay;

        public Frm02_Money()
        {
            InitializeComponent();
            TotalLoan = Convert.ToDouble(txtLoanMoney.Text);
            year = Convert.ToDouble(txt期限.Text) * 12;
            rate = Convert.ToDouble(txt利率.Text) / 12 / 100;
            downpay = Convert.ToDouble(txt頭期款.Text);
        }

        private void btnMonthPay_Click(object sender, EventArgs e)
        {
            if (TotalLoan == 0)
            {
                MessageBox.Show("月付額:0元");
            }
            else
            {
                double monthpay1 = LoanCal().monthpay;
                MessageBox.Show("月付額:" + monthpay1 + "元");
            }
        }

        private void txt期限_TextChanged(object sender, EventArgs e)
        {
            if (txt期限.Text == "")
            {
                year = 0;
            }
            else
            {
                year = Convert.ToDouble(txt期限.Text) * 12;
            }
        }

        private void txtLoanMoney_TextChanged(object sender, EventArgs e)
        {
            if (txtLoanMoney.Text == "")
            {
                TotalLoan = 0;
            }
            else
            {
                TotalLoan = Convert.ToDouble(txtLoanMoney.Text);
            }

        }

        private void txt利率_TextChanged(object sender, EventArgs e)
        {
            if (txt利率.Text == "")
            {
                rate = 0;
            }
            else
            {
                rate = Convert.ToDouble(txt利率.Text) / 12 / 100;
            }
        }

        private void txt頭期款_TextChanged(object sender, EventArgs e)
        {
            if (txt頭期款.Text == "")
            {
                downpay = 0;
            }
            else
            {
                downpay = Convert.ToDouble(txt頭期款.Text);
            }

        }

        private void lab貸款金額_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalPay_Click(object sender, EventArgs e)
        {
            double totalpay1 = LoanCal().totalpay;
            MessageBox.Show("總付額:" + totalpay1 + "元");

        }



        private void btnReport_Click(object sender, EventArgs e)
        {
            Report.totalloan = TotalLoan - downpay;
            Report.totalpay = LoanCal().totalpay;
            Report.rate = Math.Round(rate * 100 * 12);
            Report.year = year / 12;
            Report.monthpay = LoanCal().monthpay;
            Frm_Report fr = new Frm_Report();
            fr.Show();
        }

        public (double monthpay, double totalpay) LoanCal()
        {
            double Prate = Math.Pow((1 + rate), year) * rate / (Math.Pow((1 + rate), year) - 1);
            double monthpay = Math.Round((TotalLoan - downpay) * Prate);
            double totalpay = monthpay * year;

            return (monthpay, totalpay);
        }










    }
}
/*本息金額之平均攤還率(Prate)＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
           (公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12)*/

//平均每月應攤付本息金額(PMT)＝貸款本金(TotalLoanMoney)×每月應付本息金額之平均攤還率(Prate) ＝每月應還本金金額(PPay)＋每月應付利息金額(MPay)
//每月應付利息金額(Mpay)＝本金餘額×月利率
//每月應還本金金額(PPay)＝平均每月應攤付本息金額(PMT)－每月應付利息金額(MPay)