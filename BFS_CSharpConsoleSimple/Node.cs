using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_CSharpConsoleSimple
{
    public class Node
    {
        public Node left;
        public Node right;
        public String data;

        public Node( String data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public Node(String data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}
