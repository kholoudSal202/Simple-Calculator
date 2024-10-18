// See https://aka.ms/new-console-template for more information

public class Calculator
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to UR Calculetor");
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Insert First Number");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insert Operator");
        string Operator = Console.ReadLine();
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Insert Second Number");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double Result = 0;
        if (Operator == "+")
            Result = number1 + number2;

        else if (Operator == "-")
            Result = number1 - number2;
        else if (Operator == "*")
            Result = number1 * number2;
        else if (Operator == "/")
            Result = number1 / number2;
        else
            Console.WriteLine("Invalid Input");
            Console.WriteLine($"Result is {Result,2}");
            
    }
}

