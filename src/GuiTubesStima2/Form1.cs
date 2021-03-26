using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiTubesStima2
{
    public partial class Form1 : Form
    {
        string iniNamaFile;

        public Form1()
        {
            InitializeComponent();
        }
        public void LoadFileVis(string filename, Microsoft.Msagl.Drawing.Graph graph, List<string> path)
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
                int x;
                for (x=0; x<path.Count-1; x++)
                {
                    if((node1==path[x] && node2 == path[(x + 1)])|| (node2 == path[x] && node1 == path[(x + 1)]))
                    {
                        break;
                    }
                }
                if (x == path.Count-1)
                {
                    graph.AddEdge(node1, node2);
                }
                else
                {
                    graph.AddEdge(node1, node2).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                graph.FindNode(node1).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
                graph.FindNode(node2).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            }
        }
        public void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:";
            openFileDialog1.Title = "Open file";
            openFileDialog1.ShowDialog();

            iniNamaFile = System.IO.Path.GetFileName(openFileDialog1.FileName);

            labelFilename.Text = iniNamaFile;

            //richTextBox1.Text = filenyeNiBos;
        }   

        public void dfsButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void bfsButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void account1_TextChanged(object sender, EventArgs e)
        {

        }

        private void account2_TextChanged(object sender, EventArgs e)
        {

        }

        public void Submit_Click(object sender, EventArgs e)
        {
            visualisasiGraph.Controls.Clear();
            richTextBox1.Clear();
            string akunMain = account1.Text;
            string akunSecondary = account2.Text;
            //string hasilRecommendation;
            //string hasilExploreFriends;
            bool dfsChosen;
            Graph filenyeNiBos = new Graph();
            filenyeNiBos.LoadFile(iniNamaFile);
            
            if (dfsButton.Checked)
            {
                dfsChosen = true;

            }

            else //(bfsButton.Checked)
            {
                dfsChosen = false;
            }
            List<Node> mutual = new List<Node>();
            mutual = filenyeNiBos.Recommendation(akunMain, dfsChosen);
            if (mutual.Count != 0)
            {
                mutual.Sort((a, b) => b.edges.Count - a.edges.Count);
                richTextBox1.Text += "Daftar rekomendasi teman untuk akun " + akunMain + ":\n";
                foreach (var v in mutual)
                    if (v.edges.Count != 0)
                    {
                        richTextBox1.Text += "Nama akun : " + v.name + "\n";
                        richTextBox1.Text += v.edges.Count + " mutual friends:\n";
                        foreach (var ed in v.edges)
                            richTextBox1.Text += ed +"\n";
                        richTextBox1.Text += "\n";
                    }
            }
            else
            {
                richTextBox1.Text = "Invalid Graph\n";
            }
            List<string> path = new List<string>();
            path = filenyeNiBos.ExploreFriend(akunMain, akunSecondary, dfsChosen);
            richTextBox1.Text += "Nama Akun: " + akunMain + " dan " + akunSecondary +"\n";
            if (path.Count != 0)
            {
                richTextBox1.Text += "(";
                int i;
                for (i = path.Count - 1; i > 0; i--)
                {
                    richTextBox1.Text += path[i] + "->";
                }
                richTextBox1.Text += path[i] + ", " + (path.Count - 2).ToString();
                if (path.Count - 2 == 1)
                {
                    richTextBox1.Text += "st";
                }
                else if (path.Count - 2 == 2)
                {
                    richTextBox1.Text += "nd";
                }
                else if (path.Count - 2 == 3)
                {
                    richTextBox1.Text += "rd";
                }
                else
                {
                    richTextBox1.Text += "th";
                }
                richTextBox1.Text += " Degree)\n";
            }
            else
            {
                richTextBox1.Text += "Tidak ada jalur koneksi yang tersedia";
                richTextBox1.Text += "Anda harus memulai koneksi baru itu sendiri.";
            }
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            LoadFileVis(iniNamaFile, graph, path);
            viewer.Graph = graph;
            visualisasiGraph.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            visualisasiGraph.Controls.Add(viewer);
            viewer.ResumeLayout();

            //richTextBox1.Text = "ini " + akunMain + " dan " + akunSecondary;
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}