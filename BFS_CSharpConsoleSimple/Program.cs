using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BFS_CSharpConsoleSimple
{
    class Program
    {
        static Node InitialTree()
        {
            Node root = new Node("A",
                new Node("B",
                    new Node("C"), new Node("D")),
                new Node("E",
                    new Node("F"), new Node("G", 
                                    new Node("H"), null)));

            return root;
        }

        static void Main(string[] args)
        {
            Node tree = InitialTree();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BFS is --> ");
            TraversialBFS(tree);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DFS is --> ");
            TraversialDFS(tree);

            Console.ReadLine();
        }

        private static void TraversialDFS(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.data + " ");
            TraversialDFS(node.left);
            TraversialDFS(node.right);

            //Thread.Sleep(2000);
        }

        private static void TraversialBFS(Node node)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while(queue.Count > 0)
            {
                node = queue.Dequeue();
                Console.Write(node.data + " ");

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);

                //Thread.Sleep(2000);
            }
        }
    }
}
