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
            int s = Convert.ToInt32(comboBox1.Text);
            string taxt = "";
            if(pareamiento(matriz, s) == true)
            {
                for (int i = 0; i < s; i++)
                {
                    taxt += pareja[i] + " --> " + pareja2[i];

                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9)
                    {
                        taxt += Environment.NewLine;
                    }

                }
                textBox1.Text = taxt;
                taxt = "";

            }
            else
            {
                textBox1.Text = "No hay emparejamiento perfecto";
            }



        }
        int[] pareja = new int[20];
        int[] pareja2 = new int[20];
        public bool pareamiento(int[,] matrix , int n )
        {
            int cont=0;
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
                    if (matrix[j, k] == 1)
                    {
                        pareja[j] = j + 1;
                        pareja2[j] = k + 1;
                        num = k;
                        num2 = j;
                        cont += 1;
                        break;
                       
                    }
                }
                for (int l = 0; l < num3; l++)
                {
                    matrix[l, j] = 0;
                    matrix[l, num] = 0;
                }
            }
            if(cont == num3 / 2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            for (int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    matriz[i, j] = 0;
                 
                }
                pareja[i] = 0;
                pareja2[i] = 0;
            }
            panel1.Hide();
        }
    }
}
