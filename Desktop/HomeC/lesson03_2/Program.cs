// Задача 21.
// Напишите метод, который принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int[] CoordinatesPoints(int[] point)
{
    for (int i = 0; i < 3; i++)
    {
        Console.Write("Введите координаты точки ");
        point[i] = int.Parse(Console.ReadLine());
    }
    return point;
}

void Distance(int[] args1, int[] args2)
{
    double distance = Math.Sqrt(Math.Pow(args2[0] - args1[0], 2) +
    +Math.Pow(args2[1] - args1[1], 2) + Math.Pow(args2[2] - args1[2], 2));
    Console.Write(distance);
}
int[] point1 = new int[3];
int[] point2 = new int[3];
CoordinatesPoints(point1);
CoordinatesPoints(point2);
Distance(point1, point2);