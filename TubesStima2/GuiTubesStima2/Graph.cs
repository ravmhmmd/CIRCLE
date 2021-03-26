using System;
using System.Collections.Generic;
namespace GuiTubesStima2
{
    class Node
    {
        public List<string> edges;
        public string name;
        public Node(string name)
        {
            this.name = name;
            this.edges = new List<string>();
        }
        public void PrintEdge()
        {
            Console.Write(name + " | ");
            foreach (var e in edges)
                Console.Write(e + " ");
            Console.Write('\n');
        }
        public void PrintMutual()
        {
            if (edges.Count != 0)
            {
                Console.WriteLine("Nama akun : " + name);

                Console.WriteLine(edges.Count + " mutual friends:");
                foreach (var e in edges)

                    Console.WriteLine(e);
                Console.WriteLine('\n');
            }
        }
    }
    class ListNode
    {
        public List<Node> edgeList;
        public ListNode()
        {
            edgeList = new List<Node>();
        }
        public void AddEdgeList(string node1, string node2)
        {
            edgeList.Find(v => v.name == node1).edges.Add(node2);
        }
        public void AddNodeList(string newNode)
        {
            if (edgeList.Find(v => v.name == newNode) == null)
            {
                edgeList.Add(new Node(newNode));
            }
        }
        public void PrintListNode()
        {
            if (edgeList.Count != 0)
            {
                foreach (var v in edgeList)
                    v.PrintEdge();
            }
        }
        public void FindPath(List<string> path, string name, string other)
        {
            string tempPath = other;
            for (int i = edgeList.Count - 1; i >= 0; i--)
            {
                if (edgeList[i].edges.Contains(tempPath))
                {
                    path.Add(tempPath);
                    tempPath = edgeList[i].name;
                }
            }
            path.Add(name);
        }
        public void PrintPath(List<string> path)
        {
            Console.Write("(");
            int i;
            for (i = path.Count - 1; i > 0; i--)
            {
                Console.Write(path[i] + "->");
            }
            Console.Write(path[i] + ", " + (path.Count - 2).ToString());
            if (path.Count - 2 == 1)
            {
                Console.Write("st");
            }
            else if (path.Count - 2 == 2)
            {
                Console.Write("nd");
            }
            else if (path.Count - 2 == 3)
            {
                Console.Write("rd");
            }
            else
            {
                Console.Write("th");
            }
            Console.Write(" Degree)\n");
        }
    }
    class Graph
    {

        public List<Node> adjacencyList;

        public Graph()
        {
            adjacencyList = new List<Node>();
        }
        public void AddEdge(string node1, string node2)
        {
            adjacencyList.Find(v => v.name == node1).edges.Add(node2);
            adjacencyList.Find(v => v.name == node2).edges.Add(node1);
        }
        public void AddNode(string newNode)
        {
            if (adjacencyList.Find(v => v.name == newNode) == null)
            {
                adjacencyList.Add(new Node(newNode));
            }
        }
        public void PrintadjacencyList()
        {
            if (adjacencyList.Count != 0)
            {
                foreach (var v in adjacencyList)
                    v.PrintEdge();
            }
        }
        public void LoadFile(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            for (int idx = 1; idx < lines.Length; idx++)
            {
                string node1 = "";
                string node2 = "";
                bool parse = false;
                for (int i = 0; i < lines[idx].Length; i++)
                {
                    if (lines[idx][i] != ' ' && !parse)
                    {
                        node1 += lines[idx][i];
                    }
                    if (lines[idx][i] != ' ' && parse)
                    {
                        node2 += lines[idx][i];
                    }
                    if (lines[idx][i] == ' ')
                    {
                        parse = true;
                    }
                }
                AddNode(node1);
                AddNode(node2);
                AddEdge(node1, node2);
            }
        }
        public void PrintQueue(Queue<string> queue)
        {
            foreach (string name in queue)
                Console.Write(name);
        }
        public List<string> BFS(Queue<string> queue, Queue<string> visited, int limit)
        {
            string node;
            int level = 0;
            int tempLevel = 0;
            int countElmtinLevel = 1;
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
                    //Console.WriteLine(node);
                    if (level <= limit - 1)
                    {
                        for (int i = 0; i < adjacencyList.Find(v => v.name == node).edges.Count; i++)
                        {
                            adjacentnode = adjacencyList.Find(v => v.name == node).edges[i];
                            if (!visited.Contains(adjacentnode))
                            {
                                queue.Enqueue(adjacentnode);
                                visited.Enqueue(adjacentnode);
                                tempLevel++;
                                if (level == limit - 1)
                                {
                                    if (queue.Count != 0)
                                    {
                                        result.Add(adjacentnode);
                                    }
                                }
                            }

                        }
                        countForLoop++;
                    }
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
            }
            return (result);
        }
        public void BFSSearch(Queue<string> queue, Queue<string> visited, string other, ListNode result)
        {
            string node;
            bool found = false;
            string adjacentnode;
            while (queue.Count != 0 && !found)
            {
                node = queue.Dequeue();
                result.AddNodeList(node);
                for (int i = 0; i < adjacencyList.Find(v => v.name == node).edges.Count; i++)
                {
                    adjacentnode = adjacencyList.Find(v => v.name == node).edges[i];
                    if (!visited.Contains(adjacentnode))
                    {
                        queue.Enqueue(adjacentnode);
                        visited.Enqueue(adjacentnode);

                        result.AddEdgeList(node, adjacentnode);
                        if (adjacentnode == other)
                        {
                            found = true;

                            break;
                        }
                    }
                }

            }


        }

        public void DFSSearch(string startVertex, string other, ListNode result)
        {
            Node start = adjacencyList.Find(v => v.name == startVertex);
            Queue<string> visited = new Queue<string>();
            Stack<Node> stack = new Stack<Node>();
            stack.Push(start);

            string node;
            bool found = false;
            string adjacentnode;
            while (stack.Count != 0 && !found)
            {
                var current = stack.Pop();
                result.AddNodeList(current.name);
                for (int i = 0; i < adjacencyList.Find(v => v.name == current.name).edges.Count; i++)
                {
                    adjacentnode = adjacencyList.Find(v => v.name == current.name).edges[i];
                    if (!visited.Contains(adjacentnode))
                    {
                        stack.Push(adjacencyList.Find(v => v.name == adjacentnode));
                        visited.Enqueue(adjacentnode);

                        result.AddEdgeList(current.name, adjacentnode);
                        if (adjacentnode == other)
                        {
                            found = true;

                            break;
                        }
                    }
                }


            }
            Console.WriteLine(startVertex);
            Console.WriteLine(other);



        }



        public List<string> DFS(string startVertex)
        {
            Node start = adjacencyList.Find(v => v.name == startVertex);
            if (start == null) return null;

            List<string> result = new List<string>();
            Queue<string> visited = new Queue<string>();
            Stack<Node> stack = new Stack<Node>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (visited.Contains(current.name)) continue;
                result.Add(current.name);
                visited.Enqueue(current.name);

                foreach (var neighbor in current.edges)
                {

                    if (!visited.Contains(neighbor))
                    {
                        stack.Push(adjacencyList.Find(v => v.name == neighbor));
                    }
                }
            }
            result.RemoveAt(0);
            return result;
        }





        public void Recommendation(string name)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(name);
            Queue<string> visited = new Queue<string>();
            visited.Enqueue(name);
            List<string> result = new List<string>();

            Console.WriteLine("================");
            Console.WriteLine("Friend Recommendation");
            Console.WriteLine("Enter Methods:");
            Console.WriteLine("1. BFS");
            Console.WriteLine("2. DFS");
            Console.WriteLine("================");
            int method = Convert.ToInt32(Console.ReadLine());
            if (method == 1)
                result = BFS(queue, visited, 2);

            if (method == 2)
                result = DFS(name);




            List<Node> mutual = new List<Node>();
            foreach (string res in result)
                mutual.Add(new Node(res));
            for (int i = 0; i < result.Count; i++)
            {
                for (int a = 0; a < adjacencyList.Find(v => v.name == name).edges.Count; a++)
                {
                    if (adjacencyList.Find(u => u.name == result[i]).edges.Contains(adjacencyList.Find(v => v.name == name).edges[a]))
                    {
                        mutual[i].edges.Add(adjacencyList.Find(v => v.name == name).edges[a]);
                    }
                }

            }
            if (mutual.Count != 0)
            {
                mutual.Sort((a, b) => b.edges.Count - a.edges.Count);
                Console.WriteLine("Daftar rekomendasi teman untuk akun " + name + ":");
                foreach (var v in mutual)
                    v.PrintMutual();
            }

        }

        public void ExploreFriend(string name, string other)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(name);
            Queue<string> visited = new Queue<string>();
            visited.Enqueue(name);
            ListNode result = new ListNode();
            List<string> path = new List<string>();

            Console.WriteLine("================");
            Console.WriteLine("Explore Friends");
            Console.WriteLine("Enter Methods:");
            Console.WriteLine("1. BFS");
            Console.WriteLine("2. DFS");
            Console.WriteLine("================");
            int method = Convert.ToInt32(Console.ReadLine());
            if (method == 1)
                BFSSearch(queue, visited, other, result);
            result.PrintListNode();
            if (method == 2)
                DFSSearch(name, other, result);
            result.PrintListNode();



            Console.WriteLine("Nama Akun: " + name + " dan " + other);

            if (result.edgeList[(result.edgeList.Count - 1)].edges.Contains(other))
            {
                result.FindPath(path, name, other);

                result.PrintPath(path);
            }
            else
            {

                Console.WriteLine("Tidak ada jalur koneksi yang tersedia");
                Console.WriteLine("Anda harus memulai koneksi baru itu sendiri.");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Graph recom = new Graph();
            recom.LoadFile("friend.txt");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            Queue<string> visited = new Queue<string>();
            visited.Enqueue("A");
            //recom.BFSSearch(queue, visited, "H");
            recom.Recommendation("A");
            recom.ExploreFriend("A", "H");


        }
    }

}
