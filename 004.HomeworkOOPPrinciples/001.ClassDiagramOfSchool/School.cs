using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class School 
{
    //field
    private List<ClassesOfStudents> classes;

    //properties
    public ClassesOfStudents[] Classes
    {
        get
        {
            return this.classes.ToArray();
        }
        set
        {
            if (value.Length >=1)
            {
                this.Classes = value;
            }
            else
            {
                throw new ArgumentException("Class not recorded");
            }
        }

    }

    //constructor
    public School(ClassesOfStudents classes)
    {
        this.classes = new List<ClassesOfStudents>(Classes);

    }

    public void AddClass(ClassesOfStudents classes)
    {
        this.classes.Add(classes);
    }

    public void DeleteClass(ClassesOfStudents classes)
    {
        this.classes.Remove(classes);
    }

}

