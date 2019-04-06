using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bst = new BST();

            Node n = new Node(5);
            Node n1 = new Node(3);
            Node n2 = new Node(8);
            Node n3 = new Node(1);

            bst.Add(n);
            bst.Add(n1);
            bst.Add(n2);
            bst.Add(n3);
        }
    }

    public class BST
    {
        public Node Top { get; set; }

        public void Add(Node n)
        {
            if (Top == null)
            {
                Top = n;
            }

            var curr = Top;

            while (curr != null)
            {
                if (n.Data <= curr.Data)
                {
                    curr = curr.Left;
                }
                else
                {
                    curr = curr.Right;
                }
            }

            curr.Left = n;
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }
}
