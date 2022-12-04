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
        bool[,] matriz; //Matriz de adyacencia 
        int xPos = 100, yPos = 140;  //Posiciones de las etiquetas y textbox
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
                        if(int.Parse(aux.Text) == 0)
                        {
                            matriz[i, j] = false;
                        }
                        else
                        {
                            matriz[i, j] = true;
                        }
                        
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
            //Hacer pareo máximo 
            GFG m = new GFG();
            MostrarPareo.Text = m.maxBPM(matriz);
           
        }

        private void IngresarA_Click(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(Tamaño.Text); //Declara el tamaño dado por el usuario
                matriz = new bool[n, n]; //Se guarda espacio para la matriz
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
