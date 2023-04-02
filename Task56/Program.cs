// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

Console.Clear();

Console.WriteLine("Задайте число строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());

if (rows < 1) 
{
    Console.WriteLine("Число строк массива должно быть больше 0.");
    return;
}

Console.WriteLine("Задайте число столбцов массива:");
int columns = Convert.ToInt32(Console.ReadLine());

if (columns < 1) 
{
    Console.WriteLine("Число столбцов массива должно быть больше 0.");
    return;
}

int[,] array = Create2DMatrixRndInt(rows,columns, 0,10);

Console.WriteLine ("Массив:");
Print2DArray(array);

int stringWithMinSum = StringWithMinSum(array);
Console.WriteLine ($"Индекс строки с минимальной суммой элементов: {stringWithMinSum}");



int[,] Create2DMatrixRndInt(int rows, int columns, int min, int max)
{                          
    int[,] matrix = new int[rows, columns];
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
        Console.Write($"[индекс строки: {i,3} ]");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j], 4}");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

int StringWithMinSum(int[,] arr)
{
    int stringIndex = 0;
    
    int minSum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        minSum = minSum + arr[0,j];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
        {
            int stringSum = 0;

            for (int j = 0; j < arr.GetLength(1); j++)
                {
                    stringSum = stringSum + arr[i,j];
                }
            if(stringSum < minSum)
            {
                minSum = stringSum;
                stringIndex = i;
            }
        }

    return stringIndex;
}