using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Breakthrough_Studios_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Hide();
            button4.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/Y3X5g4u");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.roblox.com/groups/6590206/Break-through-studios#!/about");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.roblox.com/games/5426365206/Applications");
        }

        private void comingSoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label1.Hide();
            label2.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            label3.Show();
            button4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            label1.Show();
            label2.Show();
            button1.Show();
            button2.Show();
            button3.Show();
            label3.Hide();
            button4.Hide();
        }
    }
}
