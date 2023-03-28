// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

if (arraySize <= 0)
{
    Console.WriteLine("Введено непреемлемое значение размера массива!");
    Console.WriteLine("Массив должен содержать хотя бы один нечетный элемент!");
    return;
}

if (arraySize == 1)
{
    Console.WriteLine("Массив должен содержать хотя бы один нечетный элемент!");
    return;
}


Console.Write("Введите нижную границу диапазона случайных чисел: ");
int minRandom = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите верхнюю границу диапазона случайных чисел: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());

if (maxRandom < minRandom + 2)
{
    Console.WriteLine("Введены некорректные границы диапазона случайных чисел!");
    return;
}


int[] arr = CreateArray(arraySize);     // вызов метода создания массива

PrintArray(arr);                        // вызов метода печати массива

int sumOverOddIndex = SumOverOddIndex(arr);                // вызов метода подсчета суммы элементов с нечётными номерами

Console.WriteLine($"Сумма элементов с нечётными номерами равна: {sumOverOddIndex}");

int[] CreateArray(int arrayLength)     // задание метода CreateArray
{
    int[] newArray = new int[arrayLength];
    
    for(int i = 0; i < arrayLength; i++)
    {
        newArray[i] = new Random().Next(minRandom,maxRandom);
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

int SumOverOddIndex(int[] arr1)                // задание метода подсчета суммы элементов массива с нечетными номерами 
{
    int sum = 0;
    for(int i = 1; i < arr1.Length; i = i + 2)
    {
        sum =sum + arr1[i]; 
    }
    return sum;
}