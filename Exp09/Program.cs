//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine(Check(23432));

bool Check(long val1)
{
long val2 = 0;
long t = val1;

while (val1 > 0)
{
  long o = val1 % 10;
  val1 = val1 / 10;
  val2 = val2 * 10 + o;
}

return t == val2;
}

