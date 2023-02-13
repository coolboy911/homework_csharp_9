// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfNumberInRange(int m , int n)
{
    if (m == n) return m;
    else return n + SumOfNumberInRange(m, n - 1);
}

Console.Clear();
Console.WriteLine(SumOfNumberInRange(4, 10));