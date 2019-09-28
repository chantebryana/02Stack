using System;

namespace _02Stack
{
    class Stack
    {
        private int number;

        public void Push()
        {
            Console.WriteLine("Push");
        }

        public void Pop()
        {
            Console.WriteLine("Pop");
        }

        public void Clear()
        {
            Console.WriteLine("Clear");
        }
    }

    class Program
    {
        static void Main()
        {
            var stack = new Stack();

            stack.Push();
            stack.Pop();
            stack.Clear();
        }
    }
}
