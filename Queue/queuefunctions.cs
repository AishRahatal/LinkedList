using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class queuefunctions
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Queue Program!");
            queuefunctions q = new queuefunctions();
            q.enqueue(56);
            q.enqueue(30);
            q.enqueue(70);
            Console.WriteLine(" ------------------------");

            q.dequeue();

            Console.WriteLine(" ------------------------");
        }
        
        internal Node head;
        
        //Adding Node to queue
        internal void enqueue(int data)
        {
            Node newnode = new Node(data);

            if (head == null)
            {
                head = newnode;
            }
            else
            {

                Node temp = new Node(data);
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newnode;

            }
            Console.WriteLine("{0} added into the linked list", newnode.data);
        }


        //Removing node from queue 
        internal void dequeue()
        {
            
            if (head == null)
            {
                Console.WriteLine(" Cant perform delete operation ");
            }
            else
            {
                while (head != null)
                {
                    Node temp = head;
                    Console.WriteLine(" Dequeue  Node !! " + temp.data);

                    head = head.next;
                    temp = null;
                }
                Console.WriteLine(" ------------------------");

                Console.WriteLine(" Queue: ");

                if(head== null)
                {
                    Console.WriteLine("Queue is empty");

                }
            }
        }

    }
 }

   
   


