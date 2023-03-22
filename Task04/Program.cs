// Напишите программу, которая принимает на вход три числа 
// и выдает максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber;

if (number1 > number2)
    maxNumber = number1;
else
    maxNumber = number2;

if (number3 > maxNumber)
    maxNumber = number3;

Console.WriteLine($"Максимальным является число {maxNumber}");
