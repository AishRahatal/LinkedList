using System;

namespace Stack
{
    class StackOperations
    {
        internal Node top = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Program!");
            StackOperations s = new StackOperations();

            s.push(70);
            s.push(30);
            s.push(56);

            Console.WriteLine(" ------------------------");
            s.peek();
            Console.WriteLine(" ------------------------");
            s.pop();

        }

        //Adding node to stack
        internal void push(int data)
        {
            Node newnode = new Node(data);
            // top = newnode;

            newnode.next = top;
            top = newnode;
            Console.WriteLine(top.data + "  :Pushed in to stack");

        }
        // Retrving top node of stack
        internal void peek()
        {
            if (top == null)
            {
                Console.WriteLine(" Stack is Empty!");

            }
            else
            {
                Console.WriteLine("Top node of stack " + top.data);
            }

        }
        // Removing node from stack
        internal void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            while (top != null)
            {
                Console.WriteLine(" Popped  Node !! " + top.data);

                top = top.next;

            }
            Console.WriteLine(" ------------------------");

            Console.WriteLine(" Stack: ");

            if (top == null)
            {
                Console.WriteLine("Stack is empty");

            }

        }

    }
}