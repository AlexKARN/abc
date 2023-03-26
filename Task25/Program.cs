// Напишите цикл, который принимает на вход два числа (А и В) и возводит А в натуральную степень В.
// 3,5 -> 243
// 2,4 -> 16

Console.Clear();
Console.WriteLine("Введите первое число (А):");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число (В):");
int numberB = Convert.ToInt32(Console.ReadLine());

int powerOfNumber = PowerOfNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно: {powerOfNumber}");

int PowerOfNumber(int num1,int num2)
{
    int tempNum = num1; 
    for(int i = 1; i < num2; i++)
    {        
        num1 = num1*tempNum;
    }
    return num1;
}
