// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter the number A");
int number = Convert.ToInt32(Console.ReadLine());
int summ = 0;
string line = number.ToString();

for (int i = 0; i < line.Length; i++)
{
    summ += (int)char.GetNumericValue(line[i]);
}

Console.WriteLine($"summ of A charachters is {summ}");