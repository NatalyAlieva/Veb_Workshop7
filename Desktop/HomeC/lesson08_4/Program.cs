// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/* Например, на выходе получается вот такой массив:
 1  2  3  4
12 13 14  5
11 16 15  6
10  9  8  7
 */
int[,] fillMatrix(int n)
{
    int[,] spiralMatrix = new int[n, n];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
        spiralMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return spiralMatrix;
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
Console.Write("Введите размерность массива ");
int n = Int16.Parse(Console.ReadLine());
int[,] mas = fillMatrix(n);
printMatrix(mas);
Console.WriteLine();
