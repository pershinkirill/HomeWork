// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = new Random().Next(2,8);
int columns = new Random().Next(2,8);
int [,] matrix = new int [rows, columns];

int min = 0;
int rowMinSum = 1;
for (var i = 0; i < rows; i++)
{
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(10);
        sum += matrix[i, j];
        Console.Write(matrix[i, j] + "\t");
    }
    if (i == 0)
    {
        min = sum;
    }
    else
    {
        if (sum < min)
        {
            min = sum;
            rowMinSum = i;
        }
    }

    Console.WriteLine();
}
Console.WriteLine($"The row's  (with index - {rowMinSum}) elements have the smallest sum {min}");