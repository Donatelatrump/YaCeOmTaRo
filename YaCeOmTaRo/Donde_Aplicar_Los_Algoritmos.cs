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
    public partial class Donde_Aplicar_Los_Algoritmos : Form
    {
        public Donde_Aplicar_Los_Algoritmos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_Problemas.SelectedIndex)
            {
                case 0:
                    TB_Espacio.Text = "";
                    break;
                case 1:
                    TB_Espacio.Text = "en las permutaciones al si importar el orden podriamos usarlo en una paleteria donde las permutaciones son las bolas de nieve donde importa  el orden para ver el helado final";
                    break;
                case 2:
                    TB_Espacio.Text = "En las Combinaciones al si importar el orden podriamos usarlo para una tienda de ropa donde usariamos la combinaciones de ropa que puedes usar";
                    break;
                case 3:
                    TB_Espacio.Text = "Para lo que nos puede servir el tener los numeros en binario seria para el conjuto potencia. lo podemos usar como para dependiendo de que monedas o billetes negamos, ver las formas en las que podriamos pagar algo con ese dinero";
                    break;
            }
        }
    }
}
