﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


string PrintRange(int m, int n)
{
    if (m == n) return Convert.ToString(n);
    return PrintRange(m, n - 1) + ", " + Convert.ToString(n);
}

Console.WriteLine("Please enter M number");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter N number");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M = {m}; N = {n} ->  \"\"{PrintRange(m, n)}\"\"");
