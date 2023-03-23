// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int absnum = Math.Abs(number);

if (absnum > 99 && absnum < 1000) 
    {
        int tempnum = absnum/10;
        int secondNumber = tempnum % 10;
        Console.Clear();
        Console.WriteLine($"Введённое число: {number}");
        Console.WriteLine($"Вторая цифра введенного числа: {secondNumber}");
    }
    
    
else
    { 
       Console.WriteLine("Введено ненадлежащее число.");
    }