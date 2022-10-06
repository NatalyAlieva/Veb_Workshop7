/*Задача 34: 
 Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

void FillArray(int[] collection)
{
    for (int i=0;i<collection.Length;i++)
    {
        collection[i]=new Random().Next(100,1000);
        
    }
}

void PrintArray(int[] col)
{
   for (int i=0;i<col.Length;i++)
    {
        Console.Write(col[i]+" ");
    }
}

int FindEven (int[] mas)
{  int count=0;
  for (int i=0;i<mas.Length;i++)
    {   
        if (mas[i] % 2 == 0) 
         count++;
         
    }
    return count;
}

int[] array =new int[4];
FillArray(array);
PrintArray(array);
int number=FindEven(array);
Console.WriteLine("Количество четных чисел = "+number);


