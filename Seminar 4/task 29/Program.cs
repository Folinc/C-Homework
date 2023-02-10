// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] rundNums = new int[8];
for (int i = 0; i < rundNums.Length; i++)
{
    rundNums[i] = new Random().Next(-9, 10);
}
Console.WriteLine("[{0}]", string.Join(", ", rundNums));