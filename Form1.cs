using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Tree temp = new Tree();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadDictionary()
        {
            string[] words = File.ReadAllLines("WORDS.txt");
            foreach(string a in words)
            {
                temp.InsertData(a);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDictionary();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string WordSEARCh(Node node, string s)
        {
            if (node == null)
                return "not found";
            else if (s.CompareTo(node.data) < 0)
                return WordSEARCh(node.left, s);
            else if (s.CompareTo(node.data) > 0)
                return WordSEARCh(node.right, s);

            return "found";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = textBox1.Text;
            if(WordSEARCh(temp.root,test)=="found")

            {
                MessageBox.Show("Correct Word");
            }
            else
            {
                MessageBox.Show("not found");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
