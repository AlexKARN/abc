﻿// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D-пространстве.

Console.Clear();

double[] p1 = {0,0,0};
double[] p2 = {0,0,0};

Ask3DCoordinates(p1, "A");
Ask3DCoordinates(p2, "B");

double distance3D = Distance3D(p1, p2);
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
