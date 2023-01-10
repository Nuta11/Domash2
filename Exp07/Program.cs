
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
Console.WriteLine("Третьей цифры нет");
}
else
{
while (number >= 1000)
{
  number = number / 10  ;
}

Console.WriteLine(number % 10);
}
