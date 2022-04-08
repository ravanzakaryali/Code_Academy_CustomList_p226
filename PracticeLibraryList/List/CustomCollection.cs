using Exceptions.CustomExceptions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeLibraryList.List
{
    public class CustomCollection<T> : IEnumerable<T>
    {
        private T[] _storage;
        public int Count { get; set; }
        public T this[int index]
        {
            get {

                if (index < Count)
                {
                    return _storage[index]; 
                }
                throw new CustomOutOfRangeException("Out of range");
            }
            set {
                if (index < Count)
                {
                    _storage[index] = value;
                }
                throw new CustomOutOfRangeException("Out of range");
            }
        }
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value < 1)
                {
                    throw new RangeException("value");
                }
                _capacity = value;
            }
        }
        public CustomCollection() : this(2)
        {

        }
        public CustomCollection(int newCapasity)
        {
            Capacity = newCapasity;
            _storage = new T[newCapasity];
        }
        public void Add(T item)
        {
            if(Count == Capacity)
            {
                Resize();
            }
            _storage[Count] = item;
            Count++;
        }
        public void Resize()
        {
            T[] resizedList = new T[Capacity + 10];
            for (int i = 0; i < Capacity; i++)
            {
                resizedList[i] = _storage[i];
            }
            _storage = resizedList;
            Capacity += 10;
        }
        public void Insert(int index, T item)
        {
            if (Count == Capacity)
                Resize();
            for (int i = Count - 1; i >= 0; i--)
            {
                _storage[i] = _storage[i - 1];
            }
            _storage[index] = item;
            Count++;
        }
        public void Clear()
        {
            _storage = new T[Capacity];
            Count = 0;
        } 
        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if(_storage[i].Equals(item))
                    return i;
            }
            return -1;
        }
        public int LastIndexOf(T item)
        {
            for (int i = Count -1 ; i >= 0; i--)
            {
               if(_storage[i].Equals(item))
                    return i;

            }
            return -1;
        }
       
        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if(_storage[i].Equals(item))
                    return true;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
