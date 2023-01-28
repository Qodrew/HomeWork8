/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

int[,] array1Task58 = new int[3,2];
int[,] array2Task58 = new int[2,2];

void FillArray(int [,] inputArray) // Заполнение массива рандомными данными
{
    for(int i = 0; i < inputArray.GetLength(0); i++)
    {
        for(int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i,j] = new Random().Next(1,4);
        }
    }
}

void PrintArray(int[,] inputArray) // Вывод массива 
{
    for (int i = 0; i  < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j]} ");
        }
    Console.WriteLine();
    }
}

// Умножение матриц
int[,] Prod2Array (int [,] input1Array, int [,] input2Array) {
    int[,] arrayProd = new int[input1Array.GetLength(0), input1Array.GetLength(1)];
    if (input1Array.GetLength(1) != input2Array.GetLength(0)) {
        Console.WriteLine("Матрицы нельзя перемножить");
    }
    else {
        for (int i = 0; i < input1Array.GetLength(0); i++)
        {
            for (int j = 0; j < input2Array.GetLength(1); j++)
            {
                for (int k = 0; k < input2Array.GetLength(0); k++)
                {
                    arrayProd[i, j] += input1Array[i,k] * input2Array[k, j];
                }
            }
        }
    }
    return arrayProd;
}


FillArray(array1Task58);
FillArray(array2Task58);
PrintArray(array1Task58);
System.Console.WriteLine();
PrintArray(array2Task58);
System.Console.WriteLine();
PrintArray(Prod2Array(array1Task58, array2Task58));
