 // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int rows = new Random().Next(2,8);
int columns = new Random().Next(2,8);
int [,] matrix = new int [rows, columns];
int[] tempArray = new int[columns]; // a temporary array to sort arrays in descending order

Console.WriteLine("The original matrix is: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = new Random().Next(-10,11);
        Console.Write(matrix[i,j] + "\t ");
    }
    Console.WriteLine();
}

Console.WriteLine("The modified matrix is: ");



for (var i = 0; i < rows; i++)
{
    tempArray = new int[columns];
    for (int j = 0; j < columns; j++)
    {
        tempArray[j] = matrix[i, j];
    }
// Sort the temporary array elements from last to the first, comparing every element to each other
    Array.Sort<int>(tempArray, new Comparison<int>((i1, i2) => i2.CompareTo(i1))); 

    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = tempArray[j];
    }
}

for (var i = 0; i < rows; i++)
{
    for (var j = 0; j < columns; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}