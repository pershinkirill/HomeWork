// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter the number A");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
string line = a.ToString();

for (int i = 0; i < line.Length; i++)
{
    b += (int)char.GetNumericValue(line[i]);
}

Console.WriteLine($"summ of A charachters is {b}");