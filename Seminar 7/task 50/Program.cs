// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
int num = new Random().Next(2,5);
int num2 = new Random().Next(2,5);
int[,] array = new int[num,num2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(10,100);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j <array.GetLength(1); j++)
    {
        System.Console.Write(j == array.GetLength(1) - 1 ? array[i, j] + "\n" : array[i, j] + "  |  ");
    }
}
Console.Write("Введите  первую позицую: ");
int position_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  вторую позицую: ");
int position_2 = Convert.ToInt32(Console.ReadLine());
if (num < position_1 || num2 < position_2)
{
    System.Console.WriteLine("Такой позиции нет");
}
else
{
    System.Console.WriteLine(array[position_1,position_2]);
}