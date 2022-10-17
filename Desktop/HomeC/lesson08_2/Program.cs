// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/* Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] compositionMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            array3[i, j] = 0;
            for (int n = 0; n < array3.GetLength(1); n++)
            {
                array3[i, j] += array1[i, n] * array2[n, j];
            }
        }
    }


    return array3;
}

Console.Write("Введите кол-во строк ");
int n = Int16.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int m = Int16.Parse(Console.ReadLine());
int[,] mas1 = fillMatrix(n, m);
int[,] mas2 = fillMatrix(n, m);
printMatrix(mas1);
Console.WriteLine();
printMatrix(mas2);
Console.WriteLine();

int[,] mas3 = compositionMatrix(mas1, mas2);
printMatrix(mas3);



