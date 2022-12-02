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
    public partial class Saber_Si_Es_Arbol : Form
    {   
        int[,] Grafo = new int[50, 50];
        int numeronodos = 0;
        bool arbol = true, pasar = true;
        public Saber_Si_Es_Arbol()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            TB_Numeronodos.Text = "2";
            
        }

        private void BT_Reiniciar_Click(object sender, EventArgs e)
        {
            TB_Numeronodos.Text = "2";
            TB_Numeronodos.Enabled = true;
            BT_Creargrafo.Enabled = true;

            TB_Grafo.Text = "";

            TB_Nodo1.Enabled = false;
            TB_Nodo2.Enabled = false;
            TB_Nodo1.Text = "";
            TB_Nodo2.Text = "";

            BT_Comenzar.Enabled = false;
            TB_Respuesta.Text = "";
        }

        private void BT_Creargrafo_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TB_Numeronodos.Text) < 2|| Convert.ToInt32(TB_Numeronodos.Text) > 50)
            {
                MessageBox.Show("No puedes tener menos de dos nodos ni mayor a 50");
            }
            else
            {
                numeronodos = Convert.ToInt32(TB_Numeronodos.Text);
                TB_Numeronodos.Enabled = false;
                BT_Creargrafo.Enabled = false;
                TB_Nodo1.Enabled = true;
                TB_Nodo2.Enabled = true;

                //Mostrar la matriz
                string texto = "";
                for (int i = 0; i < numeronodos; i++)
                {
                    for (int j = 0; j < numeronodos; j++)
                    {
                        Grafo[i, j] = 0;
                        texto += Convert.ToString(Grafo[i, j]) + "     ";
                    }
                    texto += Environment.NewLine;
                }
                TB_Grafo.Text = texto;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BT_Comenzar.Enabled = true;
            int n1 = Convert.ToInt32(TB_Nodo1.Text);
            int n2 = Convert.ToInt32(TB_Nodo2.Text);
            if ((n1 > 0 && n1 <= numeronodos) && (n2 > 0 && n2 <= numeronodos))
            {
                if (n1 != n2)
                {   
                    TB_Grafo.Text = "";
                    //Agregar al grafo
                    Grafo[n1 - 1, n2 - 1] = 1;
                    Grafo[n2 - 1, n1 - 1] = 1;
                    
                    TB_Nodo1.Text = "";
                    TB_Nodo2.Text = "";

                    string texto = "";
                    for (int i = 0; i < numeronodos; i++)
                    {
                        for (int j = 0; j < numeronodos; j++)
                        {
                            texto += Convert.ToString(Grafo[i, j]) + "     ";
                        }
                        texto += Environment.NewLine;
                    }
                    TB_Grafo.Text = texto;
                }
                else
                {
                    MessageBox.Show("El nodo de inicio y el del final no pueden ser iguales ");
                }
            }
            else
            {
                MessageBox.Show("Error en valores a insertar en la casilla nodos");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Saber_Si_Es_Arbol_FormClosed(object sender, FormClosedEventArgs e)
        {
            TB_Numeronodos.Text = "2";
            TB_Numeronodos.Enabled = true;
            BT_Creargrafo.Enabled = true;

            TB_Grafo.Text = "";

            TB_Nodo1.Enabled = false;
            TB_Nodo2.Enabled = false;
            TB_Nodo1.Text = "";
            TB_Nodo2.Text = "";

            BT_Comenzar.Enabled = false;
            TB_Respuesta.Text = "";
        }

        private void BT_Comenzar_Click(object sender, EventArgs e)
        {
            int random = 0;
            int i, j;
            int evaluar = random;
            int cont = 0;
            int[] Vector = new int[numeronodos];
            Vector[cont] = random;
            cont++;
            arbol = true;
            pasar = true;
            int xd = 0;

            while (arbol != false && cont < numeronodos)
            {
                xd = 0;
                for (i = 0; i < numeronodos; i++)
                {
                    //Buscamos las conecciones
                    if (Grafo[evaluar,i] == 1)
                    {

                        Grafo[evaluar,i] = 0;
                        Grafo[i,evaluar] = 0;
                        //Revisamos que no repitamos nodo
                        for (j = 0; j < cont; j++)
                        {
                            if (Vector[j] == i)
                            {
                                pasar = false;
                                j = cont;
                            }
                        }

                        //si repitio nodo
                        if (pasar == false)
                        {
                            //no es un arbol
                            arbol = false;
                        }
                        else
                        {
                            //Seguir revisando
                            Vector[cont] = i;
                            cont++;
                            evaluar = i;
                            i = 0;
                        }

                    }
                    else
                    {
                        xd++;
                    }
                    if (xd == (numeronodos-1))
                    {
                        evaluar = random;
                    }
                }
            }

            if (arbol == false)
            {
               TB_Respuesta.Text = "El grafo no es un arbol";
            }
            else
            {
                TB_Respuesta.Text = "El grafo si es un arbol";
            }
        }

    }
}
