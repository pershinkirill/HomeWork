// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter a sequence of numbers, separated with spaces without commas");

string[] numbersSequence = Console.ReadLine().Split(' ');
int counter = 0;

for (int i = 0; i < numbersSequence.Length; i++)
{
    if (Convert.ToInt32(numbersSequence[i]) > 0) counter ++;
}

if (counter > 1) Console.WriteLine($"There are {counter} positive numbers in the array - [{String.Join("; ", numbersSequence)}]");
if (counter == 1) Console.WriteLine($"There is the only 1 number that more than 0 in the array - [{String.Join("; ", numbersSequence)}]");
if (counter == 0) Console.WriteLine($"There is not a single positive number in the array - [{String.Join("; ", numbersSequence)}]");