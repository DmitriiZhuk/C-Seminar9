/*
Задача 2*. Напишите программу, которая заполнит спирально двумерный массив 4 на 4.
*Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
Указание:
При заполнении массива использовать циклы.
*/

// 1. Объявляю массив 5х5 и вводные данные для его заполнения
// работает и при 4х4
int nRow = 5;
int nCol = 5;
int[,] numArray = new int[nRow, nCol];

int row = 0;
int column = 0;
int dirX = 1;
int dirY = 0;
int dirChanges = 0;
int passes = nCol;

// 2. Заполняю массив
for (int i = 0; i < numArray.Length; i++)
{
    numArray[row, column] = i + 1;
    if (--passes == 0)
    {
        passes =
          nCol * (dirChanges % 2) + nRow * ((dirChanges + 1) % 2) -
          (dirChanges / 2 - 1) - 2;
        int temp = dirX;
        dirX = -dirY;
        dirY = temp;
        dirChanges++;
    }

    column += dirX;
    row += dirY;
}

// 3. Вывожу массив на экран
for (int i = 0; i < numArray.GetLength(0); i++)
{
    for (int j = 0; j < numArray.GetLength(1); j++)
    {
        Console.Write(numArray[i, j] + " ");
    }
    Console.WriteLine();
}

