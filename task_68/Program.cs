// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/* Результаты
n/m 0 1 2  3
------------
0 | 1 2 3  5
1 | 2 3 5  13
2 | 3 4 7  29
3 | 4 5 9  61
4 | 5 6 11 125
5 | 6 7 13 253
*/

// по методу от Grossman & Zeitman 
// A(0, n) = n + 1
// A(m, 0) = A(m - 1, 1)
// A(m, n) = A(m - 1, A(m, n - 1))

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

Console.Clear();
Console.WriteLine(Ack(m: 3, n: 2));