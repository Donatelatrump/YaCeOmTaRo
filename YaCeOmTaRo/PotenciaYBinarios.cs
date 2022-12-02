using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaCeOmTaRo
{
    public partial class ConjuntoPotenciaBinario : Form
    {
        //Variables para almacenar los datos
        int n; //Tamaño del conjunto
        char[,] conjunto; //Almacena los valores del conjunto y el valor binario
        int i = 0; //iterador
        SortedSet<char> repetidos = new SortedSet<char>(); //Comprobar que no se repitan los elementos
        TaskCompletionSource<bool> tcs = null;

        public ConjuntoPotenciaBinario()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (cmbTamaño.Text != null) //Mientras que se haya seleccionado una opción
            {
                //Hace visible el label y textbox
                lblElemento.Visible = true;
                txtElemento.Visible = true;
                //Obtiene el valor que dio el usuario y guarda espacio para el conjunto
                n = int.Parse(cmbTamaño.Text);
                conjunto = new char[n, 2];
                //Deshabilita la opción de cambiar el tamaño
                cmbTamaño.Enabled = false;
                btnEjecutar.Enabled = false;

                //Pide los valores
                for (i = 0; i < n; i++)
                {
                    tcs = new TaskCompletionSource<bool>(false);
                    lblElemento.Text = "Ingresa el valor del elemento " + (i + 1) + ":";
                    await tcs.Task; //Espera a que se ingrese el valor del elemento
                }
                //Desactiva el textbox de los elementos
                txtElemento.Enabled = false;
                //Total de elementos del conjunto potencia
                int total = (int)Math.Pow(2, n);
                //Imprime el conjunto potncia y la tabla de binarios en pantalla
                richConjunto.Text = "\tCONJUNTO POTENCIA\n";
                richBinarios.Text = "\tTABLA DE BINARIOS\n";
                for(i = 0; i < total; i++)
                {
                    DecABin(i, conjunto, n - 1);
                    Imprimir(conjunto);
                }
            }
        }

        private void txtElemento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtElemento_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtElemento_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Si el texto no está vacío y se presiona enter
                if (txtElemento.Text != null && e.KeyData == Keys.Enter)
                {
                    //Variable auxiliar
                    char aux = char.Parse(txtElemento.Text);
                    if (!repetidos.Contains(aux)) //Si no se encunetra ya ese valor
                    {
                        conjunto[i, 0] = aux; //Se añade al conjunto, en la posición de los elementos
                        repetidos.Add(aux); //Se añade ese elemento al conjunto y a los repetidos
                        tcs?.TrySetResult(true); //Se declara como completada la tarea
                        txtElemento.Text = null; //Se borra lo escrito en el textbox
                    }
                    else
                    {
                        MessageBox.Show("El elemento ya se encuentra en el conjunto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Métodos
        //Decimal a binario
        private void DecABin(int dec, char[,] vec, int pos)
        {
            int residuo, cociente;
            cociente = dec / 2;
            residuo = dec % 2;

            if (cociente != 0)
                DecABin(cociente, vec, pos - 1);

            vec[pos, 1] = (char)residuo;
        }
        //Imprimir en RichTextBox
        private void Imprimir(char[,] vec)
        {
            //Verifica si tiene uno, en caso de que sí, imprime el caracter correspondiente
            richConjunto.AppendText("\t\t{");
            richBinarios.AppendText("\t\t{");
            for (int i = 0; i < n; i++)
            {
                if (vec[i, 1] == 1)
                {
                    richConjunto.AppendText(vec[i, 0].ToString());
                }
                richBinarios.AppendText(((int)vec[i, 1]).ToString());
            }
            richConjunto.AppendText("}\n");
            richBinarios.AppendText("}\n");
        }

        private void ConjuntoPotenciaBinario_FormClosed(object sender, FormClosedEventArgs e) // Cuando el forms se cierre este debe reiniciarse
        {
            lblElemento.Visible = false;
            txtElemento.Visible = false;
            lblElemento.Text = "";
            txtElemento.Text = "";
            cmbTamaño.Text = "";
            richConjunto.Text = "";
            richBinarios.Text = "";
            cmbTamaño.Enabled = true;
            btnEjecutar.Enabled = true;
            txtElemento.Enabled = true;
            repetidos.Clear();
        }
    }
}