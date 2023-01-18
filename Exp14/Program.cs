
int GetArraySize()
{
 Console.WriteLine("Введите количество элементов массива: ");
 int Size = Convert.ToInt32(Console.ReadLine());
 return Size;
}


int[] FirstArray(int Size)
{
 return new int[Size];
}


int[] FillArray(int[] Arr)
{
  int index = 0;
  int lenght = Arr.Length;
  while (index < lenght)
  {
    Arr[index] = Random.Shared.Next(1, 10);
    Console.Write($"{Arr[index]} ");
    index++;
  }
  Console.WriteLine();
  return Arr;
}


int[] GetProd(int[] Array)
{
  int[] ArrRez = new int[Array.Length / 2];
  int count = Array.Length;
  for (int i = 0; i < count / 2; i++)
  {
    ArrRez[i] = Array[i] * Array[count - 1 - i];
  }
  return ArrRez;
}


void PrintArray(int[] Array)
{
  int count = Array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{Array[i]} ");
  }
}

int Size = GetArraySize();
int[] Arr = FirstArray(Size);
FillArray(Arr);
int[] ArrRez = GetProd(Arr);
PrintArray(ArrRez);




