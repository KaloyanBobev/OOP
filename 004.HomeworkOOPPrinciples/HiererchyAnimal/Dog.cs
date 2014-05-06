using System;

class Dog : Animal, ISound
{

    //constructor
    public Dog(int age, string name, AnimalSex sex)
        : base(age, name, sex)
    {
    }
    public override string ToString()
    {
        return base.ToString();
    }

    public string ProduceSpecificSound()
    {
       return "Barking"; 
    }

}

