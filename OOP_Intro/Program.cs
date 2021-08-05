using System;

namespace OOP_Intro
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar1 = new Car("Black", 2016, "M1", "Tesla");
            Car myCar3 = new Car();///cannot be done, if there is no unparametrised constructor defined

            // myCar1.SetMyProperties("Black", 2016, "M1", "Tesla");
            // myCar1.color = "Black";
            // myCar1.year = 2016;

            myCar1.ShowMyInfo();
            // Console.WriteLine("The color of my first car is " + myCar1.color);
            // Console.WriteLine("The year of my first car is " + myCar1.year);

            Car myCar2 = new Car("White", 2019, "F1", "Ford");
            // myCar2.SetMyProperties("White", 2019, "F1", "Ford");
            // myCar2.color = "White";
            // myCar2.year = 2019;
            myCar2.ShowMyInfo();
            // Console.WriteLine("The color of my second car is " + myCar2.color);
            // Console.WriteLine("The year of my second car is " + myCar2.year);
        }
    }
    // class Car2
    // {
    //     public string color, model, manifacturer;
    //     public int year;

    //     public void SetMyProperties(string color, int year, string model, string manifacturer)
    //     {
    //         this.year = year;
    //         this.color = color;
    //         this.model = model;
    //         this.manifacturer = manifacturer;
    //     }

    //     public void ShowMyInfo()
    //     {
    //         Console.WriteLine("The color of the car is " + this.color);
    //         Console.WriteLine("The year of the car is " + this.year);
    //         Console.WriteLine("The manifacturer of the car is " + this.manifacturer);
    //         Console.WriteLine("The model of the car is " + this.model);

    //     }

    // }
}
