// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("To calculate the distance between two dots in a three-dimensional space - please enter the dots coordinates");

Console.WriteLine("X1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("X2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z2");
int z2 = Convert.ToInt32(Console.ReadLine());

//𝑑(𝑃1,𝑃2)=√(𝑥2 −𝑥1)2 +(𝑦2 −𝑦1)2 +(𝑧2 −𝑧1)2.

double d = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));

Console.WriteLine(Math.Round(d, 2));