using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.IEnumerable
{

    public static class IEnumarableExtension
    {
        public static decimal Sum<T>(this IEnumerable<T> collection)
        {
            decimal sum = 0;
            foreach (T element in collection)
            {
                sum += Convert.ToDecimal(element);
            }
            return sum;
                           
        }


        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            decimal product = 0;
            foreach (T element in collection) product *= Convert.ToDecimal(element);
            return product;

        }

       


        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.ElementAt(0);

            foreach (T element in collection)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.ElementAt(0);

            foreach (T element in collection)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }
            return max;
        }

        public static decimal Avg<T>(this IEnumerable<T> collection)
        {
            return collection.Sum<T>() / collection.Count<T>();
        }

    }
    class IEnumarable
    {
        static void Main(string[] args)
        {
            
            List<decimal> numbersIE = new List<decimal>();
            numbersIE.Add(4.3m);
            numbersIE.Add(5.2m);
            numbersIE.Add(1.3m);
            numbersIE.Add(-7.4m);
            numbersIE.Add(2.2m);
 
            Console.WriteLine("Sum: {0}", numbersIE.Sum());
            Console.WriteLine("Min: {0}", numbersIE.Min());
            Console.WriteLine("Max: {0}", numbersIE.Max());
            Console.WriteLine("Avg: {0}", numbersIE.Avg());
            Console.WriteLine("Product: {0}", numbersIE.Product());
        
        }
    }
}
