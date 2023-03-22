// Задача 08: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int lastCount = (N / 2) * 2;

if (N < 2) { Console.Write($"Чётных чисел в диапазоне от 1 до {N} нет"); }
else
{
    Console.Write($"Чётные числа в диапазоне от 1 до {N}:  ");
    for (int i = 2; i <= N - 2; i += 2)
        Console.Write($"{i}, ");
        Console.WriteLine($"{lastCount}.");
};








