
namespace GuiTubesStima2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.account1 = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.account2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bfsButton = new System.Windows.Forms.RadioButton();
            this.dfsButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFilename = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.visualisasiGraph = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1740, 94);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(1026, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "connecting people";
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logo.ForeColor = System.Drawing.Color.Navy;
            this.logo.Location = new System.Drawing.Point(23, 15);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(207, 55);
            this.logo.TabIndex = 1;
            this.logo.Text = "C!RCLE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.visualisasiGraph);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1699, 703);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(578, 134);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(703, 351);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Khaki;
            this.panel5.Controls.Add(this.account1);
            this.panel5.Controls.Add(this.Submit);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.account2);
            this.panel5.Location = new System.Drawing.Point(707, 30);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(574, 83);
            this.panel5.TabIndex = 7;
            // 
            // account1
            // 
            this.account1.Location = new System.Drawing.Point(222, 17);
            this.account1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(133, 23);
            this.account1.TabIndex = 5;
            this.account1.TextChanged += new System.EventHandler(this.account1_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(413, 19);
            this.Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(133, 50);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(23, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Explore Friends with  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose Account          :";
            // 
            // account2
            // 
            this.account2.Location = new System.Drawing.Point(222, 48);
            this.account2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.account2.Name = "account2";
            this.account2.Size = new System.Drawing.Size(133, 23);
            this.account2.TabIndex = 8;
            this.account2.TextChanged += new System.EventHandler(this.account2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 350);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Controls.Add(this.bfsButton);
            this.panel4.Controls.Add(this.dfsButton);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(386, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 83);
            this.panel4.TabIndex = 5;
            // 
            // bfsButton
            // 
            this.bfsButton.AutoSize = true;
            this.bfsButton.Location = new System.Drawing.Point(178, 46);
            this.bfsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bfsButton.Name = "bfsButton";
            this.bfsButton.Size = new System.Drawing.Size(44, 19);
            this.bfsButton.TabIndex = 2;
            this.bfsButton.TabStop = true;
            this.bfsButton.Text = "BFS";
            this.bfsButton.UseVisualStyleBackColor = true;
            this.bfsButton.CheckedChanged += new System.EventHandler(this.bfsButton_CheckedChanged);
            // 
            // dfsButton
            // 
            this.dfsButton.AutoSize = true;
            this.dfsButton.Location = new System.Drawing.Point(55, 46);
            this.dfsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dfsButton.Name = "dfsButton";
            this.dfsButton.Size = new System.Drawing.Size(45, 19);
            this.dfsButton.TabIndex = 1;
            this.dfsButton.TabStop = true;
            this.dfsButton.Text = "DFS";
            this.dfsButton.UseVisualStyleBackColor = true;
            this.dfsButton.CheckedChanged += new System.EventHandler(this.dfsButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(96, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Algorithm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labelFilename);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.buttonBrowse);
            this.panel3.Location = new System.Drawing.Point(23, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 83);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filename     :";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilename.Location = new System.Drawing.Point(151, 47);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(18, 20);
            this.labelFilename.TabIndex = 3;
            this.labelFilename.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(21, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Graph File   :";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(151, 16);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(82, 22);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // 
            // visualisasiGraph
            // 
            this.visualisasiGraph.Location = new System.Drawing.Point(23, 134);
            this.visualisasiGraph.Name = "visualisasiGraph";
            this.visualisasiGraph.Size = new System.Drawing.Size(533, 339);
            this.visualisasiGraph.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton bfsButton;
        private System.Windows.Forms.RadioButton dfsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox account1;
        private System.Windows.Forms.TextBox account2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel visualisasiGraph;
    }
}

