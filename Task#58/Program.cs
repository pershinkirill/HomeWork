/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

int rows = new Random().Next(2,8);
int columns = new Random().Next(2,8);

int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[rows, columns];
int[,] resultedMatrix = new int[rows, columns];


for (var i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix1[i, j] = new Random().Next(5);
        matrix2[i, j] = new Random().Next(5);
        resultedMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
    }
}

void PrintArray(int rows, int columns, int[,] matrix)
{
    for (var i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("First matrix");
PrintArray(rows, columns, matrix1);
Console.WriteLine("Second matrix");
PrintArray(rows, columns, matrix2);
Console.WriteLine("The result of the matrices multiplication:");
PrintArray(rows, columns, resultedMatrix);