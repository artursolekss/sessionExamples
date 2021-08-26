using System;

namespace AbstractClasses
{
    class Car : Transport
    {

        public Car() : base(4)
        {
        }

        protected override string GetMyType()
        {
            return "Car";
        }

        public override void Move(int age)
        {
            if (age < 18)
                Console.WriteLine("Can't move, because too young");
            else if (this.moving)
                Console.WriteLine("The car is already moving");
            else
            {
                this.speed = 1;
                this.moving = true;
            }
        }
        public override void SpeedUp()
        {
            if (this.speed < 120)
                this.speed++;
            else
                Console.WriteLine("The max speed is exceeded");
        }

    }
}