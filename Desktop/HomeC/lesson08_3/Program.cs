// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/* Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
 */
int[,,] fillMatrix3D(int n, int m, int q)
{
    int[,,] matrix3D = new int[n, m, q];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < q; k++)
            {
                int temp = new Random().Next(10, 100);
                if (matrix3D[i, j, k] == temp)
                    matrix3D[i, j, k] = new Random().Next(10, 100);
                else
                    matrix3D[i, j, k] = temp;
            }

        }
    }

    return matrix3D;
}

void printMatrix3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k],1}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность трехмерной матрицы ");
Console.Write("Введите n ");
int n = Int16.Parse(Console.ReadLine());
Console.Write("Введите m ");
int m = Int16.Parse(Console.ReadLine());
Console.Write("Введите q ");
int q = Int16.Parse(Console.ReadLine());
int[,,] mas = fillMatrix3D(n, m, q);
printMatrix3D(mas);




