using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuffmanForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tree huffman;
        string input = "";
        private void btnPakkaa_Click(object sender, EventArgs e)
        {
            input = tbInput.Text;
            labelInput.Text = input;
            huffman = new Tree();
            huffman.Build(input);
            List<string> paths = huffman.CreatePath(input);
            foreach (string item in paths)
            {
                listBox1.Items.Add(item);
            }
            Dictionary<char, int> letters = huffman.GetLetters();
            foreach (KeyValuePair<char, int> item in letters)
            {
                string bits = huffman.FindLetter(item.Key);
                string letter = item.Key + ", " + item.Value.ToString() + " kpl : " + bits;
                listBox2.Items.Add(letter);
            }
            tbInput.Text = "";
            input = "";

        }

        private void btnPura_Click(object sender, EventArgs e)
        {
            List<string> paths = new List<string>();
            foreach (string item in listBox1.Items)
            {
                paths.Add(item);
            }
            string followed = huffman.FollowPath(paths);
            tbOutput.Text = followed;
        }

        private void btnTyhjää_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            tbInput.Text = "";
            tbOutput.Text = "";
            huffman = new Tree();
            input = "";
            labelInput.Text = "Input";
        }
    }
}
