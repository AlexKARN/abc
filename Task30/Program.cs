// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в произвольном порядке.
// [1,0,1,1,0,1,0,0]

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

int[] CreateArray(int arrayLength)     // задание метода CreateArray
{
    Random random = new Random();

    int[] newArray = new int[arrayLength];
    
    for(int i = 0; i < arrayLength; i++)
    {
        newArray[i] = random.Next(0,2);
    }
    return newArray;
} 

void PrintArray(int[] array)           // задание метода PrintArray
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}

