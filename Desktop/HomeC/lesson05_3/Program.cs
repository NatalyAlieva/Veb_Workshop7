/*Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/
void FillArray(float[] collection)
{
    for (int i=0;i<collection.Length;i++)
    {
        collection[i]=new Random().Next(1,100);
        
    }
}

void PrintArray(float[] col)
{
   for (int i=0;i<col.Length;i++)
    {
        Console.Write(col[i]+" ");
    }
}

float Difference(float[] mas)
{
float min = mas[1];
float max = mas[1];
for (int i=0;i<mas.Length;i++)  
{
    if (min > mas[i]) min = mas[i];
    if (max < mas[i]) max = mas[i];
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
return (max-min);
}

float[] array =new float[5];
FillArray(array);
PrintArray(array);
float number=Difference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом: {number}");

