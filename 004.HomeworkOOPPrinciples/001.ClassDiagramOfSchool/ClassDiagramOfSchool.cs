

using System;

class Program
{
    static void Main()
    {
       Disciplines disclineOne = new Disciplines("math", 10, 12);
       Disciplines[] discipline = new Disciplines[] { disclineOne};

       Teacher teacherOne = new Teacher("Ivan Ivanov", discipline);
       Teacher[] teachers = new Teacher[] { teacherOne };

       Student studentOne = new Student("Stoyan", 1);
       Student studentTwo = new Student("Daniel", 2);
       Student studentThree = new Student("Yavor", 3);
       Student studentFour = new Student("Pesho", 5);
       Student studentFive = new Student("Darin", 8);
       Student [] students = new Student[]{studentOne,studentTwo,studentThree,studentFour,studentFive};

       ClassesOfStudents classOne = new ClassesOfStudents(teachers, students, "6C");

       classOne.AddTeacher(teacherOne);
       classOne.AddStudent(studentOne);
       classOne.AddStudent(studentFour);

       foreach (var s in students)
       {
           Console.WriteLine("Name of student:{0}",s.Name);
       }
       
      
       studentOne.AddText("vacation is over");
       Console.WriteLine("The commnent of student is: {0}", studentOne.FreeTexts[0]);
    }
}

