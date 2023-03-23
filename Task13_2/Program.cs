// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число:");
int enteredNumber = Convert.ToInt32(Console.ReadLine());

if (enteredNumber < 0) enteredNumber = -enteredNumber;

if (enteredNumber < 100) Console.WriteLine("Во введенном числе третьей цифры нет.");

else
{
    int num3 = Num3(enteredNumber);
    Console.WriteLine($"Третья цифра введенного числа:  {num3}");
}

int Num3(int number)
{

    int tempNumber = number;
    int decimalNum = 0; 
    while (tempNumber > 0)
       {
        tempNumber = tempNumber/10;
        decimalNum++;
        } 
 
    for(int i = 1; i < decimalNum -2; i++)
        {
        number = number/10;
        }
    number = number % 10;
    return number;
}