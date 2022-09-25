//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();
Console.Write("Введите число ");
int a = Int32.Parse(Console.ReadLine());
string str = a.ToString();
int[] aint = new int[str.Length];

if (str.Length > 2)
{
    aint[2] = int.Parse(str[2] + "");
    Console.WriteLine(aint[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

