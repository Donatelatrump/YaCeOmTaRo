using System;
using System.Collections.Generic;
using System.Windows;

public static class Globals
{
	// Realiza DFS en el graph a partir del v�rtice `v`
	public static bool DFS(in Graph graph, int v, List<bool> discovered, List<int> color)
	{
		// hacer para cada borde (v, u)
		foreach (int u in graph.adjList[v])
		{
			// si se explora el v�rtice `u` por primera vez
			if (!discovered[u])
			{
				// marca el nodo actual como descubierto
				discovered[u] = true;

				// el nodo actual tiene el color opuesto al de su padre
				color[u] = color[v] == 0 ? 1 : 0;

				// si DFS en cualquier sub�rbol enraizado en `v` devuelve falso
				if (!DFS(graph, u, discovered, color))
				{
					return false;
				}
			}

			// si el v�rtice ya fue descubierto y el color del v�rtice
			// `u` y `v` son iguales, entonces el graph no es bipartito
			else if (color[v] == color[u])
			{
				return false;
			}
		}

		return true;
	}

	// Funci�n para verificar si un graph es bipartito usando DFS
	public static bool isBipartite(in Graph graph)
	{
		// para realizar un seguimiento de si se descubre un v�rtice o no
		List<bool> discovered = new List<bool>(new bool[graph.n]);

		// realizar un seguimiento del color asignado (0 o 1) a cada v�rtice en DFS
		List<int> color = new List<int>(new int[graph.n]);

		// comienza desde cualquier nodo ya que el grafo es conectado y no dirigido
		int src = 0;

		// marca el v�rtice de origen como descubierto y establece su color en 0
		discovered[src] = true; color[src] = 0;

		// llamar al procedimiento DFS
		return DFS(graph, src, discovered, color);
	}

   public  static void Maiz()
	{
		// vector de los bordes del graph
		List<Edge> edges = new List<Edge>();
		edges.Insert(0, new Edge { src = 0, dest = 1 });
		edges.Insert(1, new Edge { src = 1, dest = 2 });
		edges.Insert(1, new Edge { src = 1, dest = 7 });
		edges.Insert(2, new Edge { src = 2, dest = 3 });
		edges.Insert(3, new Edge { src = 3, dest = 5 });
		edges.Insert(4, new Edge { src = 4, dest = 6 });
		edges.Insert(4, new Edge { src = 4, dest = 8 });
		edges.Insert(7, new Edge { src = 7, dest = 8 });
		edges.Insert(1, new Edge { src = 1, dest = 3 });
		// n�mero total de nodos en el graph (0 a 8)
		int n = 9;

		// construye un graph a partir de los bordes dados
		Graph graph = new Graph(edges, n);

		if (isBipartite(graph))
		{
			MessageBox.Show("El Grafo es Bipartito");
		}
		else
		{
            MessageBox.Show("El grafo no es Bipartito");
		}

	}


}
