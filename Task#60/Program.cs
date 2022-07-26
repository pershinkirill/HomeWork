// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int len = 3;
int[,,] array3D = new int[len, len, len];
List<int> checker = new List<int>();
int number = 0;

for (int i = 0; i < len; i++)
{
    for (int j = 0; j < len; j++)
    {
        for (int k = 0; k < len; k++)
        {
            bool contains = true;
            while (contains)
            {
                number = new Random().Next(10, 100);
                contains = checker.Contains(number);
            }
            array3D[i, j, k] = number;
            checker.Add(number);
            Console.Write($"{number}({i},{j},{k})   ");
        }
        Console.Write("\t");

    }
    Console.Write("\n");
}