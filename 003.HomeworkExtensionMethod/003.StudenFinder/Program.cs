//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.StudenFinder
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new[]
            {
                new {firstName ="Ivan", lastName = "Jorgov",age = 23},
                new {firstName ="Boris", lastName = "Dobrev",age = 19},
                new {firstName ="Pesho", lastName = "Ivanov",age = 26},
                new {firstName ="John", lastName = "Atanasov",age = 33},
                new {firstName ="Steve", lastName = "Jobs",age = 37},
                new {firstName ="Miro", lastName = "Stavrev",age = 18}
            };

            var allStudents =
                from student in students
                where student.lastName.CompareTo(student.firstName) == 1
                orderby student.age
                select student;
            foreach (var student in allStudents)
            {
                Console.WriteLine("Student: {0} {1} {2}",student.firstName,student.lastName,student.age);
            }
        }
    }
}
