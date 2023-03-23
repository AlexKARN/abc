// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
char num3;
if (number < 0) number = -number;
string snumber = Convert.ToString(number);
if (snumber.Length < 3) Console.WriteLine("Третьей цифры нет");
else
    {
        num3 = snumber[2];
        Console.WriteLine($"Третья цифра введенного числа: {num3}");
    }   
