//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005.ExtansionMethodOrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new {firstName ="Ivan", lastName = "Jorgov",age = 23},
                 new {firstName ="Ivan", lastName = "Ivanov",age = 24},
                new {firstName ="Boris", lastName = "Dobrev",age = 19},
                new {firstName ="Pesho", lastName = "Ivanov",age = 26},
                new {firstName ="John", lastName = "Atanasov",age = 33},
                new {firstName ="Steve", lastName = "Jobs",age = 37},
                new {firstName ="Krasimir", lastName = "Stefanov",age = 20},
                 new {firstName ="Ivan", lastName = "Berov",age = 20},
                new {firstName ="Miro", lastName = "Stavrev",age = 18}
            };
            var lamdaStudents = students.OrderByDescending(student => student.firstName).ThenByDescending(student => student.lastName);

            foreach (var student in lamdaStudents)
            {
                Console.WriteLine("Lamda expression: {0} {1}",student.firstName,student.lastName);
            }

            Console.WriteLine();
            var allStudents =
                from student in students
                orderby student.firstName descending, student.lastName descending
                select student;
            foreach (var student in allStudents)
            {
                Console.WriteLine("Linq : {0} {1} ", student.firstName, student.lastName);
            }
        }
    }
}
