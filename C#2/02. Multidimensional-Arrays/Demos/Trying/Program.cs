using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trying
{
    class Program
    {

        static void Main()
        {


            int[][] graph =
        {
new [] { 1, 6, 7 },
new [] { 0, 2, 5 },
new [] { 1, 3, 4 },
new [] { 2 },
new [] { 2 },
new [] { 1 },
new [] { 0 },
new [] { 0, 8, 11 },
new [] { 7, 9, 10 },
new [] { 8 },
new [] { 8 },
new [] { 7 },
};
            bool[] visited = new bool[graph.Length];

        }

        

        static void DfsRecursive(int[][] graph,int node, bool[] visited)
        {
            visited[node] = true;

            Console.WriteLine(node);

            foreach (int neighbor in graph[node])
            {
                if (visited[neighbor])
                {
                    continue;
                }
                int index = Array.FindIndex(graph, neighbor);
                DfsRecursive(node, visited);
            }
        }

        static void DfsIterative(int node)
        {
            var stack = new Stack<int>();

            stack.Push(node);

            while (stack.Count != 0)
            {
                int currentNode = stack.Pop();
                visited[currentNode] = true;

                Console.WriteLine(currentNode);

                foreach (int neighbor in graph[currentNode].Reverse())
                {
                    if (visited[neighbor])
                    {
                        continue;
                    }

                    stack.Push(neighbor);
                }
            }
        }
    }
}
