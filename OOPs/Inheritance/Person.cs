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

        public override string ToString()
        {
            return "Name is " + this.GetName() + "\n" +
            "Surname is " + this.GetSurname();
        }

    }

}