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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HOMEWORK_FORM
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        bool b = false;
        
        int h, m, s;    
        void IsNum()
        {
            int.TryParse(this.txtHour.Text, out h);
            if (h > 24) { MessageBox.Show("看好時間啦"); }
          

            int.TryParse(this.txtMin.Text, out m);
            if (m > 59) { MessageBox.Show("看好時間啦"); }
        

            int.TryParse(this.txtSec.Text, out s);
            if (s > 59) { MessageBox.Show("看好時間啦"); }
          

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IsNum();
            b = false;      
        }      
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            txtTime.Text = String.Format("{0:00}:{1:00}:{2:00}",
             time.Hour, time.Minute, time.Second);

            if (b == false)
            {
                if (h == DateTime.Now.Hour)
                {
                    if (m == DateTime.Now.Minute)
                    {
                        if (s == DateTime.Now.Second)
                        {
                            b = true;//證明時間剛好到了
                            MessageBox.Show("好了啦到了啦");
                            Form12_1 form12_1 = new Form12_1();
                            form12_1.Show();                      
                        }
                    }
                }
            }

        }
        
    }
}
