using System;

namespace Inheritance
{
    class Kid : Person
    {

        private string favouriteToy;

        public Kid(string name, string surname, string favToy) : base(name, surname)
        {
            this.favouriteToy = favouriteToy;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Favorite toy is  " + this.favouriteToy;
        }

        public override void PrintAvailableCastingClass()
        {
            Console.WriteLine("This object can be casted to the variable typed as Person");
        }

    }

}