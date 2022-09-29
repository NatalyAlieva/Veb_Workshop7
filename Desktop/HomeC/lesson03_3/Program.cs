// Задача 23
// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Cubes(int n)
{
           int[] result=new int[n];
       for (int i=1;i<n+1;i++)
       {
        Console.WriteLine(Math.Pow(i, 3)+" ");
       }
        
}
Console.Write("Введите n = ");
int a=Int32.Parse(Console.ReadLine());
Cubes(a);
