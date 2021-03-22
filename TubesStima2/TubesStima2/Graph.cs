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
        public void printMutual()
        {
            Console.WriteLine("Nama akun : " + name);
            Console.WriteLine(edges.Count + " mutual friends:");
            foreach (var e in edges)
                Console.WriteLine(e);
            Console.WriteLine('\n');

        }
    }
    /*class Mutual
    {
        public List<string> mutualFriend;
        public string name;
        public Mutual(string name)
        {
            this.name = name;
            this.mutualFriend = new List<string>();
        }
        public void addMutualFriend(string name, string friend)
        {

        }
    }*/
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
        public List<string> BFS(Queue<string> queue,Queue<string> visited, int limit)
        {
            string node;
            int level = 0;
            int tempLevel = 0;
            int countElmtinLevel = 0;
            int countForLoop = 0;
            string adjacentnode;
            string firstNode = queue.Peek();
            List<string> result = new List<string>();
            if (limit == 0)
            {
                result.Add(firstNode);
            }
            else
            {
                while (queue.Count != 0 && level <= limit)
                {
                    node = queue.Dequeue();
                    for (int i = 0; i < adjacencyList.Find(v => v.name == node).edges.Count; i++)
                    {
                        adjacentnode = adjacencyList.Find(v => v.name == node).edges[i];
                        if (!visited.Contains(adjacentnode))
                        {
                            queue.Enqueue(adjacentnode);
                            if (level <= limit - 1)
                            {
                                visited.Enqueue(adjacentnode);
                                /*if (level == limit - 2)
                                {
                                    result.Enqueue(adjacentnode);
                                }*/
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
                        if (level == limit - 1)
                        {
                            result.Add(queue.Peek());
                        }
                        if (countForLoop == countElmtinLevel)
                        {
                            level++;
                            countForLoop = 0;
                            countElmtinLevel = tempLevel;
                            tempLevel = 0;
                        }
                    }
                }
            }
            return (result);
        }
        public void recommendation(string name)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(name);
            Queue<string> visited = new Queue<string>();
            visited.Enqueue(name);
            List<string> result = new List<string>();

            result = BFS(queue, visited, 2);
            List<Vertex> mutual = new List<Vertex>();
            foreach (string res in result)
                mutual.Add(new Vertex(res));
            for(int i=0; i<result.Count; i++)
            {
                for (int a = 0; a < adjacencyList.Find(v => v.name == name).edges.Count; a++)
                {
                    if (adjacencyList.Find(u => u.name == result[i]).edges.Contains(adjacencyList.Find(v => v.name == name).edges[a]))
                    {
                        mutual[i].edges.Add(adjacencyList.Find(v => v.name == name).edges[a]);
                    }
                }

            }
            mutual.Sort((a, b) => b.edges.Count - a.edges.Count);
            if (mutual.Count != 0)
            {
                Console.WriteLine("Daftar rekomendasi teman untuk akun " + name + ":");
                foreach (var v in mutual)
                    v.printMutual();
            }

        }
        /*public void addMutualFriend(string name, string friend)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(name);
            Queue<string> visited = new Queue<string>();
            visited.Enqueue(name);
            Queue<string> result = new Queue<string>();
            Queue<string> result2 = Queue<string>();
            result = BFS(queue, visited, 2);
            result2 = BFS(queue, visited, 1);
            printQueue(result2);
        }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
           /* Graph mutual = new Graph();
            mutual.addVertex("mia");
            mutual.addVertex("mia");
            mutual.addVertex("bambang");
            mutual.addEdge("mia", "bambang");
            mutual.addVertex("diap");
            mutual.addVertex("sadjo");
            mutual.addEdge("diap", "sadjo");
            mutual.addEdge("sadjo", "bambang");
            mutual.printadjacencyList();*/
            Graph recom = new Graph();
            recom.loadFile("friend.txt");
            /*Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            Queue<string> visited = new Queue<string>();
            visited.Enqueue("A");
            recom.BFS(queue, visited,0);*/
            recom.recommendation("A");

        }
    }

}
