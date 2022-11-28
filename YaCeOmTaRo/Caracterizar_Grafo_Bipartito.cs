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

namespace YaCeOmTaRo
{
    public partial class Caracterizar_Grafo_Bipartito : Form
    {
        public Caracterizar_Grafo_Bipartito()
        {
            InitializeComponent();
            panel1.Hide();
            button4.Enabled = false;
            button5.Enabled = false;
            comboBox2.Enabled = false;

        }
       
private void button1_Click(object sender, EventArgs e)//Lista de adyacencia
        {
            panel1.Show();

        }
        private void button2_Click(object sender, EventArgs e)//Matriz de adyacencia
        {
            panel1.Show();
            panel2.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)//Metodo Distinto
        {

        }

        int x;
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

        private void button4_Click(object sender, EventArgs e)//Agregar elemento 1 panel
        {
            int a, s;
           
                a = Convert.ToInt32(comboBox3.Text);
                s = Convert.ToInt32(comboBox2.Text);
                switch (a)
                {
                    case 1:
               
                  
          


                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                

            }
            comboBox3.SelectedIndex=0;
            comboBox2.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e) //Siguiente elemento 1 panel
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) 
        {
     
        }
        int m = 0;
        int[,] matriz_adyacencia = new int[10,10];
        string matriz = "";
        private void button7_Click(object sender, EventArgs e)//generar matriz
        {
            
         
            m = Convert.ToInt32(comboBox4.Text);
           
            //imprime la matriz inicial 
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    
                    
                    matriz_adyacencia[i, j] = 0;
                    matriz_adyacencia[i, 0] = i + 1;
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
                comboBox6.SelectedIndex = 0;
                a = 0; b = 0;
            }
            string linea = "";
            for(int i = 0; i < m; i++)
            {
                for(int j=0;j<= m; j++)
                {
                    if(a == matriz_adyacencia[i, j])
                    {
                      
                            matriz_adyacencia[i, j+b] = 9;
                        
                    }
                    linea += "" + matriz_adyacencia[i, j] + "   ";
                }
                linea += Environment.NewLine;
            }
            textBox1.Text = linea;
            linea = "";
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*  bool DFS(Graph const &graph, int v, vector< bool > &discovered, vector<int> & color)
  {
                  // hacer para cada borde (v, u)
                  for (int u: graph.adjList[v])
                  {
                      // si se explora el vértice `u` por primera vez
                      if (!discovered[u])
                      {
                          // marca el nodo actual como descubierto
                          discovered[u] = true;

                          // el nodo actual tiene el color opuesto al de su padre
                          color[u] = !color[v];

                          // si DFS en cualquier subárbol enraizado en `v` devuelve falso
                          if (!DFS(graph, u, discovered, color))
                          {
                              return false;
                          }
                      }

                      // si el vértice ya fue descubierto y el color del vértice
                      // `u` y `v` son iguales, entonces el graph no es bipartito
                      else if (color[v] == color[u])
                      {
                          return false;
                      }
                  }

                  return true;
              }
            */
            bool[,] mat = new bool[10, 10];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j <= m; j++)
                {
                    mat[i, j] = false;
                    if (matriz_adyacencia[i, j] == 9)
                    {
                        mat[i, j] = true;
                    }    

                }
            }

        }
    }
}
