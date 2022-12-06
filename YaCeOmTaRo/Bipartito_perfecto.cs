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
    public partial class Bipartito_perfecto : Form
    {
        //Atributos
        int nodos;
        int[,] Grafo = new int[10, 10];
        int[] pareja = new int[20];
        int[] pareja2 = new int[20];

        //constructor
        public Bipartito_perfecto()
        {
            InitializeComponent();
            MessageBox.Show("Recuerda que el grafo a ingresar ya sea bipartito");

            //Limpiar Matriz
            Limpiar();
            //Activar y Desactivar botones
            TB_NumeroNodos.Text = "";
            BT_Comenzar.Enabled = true;
            TB_NumeroNodos.Enabled = true;

            TB_Inicio.Text = "";
            TB_Final.Text = "";
            TB_MatrizGrafo.Text = "";
            TB_Inicio.Enabled = false;
            TB_Final.Enabled = false;
            button1.Enabled = false;

            TB_Resultado.Text = "";
            BT_Pareamiento.Enabled = false;
            TB_Resultado.Enabled = false;

            BT_Reiniciar.Enabled = false;
        }

        //Boton comenzar 
        private void BT_Comenzar_Click(object sender, EventArgs e)
        {
            if(TB_NumeroNodos.Text != "")
            {
                int nodo = Convert.ToInt32(TB_NumeroNodos.Text);
                if (nodo < 2)
                {
                    MessageBox.Show("Tienes que tener al menos dos nodos");
                }
                else
                {
                    if (nodo < 11)
                    {
                        if(nodo%2 == 0)
                        {
                            nodos = nodo;
                            BT_Comenzar.Enabled = false;
                            TB_NumeroNodos.Enabled = false;

                            TB_Inicio.Enabled = true;
                            TB_Final.Enabled = true;
                            button1.Enabled = true;
                            MostrarGrafo();

                            BT_Reiniciar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Para hacer pareamiento perfecto los nodos deben de ser un numero par");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Maximo 10 nodos");
                    }
                }
            }
            else
            {
                MessageBox.Show("Dejaste el espacio vacio en el numero de nodos");
            }
            
        }

        //Limpiar matriz
        public void Limpiar()
        {
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Grafo[i,j] = 0;
                }
            }
        }

        //Rellena el textBox de Matriz
        public void MostrarGrafo()
        {
            string texto = "";
            for (int i = 0; i < nodos; i++)
            {
                for (int j = 0; j < nodos; j++)
                {
                    texto += Convert.ToString(Grafo[i, j]) + "  ";
                }
                texto += Environment.NewLine;
            }
            TB_MatrizGrafo.Text = texto;
        }

        //boton para conexion
        private void button1_Click(object sender, EventArgs e)
        {
            int inicio, fin;
            if(TB_Final.Text != "" && TB_Final.Text != "")
            {
                inicio = Convert.ToInt32(TB_Inicio.Text);
                fin = Convert.ToInt32(TB_Final.Text);
                if(inicio > 0 && inicio <= nodos && fin <= nodos && fin > 0 && inicio != fin)
                {
                    Grafo[(inicio-1), (fin-1)] = 1;
                    Grafo[(fin-1), (inicio-1)] = 1;
                    MostrarGrafo();
                    TB_Final.Text = "";
                    TB_Inicio.Text = "";
                    BT_Pareamiento.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error al insertar conexion (indices mal)");
                    TB_Final.Text = "";
                    TB_Inicio.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Dejaste espacios en Blanco");
            }
        }

        //Boton de pareamiento 
        private void BT_Pareamiento_Click(object sender, EventArgs e)
        {
           int cont=0;
           String texto = "";
           //Ciclo para toda la matriz
           for(int k = 0; k < nodos; k++)
           {
                //Recorrer la linea
                for(int i = 0; i < nodos; i++)
                {
                    if (Grafo[k, i] == 1)
                    {
                        //Guardo la conexion
                        texto += Convert.ToString((k + 1)) + "->" + Convert.ToString((i+1)) + Environment.NewLine;
                        //elimino todas las conexiones de la conexion 
                        for(int j = 0; j < nodos; j++)
                        {
                            Grafo[k, j] = 0;
                            Grafo[j, k] = 0;
                            Grafo[i, j] = 0;
                            Grafo[j, i] = 0;
                            cont++;
                        }
                    }
                    
                }  
           }
           texto += Environment.NewLine;
           if (cont == (nodos / 2)){
               
                texto += Environment.NewLine + "No tiene Pareamiento Perfecto pero este es el mejor "; 
                TB_Resultado.Text = texto;
           }
            else
            {
                TB_Resultado.Text = texto;
            }
           
           
        }
        //Boton reiniciar 
        private void BT_Reiniciar_Click(object sender, EventArgs e)
        {
            //Limpiar Matriz
            Limpiar();
            //Activar y Desactivar botones
            TB_NumeroNodos.Text = "";
            BT_Comenzar.Enabled = true;
            TB_NumeroNodos.Enabled = true;

            TB_Inicio.Text = "";
            TB_Final.Text = "";
            TB_MatrizGrafo.Text = "";
            TB_Inicio.Enabled = false;
            TB_Final.Enabled = false;
            button1.Enabled = false;

            TB_Resultado.Text = "";
            BT_Pareamiento.Enabled = false;
            TB_Resultado.Enabled = false;

            BT_Reiniciar.Enabled = false;
        }
    }
}
