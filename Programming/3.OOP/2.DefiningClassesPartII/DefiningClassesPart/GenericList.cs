using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClassesPartII
{
    public class GenericList<T>
    {
        const int capacity = 4;
        public T[] elements;
        private int count = 0;

        public GenericList()
        {
            elements = new T[capacity];
        }




        public int Count
        {
            get
            {
                return this.count;
            }
        }

       

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public void Add(T item)
        {
            InsertAt(Count, item);
        }
        public void InsertAt(int index, T item)
        {
            
            T[] newArr = elements;
            if (count == elements.Length)
            {
                newArr = new T[elements.Length * 2];
            }
            Array.Copy(elements, newArr, index);
            Array.Copy(elements, index, newArr, index + 1, Count - index - 1);
            newArr[index] = item;
            elements = newArr;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                result.Append(elements[i] + " ");
            }
            return result.ToString();
        }

        public T Min<T>(T first, T second)
        where T : IComparable<T>
        {
            dynamic min = elements.Min();
            if (first.CompareTo(second) <= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public  T Max<T>(T first, T second)
        where T : IComparable<T>
        {
            dynamic max = elements.Max();
            if ((first.CompareTo(second) >= 0))
            {
                return first;
            }
            else
            {
                return second;
            }
        }


    }
}
