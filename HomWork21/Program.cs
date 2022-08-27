/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

double x1 = Kor("x", "A");
double y1 = Kor("y", "A");
double z1 = Kor("z", "A");
double x2 = Kor("x", "B");
double y2 = Kor("y", "B");
double z2 = Kor("z", "B");

int Kor(string KorName, string point)
{
    Console.Write($"Введите координату {KorName} точки {point}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Длина отрезка  {segmentLength}");



