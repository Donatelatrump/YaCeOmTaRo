using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

public static class Globals
{

	/*
	Bipartito:
	0 0 1 1 0 1
	0 0 0 0 1 1
	1 0 0 0 0 0
	1 0 0 0 0 0
	0 1 0 0 0 0
	1 1 0 0 0 0
	
	No bipartito:
	0 0 1 1 0 1
	0 0 0 0 1 1
	1 0 0 0 0 0
	1 0 0 0 0 0
	0 1 0 0 0 1
	1 1 0 0 1 0
	*/

	public static string Maiz(int[,] matriz,string aveces)
	{

		int n=0;
		n = Convert.ToInt32(aveces);
        bool[,] ady = new bool[n, n];
        for (int i = 0; i < n; i++)
		{
            for(int j = 0; j < n; j++)
			{
				if (matriz[i, j] == 0)
				{
					ady[i, j] = false;
				}
				else
				{
                    ady[i, j] = true;
                    
                    }
			}
		}
            int[] colores = new int[n];

		int origen = 0;

		colores[origen] = 1;

        Stack<int> myStack = new Stack<int>();
        myStack.Push(origen);

		while (myStack.Count != 0)
		{
            origen = (int)myStack.First();
			myStack.Pop();
            

			for (int x = 0; x < n; x++)
			{
				MessageBox.Show("matriz  " + matriz[origen, x]);
                if (matriz[origen,x]!=0 && (colores[x] == 0))
				{
                    MessageBox.Show("Entre en el primer if");
                    colores[x] = colores[origen] * -1; 
				}
                
                if (matriz[origen,x]!=0 && (colores[origen] == colores[x]))
                {
                    return "No es bipartito";
                }
               
			}
		}

        return ("Es bipartito");
	}
}
