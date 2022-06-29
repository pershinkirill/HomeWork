// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int number = new Random().Next(99,999);
Console.WriteLine($"Random number - {number}");

string stNumber = number.ToString();
stNumber = stNumber.Remove(1,1);

Console.WriteLine($"The number without a middle character - {stNumber}");