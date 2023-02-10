// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int count = 0;
Console.Write("Введите сколько будет чисел: ");
int lenArray  = Convert.ToInt32(Console.ReadLine());
int[] array =  new int[lenArray];
for (int i = 0; i < lenArray; i++)
{
    Console.Write("Введите число: ");
    int number  = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
    if (number > 0)
    {
        count ++;
    }
}
Console.Write("Числа ввёденые пользователем: ");
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.Write($"Количесво чисел больше нуля: {count}");
