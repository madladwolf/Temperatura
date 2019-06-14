using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double temp = double.Parse(txt_temp.Text);
                if (temp < 3)
                {
                    this.BackColor = Color.FromArgb(0, 153, 153);
                    //Image.FromFile(@'C:\Users\t0114312\source\repos\Temperatira\Temperatira\Imagens\gelo');
                    pictureBox1.Image = Temperatura.Properties.Resources._23917;

                }
                else if (temp > 3 && temp < 15)
                {
                    pictureBox1.Image = Temperatura.Properties.Resources._49823;
                    this.BackColor = Color.FromArgb(255, 229, 204);
                }
                else if (temp > 15)
                {
                    this.BackColor = Color.FromArgb(255, 102, 102);
                    pictureBox1.Image = Temperatura.Properties.Resources.sol;
                }
            }
            catch
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void Chk_chover_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_chover.Checked)
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Temperatura.Properties.Resources.rain_PNG13459;
            }
            else
            {
                pictureBox2.Visible = false;
            }
        }
    }
}
