// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

Console.Clear();

Console.WriteLine("Задайте число строк массива:");
int rows = Convert.ToInt32(Console.ReadLine()); 

if (rows < 1) 
{
    Console.WriteLine("Введено неприемлемое число!");
    return;
}

Console.WriteLine("Задайте число столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());

if (columns < 1) 
{
    Console.WriteLine("Введено неприемлемое число!");
    return;
}


int[,] array = Create2DMatrixRndInt(rows,columns, 0,30);

Print2DArray(array);

ArrangedArray(array);

Console.WriteLine("Упорядоченный массив:");
Print2DArray(array);


int[,] Create2DMatrixRndInt(int rs, int cs, int min, int max)
{                      
    int[,] matrix = new int[rs, cs];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }

    }
    return matrix;
}

void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j], 3}");
        }
    Console.WriteLine();
    }
}


void MaxOnFirst(int[,] arr, int rowID, int columnID)
{
    int tempMax = arr[rowID, columnID];
    for (int j = columnID; j < arr.GetLength(1); j++)
    {
        if (arr[rowID,j] > tempMax)
        {
            tempMax = arr[rowID,j];
        arr[rowID, j] = arr[rowID, columnID]; 
        arr[rowID, columnID] = tempMax;
        }
    }
}

void ArrangedArray(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        MaxOnFirst(arr1, i, j);
     }
}