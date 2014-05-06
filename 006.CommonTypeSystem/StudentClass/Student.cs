/* Define a class Student, which contains data about a student – first, middle and last name,
* SSN, permanent address, mobile phone e-mail, course.*/

using System;

public class Student :ICloneable, IComparable<Student>
{
    //fields 
    private string firstName;
    private string middleName;
    private string lastName;
    private long ssn;
    private string address;
    private int mobilePhone;
    private string email;
    private string course;
    private Specialties specialty;
    private Faculties facility;
    private Universitaties university;

    //properties
    public string FirstName
    {
        get
        { return this.firstName; }
        set
        {
            if (value.Length > 0)
            {
                this.firstName = value;
            }
            else
            {
                throw new ArgumentException("First Name is too short");
            }
        }
    }

    public string MiddleName
    {
        get
        { return this.middleName; }
        set
        {
            if (value.Length > 0)
            {
                this.middleName = value;
            }
            else
            {
                throw new ArgumentException("Middle Name is too short");
            }
        }
    }

    public string LastName
    {
        get
        { return this.lastName; }
        set
        {
            if (value.Length > 0)
            {
                this.lastName = value;
            }
            else
            {
                throw new ArgumentException("Last Name is too short");
            }
        }
    }

    public long SSN
    {
        get
        { return this.ssn; }
        set
        {
            if (value == 10)
            {
                this.ssn = value;
            }
            else
            {
                throw new ArgumentException("SSN is exactly 9 digits");
            }
        }
    }

    public string Address
    {
        get
        { return this.address; }
        set
        {
            if (value.Length > 0)
            {
                this.address = value;
            }
            else
            {
                throw new ArgumentException("Address is too short");
            }
        }
    }

    public int MobilePhone
    {
        get
        { return this.mobilePhone; }
        set
        {
            if (value == 10)
            {
                this.mobilePhone = value;
            }
            else
            {
                throw new ArgumentException("Mobile number is exactly 10 digits");
            }
        }
    }

    public string Email
    {
        get
        { return this.email; }
        set
        {
            if (value.Length > 0)
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentException("Email is too short");
            }
        }
    }

    public string Course
    {
        get
        { return this.course; }
        set
        {
            if (value.Length > 0)
            {
                this.course = value;
            }
            else
            {
                throw new ArgumentException("Course is too short");
            }
        }
    }

    public Specialties Specialty
    {
        get { return this.specialty; }
        set{}

    }

    public Faculties Facility
    {
        get { return this.facility; }
        set{}
    }

    public Universitaties University
    {
        get { return this.university; }
        set{}
    }

    //construtors

    public Student()
    {
    }

    public Student(string firstName, string middleName, string lastName, long ssn, string address,
        int mobilePhone, string email, string course, Specialties specialty, Faculties facility, Universitaties university)
    {
        this.firstName = firstName;
        this.middleName = middleName;
        this.lastName = lastName;
        this.ssn = ssn;
        this.address = address;
        this.mobilePhone = mobilePhone;
        this.email = email;
        this.course = course;
        this.specialty = specialty;
        this.facility = facility;
        this.university = university;
    }

    //method
    public override string ToString()
    {
        return String.Format("Full name of student : {0} {1} {2}\nand SSN : {3}", this.firstName, this.middleName, this.lastName, this.ssn);
    }

    public override bool Equals(object param)
    {
        Student student = param as Student;

        if (student == null)
        {
            return false;
        }
        if (!Object.Equals(this.firstName, student.firstName))
        {
            return false;
        }
        if (!Object.Equals(this.middleName, student.middleName))
        {
            return false;
        }
        if (!Object.Equals(this.lastName, student.lastName))
        {
            return false;
        }
        if (this.ssn!=student.ssn)
        {
            return false;
        }
        return true;
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
    }

    public static bool operator == (Student firstStudent, Student secondStudent)
    {
        return Student.Equals(firstStudent, secondStudent);
    }

    public static bool operator !=(Student firstStudent, Student secondStudent)
    {
        return !(Student.Equals(firstStudent, secondStudent));
    }

    //Add implementations of the ICloneable interface.
    public Student Clone()
    {
        return new Student(this.firstName, this.middleName, this.lastName, this.ssn, this.address, this.mobilePhone, this.email,
            this.course, this.specialty, this.facility, this.university);
    }

    object ICloneable.Clone()
    { return this.Clone(); }

    //Implement the  IComparable<Student> interface
    public int CompareTo(Student student)
    {
        if (this.firstName!=student.firstName)
        {
            return (this.firstName.CompareTo(student.FirstName));
        }
        if (this.middleName != student.middleName)
        {
            return (this.middleName.CompareTo(student.MiddleName));
        }
        if (this.LastName != student.LastName)
        {
            return (this.LastName.CompareTo(student.LastName));
        }
        if (this.SSN != student.SSN)
        {
            return (int)((this.SSN - student.SSN));
        }

        return 0;
    }
}