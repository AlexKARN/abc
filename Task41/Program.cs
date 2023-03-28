// Задача 41: Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine("Введите желательное количество запросов числа у пользователя:");
int howManyNumberRequests = Convert.ToInt32(Console.ReadLine());

if (howManyNumberRequests < 1) 
{
    Console.WriteLine("Введённое число запросов неприемлемо!");
    return;
}

int[] inputNumbers = InputNumbers(howManyNumberRequests);

Console.WriteLine("_________________________");
Console.WriteLine("Пользователь ввёл числа:");
PrintArray (inputNumbers);

int numbersBiggerThanZero = NumbersBiggerThanZero(inputNumbers); 
Console.WriteLine($"Среди {inputNumbers.Length} чисел, введённых пользователем, чисел больше нуля: { numbersBiggerThanZero}");


int[] InputNumbers(int arrayLength)     // задание метода создания массива - последовательным вводом чисел
{
    int[] newArray = new int[arrayLength];

    for (int i = 1; i <= arrayLength; i++)
    {
        Console.WriteLine($"Введите число № {i} из {arrayLength}:");
        newArray[i-1] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void PrintArray(int[] array)           // задание метода вывода массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

int NumbersBiggerThanZero(int[] arr)
{   int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result=result + 1;
    }
    return result;
}