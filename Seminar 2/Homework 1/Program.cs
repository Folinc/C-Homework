// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трёхзначное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 100 || number1 > 999)
{
    Console.Write("Неверное число! ");
    
}
else 
{
    int answer = number1 / 10 % 10 ;
Console.Write(answer);
}