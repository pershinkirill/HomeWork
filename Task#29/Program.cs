// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1. With separate appending of each element of the array

// int[] array = new int[8];
//
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine($"Enter {i} element of the array");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"{String.Join("; ",array)}");

//2. Wtih Split fuction
//
// Console.WriteLine("Please enter 8 elements of the array with spaces,b ut without commas");

// string array = Console.ReadLine();
// string[] array1 = array.Split(' ');

// Console.WriteLine($"{String.Join("; ",array1)}");


// 3. With random function
int size = 8;
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next();
}
Console.WriteLine($"{String.Join("; ",array)}");