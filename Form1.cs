using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Tree temp = new Tree();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadDictionary()
        {
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"E:\New folder\4th semester\DSA\DSA\spell corector\spell corector\WORDS.txt");
            while ((line = file.ReadLine()) != null)
            {
                temp.InsertData(line);
            }

            file.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDictionary();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (Search(temp.root, a)==true)
            {
                label4.Text = " Word Found";
            }
            else
            {
                label4.Text = "Word not Found";
            }

        }
        public bool Search(Node a, string x)
        {

            if (a == null)
                return false;
            if (string.Compare(x, a.data) == 0)
            {

                return true;

            }

            if (string.Compare(x, a.data) < 0)
                return Search(a.left, x);
            else
                return Search(a.right, x);
        }
    }
}
