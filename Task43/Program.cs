// Задача 43: Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1*x + b1, y = k2*x + b2; 
// значения b1,k1,b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0.5, -0.5)

Console.Clear();
string[] coeffNames = {"b1","k1","b2","k2"};

double[] inputCoeff = InputCoeff(coeffNames);  // вызов метода ввода коэффициентов по их именам


if(inputCoeff[0] == inputCoeff[2] && inputCoeff[1] != inputCoeff[3]) 
{
    Console.WriteLine("При данном наборе параметров прямые не пересекаются (они параллельны)!");
    return;
}
if(inputCoeff[0] == inputCoeff[2] && inputCoeff[1] == inputCoeff[3]) 
{
    Console.WriteLine("При данном наборе параметров прямые совпадают!");
    return;
}


Console.WriteLine("______________________________");
Console.WriteLine("Пользователь ввёл коэффициенты:");

for (int i =0; i < coeffNames.Length; i++)
{
Console.Write($"{coeffNames[i]} = {inputCoeff[i]}   ");
}

Console.WriteLine();

double[] pointCoordinates = PointCoordinates(inputCoeff); 
Console.WriteLine($"Точка пересечения прямых имеет координаты: x = {pointCoordinates[0]}  y = {pointCoordinates[1]}");


double[] PointCoordinates(double[] d)   // задание метода вычисления координат точки пересечения прямых
{   double[] point = {0,0};
     point[0] = Math.Round((d[2] - d[0])/(d[1] - d[3]), 2);
     point[1] = Math.Round((d[1]*d[2] - d[0]*d[3])/(d[1] - d[3]), 2);
    return point;
}

double[] InputCoeff(string[] names)                         // задание метода ввода пользователем коэффициентов по их именам           
{
    double[] arr = {0,0,0,0};
    for (int i = 0; i < 4; i++)
    {
    Console.WriteLine($"Введите коэффициент {names[i]}:");
    arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}
