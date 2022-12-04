using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaCeOmTaRo
{
    public partial class PareoTonto_GNormal : Form
    {
        int n; //Tamaño de a matriz 
        int[,] matriz; //Matriz de adyacencia 
        int xPos = 100, yPos = 140;  //Posiciones de las etiquetas y textbox
        SortedSet<int> visitados = new SortedSet<int>();
        public PareoTonto_GNormal()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IngresarA_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(Tamaño.Text); //Declara el tamaño dado por el usuario
                matriz = new int[n, n]; //Se guarda espacio para la matriz
                //Desactiva para cambiar el tamaño
                Tamaño.Enabled = false;
                IngresarA.Enabled = false;
                //Hace visible la etiqueta de nodos y matriz
                LBMA.Visible = true;
                Guardar.Visible = true;
                BTPareo.Visible =true;
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

        private void BTPareo_Click(object sender, EventArgs e)
        {
            LBMA.Visible = true;
            Pareo.Visible = true;
            MostrarPareo.Visible = true;
            visitados.Clear();
            //Hacemos el pareo tonto del grafo 
            String a="";
            a += "Parejas: ";
            a += Environment.NewLine;
            for (int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    if (matriz[i, j] == 1 && !visitados.Contains(i) && !visitados.Contains(j))
                    {
                        visitados.Add (i);
                        visitados.Add(j);
                        a += Convert.ToString(i + 1);
                        a += " -> ";
                        a += Convert.ToString(j + 1);
                        a += Environment.NewLine;
                    }
                }
            }
            MostrarPareo.Text = a;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pareo_Click(object sender, EventArgs e)
        {

        }

        private void MostrarPareo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
