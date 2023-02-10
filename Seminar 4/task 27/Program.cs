// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int number  = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (number != 0)
{
    count = count + number % 10;
    number = number / 10;

}
System.Console.WriteLine($"Cумма цифр в числе: {count}");