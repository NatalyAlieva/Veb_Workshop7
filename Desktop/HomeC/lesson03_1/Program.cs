// Задача 19. Напишите метод, который принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void FillArray(int[] collection)
{
    int index = 0;
    while (index < 5)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

void Palindrom(int[] number)
{
    int count = 0;
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] == number[number.Length - 1 - i]) count++;
    }
    if (count ==2) Console.WriteLine(" да");
    else Console.WriteLine(" нет");
}

int[] array = new int[5];
//int[] array ={1,4,2,1,2};
FillArray(array);
PrintArray(array);
Palindrom(array);
Console.WriteLine();