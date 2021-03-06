using System;

namespace Inheritance
{
    class Programmer : Employee, ILearner
    {
        private string programmingLanguage;


        //Not possible to leave the constructor, without calling the construcotr of the base class, because it has NO non-parameterised constructor
        // public Programmer()
        // {

        // }

        public Programmer(string name, string surname, double salary, string programmingLang) : base(name, surname, salary)
        {
            this.programmingLanguage = programmingLang;
        }

        public override string ToString()
        {
            return base.ToString() + "\n Main programming language = " + this.programmingLanguage;
        }

        public override void PrintAvailableCastingClass()
        {
            Console.WriteLine("This object can be casted to the variable typed as Person or Employee");
        }


        public void Learn()
        {
            Console.WriteLine("I'm learning how to write a good code");
        }

        public void ShareKnowLedge(ILearner learner)
        {
            Console.WriteLine("I'm sharing my knowledge with other learner " + learner);
        }

    }

}