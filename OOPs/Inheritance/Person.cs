using System;

namespace Inheritance
{
    // class Person//ALL THE CLASSES IN C# ARE ACTUALLY INGERITED FROM "OBJECT"
    abstract class Person
    {

        protected string name, surname;

        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public virtual void PrintAvailableCastingClass()///if the method is defined as virtual, then it can we can ovveride it in all the subclasses
        //if we don't override the method in the subclass, then the implementation of the method from the base class will be called 
        {
            Console.WriteLine("This class can't be casted to any other class");
        }

        // public virtual void Play()
        // {
        //     Console.WriteLine("The person is playing");
        // }

//In case we are sure, that the implementation of the method can only be defined in the sub-class (witch is not the abstract class)
        public abstract void Play();///Abstract methods do not have the implementation

        public override string ToString()
        {
            return "Name is " + this.GetName() + "\n" +
            "Surname is " + this.GetSurname();
        }

    }

}