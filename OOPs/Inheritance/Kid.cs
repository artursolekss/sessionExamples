using System;

namespace Inheritance
{
    class Kid : Person, ILearner
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

        public override void Play()
        {
            Console.WriteLine("The kid is playing");
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning how to eat, walk and play the games");
        }

        public void ShareKnowLedge(ILearner learner)
        {
            Console.WriteLine("I'm sharing my knowledge with " + learner);
        }

    }

}