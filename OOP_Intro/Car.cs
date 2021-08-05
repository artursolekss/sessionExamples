using System;

namespace OOP_Intro
{
    public class Car
    {
        public string color, model, manufacturer;
        public int year;

        public Car()
        {
            ///Fill default values
            this.color = "Green";
            this.manufacturer = "Volvo";
            this.model = "T3";
            this.year = 2000;
        }

        public Car(string color, int year, string model, string manufacturer)
        {
            this.year = year;
            this.color = color;
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public void SetMyProperties(string color, int year, string model, string manufacturer)
        {
            this.year = year;
            this.color = color;
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public void ShowMyInfo()
        {
            // string color = "Yellow";
            // int myVar = 2;
            // this.myVar = 5;/// not correct, becayse myVar is not the attribute of the class
            Console.WriteLine("The color of the car is " + this.color);
            Console.WriteLine("The year of the car is " + this.year);
            Console.WriteLine("The manufacturer of the car is " + this.manufacturer);
            Console.WriteLine("The model of the car is " + this.model);

        }

    }
}