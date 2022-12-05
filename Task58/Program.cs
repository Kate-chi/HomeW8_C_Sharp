/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrixA = {{2, 4}, {3, 2}};
int[,] matrixB = {{3, 4}, {3, 3}};

if(matrixA.GetLength(1) != matrixB.GetLength(0))
{
    Console.WriteLine("Эти матрицы нельзя умножать");
    return;
}

int[,] matrixResult = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

matrixResult = MatrixMultiplication(matrixA, matrixB, matrixResult);

Print2DArr(matrixA);
Console.WriteLine();

Print2DArr(matrixB);
Console.WriteLine();

Print2DArr(matrixResult);

int[,] MatrixMultiplication(int[,] arrA, int[,] arrB, int[,] arrRes)
{
    for(int i = 0; i < arrRes.GetLength(0); i++)
    {
        for(int j = 0; j < arrA.GetLength(1); j++)
        {
            arrRes[i, j] = 0;
            for(int k = 0; k < arrA.GetLength(1); k++)
            {
                arrRes[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return arrRes;
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