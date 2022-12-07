using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaCeOmTaRo
{
    public partial class Anchura_dirigidos : Form
    {

        /*Ejemplo a usar
            3->2
            2->4
            4->3
            4->1
            4->6
            3->5
            5->7
            7->4

            Recorrido iniciando en el nodo 3
            3,2,5,4,7,1,6
        */

        //Atributos
        int nodos;
        int[,] Grafo = new int[20, 20];

        //Constructor
        public Anchura_dirigidos()
        {
            InitializeComponent();

            //Limpiar Matriz
            Limpiar();

            //Reinciar Botones y TextBox 
            TB_Nodos.Text = "";
            TB_Nodos.Enabled = true;
            BT_Comenzar.Enabled = true;

            TB_Grafo.Text = "";
            TB_Grafo.Enabled = false;

            TB_Inicio.Text = "";
            TB_Fin.Text = "";
            TB_Inicio.Enabled = false;
            TB_Fin.Enabled = false;
            BT_Conexion.Enabled = false;

            TB_Resultado.Text = "";
            TB_Resultado.Enabled = false;
            TB_Comienzo.Text = "";
            TB_Comienzo.Enabled = false;
            BT_Recorrido.Enabled = false;

            BT_Reiniciar.Enabled = false;
        }

        //Boton comenzar
        private void BT_Comenzar_Click(object sender, EventArgs e)
        {
            if(TB_Nodos.Text != "")
            {
                int nodo;
                try
                {
                    nodo = Convert.ToInt32(TB_Nodos.Text);

                    if(nodo >= 2 && nodo <= 20)
                    {
                        nodos = nodo;
                        Mostrar();

                        //Mostrar botones
                        BT_Comenzar.Enabled = false;
                        TB_Nodos.Enabled = false;

                        TB_Grafo.Enabled = true;

                        TB_Inicio.Enabled = true;
                        TB_Fin.Enabled = true;
                        BT_Conexion.Enabled = true;

                        BT_Reiniciar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("el numero de nodos no pude ser menor a 2 y mayor a 20");
                        TB_Nodos.Text = "";
                    }

                }
                catch
                {
                    MessageBox.Show("Error (no has colocado un dato numerico)");
                    TB_Nodos.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Coloca el numero de Nodos");
                TB_Nodos.Text = "";
            }
        }

        //Funcion para mostrar la matriz
        public void Mostrar()
        {
            String texto="";
            for (int i = 0; i < nodos; i++)
            {
                texto += Environment.NewLine;
                for (int j = 0; j < nodos; j++)
                {
                    texto += Convert.ToString(Grafo[i, j])+" ";
                }
            }
            TB_Grafo.Text = texto;
        }

        //Funcion para limpiar la matriz
        public void Limpiar()
        {
            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    Grafo[i, j] = 0;
                }
            }
        }

        //Funcion para reiniciar
        public void Reinciar()
        {
            //Limpiar Matriz
            Limpiar();

            //Reinciar Botones y TextBox 
            TB_Nodos.Text = "";
            TB_Nodos.Enabled = true;
            BT_Comenzar.Enabled = true;

            TB_Grafo.Text = "";
            TB_Grafo.Enabled = false;

            TB_Inicio.Text = "";
            TB_Fin.Text = "";
            TB_Inicio.Enabled = false;
            TB_Fin.Enabled = false;
            BT_Conexion.Enabled = false;

            TB_Comienzo.Text = "";
            TB_Comienzo.Enabled = false;
            TB_Resultado.Text = "";
            TB_Resultado.Enabled = false;
            BT_Recorrido.Enabled = false;

            BT_Reiniciar.Enabled = false;
        }

        //Boton Reiniciar
        private void BT_Reiniciar_Click(object sender, EventArgs e)
        {
            Reinciar();
        }

        //Boton para Agregar Conexiones deL Grafok
        private void BT_Conexion_Click(object sender, EventArgs e)
        {
            if(TB_Inicio.Text != "" && TB_Fin.Text != "")
            {
                int ini, fin;
                try
                {
                    ini = Convert.ToInt32(TB_Inicio.Text);
                    fin = Convert.ToInt32(TB_Fin.Text);

                    if(ini >= 1 && ini <= nodos && fin >= 1 && fin <= nodos)
                    {
                        Grafo[(ini-1), (fin-1)] = 1;
                        Mostrar();
                        BT_Recorrido.Enabled = true;
                        TB_Comienzo.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error (Colocaste mal los numeros de conexion)");
                    }

                }
                catch
                {
                    MessageBox.Show("Error (no has colocado un numero)");
                }
            }
            else
            {
                MessageBox.Show("Dejaste espacios en blanco");
            }

            TB_Fin.Text = "";
            TB_Inicio.Text = "";
        }

        //Boton de Recorido en Anchura
        private void BT_Recorrido_Click(object sender, EventArgs e)
        {
            //Proceso shido
            
                int comienzo = Convert.ToInt32(TB_Comienzo.Text)-1;

                if (comienzo >= 0 && comienzo <= (nodos-1))
                {
                    BT_Conexion.Enabled = false;
                    TB_Inicio.Enabled = false;
                    TB_Fin.Enabled = false;
                    TB_Comienzo.Enabled = false;
                    TB_Resultado.Enabled = true;

                    int[] cola = new int[nodos];
                    int visitados = 1;
                    cola[0] = comienzo;
                    int fin = 1;
                    int inicio = 0;
                    bool usado = false;
                    int Evaluar = 0;

                    while(visitados < nodos)
                    {
                        Evaluar = cola[inicio];
                        
                        for(int j = 0; j< nodos; j++)
                        {   
                            usado = false;
                            if (Grafo[Evaluar, j] == 1)
                            {
                                for(int i = 0; i< visitados; i++)
                                {
                                    if(j == cola[i])
                                    {
                                        usado = true;
                                    }
                                }
                                if(usado == false)
                                {
                                    cola[fin] = j;
                                    fin=fin+1;
                                    visitados=visitados+1;
                                    
                                }
                            }
                        }
                        inicio++;
                    }

                    //Mostrar cola de respuesta
                    string text = "";
                    for(int i = 0; i <  nodos; i++)
                    {
                        text += (cola[i]+1) + " -> "; 
                    }
                    TB_Resultado.Text = text;
                }
                else
                {
                    MessageBox.Show("El nodo de inicio elegino no es posible");
                    //Mensajes de error
                }
            }
        }
    }

