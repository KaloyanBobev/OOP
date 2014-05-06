using System;

class Kitten :Cat,ISound
    {
      //constructor
      public Kitten(int age, string name)
          : base(age, name,AnimalSex.female)
      {
         
      }

      public string ProduceSpecificSound()
      {
        return "Purring";
      }
    }

