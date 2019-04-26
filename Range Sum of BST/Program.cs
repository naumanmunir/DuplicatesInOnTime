using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Sum_of_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tn = new TreeNode(10);
            tn.left = new TreeNode(5);
            tn.right = new TreeNode(15);
            tn.right.right = new TreeNode(18);
            tn.left.left = new TreeNode(3);
            tn.left.right = new TreeNode(7);

            var sum = RangeSumBST(tn, 7, 15);
        }

        static int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;

            var curr = root;

            Stack<TreeNode> stack = new Stack<TreeNode>();

            while (curr != null || stack.Count > 0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;

                }

                curr = stack.Pop();

                if (curr.val >= L && curr.val <= R)
                    sum += curr.val;

                curr = curr.right;

            }

            return sum;
        }

        static int RangeSumBST(TreeNode root, int L, int R, int sum)
        {
            if (root == null) return 0;

            RangeSumBST(root.left, L, R, sum);
            if (root.val >= L && root.val <= R)
                sum += root.val;
            RangeSumBST(root.right, L, R, sum);

            return sum;
        }
    }
}
