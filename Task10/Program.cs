// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int absnum = Math.Abs(number);

if (absnum > 99 && absnum < 1000) 
    {
        int tempnum = absnum/10;
        int secondNumber = tempnum % 10;
        Console.Clear();
        Console.WriteLine($"Введённое число: {number}");
        Console.WriteLine($"Вторая цифра введенного числа: {secondNumber}");
    }
        
else
    { 
       Console.WriteLine("Введено ненадлежащее число.");
    };

