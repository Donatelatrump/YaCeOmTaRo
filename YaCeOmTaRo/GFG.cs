using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaCeOmTaRo
{
    internal class GFG
    {
        static int M = 6;
        static int N = 6;
        bool bpm(bool[,] bpGraph, int u,
                 bool[] seen, int[] matchR)
        {
            for (int v = 0; v < N; v++)
            {
                if (bpGraph[u, v] && !seen[v])
                {
                    seen[v] = true;
                    if (matchR[v] < 0 || bpm(bpGraph, matchR[v],
                                             seen, matchR))
                    {
                        matchR[v] = u;
                        return true;
                    }
                }
            }
            return false;
        }

        public String maxBPM(bool[,] bpGraph)
        {
            int[] matchR = new int[N];
            for (int i = 0; i < N; ++i)
                matchR[i] = -1;
            int result = 0;
            for (int u = 0; u < M; u++)
            {
                bool[] seen = new bool[N];
                for (int i = 0; i < N; ++i)
                    seen[i] = false;
                if (bpm(bpGraph, u, seen, matchR))
                    result++;
            }
            String b = "";
            b += "Total parejas: " + result;
            b += Environment.NewLine;
            for (int i=0; i<6; i++)
            {
                if (matchR[i] != -1)
                {
                    b += (matchR[i]+1) + " -> " + (i+1);
                    b += Environment.NewLine;
                }
                
            }
            return b;

        }
    }
}
