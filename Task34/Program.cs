// Задача 34: Задайте массив, заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 0)
{
    Console.WriteLine("Введено некорректное значение!");
    return;
}

int[] arr = CreateArray(arraySize);     // вызов метода создания массива

PrintArray(arr);                        // вызов метода печати массива

int numberOfEvens = NumberOfEvens(arr);                // вызов метода подсчета чётных чисел в массиве

Console.WriteLine($"Количество чётных чисел в массиве равно: {numberOfEvens}");

int[] CreateArray(int arrayLength)     // задание метода CreateArray
{
    int[] newArray = new int[arrayLength];
    
    for(int i = 0; i < arrayLength; i++)
    {
        newArray[i] = new Random().Next(100,1000);
    }
    return newArray;
} 

void PrintArray(int[] array)           // задание метода вывода массива на консоль
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int NumberOfEvens(int[] arr1)                // задание метода подсчета чётных чисел в массиве 
{
    int result = 0;
    for(int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] % 2 == 0)  result++; 
    }
    return result;
}