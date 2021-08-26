using System;

namespace AbstractClasses
{
    abstract class Transport
    {

        protected int wheels, speed;
        protected bool moving;

        public Transport(int wheels)
        {
            this.wheels = wheels;
        }

        protected abstract string GetMyType();
        public abstract void Move(int age);
        public abstract void SpeedUp();

        public void SpeedDown()
        {
            if (this.speed > 0)
            {
                this.speed--;
                if (this.speed == 0)
                    this.moving = false;
            }
            else
                Console.WriteLine("The transport is not moving");
        }

        public override string ToString()
        {
            return "This is " + this.GetMyType() + ", " + (this.moving ? " it is moving" : " it is not moving") +
            (this.speed > 0 ? ", the speed is " + this.speed : "");
        }

    }

}