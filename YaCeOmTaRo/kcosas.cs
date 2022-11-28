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
    public partial class ConjuntoP : Form
    {
        public ConjuntoP()
        {
            InitializeComponent();
        }
        static int n = 0;
        int r = 0;
        string a = "";
        char[] conjunto = new char[1000];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            n = Int32.Parse(textBox1.Text);
            r = Int32.Parse(Math.Pow(2, n).ToString());
            
            for (int x = 0; x < n; x++)
            {
                conjunto[x] = (char)(x + 65);
            }
            for (uint x=0;x < r; x++)
            {
                for (int y = 0; y < n; y++)
                {

                    if ((x & (1 << y)) != 0)
                    {
                        a += conjunto[y];
                    }
                }
                listBox1.Items.Add(a);
                a = "";
            }
        }

        private void ConjuntoP_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
        }
    }
}
