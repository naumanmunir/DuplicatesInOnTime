using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Depth
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tn = new TreeNode(3);
            tn.left = new TreeNode(9);
            tn.right = new TreeNode(20);
            tn.right.left = new TreeNode(15);
            tn.right.right = new TreeNode(7);
            tn.right.right.left = new TreeNode(5);

            Console.WriteLine(MaxDepth(tn));

            Console.ReadLine();
        }

        static public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            return (MaxDepth(root.left) + 1) + (MaxDepth(root.right) + 1);
        }

    }
}
