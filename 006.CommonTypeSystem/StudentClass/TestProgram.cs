/* 1.Define a class Student, which contains data about a student – first, middle and last name,
 * SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties,
 * universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * 2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
 3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
 * and by social security number (as second criteria, in increasing order).*/

using System;

    class TestProgram
    {
        static void Main(string[] args)
        {
            Student firstStudent = new Student("Petko", "Georgiev", "Karaulanov", 7811125447, "Makedonska 55", 0888880088, "cba@abv.bg",
                "3", Specialties.HTML, Faculties.Economics, Universitaties.FUB);

            Console.WriteLine(firstStudent.ToString());

            Student clonedFirst = firstStudent.Clone();

            Console.WriteLine(clonedFirst.ToString());

            Console.WriteLine("The two students are equals:{0}",firstStudent.Equals(clonedFirst));
        }
    }

