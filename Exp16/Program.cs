
Console.WriteLine("введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Координаты точки пересечения X= {x}, Y= {y}");