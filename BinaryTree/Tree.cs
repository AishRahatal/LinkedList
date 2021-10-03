using System;

namespace BinaryTree
{

    class Tree
    {

        public class Node
        {
            public Node Left;
            public int data;

            public Node Right;

        }
        public Node root;
        public Tree()
        {
            root = null;
        }
        public void insert(int data)
        {
            Node newnode = new Node();
            newnode.data = data;

            if (root == null)
            {
                root = newnode;
                root.data = newnode.data;
                Console.WriteLine(" Inserted to root :" + root.data);
            }
            else
            {
                Node parent = root;
                if (parent.data > newnode.data)
                {
                    root.Left = newnode;
                    Console.WriteLine(" Inserted to left :" + parent.Left.data);

                }
                else
                {
                    if (parent.data < newnode.data)
                    {
                        root.Right = newnode;
                        Console.WriteLine(" Inserted to right:" + parent.Right.data);
                        Console.WriteLine("\n");

                    }
                }
            }
        }

        

        public void SearchNode(int key)
        {

            int depth = 0;
            Node temp = new Node();
            temp = root;

            while (temp != null)
            {
                depth++;
                if (temp.data == key)
                {
                    Console.WriteLine("\nData found at depth: " + depth);
                    return;
                }
                else
                {
                    if (temp.data > key)
                    {
                        
                        Console.WriteLine("\nData found at Left depth: " + depth);
                        break;
                        
                    }
                    else
                    {
                        temp = temp.Right;
                        
                        Console.WriteLine("\nData found at right depth: " + depth);
                        break;
                        
                    }

                }

            }
            return ;
        }
    }
}












