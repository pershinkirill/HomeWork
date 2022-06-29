// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("The number is too low, therefore there is not a third character");
}
else
{
    string myString = number.ToString(); //a little bit chiterstvo
    Console.WriteLine($"The number's third character - {myString[2]}");

}