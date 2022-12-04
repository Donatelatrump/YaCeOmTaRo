using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Windows.Media;
using System.Linq.Expressions;
using System.Windows.Controls;
using System.IO;
using System.Diagnostics;

namespace YaCeOmTaRo
{
    public partial class Caracterizar_Grafo_Bipartito : Form
    {
        public Caracterizar_Grafo_Bipartito()
        {
            InitializeComponent();
            panel1.Hide();
            MinimizeBox = false;
            MaximizeBox = false;
            button4.Enabled = false;
            button5.Enabled = false;
            comboBox2.Enabled = false;
            textBox1.Enabled = false;
            

        }
       
private void button1_Click(object sender, EventArgs e)//Lista de adyacencia
        {
            panel1.Show();
            panel2.Hide();

        }
        string l = "6";
        private void button2_Click(object sender, EventArgs e)//Matriz de adyacencia
        {
            panel1.Show();
            panel2.Show();
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            
                
        }

        private void button3_Click(object sender, EventArgs e)//Metodo Distinto
        {
            using (var OT = new OtraFormaCaracterizar())
            {
                OT.ShowDialog();
            }
        }

        int x;
        int[,] lista2 = new int[10, 10];
        private void button6_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
           
            x = Convert.ToInt32(comboBox1.Text);
            int l = 0;
            for (int i = 1; i <= x; i++)//Añade los vertices de 1 en 1 hasta el numero de vertices elegidos
            {
             
                if (i != x)
                {
                    comboBox2.Items.Add("" + (i + 1));
                    
                }
                comboBox3.Items.Add("" + (l + 1));
                l++;
            }


        }

        
        int f;
        string respuesta = "";
        string texto = "";
        bool ar = false;
        int temo=1;
        private void button4_Click(object sender, EventArgs e)//Agregar elemento 1 panel
        {
            int a, s;
            
            a = Convert.ToInt32(comboBox3.Text);
            s = Convert.ToInt32(comboBox2.Text);
            f = Convert.ToInt32(comboBox1.Text);
            List<List<int>> lista = new List<List<int>>();

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < f; j++)
                {
                    lista2[i, j] = 0;
                }
                
            }
            if (temo != a)
            {
                ar = false;
                texto += Environment.NewLine;
            }

            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < f; j++)
                {
                    if (a == i + 1)
                    {

                        lista2[i, s - 1] = 1;

                    }
                    if (lista2[i, j] == 1)
                    {
                        
                        if (ar != true)
                        {
                            texto += "" + (i + 1) + " -->  " + (j + 1);
                           
                            
                        }
                        else
                        {
                            texto += " --->  " + (j + 1);
                       
                        }
                    }
                }
                

            }
            ar = true;
   
        
            temo = a;
            textBox2.Text = texto;
            respuesta = texto;
        }
       
        private void button5_Click(object sender, EventArgs e) //Finalizar panel 1
        {
            respuesta+= Environment.NewLine + Globals.Maiz(lista2, f.ToString());
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) 
        {
     
        }
        int m = 0;
        int[,] matriz_adyacencia = new int[10,10];
        string matriz = "";
        private void button7_Click(object sender, EventArgs e)//generar matriz
        {
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;

            m = Convert.ToInt32(comboBox4.Text);
           
            //imprime la matriz inicial 
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz_adyacencia[i, j] = 0;
                    matriz += "" + matriz_adyacencia[i, j] + "   ";
                }
                if (i != m)
                {
                    comboBox5.Items.Add(i + 1);
                    comboBox6.Items.Add(i + 1);
                }
                matriz += Environment.NewLine;
            }
            textBox1.Text = matriz;
            matriz = "";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(comboBox5.Text);
            b = Convert.ToInt32(comboBox6.Text);
            if (a == b)
            {
                System.Windows.MessageBox.Show("El arista no puede estar apuntando a si mismo");
                comboBox5.SelectedIndex = 0;
                comboBox6.SelectedIndex = 1;
                a = 0; b = 0;
            }
            string linea = "";
            for(int i = 0; i < m; i++)
            {
                for(int j=0; j< m; j++)
                {
                    if(a == i+1)
                    {
                      
                            matriz_adyacencia[i, b-1] = 1;
                        
                    }
                    linea += "" + matriz_adyacencia[i, j] + "   ";
                }
                linea += Environment.NewLine;
            }
            textBox1.Text = linea;
            linea = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            label7.Text = Globals.Maiz(matriz_adyacencia, l);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void BTCrear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
