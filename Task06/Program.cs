// Задача 06: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 0) Console.WriteLine("Является чётным");

else 
{
    Console.WriteLine("Не является чётным");
};

Console.WriteLine();

