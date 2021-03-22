using System;
using System.Collections.Generic;
namespace TubesStima2
{
    class Vertex
    {
        public List<string> edges;
        public string name;
        public Vertex(string name)
        {
            this.name = name;
            this.edges = new List<string>();
        }
        public void printEdge()
        {
            Console.Write(name+" | ");
            foreach (var e in edges)
                Console.Write(e + " ");
            Console.Write('\n');
        }
    }
    class Graph
    {
        
        public List<Vertex> adjacencyList;

        public Graph()
        {
            adjacencyList = new List<Vertex>();
        }
        public void addEdge(string node1, string node2)
        {
            adjacencyList.Find(v => v.name == node1).edges.Add(node2);
            adjacencyList.Find(v => v.name == node2).edges.Add(node1);
        }
        public void addVertex(string newVertex)
        {
            if (adjacencyList.Find(v => v.name == newVertex) == null)
            {
                adjacencyList.Add(new Vertex(newVertex));
            }
        }
        public void printadjacencyList()
        {
            if (adjacencyList.Count != 0)
            {
                foreach (var v in adjacencyList)
                    v.printEdge();
            }
        }
        public void loadFile(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            for (int idx=1; idx<lines.Length; idx++)
            {
                string node1="";
                string node2="";
                bool parse = false;
                for (int i=0; i<lines[idx].Length; i++)
                {
                    if (lines[idx][i]!=' ' && !parse)
                    {
                        node1 += lines[idx][i];
                    }
                    if(lines[idx][i] != ' ' && parse)
                    {
                        node2 += lines[idx][i];
                    }
                    if (lines[idx][i] == ' ')
                    {
                        parse = true;
                    }
                }
                addVertex(node1);
                addVertex(node2);
                addEdge(node1, node2);
            }
        }
        public void printQueue(Queue<string> queue)
        {
            foreach (string name in queue)
                Console.Write(name);
        }
        public void BFS(Queue<string> queue,Queue<string> visited, int limit)
        {
            string node;
            int level = 0;
            int tempLevel = 0;
            int countElmtinLevel = 0;
            int countForLoop = 0;
            string adjacentnode;
            while (queue.Count != 0 && level<limit){
                node = queue.Dequeue();
                for (int i=0; i<adjacencyList.Find(v => v.name == node).edges.Count; i++)
                {
                    adjacentnode = adjacencyList.Find(v => v.name == node).edges[i];
                    if (!visited.Contains(adjacentnode))
                    {   
                        queue.Enqueue(adjacentnode);
                        if (level == limit - 2)
                        {
                            visited.Enqueue(adjacentnode);
                        }
                        if (countForLoop == 0)
                        {
                            if (level == 0)
                            {
                                countElmtinLevel++;
                            }
                        }
                        else
                        {
                            tempLevel++;
                        }
                    }   
                }
                countForLoop++;
                if (countForLoop > 0)
                {
                    if (countForLoop == countElmtinLevel)
                    {
                        level++;
                        countForLoop = 0;
                        countElmtinLevel = tempLevel;
                        tempLevel = 0;
                    }
                }
            }
            printQueue(visited);
        }
        public void BFSSearch(string name)
        {
            
        }
        public void recommendation(string akun)
        {
            
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Graph mutual = new Graph();
            mutual.addVertex("mia");
            mutual.addVertex("mia");
            mutual.addVertex("bambang");
            mutual.addEdge("mia", "bambang");
            mutual.addVertex("diap");
            mutual.addVertex("sadjo");
            mutual.addEdge("diap", "sadjo");
            mutual.addEdge("sadjo", "bambang");
            mutual.printadjacencyList();
            Graph recom = new Graph();
            recom.loadFile("friend.txt");
            recom.printadjacencyList();
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            Queue<string> visited = new Queue<string>();
            visited.Enqueue("A");
            recom.BFS(queue, visited,2);
        }
    }

}