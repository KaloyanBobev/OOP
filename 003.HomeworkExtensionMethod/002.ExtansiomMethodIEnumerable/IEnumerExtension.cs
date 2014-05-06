//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public static class IEnumerExtension
    {
        public static decimal Sum<T>(this IEnumerable<T> collection)
        {
            if (collection.Count()==0)
            {
                throw new ArgumentException("No element in list");
            }
            dynamic sum = collection.First(); 
            foreach (var item in collection.Skip(1))
            {
                sum += Convert.ToDecimal(item);
            }
            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            if (collection.Count()==0)
            {
                throw new ArgumentException("No element in list");
            }
            dynamic sum = collection.First();
            foreach (var item in collection.Skip(1))
            {
                sum *= Convert.ToDecimal(item);
            }
            return sum;
        }

        public static decimal Minimum<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("No element in list");
            }
            decimal minimum = decimal.MaxValue;
            foreach (var item in collection)
            {
                if (Convert.ToDecimal(item)<minimum)
                {
                    minimum = Convert.ToDecimal(item);
                }
            }
            return minimum;
        }

        public static decimal Maximum<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("No element in list");
            }
            decimal maximum = decimal.MinValue;
            foreach (var item in collection)
            {
                if (Convert.ToDecimal(item) > maximum)
                {
                    maximum = Convert.ToDecimal(item);
                }
            }
            return maximum;
        }

        public static decimal AverageSum<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("No element in list");
            }
            dynamic averageSum = collection.First();
            foreach (var item in collection.Skip(1))
            {
                
                    averageSum += Convert.ToDecimal(item);
                
            }
            return (decimal)averageSum/collection.Count();
        }
    }

