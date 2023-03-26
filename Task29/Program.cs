// Задача 29: Напишите программу, которая задаем массив из 8 элементов,
// заполненный псевдослучайными числами, и выводит их на экран.
// 1,2,5,7,19,6,1,33 -> [1,2,5,7,19,6,1,33]

Console.Clear();
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 0)
{
    Console.WriteLine("Введено некорректное значение!");
    return;
}

int[] arr = CreateArray(arraySize);     // вызов метода создания массива

PrintArray(arr);                        // вызов метода первой печати массива
Console.Write(" -> [");
PrintArray(arr);                        // вызов метода второй печати массива 
Console.Write("]");


int[] CreateArray(int arrayLength)     // задание метода CreateArray
{
    Random random = new Random();

    int[] newArray = new int[arrayLength];
    
    for(int i = 0; i < arrayLength; i++)
    {
        newArray[i] = random.Next(0,50);
    }
    return newArray;
} 

void PrintArray(int[] array)           // задание метода PrintArray
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length -1]}");
}

