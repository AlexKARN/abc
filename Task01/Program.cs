Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine()); 
char num3;

if (number < 0) number = - number;
string snumber = Convert.ToString(number);
if (snumber.Length < 3) Console.WriteLine("Третьей цифры во введённом числе нет.");
else 
{
    num3 = snumber[2];
    Console.WriteLine($"Третья цифра введённого числа: {num3}");
}
