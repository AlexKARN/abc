Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
Console.WriteLine($"Первое число {number1} большее, второе число {number2} меньшее");

else if (number1 < number2)
Console.WriteLine($"Второе число {number2} большее, первое число {number1} меньшее");

else if (number1 == number2)
Console.WriteLine($"Ни одно из введенных числе {number2} и {number1} не является бОльшим, поскольку они равны между собой");



