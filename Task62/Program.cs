// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 15 16 06
// 10 09 08 07  

Console.Clear();

Console.WriteLine("Введите число строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());

if (rows < 1)
Console.WriteLine("Введено неприемлемое число!");

Console.WriteLine("Введите число столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());

if (columns < 1)
Console.WriteLine("Введено неприемлемое число!");

int[,] array = new int[rows,columns];

int minGetLength = rows;
if (rows < columns) minGetLength = columns;

Console.WriteLine("Исходный (пустой) массив:");
Print2DArray(array);

Console.WriteLine("Массив со спиральным заполнением:");
int marker =1;
int elementNum = 1;

SpiralMovement(array,0,0, elementNum);
  

void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j], 4}");
        }
    Console.WriteLine();
    }
}

Print2DArray(array);

int PointChecking(int[,] arr, int i, int j)
{
     int marker = 0;
     if( i >=0 && i < arr.GetLength(0) && j >=0 && j < arr.GetLength(1) && arr[i,j] == 0)
     {
        marker = 1;
     }
     return marker;
}    


void SpiralMovement(int[,] arr2, int i, int j, int num)    // введение метода прохождения массива, с внутренней рекурсией к самому методу:
{   
    while (PointChecking(arr2,i,j) == 1) 
    {
        arr2[i,j] = num;
        num++;
        j++;
    }
    i++;
    j--;
    while (PointChecking(arr2,i,j) == 1) 
    {
        arr2[i,j] = num;
        num++;
        i++;
    }
    i--;
    j--;
    while (PointChecking(arr2,i,j) == 1) 
    {
        arr2[i,j] = num;
        num++;
        j--;
    }
    i--;
    j++;
    while (PointChecking(arr2,i,j) == 1) 
    {
        arr2[i,j] = num;
        num++;
        i--;
    }
    i++;
    j++;
    if (PointChecking(arr2,i,j) == 1) 
    SpiralMovement(array,i,i, num);
}