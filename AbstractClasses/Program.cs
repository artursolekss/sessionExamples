using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car();
            car.Move(29);
            car.SpeedUp();
            car.SpeedUp();
            car.SpeedDown();
            Console.WriteLine(car);

            Transport bicycle = new Bicycle();
            bicycle.Move(15);
            bicycle.Move(17);
            bicycle.SpeedDown();
            bicycle.SpeedDown();
            Console.WriteLine(bicycle);

        }
    }
}
