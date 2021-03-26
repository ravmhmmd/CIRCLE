using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiTubesStima2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*Graph recom = new Graph();
            recom.LoadFile("friend.txt");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            Queue<string> visited = new Queue<string>();
            visited.Enqueue("A");
            //recom.BFSSearch(queue, visited, "H");
            recom.Recommendation("A");
            recom.ExploreFriend("A", "H");*/
        }
    }
}
