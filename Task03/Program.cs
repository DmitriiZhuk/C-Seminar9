/*
Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Например
m = 2, n = 3 -> A(m,n) = 29
*/

// 1. Вывожу на экран результат функции
Console.Write(Ackermann(2, 3));

// ZZ - Функция Аккермана
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }

}