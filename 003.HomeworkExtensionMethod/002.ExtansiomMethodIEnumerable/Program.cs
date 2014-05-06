// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int[] intArray = new int[] { 1, 3, 4, 9, 7, 55, 11, 5, 6, 120 };
 
        Console.WriteLine("Average: {0}",intArray.AverageSum());
        Console.WriteLine("Sum: {0}", intArray.Sum());
        Console.WriteLine("Product: {0}", intArray.Product());
        Console.WriteLine("Minimum: {0}", intArray.Minimum());
        Console.WriteLine("Maximum: {0}", intArray.Maximum());
        
    }
}

