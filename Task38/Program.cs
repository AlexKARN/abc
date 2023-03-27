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


Console.Write("Введите нижную границу диапазона случайных чисел (вещественное число): ");
double minRandom = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите верхнюю границу диапазона случайных чисел (вещественное число): ");
double maxRandom = Convert.ToDouble(Console.ReadLine());

if (maxRandom <= minRandom + 0.2)
{
    Console.WriteLine("Введены некорректные границы диапазона случайных чисел!");
    return;
}


double[] arr = CreateArray(arraySize);     // вызов метода создания массива

PrintArray(arr);                        // вызов метода печати массива

double diffMaxMin = DiffMaxMin(arr);                // вызов метода вычисления разности максимального и минимального элементов массива

Console.WriteLine($"Разность между максимальныи=м и минимальным элементами массива равна: {diffMaxMin}");

double[] CreateArray(int arrayLength)     // задание метода создания массива случайных вещемтвенных чисел
{
    double[] newArray = new double[arrayLength];
    
    for(int i = 0; i < arrayLength; i++)
    {
        newArray[i] = Math.Round(new Random().NextDouble(), 3);
    }
    return newArray;
} 

void PrintArray(double[] array)           // задание метода вывода массива на консоль
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double DiffMaxMin(double[] arr1)                // задание метода вычисления разности максимального и минимального элементов массива 
{
    double diff = 0;
    double max = arr1[0];
    double min = arr1[0];
    for(int i = 1; i < arr1.Length; i = i++)
    {
        if (arr1[i] > max) max = arr1[i];
        else if (arr1[i] < min) min = arr1[i];
    }
    return (max - min);
}