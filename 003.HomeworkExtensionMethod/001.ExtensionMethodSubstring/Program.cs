/*Implement an extension method Substring(int index, int length) for the class StringBuilder that 
 * returns new StringBuilder and has the same functionality as Substring in the class String. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.ExtensionMethodSubstring
{
    class Program  
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();

            str.Append("Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder.");

            Console.WriteLine("First Overload: {0} ",str.SubstringBiuld(0, 9));
            Console.WriteLine();
            Console.WriteLine("Second Overload: {0} ", str.SubstringBiuld(10));
           


        }
    }
}