// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии.

Console.Clear();
Console.WriteLine("Введите натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 1 )
{
    Console.WriteLine("Введено неприемлемое число!");
    return;
}

NaturalNumbers(n);

void NaturalNumbers(int num)
{
    if (num == 0)
    return;
Console.Write($"{num, 3}");
NaturalNumbers(num-1);
}