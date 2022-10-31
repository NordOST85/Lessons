Console.WriteLine("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > num2)
{
   Console.WriteLine("Первое число больше второго");
}
else if (num1 < num2)
{
    Console.WriteLine("Первое число меньше второго");
}
Console.WriteLine();