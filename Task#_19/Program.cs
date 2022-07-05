// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99999)
{
    Console.WriteLine("The number is too high");
}
else
{
    if (number < 10000)
    {
        Console.WriteLine("The number is too low");
    }

    else
    {
        string myString = number.ToString();
        if (myString[0] == myString[4] && myString[1] == myString[3])
        {
            Console.WriteLine($"The number {myString} is a palindrome");
        }
        else
        {
            Console.WriteLine($"The number {myString} is not a palindrome");
        }

    }
}