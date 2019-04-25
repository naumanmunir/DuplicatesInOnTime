using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    public class Graph
    {
        public Node Head;

        public Graph()
        {

        }

        public void AddEdge(Node n)
        {

        }
    }

    public class Node
    {
        public int Value { get; set; }
        public List<Node> children { get; set; }

        public Node(int val)
        {
            Value = val;

        }

        public Node(int val, List<Node> childs)
        {
            Value = val;
            children = childs;
        }
    }
}
