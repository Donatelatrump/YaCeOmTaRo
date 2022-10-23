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
    public partial class Form1 : Form
    {
        Combinaciones_Permutaciones Combinacion;
        ConjuntoP potencia;
        CadenasB binario;
        int i = 0;
        public Form1()
        {
            InitializeComponent(); 
            i = 0;
            panel1.Hide();
            Combinacion = new Combinaciones_Permutaciones();
            potencia = new ConjuntoP();
            binario = new CadenasB();
        }

        private void button1_Click(object sender, EventArgs e) //boton para iniciar el programa
        {
            panel1.Show();
        }
        private void button2_Click(object sender, EventArgs e) //Boton de cambio de integrantes
        {
            if (i == 3)
            {
                i = 0;
            }
            string[] nombres = { "Cesar Donnet Hernandez Gastelum 283189", "Yarely Lizeth Gonzales 283143", "nombre","nombre",""}; //en vez de nombres pongan sus datos
            string[] path = { "E:\\Codigosd\\YaCeOmTaRo\\gift\\Donnet.gif", "E:\\Codigosd\\YaCeOmTaRo\\gift\\Yarely.gif", "","",""}; //pongas los path de sus .gif
            //integrate
            pictureBox2.Image = Image.FromFile(path[i]);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            if (i == 1)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage; //editalo como mejor lo veas yarely
            }
            
            label2.Text = nombres[i];
         i++; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex >= 1) //desactiva el combobox para que cuando aprieten el boton no haya dos seleccionados UwU
            {
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 1)
            {
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e) //Boton del panel 2 para cargar codigo, aqui comienza el switch
        {
            switch (comboBox1.SelectedIndex) //switch de Unidad 1
            {
                case 1: //Algoritmos para generar todas las permutaciones y combinaciones de n elementos.
                    Combinacion.ShowDialog();
                    break;
                case 2: //El conjunto Potencia
                    potencia.ShowDialog();
                    break;

                case 3: //Algoritmos para generar todas las cadenas binarias de tamaño n.
                    binario.ShowDialog();
                    break;
                case 4: //Correspondencia entre el conjunto Potencia y el conjunto de todas las cadenas binarias de tamaño n
                    break;

                case 5: //Comparación de Algoritmos. Notación O grande
                    break;

                case 6: //Problemas reales donde aplicar los algoritmos. Ejercicios
                    break;

            }

            switch (comboBox2.SelectedIndex)  //Switch Unidad 2
            {
                case 1://Guardando un grafo en la computadora. Matriz de adyacencia y Lista de adyacencia
                    break;
                case 2://Recorridos de un grafo.  Algoritmo primero en profundidad y algoritmo primero en anchura

                    break;

                case 3://Algoritmo para calcular todas las componentes conexas de un grafo
                    break;
                case 4://Algoritmo que encuentra el camino más corto, entre dos vértices de un grafo
                    break;

                case 5: //saber si un grafo almacenado en la computadora es un árbol o no
                    break;

                case 6: //Árbol de expansión. Algoritmos para encontrar el árbol de expansión mínima o máxima.
                        //Aplicaciones reales donde encontrar el árbol de expansión mínima y máxima es la solución del problema
                    break;

            }




        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e) //eventos para bloquear el ingreso de escritura al comboBox, asi solo permitiendo que pueda elegir entre las opciones
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
