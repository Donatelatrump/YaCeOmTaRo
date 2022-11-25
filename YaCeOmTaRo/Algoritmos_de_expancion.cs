using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace YaCeOmTaRo
{
    public partial class Algoritmos_de_expancion : Form
    {
        //Atributos
        int Prim_numeronodos;
        int[,] Grafo = new int[50,50];

        public Algoritmos_de_expancion()
        {
            InitializeComponent();
            TB_PRIM_numerosnodos.Text = "2";
            Panel_Prim.Hide();
            BT_PRIM_IniciarAlgoritmo.Enabled = false;
        }

        //----------------------------------- METODO PRIM (ALGORITMO) --------------------------------------------------------------------
        private void aLGORITMOPRIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Prim.Show();
            panelKruskal.Hide();
            panelProblemaKruskal.Hide();
            panelProblemaPrim.Hide();
        }

        //Boton de  crear grafo
        private void BT_PRIM_Crearnodo_Click(object sender, EventArgs e)
        {
            Prim_numeronodos = Convert.ToInt32(TB_PRIM_numerosnodos.Text);
            if (Prim_numeronodos < 2)
            {
                MessageBox.Show("tienes que tener al menos dos nodos");
            }
            else
            {
                if (Prim_numeronodos > 50)
                {
                    MessageBox.Show("No puedes tener mas de 50 nodos (por temas de optimizacion)");
                }
                else
                {
                    //Autorizar pase
                    TB_PRIM_numerosnodos.Enabled = false;
                    BT_PRIM_Crearnodo.Enabled = false;

                    TB_PRIM_nodo1.Enabled = true;
                    TB_PRIM_nodo2.Enabled = true;
                    TB_PRIM_peso.Enabled = true;
                    BT_PRIM_agregarconexion.Enabled = true;

                    for(int i = 0; i < Prim_numeronodos; i++)
                    {
                        for(int j = 0; j < Prim_numeronodos; j++)
                        {
                           Grafo[i,j] = 0;
                        }
                    }

                }
            }
            
        }

        //Boton agragar Grafo
        private void BT_PRIM_agregarconexion_Click(object sender, EventArgs e)
        {
            BT_PRIM_IniciarAlgoritmo.Enabled = true;
            int n1, n2, p;
            if (TB_PRIM_nodo1.Text == "" || TB_PRIM_nodo2.Text == ""||TB_PRIM_peso.Text == "")
            {
                MessageBox.Show("No dejes espacios en blanco");
            }
            else
            {
                n1 = Convert.ToInt32(TB_PRIM_nodo1.Text);
                n2 = Convert.ToInt32(TB_PRIM_nodo2.Text);
                p = Convert.ToInt32(TB_PRIM_peso.Text);
                if ((n1 > 0 && n1 <= Prim_numeronodos) && (n2 > 0 && n2 <= Prim_numeronodos))
                {
                    if (n1 != n2)
                    {
                        if (p > 0)
                        {
                            Grafo[n1-1, n2-1] = p;
                            Grafo[n2-1, n1-1] = p;
                            MessageBox.Show("Arista agregada");
                            TB_PRIM_nodo1.Text = "";
                            TB_PRIM_nodo2.Text = "";
                            TB_PRIM_peso.Text = "";

                            string texto = "";
                            for (int i = 0; i < Prim_numeronodos; i++)
                            {
                                for (int j = 0; j < Prim_numeronodos; j++)
                                {
                                    texto += Convert.ToString(Grafo[i, j]) + "     ";
                                }
                                texto += Environment.NewLine;
                            }
                            TB_PRIM_Grafo.Text = texto;
                        }
                        else
                        {
                            MessageBox.Show("El peso no puede ser menor o igual a 0");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nodo de inicio y el del final no pueden ser iguales ");
                    }
                }
                else{
                    MessageBox.Show("Error en valores a insertar en la casilla nodos");
                }
            }
        }
        //Boton iniciar Algoritmo
        private void BT_PRIM_IniciarAlgoritmo_Click(object sender, EventArgs e)
        {
            TB_PRIM_nodo1.Enabled = false;
            TB_PRIM_nodo2.Enabled = false;
            TB_PRIM_nodo1.Text = "";
            TB_PRIM_nodo2.Text = "";
            TB_PRIM_peso.Enabled = false;
            TB_PRIM_peso.Text = "";
            BT_PRIM_agregarconexion.Enabled = false;

            //Proceso cuchi cuchi 
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var nodoinicio = random.Next(0, Prim_numeronodos-1);

            int Contn = 0;
            bool pasar = false;
            int i=0, j = 0, g=0, menor, g2=0, indice=0, pesototal = 0, peso=0;

            //guardar el primer nodo elegido de forma aleatoria
            int[] Vector = new int[Prim_numeronodos];
            Vector[Contn] = nodoinicio;
            Contn++;
            
            while (Contn < Prim_numeronodos)
            {
                menor = 99999;
                pasar = true;
                for (i = 0; i < Contn; i++)
                {
                    g = Vector[i];
                    for (j = 0; j < Prim_numeronodos; j++)
                    {
                        if (Grafo[g,j] != 0)
                        {
                            if (Grafo[g,j] < menor)
                            {
                                menor = Grafo[g,j];
                                indice = j;
                                g2 = g;
                                peso = 0;
                                peso = Grafo[g,indice];
                            }
                        }
                    }
                }

                Grafo[g2,indice] = 0;
                Grafo[indice,g2] = 0;
                for (i = 0; i < Contn; i++)
                {
                    if (indice == Vector[i])
                    {
                        pasar = false;
                        break;
                    }
                }

                if (pasar == true)
                {
                    Vector[Contn] = indice;
                    pesototal = pesototal + peso;
                    Contn++;
                    indice = 0;
                    g2 = 0;
                }
            }

            TB_PRIM_pesototal.Text = Convert.ToString(pesototal);
            String texto="Orden: ";
            for (i = 0; i < Prim_numeronodos; i++)
            {
                if (i==Prim_numeronodos)
                {
                    texto += Convert.ToString(1+Vector[i]) ;
                }
                else
                {
                    texto += Convert.ToString(1+Vector[i])+ "->";
                }
            }
            TB_PRIM_Camino.Text = texto;

        }

        //Reiniciar algoritmo
        private void BT_PRIM_Reiniciar_Click(object sender, EventArgs e)
        {
            TB_PRIM_numerosnodos.Text = "0";
            TB_PRIM_numerosnodos.Enabled = true;
            BT_PRIM_Crearnodo.Enabled = true;
            TB_PRIM_numerosnodos.Text = "";

            TB_PRIM_nodo1.Enabled = false;
            TB_PRIM_nodo2.Enabled = false;
            TB_PRIM_nodo1.Text = "";
            TB_PRIM_nodo2.Text = ""; 
            TB_PRIM_peso.Enabled = false;
            TB_PRIM_peso.Text = "";
            BT_PRIM_agregarconexion.Enabled = false;
            TB_PRIM_Grafo.Text = "";
        }

        




        
        private void aLGORITMODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Prim.Show();
            panelKruskal.Show();
            panelProblemaKruskal.Hide();
            panelProblemaPrim.Hide();
        }

        private void TB_PRIM_nodo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAristas_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------- METODO KRUSKAL Algoritmo) --------------------------------------------------------------------
        int n; //tamaño
        int[,] matriz; //Matriz de adyacencias
        int[,] arbol; //Matriz del arbol de expansión
        int totAristas; //Total de aristas del arbol
        SortedSet<int> visitados = new SortedSet<int>(); //Set de visitados

        private void cmbTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si tiene tamaño, se habilita el richTExtBox
            if (cmbTamaño.Text != null)
            {
                richMatriz.Enabled = true;
                btnMinimo.Enabled = true;
                btnMaximo.Enabled = true;
            }
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(cmbTamaño.Text);
                totAristas = n - 1; //Total de aristas
                //Se guarda espacio en la memoria para las matrices
                matriz = new int[n, n];
                arbol = new int[n, n];
                //Se guarda lo ingresado en el richtextbox
                string[] lineas = richMatriz.Text.Split('\n');
                for (int i = 0; i < n; i++)
                {
                    string[] separador = lineas[i].Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        matriz[i, j] = int.Parse(separador[j]);
                    }
                }
                KruskalMin(totAristas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        //Métodos
        //Encontrar ruta más corta
        void KruskalMin(int aristas)
        {
            int men = int.MaxValue; //Para saber cual es el arista con menor distancia
            int fil = 0, col = 0; //Posición del arista con menor distancia

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //Si existe una arista, si es el menor valor, si no se ha seleccionado ya y si no se forma un ciclo
                    if (matriz[i, j] != 0 && matriz[i, j] < men && arbol[i, j] == 0 && !Ciclo(i, j))
                    {
                        men = matriz[i, j];
                        fil = i;
                        col = j;
                    }
                    //Se limpia el set de visitados
                    visitados.Clear();
                }
            }
            //Una vez examinados todos y obteniendo la arista de menor peso, se copia esa arista en el arbol
            arbol[fil, col] = men;
            arbol[col, fil] = men;

            //Mientras no se hayan completado las aristas
            if (aristas > 1)
            {
                KruskalMin(aristas - 1);
            }
            else
            { //Se imprimen los datos
                richArbol.Text = "\t\tMÍNIMO\n";
                int costo = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        costo += arbol[i, j];
                        richArbol.Text += arbol[i, j] + "\t";
                    }
                    richArbol.Text += "\n";
                }
                richArbol.Text += "\t\tCosto: " + costo;
            }
        }
        //Encontrar ruta más corta
        void KruskalMax(int aristas)
        {
            int may = int.MinValue; //Para saber cual es el arista con menor distancia
            int fil = 0, col = 0; //Posición del arista con menor distancia

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //Si existe una arista, si es el menor valor, si no se ha seleccionado ya y si no se forma un ciclo
                    if (matriz[i, j] != 0 && matriz[i, j] > may && arbol[i, j] == 0 && !Ciclo(i, j))
                    {
                        may = matriz[i, j];
                        fil = i;
                        col = j;
                    }
                    //Se limpia el set de visitados
                    visitados.Clear();
                }
            }
            //Una vez examinados todos y obteniendo la arista de menor peso, se copia esa arista en el arbol
            arbol[fil, col] = may;
            arbol[col, fil] = may;

            //Mientras no se hayan completado las aristas
            if (aristas > 1)
            {
                KruskalMax(aristas - 1);
            }
            else
            { //Se imprimen los datos
                richArbol.Text = "\t\tMÁXIMO\n";
                int costo = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        costo += arbol[i, j];
                        richArbol.Text += arbol[i, j] + "\t";
                    }
                    richArbol.Text += "\n";
                }
                richArbol.Text += "\t\tCosto: " + costo;
            }
        }
        //Para saber si se forma un ciclo
        bool Ciclo(int fil, int col)
        {
            bool existe = false;
            visitados.Add(fil); //Se añade a los nodos ya visitados
                                   //Se recorre mientras existe sea false
            for (int j = 0; j < n && !existe; j++)
            {
                //Si j es diferente al segundo vertice, no se ha visitado ese nodo y existe arista que conecta al primer vertice con otro
                if (j != col && !visitados.Contains(j) && arbol[fil, j] != 0)
                {
                    //Se selecciona el nuevo vertice y se verifica para ver si conecta con el segundo vertice,
                    //si no, recorre para ver si alguna de sus aristas conecta con otro vertice 
                    //que termina conectando con el segundo vertice vertice
                    if (arbol[j, col] != 0)
                    {
                        existe = true;
                    }
                    else
                    {
                        existe = Ciclo(j, col);
                    }
                }
            }
            //Si no encontro un ciclo, regresa false
            return existe;
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(cmbTamaño.Text);
                totAristas = n - 1; //Total de aristas
                //Se guarda espacio en la memoria para las matrices
                matriz = new int[n, n];
                arbol = new int[n, n];
                //Se guarda lo ingresado en el richtextbox
                string[] lineas = richMatriz.Text.Split('\n');
                for (int i = 0; i < n; i++)
                {
                    string[] separador = lineas[i].Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        matriz[i, j] = int.Parse(separador[j]);
                    }
                }
                KruskalMax(totAristas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pROBLEMASREALESCONKRUSKALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Prim.Show();
            panelKruskal.Show();
            panelProblemaPrim.Show();
            panelProblemaKruskal.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pROBLEMASREALESCONPRIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Prim.Show();
            panelKruskal.Show();
            panelProblemaPrim.Show();
            panelProblemaKruskal.Hide();
        }

        private void Algoritmos_de_expancion_Load(object sender, EventArgs e)
        {

        }
    }
}
