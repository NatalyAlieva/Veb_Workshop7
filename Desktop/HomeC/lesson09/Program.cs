//Написать программу, которая из сформированного массива строк 
//содержащих символы и числа создать массив из строк, в который 
//попадут только символы, не являющиеcя цифрами int.

char[,] ArrayChar()
{
int rows = new Random().Next(5, 10);
int col = new Random().Next(5, 10);
char[,] str = new char[rows, col];
var r = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < col; j++)
    {    do

                str[i,j] = (char)r.Next(127);
            while (str[i,j] < '!');
    }
}
    return str;
}    

void PrintArray(char[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} [{i},{j}] ");
        }
        Console.WriteLine();
    }
}

char[] ArraySymbol(char[,] array2D)
{//определить количество символов в array2D для размерности нового массива
    int count = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] >= '0' && array2D[i, j] <= '9')
                Console.WriteLine($"Элемент [{i},{j}]={array2D[i, j]} является цифрой");
            else
                count++;
        }
    }
  //конец определить количество символов в array2D для размерности нового массива
    Console.WriteLine();
    Console.WriteLine("Результирующий массив");
    char[] array1D = new char[count];
    int k = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j]! >= '0' && array2D[i, j]! <= '9')
            { }
            else
            {
                array1D[k] = array2D[i, j];
                Console.Write($"{array1D[k]}({k}) ");
                k++;
            }
        }
        Console.WriteLine();
    }
    return array1D;
}


char[,] matrix = ArrayChar();
Console.WriteLine("Входной массив ");
PrintArray(matrix);
Console.WriteLine();
char[] massiv = ArraySymbol(matrix);




