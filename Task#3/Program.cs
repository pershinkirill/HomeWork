// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7)
{
    Console.WriteLine("A week has only seven days in it");
}
else
{
    if (number < 6)
    {
        Console.WriteLine("It's a workday");
    }
    else
    {
        Console.WriteLine("Congrats - it's a weekend");
    }
}