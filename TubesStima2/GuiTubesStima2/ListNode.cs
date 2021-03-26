using System;
using System.Collections.Generic;
using System.Text;

namespace GuiTubesStima2
{
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
        /*public void PrintListNode()
        {
            if (edgeList.Count != 0)
            {
                foreach (var v in edgeList)
                    v.PrintEdge();
            }
        }*/
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
        /*public void PrintPath(List<string> path)
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
        }*/
    }
}
