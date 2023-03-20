using System;
using System.Collections;
using System.Collections.Generic;

namespace Wintellect.PowerCollections
{
    public class Stack<T> : IEnumerable<T>
    {
        private readonly T[] _memory;
        private int index;

        public int Count
        {
            get { return index + 1; }
        }
        public int Capacity
        {
            get { return _memory.Length; }
        }

        public bool IsEmpty
        {
            get { return Count == 0; }
        }

        public bool IsFull
        {
            get { return Count == Capacity; }
        }

        public Stack(int size = 100)
        {
            _memory = new T[size];
            index = -1;
        }public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            return _memory[index--];
        }

        public void Push(T item)
        {
            if (IsFull)
                throw new InvalidOperationException("Stack full");
            _memory[++index] = item;
        }

        public T Top()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            return _memory[Count];
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
        public IEnumerator GetEnumerator()
        {
            return new StackEnumerator<T>(_memory, Count);
        }
    }

    class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] array;
        private int pos;
        private readonly int capasity;
        public T Current
        {
            get
            {
                return array[pos];
            }
        }
        object IEnumerator.Current => Current!;

        public StackEnumerator(T[] array, int capasity)
        {
            this.array = array;
            this.capasity = capasity;
            pos = capasity;
        }

        public bool MoveNext()
        {
            pos--;
            return pos > -1;
        }

        public void Reset() => pos = capasity;
        public void Dispose() { }
    }
}