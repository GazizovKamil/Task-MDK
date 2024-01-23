

using System.Numerics;

while (true)
{
    try
    {
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine("Результат факториала " + Factorial(number));
    }
    catch
    {
        Console.WriteLine("Вводи только цифры");
    }
}
double Factorial(double number)
{
    long result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;   
    }

    return result;
}

