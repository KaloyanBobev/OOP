using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class ClassesOfStudents : ICommentable
    {
        // fields
        private List<Teacher> setOfTeachers; // Each class has a set of teachers. 
        private List<Student> setOfStudents;
        private string numberOfClasses;
        private List<string> freeText;

        // properties
        public Teacher[] SetOfTeachers
        {
            get { return this.setOfTeachers.ToArray(); }
            set
            {
                if (value.Length >= 1)
                {
                    this.SetOfTeachers = value;
                }
                else
                {
                    throw new ArgumentException("In the class not a teacher");
                }
            }
        }

        public Student[] SetOfStudents
        {
            get {return this.setOfStudents.ToArray();}
            set
            {
                if (value.Length >= 1)
                {
                    this.SetOfStudents = value;
                }
                else
                {
                    throw new ArgumentException("In the class not a student");
                }
            }
        }

        public string NumberOfClasses
        {
            get { return this.numberOfClasses; }
            set { this.numberOfClasses = value; }
        }

        public string[] FreeTexts
        {
            get { return this.freeText.ToArray(); }
            set { }
        }
    //constructor
        public ClassesOfStudents(Teacher [] setOfTeachers, Student [] setOfStudents, string numberOfClasses)
        {
            this.setOfTeachers = new List<Teacher>(setOfTeachers);
            this.setOfStudents = new List<Student>( setOfStudents);
            this.numberOfClasses = numberOfClasses;
            this.freeText = new List<string>();
        }

        public void AddTeacher(Teacher teacher)
        {
            this.setOfTeachers.Add(teacher);
        }

        public void DeleteTeacher(Teacher teacher)
        {
            this.setOfTeachers.Remove(teacher);
        }

        public void AddStudent(Student student)
        {
            this.setOfStudents.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            this.setOfStudents.Remove(student);
        }

        public void AddText(string freeText)
        {
            this.freeText.Add(freeText);
        }
    }

