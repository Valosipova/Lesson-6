// Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindingIntersectionPoints(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;

        Console.WriteLine($"Две прямые пересекутся в точке с координатами x: {x}, y: {y}");
    }
}

Console.Write("Введите значение точки b1: ");
double pointB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение точки k1: ");
double pointK1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение точки b2: ");
double pointB2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение точки k2: ");
double pointK2 = Convert.ToDouble(Console.ReadLine());

FindingIntersectionPoints(pointB1, pointK1, pointB2, pointK2);
