using System.Collections.Generic;

namespace Linkedlist
{
    class Program
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Welcom to the Linked List Program");

            linkedlist linkedList = new linkedlist();
            linkedList.Add(70);
            Console.WriteLine("Node with data 70 is First created ");
            Console.WriteLine("------------------------------------ ");

            linkedList.Add(30);
            Console.WriteLine("Next 30 is added to 70 ");
            Console.WriteLine("------------------------------------ ");

            linkedList.Add(56);
            Console.WriteLine("Finally56 is added to 30");
            Console.WriteLine("------------------------------------ ");

            Console.WriteLine("LinkedList Sequence: 56->30->70");
        }
    }
}