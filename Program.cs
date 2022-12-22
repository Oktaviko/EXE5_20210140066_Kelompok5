using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140066_Kelompok5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class Queue
    {
        Node Okta, Pratama;
        public Queue()
        {
            Okta = null;
            Pratama = null;
        }
        public void insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukkan Element");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (Okta == null)
            {
                Okta = newnode;
                Pratama = newnode;
                return;
            }
            Pratama.next = newnode;
            Pratama = newnode;
        }
        public void delete()
        {
            if (Okta == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Okta = Okta.next;
            if (Okta == null)
                Pratama = null;
        }
        public void display()
        {
            if ( Okta == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return ;
            }
            Node display;
            for (display = Okta; display != null; display = display.next)
                Console.WriteLine(display.name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while(true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                q.insert();
                            }
                            break;
                        case '2':
                            {
                                q.delete();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return ;
                        default:
                            {
                                Console.WriteLine("Invalid Option");
                            }
                            break ;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }

        }
    }
}
