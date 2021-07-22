using System;

public class Calculator
{
    public static void PrintErrorMesage()
    {
        Console.WriteLine("Input is incorrect!");
        Console.WriteLine("Please, don't it anymore!");
    }

    // public static double Sum(double var1, double var2)
    // {
    //     return var1 + var2;
    // }

    // public static void Sum(ref double var1, double var2, ref double result)
    // {
    //     var1++;
    //     result = var1 + var2;
    // }

    public static void Sum(double var1, double var2, out double result)
    {
        result = var1 + var2;
    }

    public static bool ValidateOperator(char operatorProvided)
    {
        if (operatorProvided != '*' &&
        operatorProvided != '+' && operatorProvided != '/'
        && operatorProvided != '-' &&
        operatorProvided != '%')
            return false;
        else
            return true;
    }

    static void Main(string[] args)
    {
        double value1, value2;

        Console.WriteLine("Enter value 1:");
        if (!Double.TryParse(Console.ReadLine(), out value1))
        {
            PrintErrorMesage();
            return;
        }

        Console.WriteLine("Enter value 2:");
        if (!Double.TryParse(Console.ReadLine(), out value2))
        {
            PrintErrorMesage();
            return;
        }

        Console.WriteLine("Enter the operation (* - multiplication, / - division, + - addition, - - subtract, % - modulo");
        char operation = Char.Parse(Console.ReadLine());
        double result;

        if (!ValidateOperator(operation))
        {
            PrintErrorMesage();
            return;
        }

        switch (operation)
        {
            case '*':
                result = value1 * value2;
                break;
            case '/':
                result = value1 / value2;
                break;
            case '+':
                // result = 0;
                // Sum(value1, value2, ref result);
                Sum(value1, value2, out result);
                break;
            case '-':
                result = value1 - value2;
                break;
            case '%':
                result = value1 % value2;
                break;
            default:
                PrintErrorMesage();
                return;///stop the program
        }
        Console.WriteLine(value1 + " " + operation + " " + value2 + " = " + result);

    }

}