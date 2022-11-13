using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes5_2
{
    public class MyStack<T>
    {
        T[] _stack;

        public MyStack()
        {
            _stack = new T[0];
        }
        public void Add(T item)
        {
            var newArray = new T[_stack.Length + 1];
            _stack.CopyTo(newArray, 0);
            newArray[_stack.Length] = item;
            _stack = newArray;
        }
        public T Peek()
        {
            if (_stack.Length > 0)
            {
                return _stack[_stack.Length - 1];
            }
            else return default;
        }
        public T Remove()
        {
            var result = Peek();

            if (_stack.Length == 0)
            {
                return result;
            }
            var newArray = new T[_stack.Length-1];
            for (var i = 0; i < _stack.Length-1; i++)
            {
                newArray[i] = _stack[i];

            }
            _stack = newArray;
            return result;
        }
    }
}
