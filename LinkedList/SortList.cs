using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class SortList
    {
        internal Node head;
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
            Console.WriteLine("{0} Node Inserted :", newnode.data);

        }

        //Sorting List in increasing order
        internal void sort()
        {
            int count = 0;
            Node i = new Node();
            Node j = new Node();
            Console.WriteLine("-----------------------");

            i = j = head;
            while (i != null)
            {
                while (j.next != null)
                {
                    if (j.data > j.next.data)
                    {
                        int temp = j.data;
                        j.data = j.next.data;
                        j.next.data = temp;
                    }
                    j = j.next;
                }
                j = head;
                i = i.next;
            }
            Console.WriteLine("Sorted LinkedList ");
            while (head != null)
            {
                Console.WriteLine("{0}", head.data);
                count++;
                head = head.next;

            }

        }

    }
}