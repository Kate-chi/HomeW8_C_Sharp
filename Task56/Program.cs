/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");
int min = 1;
int max = 9;

int[,] array = new int[rows, columns];
int[] sumArray = new int[rows];

Fill2DArrRandomNum(array);
Print2DArr(array);
Console.WriteLine();

sumArray = FindRowsSum(array, sumArray);
Console.Write("Сумма элементов в каждой строке: ");
PrintArr(sumArray);
Console.WriteLine();

int minRow = RowWithMinSum(sumArray);
Console.Write($"В {minRow} строке наименьшая сумма элементов");

int RowWithMinSum(int[] arr)
{
    int min = arr[0];
    int minIndex = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
}


int[] FindRowsSum(int[,] arr, int[] sumArr)
{
    int sum = 0;
    int sumIndex = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
    sumArr[sumIndex++] = sum;
    sum = 0;
    }
    return sumArr;
}

void Fill2DArrRandomNum(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Print2DArr(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
