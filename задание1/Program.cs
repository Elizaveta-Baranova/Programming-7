//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = ReadInt ("Введите количество строк: ");
int columns = ReadInt ("Введите количество столбцов: ");
int[,] numbers = new int [rows, columns];
FillArray2D(numbers);
PrintArray2D(numbers);

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
            array[i, j] = new Random().Next(-10,11);
        }
    }
}

int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}