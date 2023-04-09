// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Введите первое целое число:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число:");
int n = Convert.ToInt32(Console.ReadLine());

if ( m > n )
{
    int tempN = n;
    n = m;
    m = tempN;
}

Console.WriteLine($"Сумма целых чисел в промежутке от {m} до {n} равна {Sum(m,n)}");

int Sum(int num1, int num2)
{
    if (num1 > num2)
    return 0;
    else return (num1 + Sum( num1 + 1, num2));
}