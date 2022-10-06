/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void FillArray(int[] collection)
{
    for (int i=0;i<collection.Length;i++)
    {
        collection[i]=new Random().Next(1,100);
        
    }
}

void PrintArray(int[] col)
{
   for (int i=0;i<col.Length;i++)
    {
        Console.Write(col[i]+" ");
    }
}

int FindNoEvenIndex (int[] mas)
{  int  sum=0;
  for (int i=1;i<mas.Length;i+=2)
    {   
        sum=sum+mas[i];
         
    }
    return sum;
}

int[] array =new int[6];
FillArray(array);
PrintArray(array);
int amount=FindNoEvenIndex(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = "+amount);