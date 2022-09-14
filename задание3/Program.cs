// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] numbers = new int [3, 3];
FillArray2D(numbers);
PrintArray2D(numbers);
for (int i = 0; i < 3; i++) 
{
    int srAr = 0;
    for (int j = 0; j < 3; j++)
    {
        srAr += numbers[j, i];
    }
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/3}");
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}