// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

PrintQubesRow(number);


void PrintQubesRow(int num)
{
Console.WriteLine("Число  Куб числа");
for(int i = 1; i <= num; i++)
{
    int qube = i*i*i;
    Console.WriteLine($"{i,3} {qube, 9}");
}
}