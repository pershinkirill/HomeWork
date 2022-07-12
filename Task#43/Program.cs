// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("To define a crossing point we have to solve a sustem of equasions");
Console.WriteLine("Please enter B1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter K1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter B2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter K2");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The sustem of equasions:"); 
Console.WriteLine($"y = {k1} * x + {b1}");
Console.WriteLine($"y = {k2} * x + {b2}");

// According to the Gaussian elimination method there are three types of elementary row operations, that can be used for solving systems of linear equations:
// 1. Swapping two rows,
// 2. Multiplying a row by a nonzero number,
// 3. Adding a multiple of one row to another row. 

// Using Gaussian elimination method we can multiply the first row on -1 and add it to the second row
double x = (b1 - b2) / (-k1 + k2);
// Now we can use the result putting it to the sum of rows
double y = ((k2 + k1) * x + (b1 + b2) )/ 2;

Console.WriteLine($"(y = {y} ; x = {x})");
