using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


     public class Disciplines : ICommentable
    {
        //fields
         private string disciplinesName;
         private int lectureNumber;
         private int exercisesNumber;
         private List<string> freeText;

         //properties
         public string DisciplinesName
         {
             get { return this.disciplinesName; }
             set
             {
                 if (value != string.Empty)
                 {
                     this.disciplinesName = value;
                 }
                 else
                 {
                     throw new ArgumentException("The name of discipline can't be empty");
                 }
             }
         }
         public int LectureNumber
         {
             get { return this.lectureNumber; }
             set { this.lectureNumber=value; }
         }

         public int ExercisesNumber
         {
             get { return this.exercisesNumber; }
             set { this.exercisesNumber = value; }
         }

         public string[] FreeTexts
         {
             get { return this.freeText.ToArray(); }
             set { }
         }

        //constructors
        public Disciplines(string disciplnesName, int lectureNumber, int exercisesNumber) //Disciplines have name, number of lectures and number of exercises
        {
            this.DisciplinesName = disciplnesName;
            this.LectureNumber = lectureNumber;
            this.ExercisesNumber = exercisesNumber;
            this.freeText = new List<string>();
        }

        public void AddText(string freeText)
        {
            this.freeText.Add(freeText);
        }
    }

