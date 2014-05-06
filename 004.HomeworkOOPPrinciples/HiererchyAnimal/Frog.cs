using System;

class Frog : Animal, ISound
{
    //constructor
    public Frog(int age, string name, AnimalSex sex)
        : base(age, name, sex)
    {
    }

    public string ProduceSpecificSound()
    {
       return "Kwak,Kwak";
    }

}


