using System;

namespace Inheritance
{
    // sealed class Employee : Person/// if the class is defined as sealed, then we can't create any sublcasses of it
    class Employee : Person// if the keyword sealed is not used, than I can create the subclasses
    {
        private double salary;

        public double GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        //Here we MUST call the parameterized constructor from the superclass (base class)
        public Employee(string name, string surname, double salary) : base(name, surname)
        {
            this.salary = salary;
            // this.name = name; NOT CORRECT (if the attribute name in the class Person is defined as private), BECASUE name is privately defined in Person class
            // this.name = name;  IT IS CORRECT, if the attribute is defined as protected in the class Person//
        }

        public override string ToString()
        {
            return base.ToString()//the method ToString will be called from the class Person
            + "\nSalary is " + this.salary;
        }

        public override void PrintAvailableCastingClass()
        {
            Console.WriteLine("This object can be casted to the variable typed as Person");
        }

    }

}