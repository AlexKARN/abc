// Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Hello, Task06 !");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
Console.WriteLine($"Число {number} является чётным");
else
Console.WriteLine($"Число {number} НЕ является чётным");
