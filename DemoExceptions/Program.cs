namespace DemoExceptions
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string test;
            try
            {
                test = "ABCd";
                RandomMethod();
            }
            catch (MyOwnException2 e)
            {
                e.PrintError();
            }
            catch (Exception e)
            {
                if (e is MyOwnException || e is MyOwnException2)
                    Console.WriteLine("My custom exception is handled");
                else
                    throw;///it is the same as throw new Exception()
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
        }

        static void RandomMethod()
        {
            throw new MyOwnException();
        }
    }
}
