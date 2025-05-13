namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Node
    {
        public int d;
        public Node Right;
        public Node Left;
        public Node(int x)
        {
            d = x;
            Right = null;
            Left = null;
        }
    }
    public class BST(Node? node)
    {
        public Node? root = node;
        public bool Search(int n, Node? node = null)
        {
            if (node == null) return false;
            else if (node.d == n) return true;
            else
            {
                if (node.d > n) return Search(n, node.Left);
                else return Search(n, node.Right);
            }
        }
        public void Add(int x, ref Node? r)
        {
            if (r == null)
            {
                r = new Node(x);
                return;
            }
            if (x < r.d) Add(x, ref r.Left);
            else if (x > r.d) Add(x, ref r.Right);
        }
    }
}
