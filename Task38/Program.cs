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

double maxElement = MaxElement(arr);    // вызов метода определения максимального элемента массива
double minElement = MinElement(arr);    // вызов метода определения минимального элемента массива
double diffMaxMin = DiffMaxMin(maxElement, minElement);    // вызов метода вычисления разности максимального и минимального элементов массива

Console.WriteLine($"Максимальный элемент массива: {maxElement}");
Console.WriteLine($"Минимальный элемент массива: {minElement}");
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

double DiffMaxMin(double max, double min)                // задание метода вычисления разности двух вещественных чисел 
{
    double diff = Math.Round((max - min),1);
    return diff;   
}

double MaxElement(double[] arr1)          // задание метода определения максимального элемента массива
{
    double max = arr1[0];
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] > max) max = arr1[i];
    }
    return Math.Round(max,1);
}

double MinElement(double[] arr2)          // задание метода определения минимального элемента массива
{
    double min = arr2[0];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] < min) min = arr2[i];
    }
    return Math.Round(min,1);
}