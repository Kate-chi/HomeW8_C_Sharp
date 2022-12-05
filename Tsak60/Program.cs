/*
Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int rows = InputNum("введите количество строк: ");
int columns = InputNum("введите количество столбцов: ");
int depth = InputNum("введите глубину: ");

if(rows * columns * depth > 90)
{
    Console.Write("Такой массив невозможно заполнить уникальными двухзначными числами");
    return;
}

int[,,] array3D = new int[rows, columns, depth];

int totalNumbers = 90;
int[] randomArray = new int[totalNumbers];

FillArr(randomArray);
MakeRandom(randomArray);

Fill3DArr(array3D, randomArray);
Print3DArr(array3D);


void Print3DArr(int[,,] arr)
{
    for(int i = 0; i < arr.GetLength(2); i++)
    {
        for(int j = 0; j < arr.GetLength(0); j++)
        {
            for(int k = 0; k < arr.GetLength(1); k++)
            {
                Console.Write($"{arr[j, k, i]} ({j} {k} {i}) ");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
}

void MakeRandom(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        int index = new Random().Next(0, arr.Length);
        int temp =  arr[index];
        arr[index] = arr[i];
        arr[i] = temp;
    }
}

void FillArr(int[] arr)
{
    int count = 10;
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = count++;
    }
}

void Fill3DArr(int[,,] arr, int[] randArr)
{
    int index = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = randArr[index++];
            }
        }
    }
}

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
