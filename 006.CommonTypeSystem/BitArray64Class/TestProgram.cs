// Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

using System;

    class TestProgram
    {
        static void Main(string[] args)
        {
            BitArray64 firstNumber = new BitArray64(9);
            Console.WriteLine("The first number: ");
            foreach (var bit in firstNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
                        
            BitArray64 secondNumber = new BitArray64(13);

            Console.WriteLine("The second number: ");
            foreach (var bit in secondNumber)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine("The two numbers are equals:{0}", firstNumber.Equals(secondNumber));
        }
    }

