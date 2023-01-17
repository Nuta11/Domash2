// 1. Ввод N
// int <- (string)

int ValueInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Создание массива
// int[] <- (int)

int[] CreateArray(int Number)
{
    int[] array = new int[Number];
    return array;
}

// 3. Заполнение массива 0 и 1
// void <- (int[])

void FillArray(int[] binarNumber)
{
    int count = binarNumber.Length;
    for (int i = 0; i < count; i++)
    {
        binarNumber[i] = Random.Shared.Next(2);
    }
    binarNumber[0] = 1;
}

// 4. Печать массива
// string <- (int[])

string PrintArray(int[] Numbers)
{
    string output = String.Empty;
    int size = Numbers.Length;

    for (int i = 0; i < size; i++)
    {
        output = output + $"{Numbers[i]}";
    }
    return output;
}

// 5. Конвертация из 2-ого в 10-ое
// int <- (int[]).
int BitToDecimal(int[] arrayBin)
{
    int count = arrayBin.Length;
    int exponent = arrayBin.Length - 1;
    int result = 0;
    for (int i = 0; i < arrayBin.Length; i++)
    {
        if (arrayBin[i] == 1)
        {
            result += Convert.ToInt32(Math.Pow(2, exponent));
        }
        exponent--;

    }
    return result;
}

// 6. 10110100 >> 180
// string <- (int[] , int)
string GoodPrint(int[] bin, int dec)
{
    return $"{String.Join("", bin)} >> {dec}";
}
int Number = ValueInput();

int[] array = CreateArray(Number);
FillArray(array);
int result = Convert.ToInt32(BitToDecimal(array));
string binPrin = PrintArray(array);

Console.WriteLine(binPrin);
Console.WriteLine(GoodPrint(array, result));

