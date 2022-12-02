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
    public partial class CadenasChidas : Form
    {
        public CadenasChidas()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }
        int decima = 0;
        int[] binario = new int[100];
        string a = "";
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            decima = Int32.Parse(textBox1.Text);
            for (int i = 0; i < decima; i++)
            {
                funcione(i + 1);
            }
        }
        public void funcione(int decimalx)
        {
            {
                int i = 0;

                while (decimalx > 0)
                {
                    binario[i] = decimalx % 2;
                    decimalx = decimalx / 2;
                    i++;
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    a += binario[j];
                }
                listBox1.Items.Add(a);
                a = "";
            }
        }

        private void CadenasChidas_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
        }
    }
    } 
