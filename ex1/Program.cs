// Задача 49: Задайте двумерный массив. Найдите элементы, у
//которых оба индекса чётные, и замените эти элементы на их
//квадраты.
int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

int[,] CreateArr(int first, int second)
{
  int[,] array = new int[first, second];
  return array;
}

void FillArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = i + j;
    }
  }
}
void ConvertArr(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i+=2)
  {
    for (int j = 0; j < arr.GetLength(1); j+=2)
    {
     
      arr[i, j] *= arr[i, j];
      
    }
  }
}
void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = CreateArr(rows, columns);
FillArray(myArray);
PrintArray(myArray);
System.Console.WriteLine();
ConvertArr(myArray);
PrintArray(myArray);