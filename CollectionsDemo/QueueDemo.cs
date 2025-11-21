using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Anvith");
            queue.Enqueue(45.67);
            queue.Enqueue(true);
            queue.Enqueue('A');

            foreach (Object item in queue)
            {
                Console.WriteLine(item + " ");
            }

            queue.Dequeue();
            Console.WriteLine("After dequeue()" + queue.Count);
            Console.WriteLine("Top item in queue " + queue.Peek());
            Console.ReadLine();


        }
    }
}
    

