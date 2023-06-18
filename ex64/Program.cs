//Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

void ForNtoOne (int n)
{
    if (n>0)
    {
        Console.Write(n+" ");
        ForNtoOne(n-1);
    }
}

ForNtoOne(n);