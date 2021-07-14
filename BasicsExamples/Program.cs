namespace Variables
{
    class Program
    {
        public static void Main(string[] args)
        {

            double dog;
            System.Console.WriteLine("Variable Casting!");

            double numberDouble1 = 5.67;
            int numberInt1 = (int)numberDouble1;
            //numberInt  = 5; casting will cut off all digits after comma without rounding

            System.Console.WriteLine("numberDouble1: " + numberDouble1
                + ", numberInt1: " + numberInt1);

            // int numberInt1 = 4;
            double numberDouble2 = numberInt1;
            System.Console.WriteLine("numberDouble2: " + numberDouble2);



        }
    }
}
