using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular_velocidad
{
    public partial class Form1 : Form
    {
        float dis, tiem, vel1, vel2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dis = float.Parse(textBox1.Text);
                tiem = float.Parse(textBox2.Text);

                if (dis <= 0 || tiem <= 0)
                {
                    dis = float.Parse(textBox1.Text);
                    tiem = float.Parse(textBox2.Text);
                    MessageBox.Show("Por favor ingrese valores mayores que 0 en los respectivos campos");

                }

                else
                {

                    vel1 = dis / tiem;
                    vel2 = (vel1 * 1000) / 3600;
                    richTextBox1.Text += ("La velovidad es de: " + vel1 + "km/h tambien expresada como: " + vel2 + "m/s" + Environment.NewLine);
                }
            }

            catch
            {
                MessageBox.Show("Por favor ingrese datos numericos en los campos");
                Application.Restart();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            richTextBox1.Clear();
        }
    }
}
