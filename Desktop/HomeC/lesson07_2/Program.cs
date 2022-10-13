// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
/* 1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] fillMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
    return matrix;
}

void printMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void searchPos(int[,] array, int a, int b)
{

    if (a < array.GetLength(0) && b < array.GetLength(1))
        Console.Write(array[a, b]);
    else Console.WriteLine($"array [{a}, {b}] Такого элемента нет");

}

Console.Write("Введите кол-во строк ");
int n = Int16.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int m = Int16.Parse(Console.ReadLine());
int[,] mas = fillMatrix(n, m);
printMatrix(mas);

Console.Write("Введите позицию строки ");
int rows = Int16.Parse(Console.ReadLine());
Console.Write("Введите позицию столбца ");
int columns = Int16.Parse(Console.ReadLine());

Console.WriteLine();
searchPos(mas, rows, columns);