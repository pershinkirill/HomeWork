// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//there aren't special requirements for the matrix, therefore we can generate it randomly
int rows = new Random().Next(2,8);
int columns = new Random().Next(2,8);
double[] avg = new double [columns]; //Additional array for average values

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

for (int j = 0; j < columns; j++)
{
    for (int i = 0; i < rows; i++)
    {
        avg[j] += (matrix[i,j] / rows);
    }
}
Console.WriteLine($"The columns average values are - [{String.Join(" ", avg.Select(avg => Math.Round(avg, 2)).ToList())}]");