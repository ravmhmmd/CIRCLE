using System;
using System.Collections.Generic;
using System.Text;

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
}
