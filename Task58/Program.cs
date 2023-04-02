// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();

Console.WriteLine("Задайте число строк 1-ой матрицы:");
int rows1 = Convert.ToInt32(Console.ReadLine());

if (rows1 < 1) 
{
    Console.WriteLine("Число строк матрицы должно быть больше 0.");
    return;
}

Console.WriteLine("Задайте число столбцов 1-ой матрицы:");
int columns1 = Convert.ToInt32(Console.ReadLine());

if (columns1 < 1) 
{
    Console.WriteLine("Число столбцов матрицы должно быть больше 0.");
    return;
}

Console.WriteLine("Задайте число строк 2-ой матрицы:");
int rows2 = Convert.ToInt32(Console.ReadLine());

if (rows2 < 1) 
{
    Console.WriteLine("Число строк матрицы должно быть больше 0.");
    return;
}

Console.WriteLine("Задайте число столбцов 2-ой матрицы:");
int columns2 = Convert.ToInt32(Console.ReadLine());

if (columns2 < 1) 
{
    Console.WriteLine("Число столбцов матрицы должно быть больше 0.");
    return;
}

if (columns1 != rows2)  
{
    Console.WriteLine ("Матрицы с такими параметрами не могут быть перемножены: число строк второй матрицы не равно числу столбцов первой.");
    return;
}

int[,] matrix1 = Create2DMatrixRndInt(rows1,columns1, 0,10);
int[,] matrix2 = Create2DMatrixRndInt(rows2,columns2, 0,10);
int[,] matrixProduct = MatrixProduct(matrix1,matrix2);

Console.WriteLine ("Матрица 1:");
Print2DArray(matrix1);

Console.WriteLine ("Матрица 2:");
Print2DArray(matrix2);

Console.WriteLine ("Произведение матриц:");
Print2DArray(matrixProduct);



int[,] Create2DMatrixRndInt(int rs, int cs, int min, int max)
{                          // 0       1
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
int[,] MatrixProduct(int[,] matr1, int[,] matr2)
{
    if (matr1.GetLength(1) != matr2.GetLength(0))  
    {
        Console.WriteLine ("Матрицы с такими параметрами не могут быть перемножены.");
    }
    int [,] matrProd = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i =0; i < matr1.GetLength(0); i++)
    {
        for (int j =0; j < matr2.GetLength(1); j++)
            {
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    matrProd[i,j] += matr1[i,k]*matr2[k,j]; 
                } 
            }
    }
    return matrProd;
}
