// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ArithmeticProgressionSum(int m, int n)
{
    if (m == n) return n;
    return ArithmeticProgressionSum(m, n - 1) + n;
}

Console.WriteLine("Please enter M number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter N number");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M = {m}; N = {n} ->  {ArithmeticProgressionSum(m, n)}");