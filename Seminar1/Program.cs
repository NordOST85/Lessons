int sum = 0;
int startNumber  = 1;

while (startNumber  <= 15)
{
  if (startNumber % 2 == 0)
  {
sum = sum + startNumber;
  }
  startNumber += 1;
}

Console.WriteLine(sum);
// 2+4+6+8+10+12+14=56