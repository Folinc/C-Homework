// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите X1: ");
double X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  Y1: ");
double Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  Z1: ");
double Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X2: ");
double X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  Y2: ");
double Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  Z2: ");
double Z2 = Convert.ToInt32(Console.ReadLine());

double distance2D = Math.Sqrt((Math.Pow((X2 - X1), 2)) + (Math.Pow((Y2 - Y1), 2)) + (Math.Pow((Z2 - Z1), 2)));

Console.Write(Math.Round(distance2D, 3));