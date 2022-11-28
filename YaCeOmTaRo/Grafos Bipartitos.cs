using System.Collections.Generic;
public class Edge
{
	public int src;
	public int dest;
}

public class Graph
{
	public List<List<int>> adjList = new List<List<int>>();

	public int n;


	public Graph(in List<Edge> edges, int n)
	{
		// cambiar el tama�o del vector para contener `n` elementos de tipo `vector<int>`
		this.n = n;
		adjList.Resize(n);

		// agrega bordes al grafo no dirigido
		foreach (var edge in edges)
		{
            adjList.Insert(edge.src, new List<int>(edge.dest));
            adjList.Insert(edge.dest, new List<int>(edge.src));
         
		}
	}
}
