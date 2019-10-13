using System;
using System.Collections.Generic;   // needed for List
using System.Linq;   // needed for Last();

namespace _02Stack
{
    class Stack
    {
        private List<object> _obj;

        public Stack()
        {
            _obj = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new System.InvalidOperationException("Stack cannot push null");
            }
            _obj.Add(obj);
        }

        public object Pop()
        {
            var last = _obj.Last<object>();
            _obj.Remove(last);
            return last;
        }

        public void Clear()
        {
            Console.WriteLine("Count: {0}", _obj.Count);
            _obj.Clear();
            Console.WriteLine("List cleared.");
            Console.WriteLine("Count: {0}", _obj.Count);
        }
    }

    class Program
    {
        static void Main()
        {
            var stack = new Stack();

            stack.Clear();
            try
            {
                Console.WriteLine(stack.Pop());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Can't pop an empty list: {0}", e);
            }

            stack.Push(1);
            stack.Push("abc");
            try
            {
                stack.Push(null);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Can't push a null object into the list: {0}", e);
            }
            stack.Push(3);
            stack.Push(true);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
        }
    }
}
