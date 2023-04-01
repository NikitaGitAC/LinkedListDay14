using System.Collections.Generic;

namespace Linkedlist
{
    class Program
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Welcom to the Linked List Program");

            linkedlist linkedList = new linkedlist();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
        }
    }
}