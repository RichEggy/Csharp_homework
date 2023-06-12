using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HOMEWORK_FORM
{
    public partial class Frm04 : Form
    {
        public Frm04()
         


        {
            InitializeComponent();
           

        }
        string name;
        int chi;
        int eng;
        int math;
        
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            int chis = 0;
            int engs = 0;
            int maths = 0;

            bool isNum = int.TryParse(txtChi.Text, out chis);
            if (isNum == true)
            {
                btnShow.Click += new EventHandler(btnShowClick);
            }
            else
            {
                MessageBox.Show("好好打字啦");
                txtChi.Clear();
               txtChi.Focus();
            }
            bool isNum1 = int.TryParse(txtEng.Text, out engs);
            if (isNum1 == true)
            {
                btnShow.Click += new EventHandler(btnShowClick);
            }
            else
            {
                MessageBox.Show("好好打字啦");
                txtEng.Clear();
                txtEng.Focus();
            }
            
            bool isNum2 = int.TryParse(txtMath.Text, out maths);
            if (isNum2 == true)
            {
                btnShow.Click += new EventHandler(btnShowClick);
            }
            else
            {
                MessageBox.Show("好好打字啦");
                txtMath.Clear();
                txtMath.Focus();
            }
            name = txtName.Text;
            chi = int.Parse(txtChi.Text);
            eng = int.Parse(txtEng.Text);
            math = int.Parse(txtMath.Text);

            ////this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //btnShow.Click += new EventHandler(btnShowClick);
        }

        private void btnShowClick(object sender, EventArgs e)
        {
            labShow1.Text = "姓名:" + name + "\n" +
                            "國文:" + chi + "\n" +
                            "英文:" + eng + "\n" +
                            "數學:" + math;           
        }


        Dictionary<string, int> scoresDictionary = new Dictionary<string, int>();
        int highest, lowest;
        string highestsub, lowestsub;
        private void btnHighLow_Click(object sender, EventArgs e)
        {
            highest = 0; lowest = 999;
            scoresDictionary.Clear();
            labShow2.Text = "";
            highestsub = "";
            lowestsub = "";
            scoresDictionary.Add("國文", int.Parse(txtChi.Text));
            scoresDictionary.Add("英文", int.Parse(txtEng.Text));
            scoresDictionary.Add("數學", int.Parse(txtMath.Text));
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
                    highestsub += " " + entry.Key;
                }

                if (entry.Value < lowest)
                {
                    lowest = entry.Value;
                    lowestsub = entry.Key;
                }
                else if (entry.Value == lowest)
                {
                    lowest = entry.Value;
                    lowestsub += " " + entry.Key;
                }
            }
            labShow2.Text = ("最高分成績為：" + highestsub + highest + "分" + "\n最低分成績爲：" + lowestsub + lowest + "分");





        }
        //Dictionary<string, int> scoresDictionary = new Dictionary<string, int>();
        //scoresDictionary.Add("科目1", 80);
        //scoresDictionary.Add("科目2", 90);
        //scoresDictionary.Add("科目3", 75);

    }
}



