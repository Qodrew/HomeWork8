/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */


Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

int[,] arrayTask54 = new int[n,m];


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
void SortToLower(int[,] inputArray) // Функция сортировки элементов в строке двумерного массива, по убыванию
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
            {
                if (inputArray[i, k] < inputArray[i, k + 1])
                {
                    int temp = inputArray[i, k + 1];
                    inputArray[i, k + 1] = inputArray[i, k];
                    inputArray[i, k] = temp;
                }
            }
        }
    }
}
 



FillArray(arrayTask54);
PrintArray(arrayTask54);
System.Console.WriteLine();
SortToLower(arrayTask54);
PrintArray(arrayTask54);
