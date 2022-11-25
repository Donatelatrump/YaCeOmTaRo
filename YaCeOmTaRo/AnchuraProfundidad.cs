using System;
using System.Collections;
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
    public partial class AnchuraProfundidad : Form
    {
        //Atributos 
        int nodos;
        int aristas;
        bool [,] matriz; 
        int cAr;
        bool[] visitado;
        Stack pila = new Stack();
        Queue cola = new Queue();
        String m;
        public AnchuraProfundidad()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
            TBCNodo.Text = "";
            TBConexion.Text = "";
            TBNodoInicio.Text = "";
            TBNodos.Text = "";
            TBRecorrido.Text = "";
            TBRecorrido.Enabled = false;
            BTGRecorrido.Enabled=false;
            TBAristas.Text = "";
            BTAgregarC.Enabled= false;
            cAr = 1;
            m = "";
            TBCNodoA.Text = "";
            TBAristasA.Text = "";
            TBConexionA.Text = "";
            TBInicioA.Text = "";
            TBNodosA.Text = "";
            TBRecorridoA.Text = "";
            BTAgregarA.Enabled = false;
            BTGRecorridoA.Enabled = false;
            TBRecorridoA.Enabled = false;

        }
        public static bool todosvisitados(bool[] visitado, int nodos)
        {
            for(int x=0; x<nodos; x++)
            {
                if (visitado[x] == false)
                {
                    return false; 
                }
                else
                {
                    return true;
                }
                
            }
            return true;
        }
        private void BTGRecorrido_Click(object sender, EventArgs e)
        {
            int ini = Convert.ToInt32(TBNodoInicio.Text);
            int inicio = ini - 1;
            m += ini;
            visitado = new bool[nodos]; 
            visitado[inicio] = true;
            do
            {
                for(int x=0; x<nodos; x++)
                {
                    if ((matriz[inicio,x] == true) && (visitado[x] == false))
                    {
                        visitado[x] = true;
                        pila.Push(x);
                    }
                }
                inicio = Convert.ToInt32(pila.Peek());
                ini = inicio + 1;
                m += " -> " + ini;
                pila.Pop();
            } while (!todosvisitados(visitado, nodos) || pila.Count!=0);
            TBRecorrido.Text = m;
        }

        private void BTReiniciar_Click(object sender, EventArgs e)
        {
            TBCNodo.Text = "";
            TBConexion.Text = "";
            TBNodoInicio.Text = "";
            TBNodos.Text = "";
            TBRecorrido.Text = "";
            TBRecorrido.Enabled = false;
            BTGRecorrido.Enabled = false;
            TBAristas.Text = "";
            BTAgregarC.Enabled = false;
            cAr = 1;
            m = "";
            TBRecorrido.Text = "";
        }

        private void BTAgregarC_Click(object sender, EventArgs e)
        {
            int nod=Convert.ToInt32(TBCNodo.Text);
            int conexion = Convert.ToInt32(TBConexion.Text);
            matriz[nod - 1, conexion - 1] = true; 
            if(cAr >= aristas)
            {
                BTAgregarC.Enabled = false;
                BTGRecorrido.Enabled = true;
            }
            MessageBox.Show("Arista agregada");
            TBCNodo.Text = "";
            TBConexion.Text = "";
            cAr += 1;
        }

        private void BTCrear_Click(object sender, EventArgs e)
        {
            BTAgregarC.Enabled = true;
            if(TBNodos.Text == "")
            {
                MessageBox.Show("No puede estar vacio el campo de nodos");

            }
            else
            {
                nodos = Convert.ToInt32(TBNodos.Text);
            }
           if(TBAristas.Text == "")
            {
                MessageBox.Show("No puede estar vacio el campo de aristas");
            }
            else
            {
                aristas = Convert.ToInt32(TBAristas.Text);
            }
            
            matriz = new bool[nodos, nodos];

            //Lenar de valores
            for (int i = 0; i < nodos; i++)
            {
                for (int j = 0; j < nodos; j++)
                {
                    matriz[i, j] = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cAr = 1;
            m = "";
            TBCNodoA.Text = "";
            TBAristasA.Text = "";
            TBConexionA.Text = "";
            TBInicioA.Text = "";
            TBNodosA.Text = "";
            TBRecorridoA.Text = "";
            BTAgregarA.Enabled = false;
            BTGRecorridoA.Enabled = false;
            TBRecorridoA.Enabled = false;
        }

        private void BTCrearA_Click(object sender, EventArgs e)
        {
            BTAgregarA.Enabled = true;
            nodos = Convert.ToInt32(TBNodosA.Text);
            aristas = Convert.ToInt32(TBAristasA.Text);
            matriz = new bool[nodos, nodos];

            //Lenar de valores
            for (int i = 0; i < nodos; i++)
            {
                for (int j = 0; j < nodos; j++)
                {
                    matriz[i, j] = false;
                }
            }
        }

        private void BTAgregarA_Click(object sender, EventArgs e)
        {
            int nod = Convert.ToInt32(TBCNodoA.Text);
            int conexion = Convert.ToInt32(TBConexionA.Text);
            matriz[nod - 1, conexion - 1] = true;
            if (cAr >= aristas)
            {
                BTAgregarA.Enabled = false;
                BTGRecorridoA.Enabled = true;
            }
            MessageBox.Show("Arista agregada");
            TBCNodoA.Text = "";
            TBConexionA.Text = "";
            cAr += 1;
        }

        private void BTGRecorridoA_Click(object sender, EventArgs e)
        {
            int ini = Convert.ToInt32(TBInicioA.Text);
            int inicio = ini - 1;
            m += ini;
            visitado = new bool[nodos];
            visitado[inicio] = true;
            do
            {
                for (int x = 0; x < nodos; x++)
                {
                    if ((matriz[inicio, x] == true) && (visitado[x] == false))
                    {
                        visitado[x] = true;
                        cola.Enqueue(x);
                    }
                }
                inicio = Convert.ToInt32(cola.Peek());
                ini = inicio + 1;
                m += " -> " + ini;
                cola.Dequeue();
            } while (!todosvisitados(visitado, nodos) || cola.Count != 0);
            TBRecorridoA.Text = m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void AnchuraProfundidad_Load(object sender, EventArgs e)
        {

        }

        private void AnchuraProfundidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            cAr = 1;
            m = "";
            TBCNodoA.Text = "";
            TBAristasA.Text = "";
            TBConexionA.Text = "";
            TBInicioA.Text = "";
            TBNodosA.Text = "";
            TBRecorridoA.Text = "";
            BTAgregarA.Enabled = false;
            BTGRecorridoA.Enabled = false;
            TBRecorridoA.Enabled = false;
            TBCNodo.Text = "";
            TBConexion.Text = "";
            TBNodoInicio.Text = "";
            TBNodos.Text = "";
            TBRecorrido.Text = "";
            TBRecorrido.Enabled = false;
            BTGRecorrido.Enabled = false;
            TBAristas.Text = "";
            BTAgregarC.Enabled = false;
            cAr = 1;
            m = "";
            TBRecorrido.Text = "";

        }
    }
}
