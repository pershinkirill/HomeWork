// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Please enter coordinates of the seeking element, separated with a comma");
int[] coordinates = Array.ConvertAll(Console.ReadLine().Trim().Split(','), int.Parse);

//there aren't special requirements for the matrix, therefore we can generate it randomly
int rows = new Random().Next(2,8);
int columns = new Random().Next(2,8);

double[,] matrix = new double [rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = Math.Round((new Random().NextDouble() * new Random().Next(-10,11)), 2);
        Console.Write(matrix[i,j] + "\t ");
    }
    Console.WriteLine();
}

if (coordinates[0] > rows ^ coordinates[1] > columns)
{
    Console.WriteLine($"There isn't an element with such coordinates row - [{coordinates[0]}] column - [{coordinates[1]}] elements in the matrix");
}

else
{
    Console.WriteLine($"The element with coordinates row - [{coordinates[0]}] column - [{coordinates[1]}] is {matrix[coordinates[0],coordinates[1]]}");
}