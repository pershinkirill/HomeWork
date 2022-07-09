// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int [10];

int size = array.Length;
int index = 0;
int evenIndexAmount = 0;

while (index < size)
{
    array[index] = new Random().Next(1,10); 
    index ++;
}

for (index = 0; index < size; index ++)
{
    if (index % 2 == 0 && index > 0) evenIndexAmount += array[index];
}
Console.WriteLine($"The total sum of elements with even indexes in the aray - [{String.Join("; ", array)}] is {evenIndexAmount} ");