using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leaf_Similar_Trees
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode tn = new TreeNode(1);
            tn.left = new TreeNode(2);
            tn.right = new TreeNode(3);

            TreeNode tn2 = new TreeNode(1);
            tn2.left = new TreeNode(3);
            tn2.right = new TreeNode(2);
            //tn.left = new TreeNode(5);
            //tn.left.left = new TreeNode(6);
            //tn.left.right = new TreeNode(2);
            //tn.left.right.left = new TreeNode(7);
            //tn.left.right.right = new TreeNode(4);
            //tn.right = new TreeNode(1);
            //tn.right.left = new TreeNode(9);
            //tn.right.right = new TreeNode(8);




            var res = LeafSimilar(tn, tn2);
            Console.ReadLine();
        }
         
        static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            if (root1 == null || root2 == null) return false;

            var l1 = DFSSearch(root1, new List<int>());
            var l2 = DFSSearch(root2, new List<int>());

            var res = l1.SequenceEqual(l2);

            if (l1.Count == l2.Count)
            {
                return l1.All(l2.Contains);
            }
            else
                return false;
        }

        static List<int> DFSSearch(TreeNode root1, List<int> leafs)
        {
            if (root1 == null) return leafs;
            if (root1.left == null && root1.right == null)
            {
                leafs.Add(root1.val);
                return leafs;
            }

            DFSSearch(root1.left, leafs);
            DFSSearch(root1.right, leafs);

            return leafs;
        }
    }
}
