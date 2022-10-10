// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
string s=" ";
int count=0;
Console.WriteLine("Введите числа через запятую");
s=Console.ReadLine();
string[] pair=s.Split(',');
int[] mas=new int[pair.Length]; 
for (int i=0;i<mas.Length;i++)
{ 
    mas[i] = Convert.ToInt32(pair[i]);
    if (mas[i]>0)   count++;
}
Console.WriteLine($"Количество чисел больше нуля {count}");


