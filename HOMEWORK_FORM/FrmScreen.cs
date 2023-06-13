using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HOMEWORK_FORM
{
    public partial class FrmScreen : Form
    {
        public FrmScreen()
        {
            InitializeComponent();
        }
        int stepX = 8, stepY = 8; //控制水平跟垂直移動距離
        int previousX=Cursor.Position.X;
        int previousY=Cursor.Position.Y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((pictureBox1.Location.X + pictureBox1.Width) > this.ClientSize.Width || pictureBox1.Location.X < 0)
                stepX = 0 - stepX;
            if ((pictureBox1.Location.Y + pictureBox1.Height) > this.ClientSize.Height || pictureBox1.Location.Y < 0)
                stepY = 0 - stepY;//正變負，負變正，變換方向
            pictureBox1.Location= new Point(pictureBox1.Location.X+stepX,pictureBox1.Location.Y+stepY);
        }

        private void FrmScreen_MouseMove(object sender, MouseEventArgs e)
        {
            int currentX = Cursor.Position.X;
            int currentY = Cursor.Position.Y;
            if (currentX != previousX && currentY != previousY)
            {
                this.Close();
            }
        }

        //private void FrmScreen_MouseClick(object sender, MouseEventArgs e)
        //{
        //    this.Close();   //滑鼠點擊關閉
        //}

    }
}
