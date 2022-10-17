// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/* 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт
 номер строки с наименьшей суммой элементов: 1 строка
 */

int[,] fillMatrix(int n)
{
    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
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

int[] sum(int[,] array)
{
    int[] sum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}

int minLine(int[] array)
{
    int min = array[1], index = 1;
    for (int i = 0; i < array.Length; i++)

        if (min > array[i])
        {
            min = array[i];
            index = i;
        }

    return index;
}
Console.Write("Введите размерность массива ");
int n = Int16.Parse(Console.ReadLine());
int[,] mas = fillMatrix(n);
printMatrix(mas);
Console.WriteLine();
int[] massiv = sum(mas);
int str = minLine(massiv);
Console.WriteLine("Строка с наименьшей суммой элементов " + str);
for (int q = 0; q < massiv.Length; q++)
{
    Console.Write(massiv[q] + " ");
}


