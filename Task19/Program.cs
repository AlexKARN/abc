// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. Выполнить с помощью 
// числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;

int numberLength = NumberLength(number);
int[] numberDigits = NumberDigits(number, numberLength);
bool yesPalindrom = YesPalindrom(numberDigits);

Console.WriteLine($"Количество цифр числа:  {numberLength}");

Console.Write("Массив цифр числа:  ");

PrintArray(numberDigits);

Console.WriteLine();

Console.WriteLine($"Введённое число является палиндромом: {yesPalindrom}");


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
int[] NumberDigits(int num2, int num2Length)     // метод возвращает массив, состоящий из цифр заданного числа
{
    int[] array = new int[num2Length];
    for (int i = 0; i < num2Length; i++)
    {
        array[i] = num2 % 10;
        num2 = num2 / 10;
    }
    return array;
}

bool YesPalindrom(int[] numberDigits)         // метод определяет палиндромность массива целых чисел         
{
    bool result = true;
    for (int i = 0; i < numberDigits.Length / 2; i++)
    {
        if (numberDigits[i] != numberDigits[numberDigits.Length - i - 1])
        {
            result = false;
            break;
        }
    }
    return result;
}

void PrintArray(int[] array)                 // метод выводит на консоль массив чисел 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

