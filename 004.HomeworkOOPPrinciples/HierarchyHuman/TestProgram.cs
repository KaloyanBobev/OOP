/*Define abstract class Human with first name and last name. Define new class Student which is derived 
 * from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary
 * and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the
 * proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by
 * grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort
 * them by money per hour in descending order. Merge the lists and sort them by first name and last name. */


using System;
using System.Collections.Generic;
using System.Linq;

class TestProgram
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {       
       new Student("Asen","Atanasov",11),
       new Student("Boyan", "Ivanov", 10),
       new Student("Ivan", "Dvambasov", 9),
       new Student("Stoyan", "Jordanov", 9),
       new Student("Stefan", "Stanchev", 9),
       new Student("Plamen", "Ognyanov", 10),
       new Student("Petyr", "Petrov", 12),
       new Student("Zelyazko", "Hristov", 11),
       new Student("Galin", "Petrov", 12),
       new Student("Hristo", "Ustapenev", 10)
        };

        var sortedStudents =
            from student in students
            orderby student.Grade descending, student.FirstName descending
            select student;

        Console.WriteLine("Sorted list of students by grade:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine("{0} {1}   {2}", student.FirstName, student.LastName, student.Grade);
        }
        Console.WriteLine();

        List<Worker> workers = new List<Worker>
        {
            new Worker("Andrej","Gospodinov",200,8),
            new Worker("Gustav","Maler",800,8),
            new Worker("Hans","Zimmer",900,8),
            new Worker("Goce","Ivanovski",235,9),
            new Worker("Pavlin","Pashov",230,10),
            new Worker("Galin","Andonov",189,9),
            new Worker("Aleksandyr","Cvetanov",250,8),
            new Worker("Onufri","Canov",330,11),
            new Worker("Colyo","Ivanov",285,11),
            new Worker("Petko","Tochev",230,8)
        };

        var sortedWorker =
            from worker in workers
            orderby worker.MoneyPerHour()
            select worker;
        Console.WriteLine("Sorted list of workers by money per hour:");
        foreach (var worker in sortedWorker)
        {
            Console.WriteLine("{0} {1}     {2:.00}",worker.FirstName,worker.LastName,worker.MoneyPerHour());
        }
        Console.WriteLine();

        var mergedList = sortedStudents.Concat<Human>(sortedWorker);

        var mergedPeople = 
            from human in mergedList
            orderby human.FirstName,  human.LastName
            select human;

        Console.WriteLine("Sorted list of people by name:");
        foreach (var sort in mergedPeople)
        {
            Console.WriteLine("{0}   {1}",sort.FirstName,sort.LastName);
        }
    }
}

