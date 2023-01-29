int n = 4;
int[,] array62 = new int[n, n];

FillArrayQadro(array62);
PrintArray(array62);

// заполнение матрицы по спирали
void FillArrayQadro (int[,] inputArray) {
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= inputArray.GetLength(0) * inputArray.GetLength(1))
    {
        inputArray[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < inputArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= inputArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > inputArray.GetLength(1) - 1)
            j--;
        else
            i--;
    } 
}

// вывод спиральной матрицы
void PrintArray (int[,] inputArray)
{
  for (int i = 0; i < inputArray.GetLength(0); i++)
  {
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
      if (inputArray[i,j] / 10 <= 0)
      Console.Write($" {inputArray[i,j]} ");

      else Console.Write($"{inputArray[i,j]} ");
    }
    Console.WriteLine();
  }
}
