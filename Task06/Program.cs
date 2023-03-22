// Задача 06: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0) Console.WriteLine($"Число {N} является чётным");

else 
{
    Console.WriteLine($"Число {N} не является чётным");
};

Console.WriteLine();

