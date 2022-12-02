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
    public partial class MatrizAdy : Form
    {
        //Atributos 
        int cAr;
        int nodos;
        int aristas;
        int[,] matriz;
        public MatrizAdy()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            TBNodos.Text = ""; 
            TBAristas.Text = "";
            TBCNodo.Text = "";
            TBConexion.Text = "";
            RTBMostrar.Text = "";
            RBDirigido.Checked = false;
            RBNoDirigido.Checked = false;
            //BTCrear.Enabled = false;
            //BTAddArist.Enabled = false; 
            CBLA.Checked = false;
            CBMA.Checked = false;
            TBCNodo.Enabled = false;
            TBConexion.Enabled = false;
            cAr = 1;
            BTAddArist.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TBNodos.Text = "";
            TBAristas.Text = "";
            TBCNodo.Text = "";
            TBConexion.Text = "";
            RTBMostrar.Text = "";
            RBDirigido.Checked = false;
            RBNoDirigido.Checked = false;
            //BTCrear.Enabled = false;
            //BTAddArist.Enabled = false;
            CBLA.Checked = false;
            CBMA.Checked = false;
            TBCNodo.Enabled = false;
            TBConexion.Enabled = false;
            BTAddArist.Enabled = false;
            cAr = 1;
        }

        private void TBNodos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BTAddArist.Enabled = true;
            cAr = 1;
            TBCNodo.Enabled = false;
            TBConexion.Enabled = false;
            nodos = Convert.ToInt32(TBNodos.Text);
            aristas = Convert.ToInt32(TBAristas.Text);
            if(nodos <= 0)
            {
                MessageBox.Show(" La cantidad de nodos debe ser mayor a 0");
            }
            matriz = new int[nodos, nodos];
            //Inicializar matriz 
            for(int i=0; i<nodos; i++)
            {
                for(int j=0; j<nodos; j++)
                {
                    matriz[i, j] = 0;
                }
            }
            if (aristas <= 0)
            {
                MessageBox.Show(" La cantidad de aristas debe ser mayor a 0");
            }
            else
            {
                int completo = (nodos * (nodos - 1)) / 2;
                if (aristas > completo){
                    MessageBox.Show(" El total de aristas debe ser menor o igual a " + completo);
                }
            }
            if(nodos!=0 && aristas != 0 && RBDirigido.Checked || RBNoDirigido.Checked && CBLA.Checked || CBMA.Checked)
            {
                BTCrear.Enabled = true; 
            }
            TBCNodo.Enabled = true;
            TBConexion.Enabled = true;
        }

        private void RBDirigido_CheckedChanged(object sender, EventArgs e)
        {
            if (RBNoDirigido.Checked)
            {
                RBDirigido.Checked = false; 
            }
        }

        private void RBNoDirigido_CheckedChanged(object sender, EventArgs e)
        {
            if (RBDirigido.Checked)
            {
                RBNoDirigido.Checked = false;
            }
        }

        private void BTAddArist_Click(object sender, EventArgs e)
        {
            
            int nod = Convert.ToInt32(TBCNodo.Text);
            int conexion = Convert.ToInt32(TBConexion.Text);
            if(cAr>=aristas)
            {
                BTAddArist.Enabled = false; 
                TBCNodo.Enabled=false;
                TBConexion.Enabled=false;
            }
            //Grafo No Dirigido 
            if (RBNoDirigido.Checked)
            {
                matriz[nod - 1,conexion - 1] = 1;
                cAr+=2;
                matriz[conexion - 1, nod - 1] = 1;
            }
            //Grafo dirigido
            if (RBDirigido.Checked)
            {
                matriz[nod - 1, conexion - 1] = 1;
                cAr+=1;
            }
            MessageBox.Show("Arista agregada");
            TBCNodo.Text = "";
            TBConexion.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String m = "";
            if (CBMA.Checked)
            {
                for (int x = 0; x < nodos; x++)
                {
                    int xx = x + 1;
                    String xvalue = Convert.ToString(xx);
                    m += "\t" + xvalue + ") ";
                }
                m += Environment.NewLine;
                for (int i = 0; i < nodos; i++)
                {
                    int ii = i + 1;
                    String ivalue = Convert.ToString(ii);
                    m += "\n" + ivalue + ") ";
                    for (int j = 0; j < nodos; j++)
                    {
                        m += "\t";
                        m += Convert.ToString(matriz[i, j]);
                    }
                    m += Environment.NewLine;
                }
                RTBMostrar.Text = m;
            }
            else
            {
                m = "";
                if (CBLA.Checked)
                {
                    for(int f=0; f<nodos; f++)
                    {
                        int ff = f + 1;
                        String fvalue = Convert.ToString(ff);
                        m += "\n El nodo " + fvalue + " se conecta con: ";
                        for(int c=0; c<nodos; c++)
                        {
                            int cc = c + 1;
                            String cvalue = Convert.ToString(cc);
                            if (matriz[f, c] == 1)
                            {
                                m += cvalue;
                                m += " ";
                            }
                        }
                        m += Environment.NewLine;
                    }
                    RTBMostrar.Text = m;
                }
            }
            
        }

        private void CBMA_CheckedChanged(object sender, EventArgs e)
        {
            if (CBLA.Checked)
            {
                CBMA.Checked = false;
            }
        }

        private void CBLA_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMA.Checked)
            {
                CBLA.Checked = false;
            }
        }

        private void MatrizAdy_Load(object sender, EventArgs e)
        {

        }

        private void MatrizAdy_FormClosed(object sender, FormClosedEventArgs e) //Se debe reiniciar todo para cuando se cierre
        {
            TBNodos.Text = "";
            TBAristas.Text = "";
            TBCNodo.Text = "";
            TBConexion.Text = "";
            RTBMostrar.Text = "";
            RBDirigido.Checked = false;
            RBNoDirigido.Checked = false;
            CBLA.Checked = false;
            CBMA.Checked = false;
            TBCNodo.Enabled = false;
            TBConexion.Enabled = false;
            BTAddArist.Enabled = false;
            cAr = 1;
        }
    }
}
