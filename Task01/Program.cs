/*
Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// 1 Объект - случайные числа.
Random rnd = new Random();

// 2 Объявляю двумерный массив размером m×n
// можно так же получать длины строк и столбцов через Console.ReadLine() и Convert.ToInt32
int nRow = 4;

int[,] numArray = new int[nRow, nRow];

// 3 Заполняю массив, вывожу на экран.		
for (int i = 0; i < numArray.GetLength(0); i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
    {
        numArray[i, j] = rnd.Next(10, 99);
        Console.Write(numArray[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 4 Сортирую массив.		
for (int i = 0; i < numArray.GetLength(0); i++)
    SortRow(numArray, i);

for (int i = 0; i < numArray.GetLength(0); i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
        Console.Write(numArray[i, j] + " ");
    Console.WriteLine();
}

// ZZ - Функция сортировки массива.		
void SortRow(int[,] m, int r)
{
    for (int i = 0; i < m.GetLength(1); i++)
    {
        for (int j = i + 1; j < m.GetLength(1); j++)
        {
            if (m[r, i] < m[r, j])
            {
                int tmp = m[r, i];
                m[r, i] = m[r, j];
                m[r, j] = tmp;
            }
        }
    }
}