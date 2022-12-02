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
    public partial class Pareamiento_Bipartito : Form
    {
        public Pareamiento_Bipartito()
        {
            InitializeComponent();
            panel1.Hide();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)//Tonto
        {
            panel1.Show();
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)//Maximo
        {

        }

        private void button3_Click(object sender, EventArgs e) //Perfecto
        {

        }
        int[,] tonto = new int[20, 20];
        private void button4_Click(object sender, EventArgs e)//generar
        {
            int num = Convert.ToInt32(comboBox1.Text);
            string text = "";
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    tonto[i, j] = 0;
                    text = text + tonto[i, j] + "  ";
                }
                text += Environment.NewLine;
                comboBox2.Items.Add(i + 1);
                comboBox3.Items.Add(i + 1);
            }
            textBox1.Text = text;
            text = "";
        }

        private void button5_Click(object sender, EventArgs e)//agregar
        {
            int num = Convert.ToInt32(comboBox2.Text);
            int num2 = Convert.ToInt32(comboBox3.Text);
            int num3 = Convert.ToInt32(comboBox1.Text);
            string text = "";
            for (int i = 0; i < num3; i++)
            {
                for (int j = 0; j < num3; j++)
                {
                    if (i == num - 1 && j == num2 - 1)
                    {
                        tonto[i, j] = 1;
                    }
                    text = text + tonto[i, j] + "  ";
                }
                text += Environment.NewLine;
            }
            textBox1.Text = text;
            text = "";
        }

        int[] pareja = new int[20];
        int[] pareja2 = new int[20]; 
        private void button6_Click(object sender, EventArgs e)//pareamiento
        {
            int num = 0;
            int num2 = 0;
            int num3 = Convert.ToInt32(comboBox1.Text);
            for (int i = 0; i < num3; i++)
            {
                pareja[i] = 0;
                pareja2[i] = 0;
            }
            for (int j = 0; j < num3; j++)
            {
                for (int k = 0; k < num3; k++)
                {
                    if (tonto[j, k] == 1)
                    {
                        pareja[j] = j + 1;
                        pareja2[j] = k + 1;
                        num = k;
                        num2 = j;
                        break;
                    }
                }
                for (int l = 0; l < num3; l++)
                {
                    tonto[l, j] = 0;
                    tonto[l, num] = 0;
                }
            }
            string text = "";
            for (int m = 0; m < num3; m++)
            {
                if (pareja[m] != 0)
                {
                    text = text + pareja[m] + " --> " + pareja2[m];
                    text += Environment.NewLine;
                }
            }
            textBox1.Text = text;
            text = "";
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)//sirven para que no editen los combobox
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
