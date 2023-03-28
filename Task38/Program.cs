// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.


Console.Clear();
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 0)
{
    Console.WriteLine("Введено некорректное значение размера массива!");
    return;
}

double[] arr = CreateArray(arraySize);  // вызов метода создания массива

PrintArray(arr);                        // вызов метода печати массива

double diffMaxMin = DiffMaxMin(arr);    // вызов метода вычисления разности максимального и минимального элементов массива

Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна: {diffMaxMin}");


double[] CreateArray(int arrayLength)     // задание метода создания массива случайных вещемтвенных чисел
{
    double[] newArray = new double[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        newArray[i] = Math.Round(100 * new Random().NextDouble(), 1);
    }
    return newArray;
}

void PrintArray(double[] array)           // задание метода вывода массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

double DiffMaxMin(double[] arr1)                // задание метода вычисления разности максимального и минимального элементов массива 
{
    double diff = 0;
    double max = arr1[0];
    double min = arr1[0];
    for(int i = 0; i < arr1.Length; i = i++)
    {
        // if (arr1[i] > max) max = arr1[i];
        // if (arr1[i] < min) min = arr1[i];
    }
    diff = Math.Round(max - min, 1);
    // return diff;
    return Convert.ToDouble(arr1.Length);
}

