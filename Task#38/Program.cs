// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double [10];

int size = array.Length;
int index = 0;

//The floating-point numeric types represent real numbers. In C# we have three floating point types: float , double , and decimal. 
while (index < size)
{
    array[index] = Math.Round(new Random().NextDouble(),2);
    index ++;
}

double minNumber = array[0];
double maxNumber = array[0];

for (index = 0; index < size; index ++)
{
    if (array[index] > maxNumber) maxNumber = array[index];
    if (array[index] < minNumber) minNumber = array[index];
}
Console.WriteLine($"The difference between minimum - {minNumber} and maximum - {maxNumber} elements in array - [{String.Join("; ", array)}] is {maxNumber - minNumber} ");
