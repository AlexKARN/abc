// Задача 08: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int lastCount = (n / 2) * 2;

if (n < 2) { Console.Write($"Чётных чисел в диапазоне от 1 до {n} нет"); }
else
{
    Console.Write($"Чётные числа в диапазоне от 1 до {n}:  ");
    for (int i = 2; i <= n - 2; i += 2)
        Console.Write($"{i}, ");
        Console.WriteLine($"{lastCount}.");
};








