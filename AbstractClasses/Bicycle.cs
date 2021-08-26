using System;

namespace AbstractClasses
{
    class Bicycle : Transport
    {

        public Bicycle() : base(2)
        {
            ///call the cosntrutor of the superclass
        }

        protected override string GetMyType()
        {
            return "Bicycle";
        }

        public override void Move(int age)
        {
            if (age < 12)
                Console.WriteLine("Can't move, because too young");
            else if (this.moving)
                Console.WriteLine("The bicycle is already moving");
            else
            {
                this.speed = 1;
                this.moving = true;
            }
        }
        public override void SpeedUp()
        {
            if (this.speed < 30)
                this.speed++;
            else
                Console.WriteLine("The max speed is exceeded");
        }

    }
}