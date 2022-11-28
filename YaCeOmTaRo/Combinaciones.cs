using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaCeOmTaRo
{
    public partial class Combinaciones : Form
    {
        public Combinaciones()
        {
            InitializeComponent();
            panel1combi.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 1: //CR^p,n
                    panel1combi.Show();
                    break;

                case 2: //C(n,r)
                    panel1combi.Show();
                    panel2combi.Show();
                    break;


            }
            switch (comboBox2.SelectedIndex)
            {
                case 1:  //P(n)=n!
                    panel1combi.Show();
                    panel2combi.Show();
                    panel1per.Show(); //13 resultado
                    break;

                case 2: //PR(n,r)=n^r
                    panel1combi.Show();
                    panel2combi.Show();
                    panel1per.Show();
                    panel2per.Show();
                    break; //label 17

                case 3: //P(n,r)
                    panel1combi.Show();
                    panel2combi.Show();
                    panel1per.Show();
                    panel2per.Show();
                    panel3per.Show();
                    break; //label21
            }
        }
        uint a = 0, n = 0, c = 0, b = 0, respuesta = 0, i = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            panel2combi.Hide();
            panel1combi.Hide();
            f = 0; l = 0; resultado = 0;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            n = UInt32.Parse(textBox5.Text);
            num = 1;
            for (i = 1; i <= n; i++)
            {
                num *= i;
            }
            label13.Text = num.ToString();

            n = 0; num = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1per.Hide();
            panel2combi.Hide();
            panel1combi.Hide();
            f = 0; l = 0; resultado = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            f = Int32.Parse(textBox6.Text);
            l = Int32.Parse(textBox7.Text);
            resultado = Math.Pow(f, l);
            label17.Text = resultado.ToString();
            f = 0; l = 0; resultado = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel2per.Hide();
            panel1per.Hide();
            panel2combi.Hide();
            panel1combi.Hide();
            f = 0; l = 0; resultado = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            n = Convert.ToUInt32(textBox8.Text);
            c = Convert.ToUInt32(textBox9.Text);
            sum = 1;
            for (i = 1; i <= n; i++)
            {
                sum *= i;
            }
            num = n - c;
            a = 1;
            for (i = 1; i <= num; i++)
            {
                a *= i;
            }
            respuesta = sum / a;
            label21.Text = respuesta.ToString();
            sum = 0; a = 0; n = 0; c = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3per.Hide();
            panel2per.Hide();
            panel1per.Hide();
            panel2combi.Hide();
            panel1combi.Hide();
            sum = 0; a = 0; n = 0; c = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != 0)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n = UInt32.Parse(textBox3.Text);
            c = UInt32.Parse(textBox4.Text);
            a = 1; b = n - c;
            for (i = 1; i <= n; i++)
            {
                a *= i;
            }
            n = 1;
            for (i = 1; i <= b; i++)
            {
                n *= i;
            }
            b = 1;
            for (i = 1; i <= c; i++)
            {
                b *= i;
            }
            respuesta = a / (n * b);
            label10.Text = "" + respuesta;
            respuesta = 0; n = 0; c = 0; b = 0; a = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1combi.Hide();
            respuesta = 0; n = 0; c = 0; b = 0; a = 0;
        }

        double f = 0, l = 0, resultado = 0;

        uint num = 0, sum = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            n = UInt32.Parse(textBox1.Text); //guardo los valores en variables y convierto lo introducido a entero
            c = UInt32.Parse(textBox2.Text);
            a = n + c - 1; b = n - 1; n = 1;
            for (i = 1; i <= a; i++)
            {
                n *= i;
            }
            a = 1;
            for (i = 1; i <= b; i++)
            {
                a *= i;
            }
            b = 1;
            for (i = 1; i <= c; i++)
            {
                b *= i;
            }
            respuesta = n / (a * b);
            label6.Text = "" + respuesta;
            //label6 es pa resultado uwu
            respuesta = 0; n = 0; c = 0; b = 0; a = 0;
        }
    }
}
