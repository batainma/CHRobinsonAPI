using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHRobinsonWebAPI.Models
{
    public class BFSearch
    {
        protected static int V = 10;
        static bool[] visited = new bool[V];

        // Djikstra's Algorithm using a dict, inverse dict, stack, and queue
        public List<string> goTo(string destination)
        {
            // create the adjacency list
            AdjacencyList adj = new AdjacencyList();
            List<List<int>> adjList = adj.get();

            // get the dictionary and inverse dictionary to simplify the actual BFS part
            Dictionary<string, int> hash = adj.createHash();
            Dictionary<int, string> invHash = adj.createInverseHash();

            // convert destination into an integer --> return null if invalid destination
            int dest;
            try 
            { 
                dest = hash[destination]; 
            }
            catch(Exception e)
            {
                return null;
            }
            //int dest = hash[destination];

            // start classic djikstra's algorithm
            int[] predecessors = new int[V];
            
            // initialize arrays to false and negative values
            for(int i = 0; i < V; i++)
            {
                visited[i] = false;
                predecessors[i] = -1;
            }

            // init variables for while loop
            int start = 0;
            int current = 0;
            visited[start] = true;

            // if there is a way to get to the destination, this will become true.
            // otherwise, it stays false and does not set up shortest path var
            bool isFound = false;

            // set up queue with source ("USA")
            Queue<int> que = new Queue<int>();
            que.Enqueue(start);

            // while there is anything in the queue
            while(que.Count != 0)
            {
                current = que.Dequeue();
                // Breadth First Search
                for(int j = 0; j < adjList[current].Count; j++)
                {
                    if (visited[adjList[current][j]] == false)
                    {
                        que.Enqueue(adjList[current][j]);
                        predecessors[adjList[current][j]] = current;
                        visited[adjList[current][j]] = true;
                    }
                }

                // if found, set bool to true and break out of loop
                if (current == dest)
                {
                    isFound = true;
                    break;
                }
            }

            // put together a stack of all traversed countries to get to destination
            int walk = dest;
            Stack<int> shortestPath = new Stack<int>();
            if (isFound)
            {
                while(predecessors[walk] != -1)
                {
                    shortestPath.Push(predecessors[walk]);
                    walk = predecessors[walk];
                }
            }

            // pop off the stack to get the correct path of source to destination
            List<string> path = new List<string>();
            while (shortestPath.Count != 0)
            {
                path.Add(invHash[shortestPath.Pop()]);
            }

            // ensure the destination is included in the path
            path.Add(destination);

            return path;

        }

    }
}
