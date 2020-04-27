using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_b
{
    public partial class Form1 : Form
    {
        string color;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            if (Height <= 330 || Width < 730)
            {
                label1.Font = new Font(Font.FontFamily, 12);
                label2.Font = new Font(Font.FontFamily, 12);
                label3.Font = new Font(Font.FontFamily, 12);
                label4.Font = new Font(Font.FontFamily, 12);
                label5.Font = new Font(Font.FontFamily, 12);
                label6.Font = new Font(Font.FontFamily, 12);
                label7.Font = new Font(Font.FontFamily, 12);
                label8.Font = new Font(Font.FontFamily, 12);
                label9.Font = new Font(Font.FontFamily, 12);

            }
            if (Height > 330 || Width >= 730)
            {
                label1.Font = new Font(Font.FontFamily, 14);
                label2.Font = new Font(Font.FontFamily, 14);
                label3.Font = new Font(Font.FontFamily, 14);
                label4.Font = new Font(Font.FontFamily, 14);
                label5.Font = new Font(Font.FontFamily, 14);
                label6.Font = new Font(Font.FontFamily, 14);
                label7.Font = new Font(Font.FontFamily, 14);
                label8.Font = new Font(Font.FontFamily, 14);
                label9.Font = new Font(Font.FontFamily, 14);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void pictureBox1_BackColorChanged(object sender, EventArgs e)
        {
            color = String.Format("#{0:X2}{1:X2}{2:X2}", pictureBox1.BackColor.R, pictureBox1.BackColor.G, pictureBox1.BackColor.B);
            toolTip1.SetToolTip(pictureBox1, color);
            Clipboard.SetText(color);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            color = String.Format("#{0:X2}{1:X2}{2:X2}", pictureBox1.BackColor.R, pictureBox1.BackColor.G, pictureBox1.BackColor.B);
            toolTip1.SetToolTip(pictureBox1, color);
            Clipboard.SetText(color);
        }
    }
}
