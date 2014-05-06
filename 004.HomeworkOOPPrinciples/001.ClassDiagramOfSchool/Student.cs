using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student : Person, ICommentable
{

    //fields
    public int studentNumber;
    private List<string> freeText;

    //properties
    public int StudentNumber
    {
        get
        {
            return this.studentNumber;
        }
        set
        {
            if (value>=1)
            {
                this.studentNumber = value; 
            }
            else
            {
                throw new ArgumentException("The number must be positive");
            }
        }

    }

    public string[] FreeTexts
    {
        get { return this.freeText.ToArray(); }
        set {  }
    }

    //constructor
    public Student(string name, int studentNumber)
        : base(name) //Students have name and unique class number
    {
        this.studentNumber = studentNumber;
        this.freeText = new List<string>();
    }

    public void AddText(string freeText)
    {
        this.freeText.Add(freeText);
    }
}

