// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[,] array = Create2DMatrixRndInt(rows,columns, 0,100);

Console.WriteLine ("Маcсив:");
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
            Console.Write($"{matr[i,j], 4}");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}
