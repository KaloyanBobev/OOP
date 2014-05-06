using System;

    class TestProgram
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Peshko Dragnev", 33);
            Person secondPerson = new Person("Vesko Malinov");
            Console.WriteLine("{0}\n{1}",firstPerson.ToString(),secondPerson.ToString());
           

        }
    }

