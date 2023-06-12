using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Threading;

namespace HOMEWORK_FORM
{
    public partial class Form05 : Form
    {
        public Form05()
        {
            InitializeComponent();
        }

        private void Form05_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("姓名", 90);
            listView1.Columns.Add("國文", 50);
            listView1.Columns.Add("英文", 50);
            listView1.Columns.Add("數學", 50);
            listView1.Columns.Add("總分", 60);
            listView1.Columns.Add("平均", 60);
            listView1.Columns.Add("最高", 110);
            listView1.Columns.Add("最低", 110);
        }
        string name,result;
        int chinese, english, math;
        string highestsub, lowestsub;
        int highest, lowest, Stu;
       

        private void btnClean_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            IsScore.Clear();
            label1.Text = "";
            btnSub.Enabled = false;
            listView1.Columns.Add("姓名", 80);
            listView1.Columns.Add("國文", 50);
            listView1.Columns.Add("英文", 50);
            listView1.Columns.Add("數學", 50);
            listView1.Columns.Add("總分", 60);
            listView1.Columns.Add("平均", 60);
            listView1.Columns.Add("最高", 120);
            listView1.Columns.Add("最低", 120);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            vl.Chinese = rdm.Next(0, 101);
            vl.English = rdm.Next(0, 101);
            vl.Math = rdm.Next(0, 101);
            Stu += 1;
            vl.Name = Stu.ToString();

            ShowScore();
            UpdateScore();

        }
     
        

        ViewList1 vl;

        private void btnRandom_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Random rdm = new Random();
                vl.Chinese = rdm.Next(0, 101);
                vl.English = rdm.Next(0, 101);
                vl.Math = rdm.Next(0, 101);
                Stu += 1;
                vl.Name = Stu.ToString();
                ShowScore();
                UpdateScore();
                Thread.Sleep(1);
            }
        }

        List<ViewList1> IsScore = new List<ViewList1>();
     

        private void btnSub_Click_1(object sender, EventArgs e)
        {
            label1.Text="";
            
            for (int i = 0; i < IsScore.Count; i++)
            {
                int totalChScore = IsScore.Sum(x => x.Chinese);
                int totalEnScore = IsScore.Sum(x => x.English);
                int totalMathScore = IsScore.Sum(x => x.Math);
                int maxChScore = IsScore.Max(x => x.Chinese);
                int maxEnScore = IsScore.Max(x => x.English);
                int maxMathScore = IsScore.Max(x => x.Math);
                int minChScore = IsScore.Min(x => x.Chinese);
                int minEnScore = IsScore.Min(x => x.English);
                int minMathScore = IsScore.Min(x => x.Math);
                
                result = $"總分{totalChScore,12}{totalEnScore,8}{totalMathScore,8}\r\n" +
                    $"平均{totalChScore / IsScore.Count,12}{totalEnScore / IsScore.Count,8}{totalMathScore / IsScore.Count,8}\r\n" +
                    $"最高分{maxChScore,10}{maxEnScore,8}{maxMathScore,8}\r\n" +
                    $"最低分{minChScore,10}{minEnScore,8}{minMathScore,8}";
                label1.Text = result;
            }
        }

        public void ShowScore()
        {
            HighLowScore();
            decimal totalscore = vl.Chinese + vl.English + vl.Math;
            vl.TotalScore = (int)totalscore;
            vl.AvrScore = (int)totalscore / 3;
            vl.Hsub = highestsub;
            vl.HS = highest;
            vl.Lsub = lowestsub;
            vl.LS = lowest;
            IsScore.Add(vl);
        }
        public void UpdateScore()
        {
            ListViewItem newitem = new ListViewItem(vl.Name);
            newitem.SubItems.Add(vl.Chinese.ToString());
            newitem.SubItems.Add(vl.English.ToString());
            newitem.SubItems.Add(vl.Math.ToString());
            newitem.SubItems.Add(vl.TotalScore.ToString());
            newitem.SubItems.Add(vl.AvrScore.ToString());
            newitem.SubItems.Add(vl.Hsub + vl.HS + "分");
            newitem.SubItems.Add(vl.Lsub + vl.LS + "分");
            listView1.Items.Add(newitem);
            btnSub.Enabled = true;

        }

        Dictionary<string, int> scoresDictionary = new Dictionary<string, int>();
        public void HighLowScore()
        {
            highest = 0; lowest = 999;
            scoresDictionary.Clear();
            scoresDictionary.Add("國文", vl.Chinese);
            scoresDictionary.Add("英文", vl.English);
            scoresDictionary.Add("數學", vl.Math);
            foreach (KeyValuePair<string, int> entry in scoresDictionary)
            {


                if (entry.Value > highest)
                {
                    highest = entry.Value;
                    highestsub = entry.Key;
                }

                else if (entry.Value == highest)
                {
                    highest = entry.Value;
                    highestsub += "," + entry.Key;
                }

                if (entry.Value < lowest)
                {
                    lowest = entry.Value;
                    lowestsub = entry.Key;
                }
                else if (entry.Value == lowest)
                {

                    lowest = entry.Value;
                    lowestsub += "," + entry.Key;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            vl.Name = txtName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("請填寫姓名！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Clear();
                txtName.Focus();
                return;
            }
          

            bool IsNum = int.TryParse(txtChinese.Text, out vl.Chinese);
            if (IsNum == false)
            {
                MessageBox.Show("國文分數請輸入數字", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChinese.Clear();
                txtChinese.Focus();
                return;
            }
            
            bool IsNum1 = int.TryParse(txtEnglish.Text, out vl.English);
            if (IsNum1 == false)
            {
                MessageBox.Show("英文分數請輸入數字", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnglish.Clear();
                txtEnglish.Focus();
                return;
            }
         
            bool IsNum2 = int.TryParse(txtMath.Text, out vl.Math);
            if (IsNum2 == false)
            {
                MessageBox.Show("數學分數請輸入數字", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMath.Clear();
                txtMath.Focus();
                return;
            }
         
            ShowScore();
            UpdateScore();
        }
    }
}