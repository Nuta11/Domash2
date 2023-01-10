
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number >= 100)
{
  number = number / 10  ;
}

Console.WriteLine(number % 10);
