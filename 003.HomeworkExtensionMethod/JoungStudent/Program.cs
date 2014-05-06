// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoungStudent
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
                new {firstName ="Krasimir", lastName = "Stefanov",age = 20},
                new {firstName ="Miro", lastName = "Stavrev",age = 18}
            };

            var allStudents =
                from student in students
                where student.age >18 
                where student.age<24
                orderby student.age
                select student;
            foreach (var student in allStudents)
            {
                Console.WriteLine("Student: {0} {1} {2}", student.firstName, student.lastName, student.age);
            }
        }
    }
}
