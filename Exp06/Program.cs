
int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Введено не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}