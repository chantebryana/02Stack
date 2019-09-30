using System;
using System.Collections.Generic;   // needed for List
using System.Linq;   // needed for Last();

namespace _02Stack
{
    class Stack
    {
        private List<int> _number;

        public void Push(int num)
        {
            _number.Add(num);
        }

        public int Pop()
        {
            var last = _number.Last<int>();
            _number.Remove(last);
            return last;
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

            var numbers = new List<int>();
            void print(List<int> num)
            {
                num.ForEach(i => Console.WriteLine("{0}\t", i));
                Console.WriteLine("\n");
            }
            numbers.Add(1);
            print(numbers);
            numbers.Add(2);
            print(numbers);
            numbers.Add(3);
            print(numbers);
            var lastItem = numbers.Last<int>();
            Console.WriteLine(lastItem);

            numbers.Remove(3);
            print(numbers);
            numbers.Remove(2);
            print(numbers);
            numbers.Remove(1);
            print(numbers);

        }
    }
}
