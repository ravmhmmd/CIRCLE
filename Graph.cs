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
            }
        }
    }

}