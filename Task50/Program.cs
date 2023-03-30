// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

PrintArray(arr);                        // вызов метода печати массива

Console.Write($"Введите номер строки элемента ( от 0 до {rows - 1}):");
int elementRow = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите номер столбца элемента ( от 0 до {columns - 1}):");
int elementColumn = Convert.ToInt32(Console.ReadLine());

if (elementRow >= rows || elementColumn >= columns) 
    {
    Console.WriteLine($"Такой позиции [{elementRow},{elementColumn}] в массиве нет!");
    return;
    }

Console.WriteLine($"Элемент на позиции [{elementRow},{elementColumn}]: {arr[elementRow,elementColumn]}");

int[,] CreateArray(int rs, int cs)     // задание метода создания массива случайных целых чисел в диапазоне от 0 до 9
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

void PrintArray(int[,] array)           // задание метода вывода массива на консоль
{
    Console.WriteLine();
        
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 3}");
        }
    Console.WriteLine(" |");
    }
}