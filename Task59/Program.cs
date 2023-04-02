// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

Console.Clear();

Console.WriteLine("Задайте число строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());

if (rows < 2) 
{
    Console.WriteLine("Число строк массива должно быть больше 1.");
    return;
}

Console.WriteLine("Задайте число столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());

if (columns < 2) 
{
    Console.WriteLine("Число столбцов массива должно быть больше 1.");
    return;
}

int[,] array = Create2DMatrixRndInt(rows,columns, -20,20);

Console.WriteLine ("Маcсив:");
Print2DArray(array);

int[] minNumberCoordinates = MinNumberCoordinates(array);
Console.WriteLine("Координаты наименьшего элемента массива:");
PrintArray(minNumberCoordinates);

int[,] reducedArray = ReducedArray(array, minNumberCoordinates[0], minNumberCoordinates[1]);
Console.WriteLine ("Редуцированный маcсив:");
Print2DArray(reducedArray);


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
            Console.Write($"{matr[i,j], 4}");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(int[] mat)
{
    for (int i = 0; i < mat.Length; i++)
    {
        Console.Write($"{mat[i], 3}");
    }
    Console.WriteLine();
}



int[] MinNumberCoordinates(int[,] arr)
{
    int minNum = arr[0,0];
    int[] coordinates = new int[2];
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for (int j =0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] < minNum)
            {
                minNum = arr[i,j];
                coordinates[0] = i;
                coordinates[1] = j;
            }
        }
    }
    return coordinates;
}

int[,] ReducedArray(int[,] ar, int ii, int jj)
{
    int[,] redArray = new int[ar.GetLength(0) - 1, ar.GetLength(1) - 1];
    {
        for (int i = 0; i < ar.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < ar.GetLength(1) - 1; j++)
            {
                if (i < ii && j < jj)
                {
                redArray[i,j] = ar[i,j];
                }
                else if (i < ii && j >=jj)
                {
                    redArray[i,j] = ar[i,j + 1];
                }
                else if (i >= ii && j < jj)
                {
                    redArray[i,j] = ar[i + 1,j];
                }    
                else if (i >=ii && j >= jj)
                {
                    redArray[i,j] = ar[i + 1,j + 1];
                }

            }
        }
    }

    return redArray;
}