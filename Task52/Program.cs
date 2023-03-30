// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 

Console.Clear();
Console.Write("Введите число строк двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

if(rows < 1) 
{
    Console.WriteLine("Введено некорректное значение числа строк!");
    return;
}    

Console.Write("Введите число столбцов двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

if(columns < 1) 
{
    Console.WriteLine("Введено некорректное значение числа столбцов!");
    return;
}    

int[,] arr = CreateArray(rows, columns);  // вызов метода создания массива

Console.Write($"Сгенерирован массив размером {rows} x {columns}:");

PrintArray(arr);                        // вызов метода печати созданного массива

Console.WriteLine("Средние арифметические столбцов:");

PrintColumnsMeanArithm(arr);   // вызов void-метода вывода на консоль средних арифметических столбцов двумерного массива целых чисел 


int[,] CreateArray(int rs, int cs)     // задание метода создания двумерного массива случайных целых чисел в диапазоне от 0 до 9
{
    int[,] newArray = new int[rs,cs];

    for (int i = 0; i < rs; i++)
    {
        for(int j = 0; j < cs; j++)
        {
        newArray[i,j] = new Random().Next(0,10);
        }
    }
    return newArray;
}

void PrintArray(int[,] array)           // задание метода вывода двумерного массива на консоль
{
    Console.WriteLine();
        
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 4}");
        }
    Console.WriteLine(" |");
    }
}

void PrintColumnsMeanArithm(int[,] array)   // задание void-метода вывода на консоль средних арифметических столбцов двумерного массива целых чисел 
{
for(int i = 0; i < array.GetLength(1); i++)
    {
    double sum = 0;
    double dRows = Convert.ToDouble(rows);
    for ( int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + Convert.ToDouble(arr[j,i]);
        }
    sum = Math.Round(sum/dRows, 1);
    Console.Write($"  {sum}");
    }
}    