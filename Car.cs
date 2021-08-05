using System;
class Car
{
    string color = "red";
    static void Main(string[] args)
    {
        Car myObj1 = new Car();
        // Car myObj2 = new Car();
        Car myObj2 = myObj1;
        myObj2.color = "black";
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj2.color);
    }
}
