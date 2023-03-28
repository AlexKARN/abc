// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1*x + b1, y = k2*x + b2; 
// значения b1,k1,b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine($"Введите коэффициент b1:");
    double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите коэффициент k1:");
    double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите коэффициент b2:");
    double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите коэффициент k2:");
    double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 != b2) 
{
    Console.WriteLine("При данном наборе параметров прямые не пересекаются (они параллельны)!");
    return;
}
if(k1 == k2 && b1 == b2) 
{
    Console.WriteLine("При данном наборе параметров прямые совпадают!");
    return;
}


Console.WriteLine("_________________________");
Console.WriteLine("Пользователь ввёл коэффициенты:");
Console.WriteLine($"b1 = {b1}  k1 = {k1}  b2 = {b2}  k2 = {k2}");

double[] pointCoordinates = PointCoordinates(b1,k1,b2,k2); 
Console.WriteLine($"Точка пересечения прямых имеет координаты: x = {pointCoordinates[0]}  y = {pointCoordinates[1]}");


double[] PointCoordinates(double d1,double d2,double d3,double d4)   // задание метода вычисления координат точки пересечения прямых
{   double[] point = {0,0};
     point[0] = Math.Round((d3 - d1)/(d2 - d4), 2);
     point[1] = Math.Round((d2*d3 - d1*d4)/(d2 - d4), 2);
    return point;
}