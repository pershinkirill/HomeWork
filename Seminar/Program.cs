// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int [12];

// int size = array.Length;

// int resultPositive = 0;
// int resultNegative = 0;

// int index = 0;

// while (index < size)
// {
//     array[index] = new Random().Next(-9,10); 
//     index ++;
// }
// Console.WriteLine($"[{String.Join("; ", array)}]");

// for (int startIndex = 0; startIndex < size; startIndex ++)
// {
//     if (array[startIndex] > 0)
//     {
//         resultPositive += array[startIndex];
//     }
//     else
//     {
//         resultNegative += array[startIndex];
//     }
// }

// Console.WriteLine($"Summ of positive numbers {resultPositive}");
// Console.WriteLine($"Summ of negative numbers {resultNegative}");

//--------------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int [12];

// int size = array.Length;
// int[] reversedArray = new int [12];
// int index = 0;

// while (index < size)
// {
//     array[index] = new Random().Next(-9,10); 
//     index ++;
// }
// index = 0;

// for (index = 0; index < size; index ++)
// {
//     reversedArray[index] = array[index] * -1;
// }
// Console.WriteLine($"Initial array - {String.Join("; ", array)}");
// Console.WriteLine($"Reversed array - {String.Join("; ", reversedArray)}");

//--------------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] array = new int [12];

// int size = array.Length;
// Console.WriteLine("Please, enter the number that you are looking for");
// int lookForNumber = Convert.ToInt32(Console.ReadLine());
// int index = 0;
// int counter = 0;

// while (index < size)
// {
//     array[index] = new Random().Next(-9,10); 
//     index ++;
// }

// for (index = 0; index < size; index ++)
// {
//     if (array[index] == lookForNumber) counter ++;
// }

// Console.WriteLine($"the number {lookForNumber} was found {counter} times in array - [{String.Join("; ", array)}]");

//--------------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int [10];

// int size = array.Length;
// int lowerLimit = 10;
// int upperLimit = 99;
// int index = 0;
// int counter = 0;

// while (index < size)
// {
//     array[index] = new Random().Next(0,201); 
//     index ++;
// }

// for (index = 0; index < size; index ++)
// {
//     if (array[index] >= lowerLimit && array[index] <= upperLimit) counter ++;
// }
// Console.WriteLine($"{counter} numbers are placed between {lowerLimit} and {upperLimit} times in array - [{String.Join("; ", array)}]");

//--------------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int [10];
int[] arrayResult = new int [5];
int size = array.Length;
int index = 0;

while (index < size)
{
    array[index] = new Random().Next(-9,10); index ++;
}

for (index = 0; index < size / 2; index ++)
{
    arrayResult[index] = array[index] * array[size - index - 1];
}
Console.WriteLine($"Array - [{String.Join("; ", array)}]");
Console.WriteLine($"Array Result- [{String.Join("; ", arrayResult)}]");