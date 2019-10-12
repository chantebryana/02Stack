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
            try
            {
                _obj.Add(obj);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("You donked: {0}", e);
                // CE I want this to throw exception if I pass null but it isn't
            }
        }

        public object Pop()
        {
            try
            {
                var last = _obj.Last<object>();
                _obj.Remove(last);
                return last;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("You donked: {0}", e);
                return _obj;
                // CE this exception does appear to work if I try to Pop on an empty list
            }
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

            Console.WriteLine(stack.Pop());
            stack.Push(1);
            stack.Push("abc");
            stack.Push(null);
            stack.Push(3);
            stack.Push(true);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
        }
    }
}
