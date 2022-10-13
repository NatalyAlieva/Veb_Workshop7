//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

double[] sum(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[j] += array[i, j];
        }
    }
    return sum;
}

Console.Write("Введите кол-во строк ");
int n = Int16.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов ");
int m = Int16.Parse(Console.ReadLine());
int[,] mas = fillMatrix(n, m);
printMatrix(mas);
Console.WriteLine();
double[] massiv = sum(mas);
for (int q = 0; q < massiv.Length; q++)
{
    Console.Write(Math.Round(massiv[q] / massiv.Length, 2) + "  ");
}


