// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int absnum = Math.Abs(number);

if (absnum > 100) 
    {
        int tempnum = absnum/100;
        int thirdNumber = tempnum % 10;
        Console.Clear();
        Console.WriteLine($"Введённое число: {number}");
        Console.WriteLine($"Третья цифра введенного числа: {thirdNumber}");
    }
    
else
    { 
       Console.WriteLine("Третьей цифры у введенного числа нет.");
    }