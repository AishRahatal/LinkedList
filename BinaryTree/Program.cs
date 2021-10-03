using System;
using static BinaryTree.Tree;

namespace BinaryTree
{
    class Program
    {
       
        static void Main(string[] args)
        {
       
            Console.WriteLine("Binary Tree :");
            Console.WriteLine("--------------------------");

            Tree t = new Tree();
            t.insert( 56);
            t.insert(30);
            t.insert(70);
            t.insert(22);
            t.insert(40);
            t.insert(60);
            t.insert(95);
            t.insert(11);
            t.insert(65);
            t.insert(3);
            t.insert(16);
            t.insert(63);
            t.insert(67);

            Console.WriteLine("----------------------------");
            Console.WriteLine("Finding node 63: \n");

           t.SearchNode(63);
            
            Console.WriteLine("----------------------------");

         


            

        }
    }
}
