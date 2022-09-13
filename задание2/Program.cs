// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет. 
//Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.

int[,] numbers = new int [3, 3];
FillArray2D(numbers);
PrintArray2D(numbers);
int rows = ReadInt ("Введите номер строки: ");
int columns = ReadInt ("Введите номер столбца: ");
if (rows > 3 || columns > 3)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine(numbers[rows-1, columns-1]);
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray2D(int[,] array)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}
Console.WriteLine();

int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}