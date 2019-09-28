using System;

namespace _02Stack
{
    class Stack
    {
        private int _number;

        public void Push(int num)
        {
            _number = num;
        }

        public int Pop()
        {
            return _number;
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

            stack.Push(1);
            Console.WriteLine(stack.Pop());
            stack.Clear();
        }
    }
}
