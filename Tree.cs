using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Node
    {
        public string data { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }

        public Node()
        {
            data = "";
            left = null;
            right = null;
        }
        public Node(string s)
        {
            this.data = s;
        }

    }
    public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public void InsertData(string data)
        {
            if (root == null)
            {
                root = new Node(data);
                return;
            }
            Insertatchild(root, new Node(data));
        }
        private void Insertatchild(Node root, Node temp)
        {
            if (root == null)
            {
                root = temp;
            }
            if (string.Compare(temp.data, root.data) < 0)
            {
                if (root.left == null)
                {
                    root.left = temp;
                }
                else
                {
                    Insertatchild(root.left, temp);
                }
            }
            else
            {
                if (root.right == null)
                {
                    root.right = temp;
                }
                else
                {
                    Insertatchild(root.right, temp);
                }
            }
        }

    }
}
