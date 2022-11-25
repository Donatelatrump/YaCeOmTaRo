using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaCeOmTaRo
{
    public partial class Form1 : Form
    { 
        int i = 0;
        string[] nombres = { "Cesar Donnet Hernandez Gastelum 283189", "Yarely Lizeth Gonzales Martinez 283143", "Omar Villalobos Rodriguez 315374\n                      El Risas", "Tania Lopez Ibarra 336673", "Roberto Cortes Valero 328892\n      La gata bajo la lluvia", "Salvador Alejandro Aguilera macias 293506" }; //en vez de nombres pongan sus datos
        string[] path = { "E:\\Descargas\\Nuevo Archivo WinRAR ZIP\\YaCeOmTaRo\\gift\\Donnet.gif", "E:\\Descargas\\Nuevo Archivo WinRAR ZIP\\YaCeOmTaRo\\gift\\Yarely.gif", "E:\\Descargas\\Nuevo Archivo WinRAR ZIP\\YaCeOmTaRo\\gift\\El risas.jpg", "E:\\Descargas\\Nuevo Archivo WinRAR ZIP\\YaCeOmTaRo\\gift\\Tania.gif", "E:\\Descargas\\Nuevo Archivo WinRAR ZIP\\YaCeOmTaRo\\gift\\Roberto.jpg", "E:\\Descargas\\Nuevo Archivo WinRAR ZIP\\YaCeOmTaRo\\gift\\Salvador.gif"  }; //pongas los path de sus .gif
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();    
        }
        private void button1_Click(object sender, EventArgs e) //boton para iniciar el programa
        {
            panel1.Show();
        }
        private void button2_Click(object sender, EventArgs e) //Boton de cambio de integrantes itera entre los gift y los label
        {
            if (i == 6)
            {
                i = 0;
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage; //Asigna el label 
            pictureBox2.Image = Image.FromFile(path[i]);
            //integrate
            if (i == 2)
            {

                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                if (i == 1)
                {
                    pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage; //editalo como mejor lo veas yarely
                }
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //desactiva el combobox para que cuando aprieten el boton no haya dos seleccionados UwU
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
                using (var frm = new Combinaciones())
                    {
                        frm.ShowDialog();
                    }
                    break;
                //pudiste?
                case 2: //El conjunto Potencia
                    using (var frm = new ConjuntoP())
                    {
                        frm.ShowDialog();
                    }
                    System.GC.Collect();

                    break;
                case 3 : //Algoritmos para generar todas las cadenas binarias de tamaño n.
                    using (var frm = new CadenasChidas())
                    {
                        frm.ShowDialog();
                    }
                    break;
                case 4: //Correspondencia entre el conjunto Potencia y el conjunto de todas las cadenas binarias de tamaño n
                    using (var frm = new ConjuntoPotenciaBinario())
                    {
                        frm.ShowDialog(); 
                    }
                    break;
                case 5: //Comparación de Algoritmos. Notación O grande
                    using (var frm = new Big_O())
                    {
                        frm.ShowDialog();
                    }
                    break;

                case 6: //Problemas reales donde aplicar los algoritmos. Ejercicios
                    using (var frm = new Donde_Aplicar_Los_Algoritmos())
                    {
                        frm.ShowDialog();
                    }
                    break;
            }
            switch (comboBox2.SelectedIndex)  //Switch Unidad 2
            {
                case 1://Guardando un grafo en la computadora. Matriz de adyacencia y Lista de adyacencia
                   
                    using (var frm = new MatrizAdy())
                    {
                        frm.ShowDialog();
                    }
                    break;
                    
                case 2://Recorridos de un grafo.  Algoritmo primero en profundidad y algoritmo primero en anchura
                  
                    using (var frm = new AnchuraProfundidad())
                    {
                        frm.ShowDialog();  
                    }
                    break;

                case 3://Algoritmo para calcular todas las componentes conexas de un grafo
                    using (var frm = new CompConexas())
                    {
                        frm.ShowDialog();
                    }
                    break;
                    
                case 4://Algoritmo que encuentra el camino más corto, entre dos vértices de un grafo
                  
                    using (var frm = new Dijkstra())
                    {
                        frm.ShowDialog();
                    }
                    break;

                case 5: //saber si un grafo almacenado en la computadora es un árbol o no
                   
                    using (var frm = new Saber_Si_Es_Arbol())
                    {
                        frm.ShowDialog();
                    }
                    break;

                case 6: //Árbol de expansión. Algoritmos para encontrar el árbol de expansión mínima o máxima.
                        //Aplicaciones reales donde encontrar el árbol de expansión mínima y máxima es la solución del problema
                 
                    using (var frm = new Algoritmos_de_expancion())
                    {
                        frm.ShowDialog();
                    }
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

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor= Color.White;
           
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.MidnightBlue;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
