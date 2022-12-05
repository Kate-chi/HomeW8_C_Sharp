/*
Доп. задача 55**: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. 
Решить НЕ используя второй массив
*/

int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");
if(rows != columns)
{
    Console.Write("поменять местами строки и столбцы не получится");
    return;
}
int min = 1;
int max = 9;

int[,] array = new int[rows, columns];

Fill2DArrRandomNum(array);
Print2DArr(array);
Console.WriteLine();

SwapRowsToColumns(array);
Print2DArr(array);

void SwapRowsToColumns(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(i < j)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = temp;
            }
                
        }
    }
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


int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

