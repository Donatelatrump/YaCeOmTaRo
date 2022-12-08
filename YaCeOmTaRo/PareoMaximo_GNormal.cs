using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace YaCeOmTaRo
{
    public partial class PareoMaximo_GNormal : Form
    {
        int n; //Tamaño de a matriz 
        int [,] matriz; //Matriz de adyacencia 
        int xPos = 100, yPos = 140;  //Posiciones de las etiquetas y textbox
        int[] pares; //Vector con los nodos expuestos y pares
        public PareoMaximo_GNormal()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            Guardar.Visible = false;
            BTPareo.Visible = false;
            Pareo.Visible = false;
            MostrarPareo.Visible = false;
            LBMA.Visible = false;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try //Se usa try en caso de que algún espacio sea null
            {
                //Guardar la matriz
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        TextBox aux = Controls.Find("txtArista" + (i + 1) + (j + 1), true)
                            .FirstOrDefault() as TextBox;
                        matriz[i, j] = int.Parse(aux.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Inicializar los pares
        private void Inicializar()
        {
            for (int i = 0; i < n; i++)
            {
                pares[i] = -1;
            }
        }
        //Método para hacer el pareo
        private void Pareos()
        {
            //Mientras no se haya encontrado el máximo
            while (!Max())
            {
                //Se obtiene un nodo expuesto
                int nodo = -1;
                for (int i = 0; i < n && nodo == -1; i++)
                {
                    if (pares[i] == -1) nodo = i;
                }
                //Se hace el recorrido en anchura y obtiene una ruta a aumentar
                int[] ruta = new int[n];
                for (int i = 0; i < n; i++)
                    ruta[i] = -1;
                ruta = BFS(nodo, 0, ruta);
                Alternar(ruta);
            }
            //Se imprime en pantalla el resultado
            List<int> visitados = new List<int>();
            String parejas = "";
            for (int i = 0; i < n; i++)
            {
                if (pares[i] != -2 && pares[i] != -1 && !visitados.Contains(i))
                {
                    parejas += " " + (i + 1) + " - " + (pares[i] + 1) + ",";
                    visitados.Add(pares[i]);
                }
            }
            MostrarPareo.Text = "Pares:" + parejas;
        }
        //Método para comprobar que no se hayan encontrado todos los pares
        private bool Max()
        {
            int cont = 0; //Cuenta los nodos expuestos
            for (int i = 0; i < n; i++)
            {
                if (pares[i] == -1) cont++;
            }
            //Verifica si debe quedar un nodo expuesto o ninguno para el pareo máximo
            if (n % 2 == 0)
            {
                if (cont == 0) return true;
                else return false;
            }
            else
            {
                if (cont == 1) return true;
                else return false;
            }
        }
        //Método de BFS
        private int[] BFS(int actual, int i, int[] ruta)
        {
            Queue<int> cola = new Queue<int>();
            ruta[i] = actual; //Se guarda la ruta
            //Se añaden los nodos vecinos
            for (int j = 0; j < n; j++)
            {
                if (!ruta.Contains(j) && matriz[actual, j] != 0)
                {
                    cola.Enqueue(j);
                }
            }
            while (cola.Any())
            {
                //Si está expuesto, se selecciona
                if (pares[cola.Peek()] < 0)
                {
                    ruta[i + 1] = cola.Dequeue();
                    //Reinicia los elementos después de esa posición
                    for (int j = i + 2; j < n; j++)
                    {
                        ruta[j] = -1;
                    }
                    return ruta;
                }
                //Si no está expuesto, sigue recorriendo hasta encontrar un nodo expuesto
                else
                {
                    ruta = BFS(cola.Dequeue(), i + 1, ruta);
                }
            }
            return ruta;
        }
        //Método de camino aumentado
        private void Alternar(int[] ruta)
        {
            int cont = 0;
            for (int i = 0; i < n && ruta[i] != -1; i++)
                cont++;
            if (cont % 2 == 0) //Si la ruta es par, intercambia posiciones
            {
                for (int i = 0; i < n && ruta[i] != -1; i += 2)
                {
                    pares[ruta[i]] = ruta[i + 1];
                    pares[ruta[i + 1]] = ruta[i];
                }
            }
            else
            {
                pares[ruta[0]] = -2; //No es posible realizar un par, por el momento
            }
        }
        private void BTPareo_Click(object sender, EventArgs e)
        {
            LBMA.Visible = true;
            Pareo.Visible = true;
            MostrarPareo.Visible = true;
            //Hacer pareo máximo 
            //Inicializar();
            Pareos();

        }

        private void IngresarA_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(Tamaño.Text); //Declara el tamaño dado por el usuario
                matriz = new int[n, n]; //Se guarda espacio para la matriz
                //Se guarda espacio para los nodos expuestos y pares y se inicializan
                pares = new int[n];
                Inicializar();
                //Desactiva para cambiar el tamaño
                Tamaño.Enabled = false;
                IngresarA.Enabled = false;
                //Hace visible la etiqueta de nodos y matriz
                LBMA.Visible = true;
                Guardar.Visible = true;
                BTPareo.Visible = true;
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
    }
}
