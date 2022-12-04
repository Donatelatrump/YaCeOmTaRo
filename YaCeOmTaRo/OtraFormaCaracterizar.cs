using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace YaCeOmTaRo
{
    public partial class OtraFormaCaracterizar : Form
    {
        int n; //Tamaño de a matriz
        int xPos = 100, yPos = 140;  //Posiciones de las etiquetas y textbox
        bool archivoActivo = false;
        string path = Environment.CurrentDirectory + "/" + "GrafoECA.txt";
        public OtraFormaCaracterizar()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            BTGuardar.Visible = false;
            BTMostrar.Visible = false;
            LBMA.Visible = false;
            RTBMostrar.Visible = false;
        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            RTBMostrar.Visible = true;
            //Guardar la matriz en forma de Lista de Adyacencia pero en un txt
            if (!File.Exists(path)){
                try
                {
                    string titulo = "Lista de Adyacencia: \n";
                    File.WriteAllText(path, titulo);
                    RTBMostrar.Text = File.ReadAllText(path);
                    MessageBox.Show("Archivo creado!\nDirectorio: " + path);
                    archivoActivo =true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error.\nExcepcion: " + ex.ToString());
                    return;
                }
            }
            else
            {
                Clipboard.SetText(Environment.CurrentDirectory);
                MessageBox.Show($"El archivo ya fue creado.\n\nDirectorio: {Environment.CurrentDirectory}\n\nCargalo o borralo. El directorio ha sido copiado en tu portapeles (CTRL+V en cargar archivo en la barra de direcciones)");
            }
            if (archivoActivo)
            {
                using (TextWriter sw = File.AppendText(path)) // AppendText es para ir agregando texto.
                {
                    for(int i = 0; i < n; i++)
                    {
                        sw.Write(Convert.ToString(i + 1) + " -> ");
                        for (int j = 0; j < n; j++)
                        {
                            TextBox aux = Controls.Find("txtArista" + (i + 1) + (j + 1), true)
                            .FirstOrDefault() as TextBox;
                            int a = int.Parse(aux.Text);
                            if (a != 0)
                            {
                                sw.Write((j+1) + ", "); //Write es para ir metiendo texto
                            }
                        }
                        sw.Write("\n");
                    }
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("No hay ningun archivo activo.");
            }
        }

        private void BTMostrar_Click(object sender, EventArgs e)
        {
            RTBMostrar.Text = File.ReadAllText(path); //Mostrarlo
        }

        private void BTCrear_Click(object sender, EventArgs e)
        {
            BTCrear.Enabled = false;
            try
            {
                n = int.Parse(Tamaño.Text); //Declara el tamaño dado por el usuario
                //Desactiva para cambiar el tamaño
                Tamaño.Enabled = false;
                //Hace visible la etiqueta de nodos y matriz
                LBMA.Visible = true;
                BTGuardar.Visible = true;
                BTMostrar.Visible = true;
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
