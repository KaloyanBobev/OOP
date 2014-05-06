using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProgram
{
    class MatrixProgram
    {
        public static void Main()
        {
            Console.WriteLine("Enter number:  ");
            int number = int.Parse(Console.ReadLine());
            Matrix<int> matrix = new Matrix<int>(number, number);
            Matrix<int> matrixTwo = new Matrix<int>(number, number);
            

            Random randomNumber = new Random();
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                     matrix[i, j]=randomNumber.Next(1,50);
                     matrixTwo[i, j]=randomNumber.Next(1,50);
                }
                
            }
            Console.WriteLine(matrix);
            Console.WriteLine(matrixTwo);
            Console.WriteLine(matrix + matrixTwo);
        }
    }
}
