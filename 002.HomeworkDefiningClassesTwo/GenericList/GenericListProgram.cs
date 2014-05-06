/* Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list 
 * in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, 
 * accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element 
 * by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListProgram
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>();
            Random randomNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                test.AddElement(randomNumber.Next(1, 100));
            }

            Console.WriteLine("The GenericList is:\n {0}",test);
            test.RemoveElementByIndex(0);
            Console.WriteLine("After removing element by index, the GenericList is:\n {0}",test);
            test.InsertElementByIndex(5, 89);
            Console.WriteLine("After insert new element, the GenericList is:\n {0}", test);
            test.FindElemByValue(89);
            Console.WriteLine("The maximal element is: {0}",test.Maximum());
            Console.WriteLine("The minimal element is: {0}", test.Minimum());
            test.CleanList();
            Console.WriteLine("After clearing the GenericList is: {0}",test);

        }
    }
}
