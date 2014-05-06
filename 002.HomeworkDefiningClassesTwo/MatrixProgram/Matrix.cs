/* 8.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
   9.Implement an indexer this[row, col] to access the inner matrix cells.
   10.Implement the operators + and - (addition and subtraction of matrices of the same size) and * 
 * for matrix multiplication. Throw an exception when the operation cannot be performed. Implement 
 * the true operator (check for non-zero elements).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProgram
{
    public class Matrix<T> where T : IComparable //8. Define a class Matrix<T>
    {
        public int columns;
        public int rows;
        private T[,] matrix;

        public Matrix(int columns, int rows)
        {
            this.columns = columns;
            this.rows = rows;
            if (columns < 0 || rows < 0)
            {
                throw new IndexOutOfRangeException("The index is negative number");
            }
            this.matrix = new T[rows, columns];
        }

        public T this[int columnPos, int rowsPos] //9.Implement an indexer
        {
            get
            {
                if (columnPos >= this.columns || rowsPos >= this.rows)
                {
                    throw new IndexOutOfRangeException("Out of the matrix!");
                }
                return this.matrix[columnPos, rowsPos];
            }
            set
            {
                if (columnPos >= this.columns || rowsPos >= this.rows)
                {
                    throw new IndexOutOfRangeException("Out of the matrix!");
                }
                this.matrix[columnPos, rowsPos] = value;
            }
        }
        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo) //10.Implement the operators +
        {
            Matrix<T> matrixThree = new Matrix<T>(matrixOne.rows, matrixOne.columns);
            if (matrixOne.columns == matrixTwo.columns && matrixOne.rows == matrixTwo.rows)
            {
                for (int i = 0; i < matrixOne.rows; i++)
                {
                    for (int j = 0; j < matrixOne.rows; j++)
                    {
                        dynamic valueOne = matrixOne[i, j];
                        dynamic valueTwo = matrixTwo[i, j];
                        matrixThree[i, j] = valueOne + valueTwo;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Difference in size!");
            }
            return matrixThree;
        }
        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo) //10.Implement the operators -
        {
            Matrix<T> matrixThree = new Matrix<T>(matrixOne.rows, matrixOne.columns);
            if (matrixOne.columns == matrixTwo.columns && matrixOne.rows == matrixTwo.rows)
            {
                for (int i = 0; i < matrixOne.rows; i++)
                {
                    for (int j = 0; j < matrixOne.rows; j++)
                    {
                        dynamic ValueOne = matrixOne[i, j];
                        dynamic ValueTwo = matrixTwo[i, j];
                        matrixThree[i, j] = ValueOne - ValueTwo;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Difference in size!");
            }

            return matrixThree;
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo) //10.Implement the operators*
        {
            if (matrixOne.columns != matrixTwo.rows)
            {
                throw new ArithmeticException("Difference in size!");
            }

            Matrix<T> matrixThree = new Matrix<T>(matrixOne.rows, matrixOne.columns);
            for (int i = 0; i < matrixThree.rows; i++)
            {
                for (int j = 0; j < matrixThree.columns; j++)
                {
                    for (int m = 0; m < matrixOne.columns; m++)
                    {
                        for (int k = 0; k < matrixOne.columns; k++)
                        {
                            dynamic valueOne = matrixOne[i, j];
                            dynamic valueTwo = matrixTwo[i, j];
                            matrixThree[i, j] += valueOne * valueTwo;
                        }
                    }
                }
            }

            return matrixThree;
        }

        public static bool operator true(Matrix<T> matrix) //10.Implement the operators true
        {
            if (matrix == null || matrix.rows == 0 || matrix.columns == 0)
            {
                return false;
            }

            for (int r = 0; r < matrix.rows; r++)
            {
                for (int c = 0; c < matrix.columns; c++)
                {
                    if (!matrix[r, c].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix) //10.Implement the operators false
        {
            if (matrix == null || matrix.rows == 0 || matrix.columns == 0)
            {
                return true;
            }

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.columns; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    str.AppendFormat("{0,5}", this[i, j]);
                }

                str.AppendLine();
            }

            return str.ToString();
        }
    }
}

