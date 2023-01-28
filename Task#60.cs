int[,,] arr = new int[3, 3, 3];

FillArray(arr);
PrintArray(arr);

void PrintArray (int[,,] inputArray)
{
  for (int i = 0; i < inputArray.GetLength(0); i++)
  {
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
      for (int k = 0; k < inputArray.GetLength(2); k++)
      {
        Console.Write( $"{inputArray[i,j,k]}({i}, {j}, {k}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

// заполнение массива неповторяющимися двузначными числами
void FillArray(int[,,] inputArray) 
{
  int[] temp = new int[inputArray.GetLength(0) * inputArray.GetLength(1) * inputArray.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < inputArray.GetLength(0); x++)
  {
    for (int y = 0; y < inputArray.GetLength(1); y++)
    {
      for (int z = 0; z < inputArray.GetLength(2); z++)
      {
        inputArray[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
