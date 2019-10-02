using System;
using System.Collections.Generic;   // needed for List
using System.Linq;   // needed for Last();

namespace _02Stack
{
    class Stack
    {
        private List<int> _number;

        public Stack()
        {
            _number = new List<int>();
            // CE turn this into an <obj> list
        }

        public void Push(int num)
        {
            if (num == -1)  // temporarily -1 to make it work with int
            {
                Console.WriteLine("You donked: {0}", new InvalidOperationException());
            }
            else
            {
                _number.Add(num);
            }
            //CE create InvalidOperationException if pass null
        }

        public int Pop()
        {
            if (_number == null)
            {
                // this doesn't work:
                Console.WriteLine("You donked: {0}", new InvalidOperationException());
                return -1;
            }
            else
            {
                var last = _number.Last<int>();
                _number.Remove(last);
                return last;
            }
           
            //CE create InvalidOperationException if Pop is called on empty list
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

            Console.WriteLine(stack.Pop());  // this throws its own exception without me...
            stack.Push(1);
            stack.Push(-1);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //stack.Clear();
        }
    }
}
