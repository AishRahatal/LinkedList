using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class NodeFunctions
    {
        internal Node head;
        //Adding nodes to LinkedList
        internal void AddNode(int data)
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
        //Appending data to LinkedList
        internal void append(int data) // adding elements to last
        {
            Node appnode = new Node(data);

            // check base case, header is null.
            if (head == null)
            {
                head = appnode;

            }
            else
            {
                // loop until we find the end of the list
                while (head.next != null)
                {
                    head = head.next;

                }
                head.next = appnode;

            }
            // set the appnode  to the head.next, and next will be null.
            Console.WriteLine("Appended  " + appnode.data);

        }

        //Displaying data of nodes
        public void display()
        {

            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            else
            {
                Console.WriteLine(" LinkedList data :");
                while (head != null)
                {
                    Console.WriteLine("{0}", head.data);
                    head = head.next;

                }
            }
        }

        //Insering  between nodes
        internal void InsertNodeBetween(int data)
        {
            Node inNode = new Node(data);
            Node temp1 = head;
            if (temp1 == null)
            {
                temp1 = inNode;
            }
            else
            {
                Node temp = new Node(data);
                while (temp1.next != null)
                {
                    temp = temp1.next;
                    temp1.next = inNode;
                    temp1.next.next = temp;

                    temp1 = temp1.next;
                }
                Console.WriteLine(" Inserted node : " + inNode.data);

            }

        }

        //Deleting front node 56
        internal void DeletefNode()
        {

            if (head == null)
            {
                Console.WriteLine(" Cant perform delete operation ");

            }
            else
            {
                Node temp = head;
                head = head.next;
                temp = null;
                Console.WriteLine(" Deleted Front Node !! ");

                Console.WriteLine(" Current LinkedList: ");

                while (head != null)
                {
                    Console.WriteLine("{0}", head.data);
                    head = head.next;

                }

            }
        }
        //deleting last node 70
        internal void DeleteLNode()
        {

            if (head == null)
            {
                Console.WriteLine(" Cant perform delete operation ");

            }
            else
            {
                Node temp = new Node();
                temp = head;
                while (temp.next.next != null) //traversing to second last
                    temp = temp.next;

                // next nde of second last set null i.e last node
                Node lnode = temp.next;
                temp.next = null;
                lnode = null;

                Console.WriteLine(" Deleted Last Node !! ");

                Console.WriteLine(" Current LinkedList: ");

                while (head != null)
                {
                    Console.WriteLine("{0}", head.data);
                    head = head.next;

                }

            }
        }

        // Searching node 30
        internal void SearchNode(int data)
        {
            Node fnode = new Node(data);
            bool flag = true;

            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");

            }
            else
            {

                while (head.next == null)
                {

                    if (head == fnode)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {

                    Console.WriteLine("Found Node !!" + fnode.data);

                }
                else
                {
                    Console.WriteLine(" Node is not present in LinkedList");

                }
            }
        }
        //Inserting node 40 after 30
        internal void InsertNodeAfter(int data)
        {
            Node inNode = new Node(data);
            Node temp1 = head;
            if (temp1 == null)
            {
                temp1 = inNode;
            }
            else
            {
                Node temp = new Node(data);
                while (temp1.next != null)
                {
                    if (temp1.data == 30) // insering 40 after 30
                    {
                        temp = temp1.next;
                        temp1.next = inNode;
                        temp1.next.next = temp;
                        Console.WriteLine(" Inserted node : " + inNode.data);
                        break;
                    }
                    temp1 = temp1.next;
                }
            }

        }
        //deleting node 40 and counting size of list
        internal void Deletebetween(int data)
        {
            Node dnode = new Node(data);
            Node curr = new Node();
            Node prev = new Node();

            bool flag = true;

            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");

            }
            else
            {
                prev = head;
                while (head.next == null)
                {

                    if (head == dnode)
                    {
                        flag = true;
                        break;
                    }

                }
                curr = head.next;
                if (flag)
                {

                    prev.next = curr;
                    curr.next = curr.next.next;
                    Console.WriteLine(" Deleted  Node !! ");

                }
                else
                {
                    Console.WriteLine(" Node is not present in LinkedList");

                }
                Console.WriteLine("--------------------------");

                Console.WriteLine("  LinkedList After removing 40: ");
                int count = 0;
                while (head != null)
                {
                    Console.WriteLine("{0}", head.data);
                    head = head.next;
                    count++;
                }
                Console.WriteLine("--------------------------");

                Console.WriteLine("Size of LinkedList =" + count);
            }
        }
    }
}