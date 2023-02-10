// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
string[] weekday = { " ", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.Write("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0 || number >= 8)
{
    Console.Write("Неверное число! ");
    Environment.Exit(0);
}
if (number <= 5)
{
    Console.Write($"{weekday[number]} - не является выходным днём " );
}
else
{
    Console.Write($"{weekday[number]} - является выходным днём " );
}