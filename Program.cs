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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
