using OpenQA.Selenium.DevTools.V104.Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaCeOmTaRo
{
    public partial class CompConexas : Form
    {
        //Atributos 
        int nodos;
        int aristas;
        int[,] matriz; 
        //Auxiliares 
        int[,] matriz1;
        int[,] aux;
        int cAr;
        public CompConexas()
        {
            InitializeComponent();
            TBAristas.Text = "";
            TBComponentes.Text = "";
            TBNodos.Text = "";
            RTBImprimir.Text = "";
            BTComponentes.Enabled = false;
            BTMaCamino.Enabled = false;
            BTMOrdena1.Enabled = false;
            BTOrdenaF.Enabled = false;
            BTAgregar.Enabled = false;
            TBCNodo.Enabled = false;
            TBConexion.Enabled = false;
            cAr = 1;
        }
        //Imprimir 
        public static String imprimir(int[,] matriz, int nodos)
        {
            String m = "";
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
            return m;
        }
        private void BTCrear_Click(object sender, EventArgs e)
        {
            
            BTAgregar.Enabled = true;
            TBCNodo.Enabled = true;
            TBConexion.Enabled = true;
            nodos = Convert.ToInt32(TBNodos.Text);
            aristas = Convert.ToInt32(TBAristas.Text);

           
            matriz = new int[nodos,nodos];
            matriz1 = new int[2,nodos];
            aux = new int[nodos,nodos];
            

            //Llenar de valores
            for (int i = 0; i < nodos; i++)
            {
                for (int j = 0; j < nodos; j++)
                {
                    matriz[i, j] = 0;
                    aux[i, j] = 0;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBAristas.Text = "";
            TBComponentes.Text = "";
            TBNodos.Text = "";
            RTBImprimir.Text = "";
            BTComponentes.Enabled = false;
            BTMaCamino.Enabled = false;
            BTMOrdena1.Enabled = false;
            BTOrdenaF.Enabled = false;
            BTAgregar.Enabled = false;
            TBCNodo.Enabled = false;
            TBConexion.Enabled = false;
            cAr = 1;
        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            int nod = Convert.ToInt32(TBCNodo.Text);
            int conexion = Convert.ToInt32(TBConexion.Text);
            matriz[nod - 1, conexion - 1] = 1;
            if (cAr >= aristas)
            {
                BTAgregar.Enabled = false;
                BTComponentes.Enabled = true;
                BTMaCamino.Enabled = true;
                BTMOrdena1.Enabled = true;
                BTOrdenaF.Enabled = true;
            }
            MessageBox.Show("Arista agregada");
            TBCNodo.Text = "";
            TBConexion.Text = "";
            cAr += 1;
        }

        private void BTMaCamino_Click(object sender, EventArgs e)
        {
            int repetir;
            //Calcular la matriz de caminos 
            for (int x = 0; x < nodos; x++)
            {
                for (int y = 0; y < nodos; y++)
                {
                    repetir = y + 1; //Inicializamos una posición adelante con el que se está comparando
                    if (x != y)
                    {
                        if (matriz[x,y] == 1)
                        {
                            for (int z = 0; z < nodos; z++)
                            {
                                if (matriz[y,z] == 1 && matriz[x,z] != 1)
                                {
                                    matriz[x,z] = matriz[y,z];
                                    //SI el valor que se cambia a uno está atrás de nuestra posición actual y está atrás del que se repitió anteriormente, entonces 
                                    //cambia el valor de repetir 
                                    if (z < y && z < repetir)
                                    {
                                        repetir = z;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        matriz[x,y] = 1;
                    }
                    //Regresar a la posición que se cambió a uno y no se ha recorrido
                    y = repetir - 1;
                }
            }
            RTBImprimir.Text = "";
            RTBImprimir.Text = imprimir(matriz, nodos);
        }

        private void BTMOrdena1_Click(object sender, EventArgs e)
        {
            int cont, may, pos;
            //Contar la cantidad de 1´s y ordenar de mayor a menor 
            for (int f = 0; f < nodos; f++)
            {
                cont = 0;
                matriz1[0,f] = f;
                for (int c = 0; c < nodos; c++)
                {
                    if (matriz[f,c] == 1)
                    {
                        cont++;
                    }
                }
                matriz1[1,f] = cont;
            }
            int temp = 0, temp2 = 0, temp3 = 0, temp4 = 0;
            //Ordenar matriz de unos
            for (int f = 0; f < nodos; f++)
            {
                may = matriz1[1,f];
                pos = f;
                for (int c = f + 1; c < nodos; c++)
                {
                    if (matriz1[1,c] > may)
                    {
                        may = matriz1[1,c];
                        pos = c; 
                    }
                }
                temp = matriz1[0, f];
                temp2 = matriz1[0, pos];
                matriz1[0, f] = temp2; matriz1[0, pos] = temp;
                temp3 = matriz1[1, f];
                temp4 = matriz1[1, pos];
                matriz1[1,f]=temp4; matriz1[1,pos] = temp3;
                //swap(matriz1[0,f], matriz1[0,pos]);
                //swap(matriz1[1,f], matriz1[1,pos]);
            }
            //Se ordenan las filas de mayor a menor cantidad de 1's
            for (int f = 0; f < nodos; f++)
            {
                for (int c = 0; c < nodos; c++)
                {
                    aux[f,c] = matriz[matriz1[0, f],c];
                }
            }
            RTBImprimir.Text = "";
            RTBImprimir.Text = imprimir(aux, nodos);
        }

        private void BTOrdenaF_Click(object sender, EventArgs e)
        {
            //Pasar de filas a columnas  
            for (int f = 0; f < nodos; f++)
            {
                for (int c = 0; c < nodos; c++)
                {
                    matriz[c,f] = aux[c,matriz1[0,f]];
                }
            }
            RTBImprimir.Text = "";
            RTBImprimir.Text = imprimir(matriz, nodos);
        }

        private void BTComponentes_Click(object sender, EventArgs e)
        {
            String m = "";
            //Paso 5: sacar componentes conexas:
            int pos = 0; //Posición a la que se llegará
            int posA = 0; //Posición en que se quedó en los nodos conexos anteriores
            int pp, pp2;
            for (int i = 0; i < nodos; i++)
            {
                //Se evalúa si la siguiente fila es cero o si está en la última fila, pues quiere decir que acaba el cuadrado
                if (i + 1 == nodos || matriz[i + 1,posA] == 0 )
                {
                    pos = i; //Se iguala a i porque hasta ahí son conexas, según la cantidad de 1's y el orden
                    for (int j = posA; j <= pos; j++)
                    {
                        if (j == pos)
                        {
                            pp = matriz1[0, j] + 1;
                            m += " " + pp;
                        }
                        else
                        {
                            pp2 = matriz1[0, j] + 1;
                            m += " " + pp2 + " ->";
                        }
                    }
                    posA = pos + 1; //La posición en que se queda según el orden de los nodos con más 1's
                    m += Environment.NewLine;
                }
            }
            TBComponentes.Text = m;
        }

        private void CompConexas_FormClosed(object sender, FormClosedEventArgs e)
        {
            TBAristas.Text = "";
            TBComponentes.Text = "";
            TBNodos.Text = "";
            RTBImprimir.Text = "";
            BTComponentes.Enabled = false;
            BTMaCamino.Enabled = false;
            BTMOrdena1.Enabled = false;
            BTOrdenaF.Enabled = false;
            BTAgregar.Enabled = false;
            TBCNodo.Enabled = false;
            TBConexion.Enabled = false;
            cAr = 1;
    
        }

        private void CompConexas_Load(object sender, EventArgs e)
        {

        }
    }
}
