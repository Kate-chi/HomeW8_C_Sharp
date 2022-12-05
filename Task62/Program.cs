/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] spiralArray = new int[4, 4];
int size = spiralArray.GetLength(0);

FillSpiralNumbers(spiralArray);
Print2DArr(spiralArray);

void FillSpiralNumbers(int[,] arr)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while(value <= size * size)
    {
        arr[i, j] = value++;
        
        if(i <= j + 1 && i + j < size - 1)
        {
            j++;
        }
        else if(i < j && i + j >= size - 1)
        {
            i++;
        }
        else if (i >= j && i + j > size - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

void Print2DArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{string.Format("{0:d2}", arr[i, j])} ");
        }
        Console.WriteLine();
    }
}
