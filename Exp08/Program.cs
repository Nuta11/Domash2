
Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

{
if (day == 7 || day == 6)
    Console.WriteLine("Выходной");

else if (day >= 1 && day <= 5)
    Console.WriteLine("Будни");

else 
    Console.WriteLine("Неверное число");
}






       