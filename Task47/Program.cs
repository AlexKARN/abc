// Задача 47: Задайте двумерный массив размером m x n, заполненный случайными 
// вещественными числами. 


Console.Clear();
Console.Write("Введите число строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

if (rows < 1)
{
    Console.WriteLine("Введено некорректное значение числа строк!");
    return;
}

Console.Write("Введите число столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (columns < 1)
{
    Console.WriteLine("Введено некорректное значение числа столбцов!");
    return;
}


double[,] arr = CreateArray(rows, columns);  // вызов метода создания массива

PrintArray(arr);                        // вызов метода печати массива


double[,] CreateArray(int rs, int cs)     // задание метода создания массива случайных вещемтвенных чисел
{
    double[,] newArray = new double[rs, cs];

    for (int i = 0; i < rs; i++)
    {
        for (int j = 0; j < cs; j++)
        {
            newArray[i, j] = Math.Round((100 * (new Random().NextDouble() - 0.5)), 2);
        }
    }
    return newArray;
}

void PrintArray(double[,] array)           // задание метода вывода массива на консоль
{
    Console.WriteLine();
    Console.WriteLine($"Размер массива: m = {array.GetLength(0)}, n ={array.GetLength(1)}");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("| ");
            Console.Write($"{array[i, j],6}");
        }
        Console.WriteLine(" |");
    }
}
