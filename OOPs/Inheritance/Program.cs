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

            Person person = employee;// Object casting - upcasting --- will always work
            // Console.WriteLine(employee);
            Console.WriteLine(person);///The logic from ToString method is triggered from the class Employee, not the class Person

            Employee employeObj;
            if (person is Employee)
                employeObj = (Employee)person;//down-casting

            // try
            // {

            Kid kidObj;
            if (person is Kid)///here we can check, if the the casting can be done 
                kidObj = (Kid)person;//it will trigger runtime exception InvalidCastException, because we try 
                                     // to pass the objected reference typed as Employee to the variable typed as Kid
                                     // }
                                     // catch (InvalidCastException)
                                     // {
                                     //     Console.WriteLine("Invalid casting.");
                                     // }
            // Person persoObj = new Person("Johny", "Staar");
            // persoObj.Play();
            employee.Play();
        }
    }
}
