// Напишите программу, которая принимает на вход число
// и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int[] numberDigits = NumberDigits(number);
int sumOfDigits = SumOfDigits(numberDigits); 

Console.WriteLine($"Сумма цифр введённого числа {number} равна: {sumOfDigits}");


int SumOfDigits(int[] array)   // метод возвращает сумму элементов массива
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

int NumberLength(int num1)                    // метод возвращает количество цифр в числе.
{
    int count = 0;
    while (num1 > 0)
    {
        num1 = num1 / 10;
        count++;
    }
    return count;
}
int[] NumberDigits(int num2)     // метод возвращает массив, состоящий из цифр заданного числа
{
    int num2Length = NumberLength(num2);   // метод NumberLength вызывается внутри метода NumberDigits                 

    int[] array = new int[num2Length];
    for (int i = 0; i < num2Length; i++)
    {
        array[i] = num2 % 10;
        num2 = num2 / 10;
    }
    return array;
}