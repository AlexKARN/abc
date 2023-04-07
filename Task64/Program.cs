// Задача 64: 

int n = 2;
int m = 10;

int PowerOfNumber(int num1, int num2)
{
    if (num2 ==00) return 1;
    else return (num1*PowerOfNumber(num1, num2-1));
}

int p = PowerOfNumber(n,m);
Console.WriteLine($"основание степени:{n}, показатель степени {m}, {p}");

