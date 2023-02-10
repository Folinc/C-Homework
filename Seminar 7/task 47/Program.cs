double[,] array = new double[new Random().Next(2,10),new Random().Next(2,10)];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        { 
                array[j,k] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
        }
    }
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j <array.GetLength(1); j++)
    {
        System.Console.Write(j == array.GetLength(1) - 1 ? array[i, j] + "\n" : array[i, j] + " | ");
    }
}
Console.Write("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());