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
            MinimizeBox = false;
            MaximizeBox = false;
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
            if (comboBox3.SelectedIndex >= 1 || comboBox1.SelectedIndex >= 1 || comboBox2.SelectedIndex >= 1 || comboBox4.SelectedIndex >= 1)
            {

                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;

            }
            else
            {
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //desactiva el combobox para que cuando aprieten el boton no haya dos seleccionados UwU
        {
            if (comboBox3.SelectedIndex >= 1 || comboBox1.SelectedIndex >= 1 || comboBox2.SelectedIndex >= 1 || comboBox4.SelectedIndex >= 1)
            {

                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
               
            }
            else
            {
                comboBox1.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex >= 1 || comboBox1.SelectedIndex >= 1 || comboBox2.SelectedIndex >= 1 || comboBox4.SelectedIndex >= 1)
            {

                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox4.Enabled = false;

            }
            else
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox4.Enabled = true;
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex >= 1 || comboBox1.SelectedIndex >= 1 || comboBox2.SelectedIndex >= 1 || comboBox4.SelectedIndex >= 1)
            {

                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Enabled = false;

            }
            else
            {
                comboBox1.Enabled = true;
                comboBox3.Enabled = true;
                comboBox2.Enabled = true;
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
                   
                    using (var frm2 = new MatrizAdy())
                    {
                        frm2.ShowDialog();
                    }
                    break;
                    
                case 2://Recorridos de un grafo.  Algoritmo primero en profundidad y algoritmo primero en anchura
                  
                    using (var frm1 = new AnchuraProfundidad())
                    {
                        frm1.ShowDialog();  
                    }
                    break;

                case 3://Algoritmo para calcular todas las componentes conexas de un grafo
                    using (var frm3 = new CompConexas())
                    {
                        frm3.ShowDialog();
                    }
                    break;
                    
                case 4://Algoritmo que encuentra el camino más corto, entre dos vértices de un grafo
                  
                    using (var frm3 = new Dijkstra())
                    {
                        frm3.ShowDialog();
                    }
                    break;

                case 5: //saber si un grafo almacenado en la computadora es un árbol o no
                   
                    using (var frm4 = new Saber_Si_Es_Arbol())
                    {
                        frm4.ShowDialog();
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
            switch (comboBox3.SelectedIndex) //Unidad 3  
            {
                case 1: //Formas de caracterizar un grafo bipartito
                    using (var zzz = new Caracterizar_Grafo_Bipartito())
                    {
                        zzz.ShowDialog();
                    }
                    break;
                case 2: //Formas para hacer el pareo de un grafo normal
                    using (var xxx = new apareamiento_normal())
                    {
                        xxx.ShowDialog();
                    }
                        break;
                case 3: //Formas de hacer el pareo de un grafo bipartito
                    using (var ccc = new Pareamiento_Bipartito())
                    {
                        ccc.ShowDialog();
                    }
                    break;
                case 4: //Problemas correspondientes de pareo de grafos
                    break;
                case 5: //Concepto pareos maximales minimos 
                    break;
          
               
                
            }
            switch (comboBox4.SelectedIndex)//Unidad 4
            {
   
                case 1: //Formas de mostrar garfos dirigidos ponderados o no
                    break;
                case 2: //Metodo de anchura y profundidad para grafos bipartitos
                    using (DFSyBFS_Dirigidos dir = new DFSyBFS_Dirigidos())
                        dir.ShowDialog();
                    break;
                case 3: //Comparacion de DFS y BFS en grafos dirigidos y grafos no dirigidos
                    break;
                case 4: //Problemas de grafos dirigos ponderados y no dirigidos ponderados
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

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
