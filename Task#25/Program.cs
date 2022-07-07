// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Enter the number A, that will be raise to the B power");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number B");
int b = Convert.ToInt32(Console.ReadLine());

int i = 0;
int result = 1;


if (b >= 0) // Whole numbers are the numbers beginning with 0, with each successive number greater than its predecessor by 1
{
    while (i < b)
    {
        result = result * a;
        i ++;
    }
}
else
{
    Console.WriteLine($"The number {b} is not a whole number");
}

Console.WriteLine(result);
