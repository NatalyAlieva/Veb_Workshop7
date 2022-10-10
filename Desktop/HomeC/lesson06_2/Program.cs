//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1,
//                     y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите значение b1");
float b1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1");
float k1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
float b2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2");
float k2 = Int32.Parse(Console.ReadLine());
if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу");
else 
{
    float x_res =(b2-b1)/(k1-k2);
    float y_res =k1*x_res+b1;
    Console.WriteLine($"Точка пересечения ({x_res};{y_res})");
}