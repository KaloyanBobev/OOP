using System;

class Tomcat: Cat,ISound
    {
     //constructoe
     public Tomcat(int age, string name)
         : base(age, name, AnimalSex.male)
     {
        
     }

     public string ProduceSpecificSound()
     {
         return "Meow,meow";
     }
    }

