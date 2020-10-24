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
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;
            label2.ForeColor = colorDialog1.Color;
            button1.ForeColor = colorDialog1.Color;
            button2.ForeColor = colorDialog1.Color;
            button3.ForeColor = colorDialog1.Color;
            button4.ForeColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://breakthrough-studios.webflow.io");
        }

        private void changeTextFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
