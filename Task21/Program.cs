// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D-пространстве.
// A(3,6,8); B(2,1,-7) -> 15,84
// A(7,-5,0); B(1,-1,9) -> 11,53

Console.Clear();

double[] pACoordinates = {0,0,0};
double[] pBCoordinates = {0,0,0};

Ask3DCoordinates(pACoordinates, "A");
Ask3DCoordinates(pBCoordinates, "B");

double distance3D = Distance3D(pACoordinates, pBCoordinates);
Console.WriteLine($"Расстояние между точками равно: {distance3D}");


void Ask3DCoordinates(double[] coordinates, string nameOfPoint)
{
    for (int i = 1; i <= 3; i++)
    {
        Console.WriteLine($"Введите координату {i} точки {nameOfPoint}:");
        coordinates[i - 1] = Convert.ToDouble(Console.ReadLine());
    }
}


double Distance3D(double[] point1, double[] point2)
{
    double tempSquareSum = 0;
    
    for (int i = 0; i < 3; i++)
    {
        tempSquareSum = tempSquareSum + (point1[i] - point2[i]) * (point1[i] - point2[i]);
    }
    double distance = Math.Sqrt(tempSquareSum);
    distance = Math.Round(distance, 2);
    return distance;
}
