using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Stackdemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("test");
            stack.Push(3.14);
            Console.WriteLine("Items in stack");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("top of the item in stack is" + stack.Peek());

            stack.Pop();
            Console.WriteLine("Items in stack after pop:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Test is there in the stack or not" + stack.Contains("test"));
            Console.WriteLine("Total item in the stack" + stack.Count);
            stack.Clear();
            Console.WriteLine("Total item in the stack" + stack.Count);
            Console.ReadLine();
        }
    }
}

    

