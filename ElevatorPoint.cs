using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKullanimlari
{
    public partial class ElevatorPoint : Form
    {
        public ElevatorPoint()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblTimer.Text = "1";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lblTimer.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblTimer.Text == "1")
            {
                pictureBox1.Top -= 5;
                if (pictureBox1.Location.Y <= 170)
                {
                    timer1.Stop();
                }
            }
            else if (lblTimer.Text == "0")
            {
                pictureBox1.Top += 5;
                if (pictureBox1.Location.Y >= 550)
                {
                    timer1.Stop();
                }
            }
        }
    }
}
