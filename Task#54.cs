/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */


Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

int[,] matr = new int[n,m];


void FillArray(int [,] inputArray) // Заполнение массива рандомными данными
{
    for(int i = 0; i < inputArray.GetLength(0); i++)
    {
        for(int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i,j] = new Random().Next(1,50);
        }
    }
}

void PrintArray(int[,] inputArray) // Вывод матрицы 
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
void SortToLower(int[,] array) // Функция сортировки элементов в строке двумерного массива, по убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
 



FillArray(matr);
PrintArray(matr);
System.Console.WriteLine();
SortToLower(matr);
PrintArray(matr);
