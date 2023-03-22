// Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maxNum = num1;

if (maxNum < num2)  maxNum = num2;

if (maxNum < num3)  maxNum = num3;

Console.WriteLine($"Введены числа: {num1}, {num2}, {num3}");
Console.WriteLine($"Максимальным является число {maxNum}");
