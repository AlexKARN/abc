// Задача 60: Сформируйте трехмерный массив из неповторяющихся двухзначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя
// индексы каждого элемента.

Console.Clear();

Console.WriteLine("Задайте первый размер 3-мерного массива:");
int size1 = Convert.ToInt32(Console.ReadLine());

if (size1 < 1 || size1 > 90) 
{
    Console.WriteLine("Задан неприемлемый размер!");
    return;
}

Console.WriteLine("Задайте второй размер 3-мерного массива:");
int size2 = Convert.ToInt32(Console.ReadLine());

if (size2 < 1 || size1*size2 > 90) 
{
    Console.WriteLine("Задан неприемлемый размер!");
    return;
}

Console.WriteLine("Задайте третий размер 3-мерного массива:");
int size3 = Convert.ToInt32(Console.ReadLine());

if (size3 < 1 || size1*size2*size3 > 90) 
{
    Console.WriteLine("Задан неприемлемый размер!");
    return;
}

int[,,] array = Create3Darray(size1,size2,size3);

Console.WriteLine($"Массив размером {size1} * {size2} * {size3} :");
Print3Darray(array);

int[,,] Create3Darray(int s1, int s2, int s3)
{                          
    int[,,] matrix = new int[s1, s2, s3];
    int number = 99;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = number;                
                number--;
            }
        }

    }
    return matrix;
}

void Print3Darray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        { 
            for (int k = 0; k < matr.GetLength(2); k++)
                {
                Console.Write($"{matr[i,j,k]}({i},{j},{k}) ");
                }
        }
    Console.WriteLine();
    }
}
