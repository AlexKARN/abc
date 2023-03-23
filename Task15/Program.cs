// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным. 
// 6 -> да,
// 7 -> да,
// 1 -> нет.

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели (от 1 до 7):");
int weekDay = Convert.ToInt32(Console.ReadLine());
if (weekDay == 6 || weekDay == 7) Console.WriteLine($"День {weekDay} является выходным.");
else Console.WriteLine($"День {weekDay} не является выходным.");
