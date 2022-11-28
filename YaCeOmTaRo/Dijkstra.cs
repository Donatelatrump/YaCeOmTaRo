using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace YaCeOmTaRo
{
    public partial class Dijkstra : Form
    {
        int n; //Tamaño de la matriz
        int[,] matriz; //Matriz de adyacencias
        int xPos = 100, yPos = 120; //Posiciones de las etiquetas y textbox
        int[,] rutas; //Rutas que se van a seguir para tener la más corta
        SortedSet<int> visitados = new SortedSet<int>(); //Set para saber qué nodos se han visitado
        int inicio, fin; //Variables de nodos inicial y final
        public Dijkstra()
        {
            InitializeComponent();
        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            try //Se usa try en caso de que algún espacio sea null
            {
                //Guardar la matriz
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        /*Se crea una variable auxiliar de tipo TextBox y con el método
                         * Find de la propiedad Controls de la clase Control, se busca por su nombre
                         * y devuelve un array de Control, del cual se selecciona el primero y
                         * se convierte a TextBox*/
                        TextBox aux = Controls.Find("txtArista" + (i + 1) + (j + 1), true)
                            .FirstOrDefault() as TextBox;
                        matriz[i, j] = int.Parse(aux.Text);
                    }
                }
                //Se activa el botón para calcular ruta, y los combobox
                btnDijkstra.Enabled = true;
                btnDijkstra.Visible = true;
                lblInicio.Visible = true;
                lblFin.Visible = true;
                cmbInicio.Visible = true;
                cmbFin.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            try
            {
                inicio = int.Parse(cmbInicio.Text);
                fin = int.Parse(cmbFin.Text);
                if (inicio != fin)
                {
                    rutas[inicio - 1, 0] = 0;
                    //Se llama al método
                    Ruta(inicio - 1);
                }
                else
                {
                    MessageBox.Show("Los nodos inicial y final no pueden ser iguales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(cmbTamaño.Text); //Declara el tamaño dado por el usuario
                matriz = new int[n, n]; //Se guarda espacio para la matriz
                rutas = new int[n, 2];
                Infinito(rutas);
                //Desactiva para cambiar el tamaño
                cmbTamaño.Enabled = false;
                btnAristas.Enabled = false;
                //Hace visible la etiqueta de nodos y matriz
                lblMatriz.Visible = true;
                lblNodos.Visible = true;
                btnMatriz.Visible = true;
                //Crea el diseño para introducir la matriz
                for (int i = 0; i < n; i++)
                {
                    Label lblVertice = new Label();
                    lblVertice.Text = (i + 1).ToString();
                    lblVertice.Location = new Point(xPos + 55 * (i + 1), yPos);
                    lblVertice.AutoSize = true;
                    lblVertice.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    Controls.Add(lblVertice);
                    Label lblVertice2 = new Label();
                    lblVertice2.Text = (i + 1).ToString();
                    lblVertice2.Location = new Point(xPos, yPos + 30 * (i + 1));
                    lblVertice2.AutoSize = true;
                    lblVertice2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    Controls.Add(lblVertice2);
                    //Añade los items al comboBox de inicio y fin
                    cmbInicio.Items.Add(i + 1);
                    cmbFin.Items.Add(i + 1);
                    for (int j = 0; j < n; j++)
                    {
                        TextBox txtArista = new TextBox();
                        txtArista.Name = "txtArista" + (i + 1).ToString() + (j + 1).ToString();
                        txtArista.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
                        txtArista.Location = new Point(xPos + 55 * (j + 1), yPos + 30 * (i + 1));
                        txtArista.Text = "0";
                        txtArista.Size = new Size(35, 20);
                        Controls.Add(txtArista);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Métodos
        //Inicializar rutas
        private void Infinito(int[,] rutas)
        {
            for (int i = 0; i < n; i++)
            {
                rutas[i, 0] = int.MaxValue; //Simula un infinito
                rutas[i, 1] = -1; //Indica que no hay nodo anterior
            }
        }

        private void lblMatriz_Click(object sender, EventArgs e)
        {

        }

        private void cmbTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Calcular la ruta
        private void Ruta(int actual)
        {
            try
            {
                int men = int.MaxValue; //Variable para cual es el nodo con menor distancia
                int pos = 0; //Posición del nodo con menor distancia

                visitados.Add(actual); //Se añade a los nodos visitados

                //se evalúa la distancia desde el nodo actual a sus nodos vecinos
                for (int i = 0; i < n; i++)
                {
                    //Si i es diferente al nodo actual o no se ha visitado el nodo, existe la arista y es menor a la ruta hasta ese nodo
                    if (!visitados.Contains(i) && matriz[actual, i] != 0 && (rutas[actual, 0] + matriz[actual, i]) < rutas[i, 0])
                    {
                        rutas[i, 0] = rutas[actual, 0] + matriz[actual, i]; //A la ruta del nodo actual se le añade la distancia a su nodo vecino
                        rutas[i, 1] = actual;
                    }
                }

                //Ver cuál tiene la menor ruta y no se haya visitado aún
                for (int i = 0; i < n; i++)
                {
                    if (rutas[i, 0] < men && !visitados.Contains(i))
                    {
                        men = rutas[i, 0];
                        pos = i;
                    }
                }

                //Mientras queden nodos sin visitar
                if (visitados.Count < n)
                {
                    Ruta(pos);
                }
                else //Se imprime la ruta
                {
                    int i = inicio - 1, f = fin - 1; //Variable auxiliares
                    lblRuta.Text = "Ruta: ";
                    Imprimir(i, f);
                    lblRuta.Text += " - " + (f + 1);
                    lblRuta.Visible = true;
                    //COsto de la ruta
                    lblCosto.Text = "Costo: " + (rutas[f, 0]);
                    lblCosto.Visible = true;
                    //Se limpia el set de visitados
                    visitados.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //Imprimir los resultados
        private void Imprimir(int i, int f)
        {
            if (i != f) //En caso de llegar al nodo inicial
            { 
                Imprimir(i, rutas[f, 1]); //se llama a la función de nuevo, para imprimir en orden
                if (rutas[f, 1] != i)
                {
                    lblRuta.Text += " - " + (rutas[f, 1] + 1);
                }
                else
                {
                    lblRuta.Text += (rutas[f, 1] + 1);
                }
                
            }
        }
    }
}