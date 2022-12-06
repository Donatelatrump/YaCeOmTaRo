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
    public partial class DFS_Dirigido : Form
    {
        int n; //Tamaño de la matriz
        int[,] matriz; //Matriz de adyacencias
        int xPos = 100, yPos = 120; //Posiciones de las etiquetas y textbox
        List<int> visitados = new List<int>(); //Nodos visitados
        int inicio; //Nodo inicial
        Stack<int> pila = new Stack<int>(); //Pila para el recorrido
        String recorrido = "";
        public DFS_Dirigido()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
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
                //Se activa el botón para sacar los pares
                btnDFS.Enabled = true;
                btnDFS.Visible = true;
                lblDFS.Visible = true;
                cmbInicio.Enabled = true;
                cmbInicio.Visible = true;
                lblInicio.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            try
            {
                //Se reinician los visitados y la pila
                pila.Clear();
                visitados.Clear();
                inicio = int.Parse(cmbInicio.Text);
                recorrido = inicio.ToString();
                DFS(inicio - 1); //Se llama a la función
                //Se imprime el resultado
                lblDFS.Text = "DFS: " + recorrido;
                if (visitados.Count() < n)
                    MessageBox.Show("No hay camino que recorra todos los nodos desde el nodo inicial", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAristas_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(cmbTamaño.Text); //Declara el tamaño dado por el usuario
                matriz = new int[n, n]; //Se guarda espacio para la matriz
                //Se guarda espacio para los nodos expuestos y pares y se inicializan
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
                    //Se añade al comboBox los nodos del que puede iniciar
                    cmbInicio.Items.Add(i + 1);
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

        private void DFS_Dirigido_Load(object sender, EventArgs e)
        {

        }

        //Método del recorrido
        private void DFS(int actual)
        {
            visitados.Add(actual); //Se añade a visitados
            for(int i = 0; i < n; i++)
            {
                //Si hay conexión entre el nodo actual y los demás que no se han visitado, se ingresa a la pila
                if (matriz[actual, i] != 0 && !visitados.Contains(i))
                {
                    pila.Push(i);
                    visitados.Add(i);
                }
            }
            //Si la pila no está vacía, la cima se hace el nodo actual y se saca de la pila
            if (pila.Any())
            {
                actual = pila.Pop();
                recorrido += " -> " + (actual + 1);
            }
            else return; //Si está vacía significa que no puede seguir recorriendo
            //Se repite mientras no se hayan visitado todos o la pila no esté vacía
            if (visitados.Count() < n || pila.Any()) DFS(actual);
        }
    }
}
