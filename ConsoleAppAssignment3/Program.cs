using System;

class Program
{
    static void Main()
    {
        // Task 1: Converting string to integer using TryParse
        Console.Write("Enter a number: ");
        string inputNumber = Console.ReadLine();
        int number;

        if (int.TryParse(inputNumber, out number))
        {
            Console.WriteLine("Using TryParse: Converted integer: " + number);
        }
        else
        {
            Console.WriteLine("Using TryParse: Invalid input. Cannot convert to integer.");
        }

        // Task 2: Converting string to double using Convert
        Console.Write("Enter a decimal number: ");
        string inputDecimal = Console.ReadLine();

        try
        {
            double decimalNumber = Convert.ToDouble(inputDecimal);
            Console.WriteLine("Using Convert: Converted double: " + decimalNumber);
        }
        catch (FormatException)
        {
            Console.WriteLine("Using Convert: Invalid input. Cannot convert to double.");
        }

        // Task 3: Converting string to decimal using Parse
        Console.Write("Enter a decimal number: ");
        string inputDecimalString = Console.ReadLine();

        try
        {
            decimal decimalValue = decimal.Parse(inputDecimalString);
            Console.WriteLine("Using Parse: Converted decimal: " + decimalValue);
        }
        catch (FormatException)
        {
            Console.WriteLine("Using Parse: Invalid input. Cannot convert to decimal.");
        }
    }
}
