//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов 
//в промежутке от M до N.

Console.WriteLine("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);

if (m>n)
{
    int temp = m;
    m = n;
    n = temp;
}

int SumForMtoN (int m, int n)
{
    if (m==n+1)
    {
        return 0;
    }
    else
    {
        return m+(SumForMtoN(m+1, n));
    }
}

Console.WriteLine(SumForMtoN(m,n));