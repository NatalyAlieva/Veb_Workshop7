Console.Write("Введите первое целое число ");
int ch1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе целое число ");
int ch2 = Int32.Parse(Console.ReadLine());

if (ch1 > ch2)
{
    Console.Write("max=");
    Console.WriteLine(ch1);
}
else
{
    Console.Write("max=");
    Console.WriteLine(ch2);
}

