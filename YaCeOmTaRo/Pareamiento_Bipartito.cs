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
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)//Tonto
        {
            panel1.Show();
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)//Maximo
        {
            using (PareoBipartitoMaximo maxBip = new PareoBipartitoMaximo())
            {
                maxBip.ShowDialog();
            }
        }

        //Perfecto
        private void button3_Click(object sender, EventArgs e) 
        {
            using (Bipartito_perfecto sexo_uwu = new Bipartito_perfecto())
            {
                sexo_uwu.ShowDialog();
            }

        }

        int[,] tonto = new int[25, 25];
        private void button4_Click(object sender, EventArgs e)//generar
        {
            comboBox1.Enabled = false;
            button4.Enabled = false;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
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
                        tonto[j, i] = 1;
                    }
                    text = text + tonto[i, j] + "  ";
                }
                text += Environment.NewLine;
            }
            textBox1.Text = text;
            text = "";
        }
        private void button6_Click(object sender, EventArgs e)//pareamiento
        {
            int nodos = Convert.ToInt32(comboBox1.Text);
            String texto = "";
            //Ciclo para toda la matriz
            for (int k = 0; k < nodos; k++)
            {
                //Recorrer la linea
                for (int i = 0; i < nodos; i++)
                {
                    if (tonto[k, i] == 1)
                    {
                        //Guardo la conexion
                        texto += Convert.ToString((k + 1)) + "->" + Convert.ToString((i + 1)) + Environment.NewLine;
                        //elimino todas las conexiones de la conexion 
                        for (int j = 0; j < nodos; j++)
                        {
                            tonto[k, j] = 0;
                            tonto[j, k] = 0;
                            tonto[i, j] = 0;
                            tonto[j, i] = 0;
                        }
                    }

                }
            }
            textBox1.Text = texto;
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

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            button4.Enabled = true;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            textBox1.Text = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    tonto[i, j] = 0;
                }
            }
            panel1.Hide();

        }
    }
}
