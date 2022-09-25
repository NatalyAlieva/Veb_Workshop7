//Напишите программу, которая принимает на вход семь 
//чисел, и находит их среднее арифметическое
//1 2 3 4 5 6 7-> 4
//10 20 30 40 50 60 70 -> 40
int[] a = new int[7];
int count = 0;
int sum = 0;
int i = 0;
int n = 7;
while (i < n)
{
    Console.WriteLine("Ввести элемент массива");
    a[i] = int.Parse(Console.ReadLine());
    sum = sum + a[i];
    count++;
    i++;
}
Console.WriteLine("Сумма= " + sum);
Console.WriteLine("Количество= " + count);
Console.WriteLine("Среднее арифметическое= " + sum / count);

