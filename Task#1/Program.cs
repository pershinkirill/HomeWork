// Задача 10 : Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999)
{
    Console.WriteLine("The number is too high");
}
else
{
    if (number < 100)
    {
        Console.WriteLine("The number is too low");
    }

    else
    {
        Console.WriteLine($"The number's middle character - {(number % 100) / 10}");
    }
}