using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alghoritms.Graphs
{
    class ShortestPathes
    {
        public static int[][] BellmanFordPath(int[][] graphMatrix,int vertexCount,int sourceVertex,int infNum)
        {
            int[][] pathMatrix=new int[vertexCount][];

            for (int i = 0; i < vertexCount; i++)
                pathMatrix[0][i] = graphMatrix[sourceVertex][i];
            
            pathMatrix[0][sourceVertex] = 0;
            List<int>[] adjEdges=new List<int>[vertexCount];
            for(int i=0;i<vertexCount;i++)
            {
                adjEdges[i]=new List<int>();
                for(int j=0;j<vertexCount;j++)
                {
                    if(graphMatrix[j][i]!=infNum) 
                        adjEdges[i].Add(j);
                }
                

            }

            
            for(int i=1;i<vertexCount-1;i++)
            {
                for(int j=0;j<vertexCount;j++)
                {
                    int minPath = 10000000;
                    if (adjEdges[j].Count != 0)
                    {
                        int adjV=adjEdges[j][0];
                        minPath = pathMatrix[i-1][adjV]+graphMatrix[adjV][j];
                        for (int l = 1; l < adjEdges[j].Count; l++)
                        {
                            adjV=adjEdges[j][l];
                            if (minPath > pathMatrix[i - 1][adjV] + graphMatrix[adjV][j])
                                minPath = pathMatrix[i - 1][adjV] + graphMatrix[adjV][j];
                        }
                    }

                    pathMatrix[i][j] = Math.Min(minPath, pathMatrix[i - 1][j]);
                }
            }

            return pathMatrix;
        }

        public static int[][] FloydWarshall(int[][] graphMatrix,int vertexCount)
        {
            int[][][] fwMatrix = new int[vertexCount][][];

            
            fwMatrix[0]=new int[vertexCount][];
            for(int i=0;i<vertexCount;i++)
            {
                fwMatrix[0][i] = new int[vertexCount];
                for (int j = 0; j < vertexCount; j++)
                    fwMatrix[0][i][j] = graphMatrix[i][j];
            }

            for(int k=1;k<vertexCount;k++)
            {
                fwMatrix[k] = new int[vertexCount][];
                for(int i=0;i<vertexCount;i++)
                {
                    fwMatrix[k][i] = new int[vertexCount];
                    for(int j=0;j<vertexCount;j++)
                    {
                        Math.Min(fwMatrix[k - 1][i][j], fwMatrix[k - 1][i][k] + fwMatrix[k - 1][k][j]);
                    }
                }
            }

            return fwMatrix[vertexCount - 1];
        }
    }
}
