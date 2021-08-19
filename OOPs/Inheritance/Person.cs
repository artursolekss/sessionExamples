using System;

namespace Inheritance
{
    class Person
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

        public override string ToString()
        {
            return "Name is " + this.GetName() + "\n" +
            "Surname is " + this.GetSurname();
        }

    }

}