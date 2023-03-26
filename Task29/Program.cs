// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в произвольном порядке.
// [1,0,1,1,0,1,0,0]
Console.Clear();
Console.Write("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.Read());

if (arraySize <= 0)
{
    Console.WriteLine("Введено неверное значение!");
    return;
}
 int arr = CreateArray(arraySize);   // вызов метода
PrintArray(arr);                    // вызов void-метода


int[] CreateArray(int arrayLength);
{
    int[] newArray = new int[arrayLength];
    Random random = new Random();

    for(int i = 0; i < arrayLength; i++)
    {
        newArray[i] = random.Next(0,2);
    }
    return newArray;
}

void PrintArray(int[] array);
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}