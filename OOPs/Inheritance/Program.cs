using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jack", "Sparrow", 1000);
            Console.WriteLine("The name of employee is " + employee.GetName());
            Console.WriteLine("The surname of employee is " + employee.GetSurname());
            Console.WriteLine("The salary of employee is " + employee.GetSalary());

            Console.WriteLine("What's the new salary of " + employee.GetName() + " " + employee.GetSurname() + "?");
            while (true)
            {
                double newSalary = employee.GetSalary();
                if (Double.TryParse(Console.ReadLine(), out newSalary))
                {
                    employee.SetSalary(newSalary);
                    break;
                }
                else
                    Console.WriteLine("Input is not correct!");
            }

            Console.WriteLine("The salary of employee is " + employee.GetSalary());


            Console.WriteLine(employee);
        }
    }
}
