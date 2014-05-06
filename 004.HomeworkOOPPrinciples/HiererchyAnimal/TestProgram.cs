/*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
 * All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, 
 * name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
 * Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ). */

using System;
using System.Collections.Generic;
using System.Linq;

class TestProgram
{
    static void Main()
    {
        
        List<Dog> dogs = new List<Dog>
        {
        new Dog (5,"Sharko",AnimalSex.male),
        new Dog (9,"Reks",AnimalSex.male),
        new Dog (7,"Strela",AnimalSex.female),
        new Dog (2,"Zvezda",AnimalSex.female)
        };

        foreach (var d in dogs)
        {
            Console.WriteLine("{0} {1}",d.Name,d.ProduceSpecificSound());
        }
        List<Kitten> kittens = new List<Kitten>
        {
        new Kitten(2,"Myra"),
        new Kitten(1,"Bqlka"),
        new Kitten(5,"Macana"),
        new Kitten(6,"Myrzelana")
        };
        foreach (var k in kittens)
        {
            Console.WriteLine("{0} {1}",k.Name,k.ProduceSpecificSound());
        }
        List<Tomcat> tomcats = new List<Tomcat>
        {
            new Tomcat(2,"Plamyk"),
            new Tomcat(4,"Cherno"),
            new Tomcat(7,"Blacki"),
            new Tomcat(4,"Kotarak")
        };

        foreach (var t in tomcats)
        {
            Console.WriteLine("{0} {1}",t.Name,t.ProduceSpecificSound()); 
        }

        List<Frog> frogs = new List<Frog> 
        { 
        new Frog(2,"Test frog One",AnimalSex.female),
        new Frog(1,"Test frog Two",AnimalSex.female),
        new Frog(3,"Test frog Three",AnimalSex.female),
        new Frog(1,"Test frog Four",AnimalSex.female),
        };

        foreach (var f in frogs)
        {
            Console.WriteLine("{0} {1}",f.Name,f.ProduceSpecificSound());
        }

        Console.WriteLine();
        var dogAge =
            from d in dogs
            select d.Age;        
        Console.WriteLine("Average age of dogs is: {0} years",dogAge.Average());

        var kittenAge =
            from k in kittens
            select k.Age;
        Console.WriteLine("Average age of kittens is: {0} years",kittenAge.Average());

        var tomcatAge =
            from t in tomcats
            select t.Age;
        Console.WriteLine("Average age of tomcats is: {0} years",tomcatAge.Average());

        var frogAge =
            from f in frogs
            select f.Age;
        Console.WriteLine("Average age of frogs is: {0}",frogAge.Average());
    }
}

