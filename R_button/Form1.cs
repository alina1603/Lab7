using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R_button
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Size defClSize;
        int diffX = 0;
        int diffY = 0;
        int h = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
            button1.Top = (ClientSize.Height - button1.Height) / 2;
            button1.Left = (ClientSize.Width - button1.Width) / 2;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int R = button1.Right;
            int B = button1.Bottom;
            if (e.X > button1.Left - h && e.X < R + h)
            {
                if (e.X >= (button1.Left + (button1.Width / 2)))
                    button1.Left= button1.Left-h;
                else
                    button1.Left= button1.Left+h;
            }

            if (e.Y >= button1.Top - h && e.Y <= B + h)
            {
                if (e.Y >= (button1.Top + (button1.Height / 2)))
                    button1.Top=button1.Top-h;
                else
                    button1.Top=button1.Top+h; ;
            }
            if (button1.Left < 0)
                button1.Left = 0;
            if (button1.Right > defClSize.Width)
                button1.Left = defClSize.Width - button1.Width;
            if (button1.Top < 0)
                button1.Top = 0;
            if (button1.Bottom > defClSize.Height)
                button1.Top = defClSize.Height - button1.Height;
        }
     
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            diffX = defClSize.Width - ClientSize.Width;
            diffY = defClSize.Height - ClientSize.Height;
            defClSize = ClientSize;
            if (diffX > 0 || diffY > 0)
            {
                if (button1.Right > ClientSize.Width)
                {
                    button1.Left = ClientSize.Width - button1.Width - 30;
                }

                if (button1.Left < 0)
                {
                    button1.Left = 30;
                }
                if (button1.Top < 0)
                {
                    button1.Top = 30;
                }

                if (button1.Bottom > ClientSize.Height)
                {
                    button1.Top = ClientSize.Height - button1.Height - 30;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            defClSize = ClientSize;
            button1.Top = (ClientSize.Height - button1.Height) / 2;
            button1.Left = (ClientSize.Width - button1.Width) / 2;
        }
    }
}
