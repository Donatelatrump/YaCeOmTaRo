using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphLib.Model;

namespace YaCeOmTaRo
{
    public partial class apareamiento_normal : Form
    {
        public apareamiento_normal()
        {
            InitializeComponent();
            panel1.Hide();
            textBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }
        /*Grafo usado para pareo perfecto
         * 0 1 1 0 0 0
         * 1 0 1 1 1 0
         * 1 1 0 1 1 0
         * 0 1 1 0 1 1
         * 0 1 1 1 0 1
         * 0 0 0 1 1 0 
         * Este grafo tiene varias formas de perfecto, 
         * 1->2
         * 3->4
         * 5->6 
         * 
         * 1->3
         * 2->4
         * 5->6
         * */
        private void button1_Click(object sender, EventArgs e) //activar panel de tonto
        {
            using (var pT = new PareoTonto_GNormal())
            {
                pT.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e) //activar panel de perfecto
        {
            panel1.Show();
        }

        private void button2_Click(object sender, EventArgs e)//activar panel de maximo
        {
            using (var pM = new PareoMaximo_GNormal())
            {
                pM.ShowDialog();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //Sirve para que no se pueda escribir o editar el combobox
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        int[,] matriz = new int[20, 20];
        private void button4_Click(object sender, EventArgs e)//Genera matriz de pareo perfecto
        {
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            comboBox1.Enabled = false;
            button4.Enabled = false;

            int n;
            string datos = "";
            n = Convert.ToInt32(comboBox1.Text);
            for (int i = 0; i < n; i++) //rellenamos la matriz de 0 
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = 0;
                    datos += "" + matriz[i, j] + "  "; 
                }
                datos += Environment.NewLine;
                
                comboBox3.Items.Add(i + 1);
                comboBox2.Items.Add(i + 1);
            }
            textBox1.Text = datos;
            datos = null;

        }

        private void button5_Click(object sender, EventArgs e) //agrega conexiones a la matriz de pareo perfecto
        {
            int n,nodo,conexion;
            string text = "";
            n = Convert.ToInt32(comboBox1.Text);
            nodo = Convert.ToInt32(comboBox2.Text);
            conexion = Convert.ToInt32(comboBox3.Text); //tomamos los valores y los convertimos a entero
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(nodo == (i + 1)) //Solo si esta en la linea del nodo puede entrar y asignar 
                    {
                        matriz[i, conexion - 1] = 1;
                        matriz[conexion - 1,i] = 1;
                    }
                    text += "" + matriz[i, j] + "  ";
                }
                text += Environment.NewLine;
            }
            textBox1.Text = text;
            text = null; //revaciamos el string para no almacenar basura
        }
        private void button6_Click(object sender, EventArgs e)//genera el emparejamiento perfecto
        {
            int nodos = Convert.ToInt32(comboBox1.Text);
            int cont = 0;
            String texto = "";
            //Ciclo para toda la matriz
            for (int k = 0; k < nodos; k++)
            {
                //Recorrer la linea
                for (int i = 0; i < nodos; i++)
                {
                    if (matriz[k, i] == 1)
                    {
                        //Guardo la conexion
                        texto += Convert.ToString((k + 1)) + "->" + Convert.ToString((i + 1)) + Environment.NewLine;
                        //elimino todas las conexiones de la conexion 
                        for (int j = 0; j < nodos; j++)
                        {
                            matriz[k, j] = 0;
                            matriz[j, k] = 0;
                            matriz[i, j] = 0;
                            matriz[j, i] = 0;
                            cont++;
                        }
                    }

                }
            }
            texto += Environment.NewLine;
            if (cont == (nodos / 2))
            {

                texto += Environment.NewLine + "No tiene Pareamiento Perfecto pero este es el mejor ";
                textBox1.Text = texto;
            }
            else
            {
                textBox1.Text = texto;
            }
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Enabled = true;
            button4.Enabled = true;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    matriz[i, j] = 0;
                 
                }
            }
            panel1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
