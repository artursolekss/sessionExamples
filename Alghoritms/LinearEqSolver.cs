using System;

class LinearEqSolver
{

    //2x + 7y = 9
    //4x + 14y = 18
    ///determinat 2 * 14 - 4 * 7 = 28 - 28 = 0 ==> no solution

    //a11 * x + a12 * y = c_1
    ///a21 * x + a22 * y = c_2
    static void Main(string[] args)
    {
        double a11 = 0, a12 = 0, a22 = 0, a21 = 0, c1 = 0, c2 = 0;
        EnterParameter(ref a11, "a11");
        EnterParameter(ref a12, "a12");
        EnterParameter(ref a21, "a21");
        EnterParameter(ref a22, "a22");
        EnterParameter(ref c1, "c_1");
        EnterParameter(ref c2, "c_2");

        ///Calulate determinant
        double determinant = (a11 * a22) - (a21 * a12);
        if (determinant == 0)
        {
            Console.WriteLine("No solutions!");
            return;
        }


        double dx = (c1 * a22) - (c2 * a12);
        double dy = (a11 * c2) - (a21 * c1);

        double x = dx / determinant;
        double y = dy / determinant;
        Console.WriteLine("Solution:\n x = " + x + " y = " + y);

    }

    public static void EnterParameter(ref double parameter, string paramName)
    {
        Console.WriteLine("Please, enter parameter " + paramName);
        while (true)
        {
            if (Double.TryParse(Console.ReadLine(), out parameter))
                break;
            else
                Console.WriteLine("Input is not correct");
        }
    }

}