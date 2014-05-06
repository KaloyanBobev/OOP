/* Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
 * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleByTwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            List<int> array = new List<int> (number);

            for (int i = 1; i < number; i++)
            {
                array.Add(i);
            }
            var allNumbers = array.FindAll(x => x % 21 == 0);
            foreach (var item in allNumbers)
            {
                Console.WriteLine("Lamda expression: {0}", item);
            }

            var linqNumbers =
                from num in array
                where num % 21 == 0
                select num;
            foreach (var num in linqNumbers)
            {
                Console.WriteLine("Linq : {0}",num); 
            }
        }

    }
}
