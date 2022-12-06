using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaCeOmTaRo
{
    internal class Pareos
    {

        public bool pareamiento(int[,] matrix, int num3)
        {
            int cont = 0;
            int num = 0;
            int num2 = 0;

            int[] pareja = new int [matrix.GetLength(0)];
            int[] pareja2 = new int[matrix.GetLength(0)];


            for (int i = 0; i < num3; i++)
            {
                pareja[i] = 0;
                pareja2[i] = 0;
            }
            for (int j = 0; j < num3; j++)
            {
                for (int k = 0; k < num3; k++)
                {
                    if (matrix[j, k] == 1)
                    {
                        pareja[j] = j + 1;
                        pareja2[j] = k + 1;
                        num = k;
                        num2 = j;
                        cont += 1;
                        break;

                    }
                }
                for (int l = 0; l < num3; l++)
                {
                    matrix[l, j] = 0;
                    matrix[l, num] = 0;
                }
            }
            if (cont == num3 / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
