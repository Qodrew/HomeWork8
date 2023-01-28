/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов. */

int[,] arrayTask56 = new int[4,5];


void FillArray(int [,] inputArray) // Заполнение массива рандомными данными
{
    for(int i = 0; i < inputArray.GetLength(0); i++)
    {
        for(int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i,j] = new Random().Next(1,10);
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
 
void FindMinSumStrAray (int [,] inputArray) {
    int count = 0;
    int sumMin = int.MaxValue;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int sumСomparison = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            
            sumСomparison += inputArray[i, j];
        }
        if (sumMin > sumСomparison)
        {
            sumMin = sumСomparison;
            count = i;
        }
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {count + 1}. Сумма элементов строки: {sumMin}");
}

FillArray(arrayTask56);
PrintArray(arrayTask56);
System.Console.WriteLine();
FindMinSumStrAray(arrayTask56);
