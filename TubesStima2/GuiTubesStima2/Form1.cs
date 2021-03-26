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

            List <Node> mutual = filenyeNiBos.Recommendation(akunMain, dfsChosen);
            if (mutual.Count != 0)
            {
                mutual.Sort((a, b) => b.edges.Count - a.edges.Count);
                richTextBox1.Text += "Daftar rekomendasi teman untuk akun " + akunMain + ":\n";
                foreach (var v in mutual)
                    if (v.edges.Count != 0)
                    {
                        richTextBox1.Text += "Nama akun : " + akunMain + "\n";
                        richTextBox1.Text += v.edges.Count + " mutual friends:\n";
                        foreach (var ed in v.edges)
                            richTextBox1.Text += ed;
                        richTextBox1.Text += "\n";
                    }
            }
            else
            {
                richTextBox1.Text = "Invalid Graph\n";
            }
            List<string> path = filenyeNiBos.ExploreFriend(akunMain, akunSecondary, dfsChosen);
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

            //richTextBox1.Text = "ini " + akunMain + " dan " + akunSecondary;
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        /*private void Form1_Load(object sender, EventArgs e)
{
   richTextBox1.Font = new Font("Consolas", 18f, FontStyle.Bold);
   richTextBox1.BackColor = Color.AliceBlue;
   string[] words =
   {
       "Dot",
       "Net",
       "Perls",
       "is",
       "a",
       "nice",
       "website."
   };
   Color[] colors =
   {
       Color.Aqua,
       Color.CadetBlue,
       Color.Cornsilk,
       Color.Gold,
       Color.HotPink,
       Color.Lavender,
       Color.Moccasin
   };
   for (int i = 0; i < words.Length; i++)
   {
       string word = words[i];
       Color color = colors[i];
       {
           richTextBox1.SelectionBackColor = color;
           richTextBox1.AppendText(word);
           richTextBox1.SelectionBackColor = Color.AliceBlue;
           richTextBox1.AppendText(" ");
       }
   }
}*/
    }
}