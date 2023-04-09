// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательный числа m и n.
// m = 2, n = 3  -> A(m,n) = 9
// m = 3, n = 2  -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите первое натуральное число:");
int m = Convert.ToInt32(Console.ReadLine());

if (m < 0)
{
    Console.WriteLine("Введено неприемлемое число!");
    return;
}

Console.WriteLine("Введите второе натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Введено неприемлемое число!");
    return;
}

Console.WriteLine($"A({m},{n}) = {Ackermann(m,n)}");

int Ackermann(int m1, int m2)  // метод вычисления функции Аккермана на основе версии (рекуррентных формул) Розы Петер
{
    if (m1 == 0 && m2 >=0)
    return (m2 + 1);
    else if (m1 > 0 && m2 == 0)
    return Ackermann(m1 - 1, 1);
    else
    return Ackermann(m1 - 1, Ackermann( m1, m2 - 1));
}