using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList!");
            Console.WriteLine("--------------------------------------------------------------------------");

            NodeFunctions obj1 = new NodeFunctions();

            int ch = 0;
            do
            {

                Console.WriteLine("***************************************************************");

                Console.WriteLine("\n \n\t\tMENU");

                Console.WriteLine("\n**************************************************************");
                Console.WriteLine("\n 1. Add Node ");
                Console.WriteLine("\n 2. Append Node");
                Console.WriteLine("\n 3. Insert Between Nodes");
                Console.WriteLine("\n 4. Delete front Node");
                Console.WriteLine("\n 5. Delete Last Node");
                Console.WriteLine("\n 6. Search Node");
                Console.WriteLine("\n 7. Insert After Node");
                Console.WriteLine("\n 8. Deleting in between Node");
                Console.WriteLine("\n 9. Sort LinkedList Node");
                Console.WriteLine("\n 10. Exit");

                Console.WriteLine("\n***************************************************************");

                Console.WriteLine("\n Enter choice from menu:");
                ch = Convert.ToInt32(Console.ReadLine());

                if (ch > 0)
                {
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("-------UC2--------------");

                            Console.WriteLine("Adding nodes to LinkedList:");

                            obj1.AddNode(70);
                            obj1.AddNode(30);
                            obj1.AddNode(56);
                            obj1.display();

                            Console.WriteLine("------------------------------------------------------");
                            break;

                        case 2:
                            Console.WriteLine("-----------------------------------------------------");
                            Console.WriteLine("-------UC3--------------");

                            Console.WriteLine("Appending nodes to LinkedList");
                            obj1.append(56);
                            obj1.append(30);
                            obj1.append(70);
                            obj1.display();
                            Console.WriteLine("-----------------------------------------------------");

                            break;

                        case 3:
                            Console.WriteLine("-----------------------------------------------------");
                            Console.WriteLine("-------UC4--------------");
                            Console.WriteLine("Inserting between nodes to LinkedList");
                            obj1.AddNode(56);
                            obj1.AddNode(70);

                            //obj1.display();
                            obj1.InsertNodeBetween(30);
                            Console.WriteLine("After Inserting:");
                            obj1.display();
                            Console.WriteLine("-----------------------------------------------------");

                            break;
                        case 4:
                            Console.WriteLine("----------------------------------------------------");

                            Console.WriteLine("---------UC5--------------");

                            Console.WriteLine("Deleting front node from LinkedList:");
                            obj1.AddNode(56);
                            obj1.AddNode(30);
                            obj1.AddNode(70);
                            Console.WriteLine("--------");

                            obj1.DeletefNode(); // deleting 56
                            Console.WriteLine("---------------------------------------------------");

                            break;
                        case 5:
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("-------UC6--------------");

                            Console.WriteLine("Deleting  last node from LinkedList:");
                            obj1.AddNode(56);
                            obj1.AddNode(30);
                            obj1.AddNode(70);
                            Console.WriteLine("--------");

                            obj1.DeleteLNode(); // deleting 70

                            Console.WriteLine("---------------------------------------------------");

                            break;
                        case 6:
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("-------UC7--------------");

                            Console.WriteLine("Finding node 30 from LinkedList:");
                            obj1.AddNode(56);
                            obj1.AddNode(30);
                            obj1.AddNode(70);
                            Console.WriteLine("--------");

                            obj1.SearchNode(30); // finding 30
                            Console.WriteLine("---------------------------------------------------");
                            break;
                        case 7:
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("-------UC8--------------");
                            Console.WriteLine("Inserting Node 40 after 30 from LinkedList:");

                            obj1.AddNode(56);
                            obj1.AddNode(30);
                            obj1.AddNode(70);
                            Console.WriteLine("--------");

                            obj1.InsertNodeAfter(40);
                            Console.WriteLine("--------");
                            obj1.display();
                            Console.WriteLine("---------------------------------------------------");
                            break;
                        case 8:
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("-------UC9--------------");

                            Console.WriteLine("Deleting 40 from LinkedList:");
                            obj1.AddNode(56);
                            obj1.AddNode(30);
                            obj1.AddNode(40);
                            obj1.AddNode(70);
                            Console.WriteLine("--------");
                            obj1.Deletebetween(40);
                            Console.WriteLine("---------------------------------------------------");
                            break;
                        case 9:
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine(" Sort LinkedList:");
                            SortList s = new SortList();
                            Console.WriteLine(" Before Sort LinkedList:");
                            s.AddNode(56);
                            s.AddNode(30);
                            s.AddNode(40);
                            s.AddNode(70);

                            Console.WriteLine("-----------------------");
                            Console.WriteLine(" After Sort LinkedList:");

                            s.sort();
                            Console.WriteLine("---------------------------------------------------");

                            break;

                        case 10:
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Thank you!, Exiting ..");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("\n Invalid choice");

                }

            } while (ch != 10);

            Console.ReadKey();

        }
    }
}