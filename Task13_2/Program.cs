// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число:");
int enteredNumber = Convert.ToInt32(Console.ReadLine());

if (enteredNumber < 0) enteredNumber = -enteredNumber;

int decimalNum = 0; 
int decimalDegree = DecimalDegree (enteredNumber);
int num3 = Num3(enteredNumber, decimalDegree);

Console.WriteLine($"Число цифр введенного числа:  {decimalDegree}");

Console.WriteLine($"Третья цифра введенного числа:  {num3}");

int DecimalDegree (int number)
{
    while (number > 0)
    {
        number = number/10;
        decimalNum++;
    } 
    return decimalNum;
}

int Num3(int number, int decimalNum)
{
    for(int i = 1; i < decimalNum -2; i++)
    {
        number = number/10;
    }
    number = number % 10;
    return number;
}