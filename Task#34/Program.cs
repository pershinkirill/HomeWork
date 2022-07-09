// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int [10];

int size = array.Length;
int index = 0;
int counter = 0;

while (index < size)
{
    array[index] = new Random().Next(100,1000); 
    index ++;
}

for (index = 0; index < size; index ++)
{
    if (array[index] % 2 == 0) counter ++;
}

if (counter > 1) Console.WriteLine($"There are {counter} even integers in array - [{String.Join("; ", array)}]");
if (counter == 1) Console.WriteLine($"There is the only one even integer in array - [{String.Join("; ", array)}]");
if (counter == 0) Console.WriteLine($"There is not a single even integer in array - [{String.Join("; ", array)}]");