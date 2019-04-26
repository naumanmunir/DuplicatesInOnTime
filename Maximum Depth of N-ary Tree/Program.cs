using References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Depth_of_N_ary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(1);
            n.children = new List<Node>();
            n.children.Add(new Node(3, new List<Node> { new Node(5), new Node(6) }));
            n.children.Add(new Node(2));
            n.children.Add(new Node(4));

            MaxDepth(n);

            Console.ReadLine();
        }

        static int MaxDepth(Node root)
        {

            if (root == null) return 0;

            int depth = 0;

            var visited = new HashSet<Node>();
            var stack = new Stack<Node>();

            stack.Push(root);
            
            while (stack.Count != 0)
            {
                var curr = stack.Pop();

                if (visited.Add(curr))
                {
                    if (curr.children != null)
                    {
                        foreach (var neighbour in curr.children)
                            stack.Push(neighbour);
                    }

                }

                depth++;
            }

            return depth;
        }
    }
}
