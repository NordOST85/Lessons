Console.WriteLine("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Первое число больше второго");
}
else if (num1 > num3)
{
    Console.WriteLine("Первое число больше третьего");
}
Console.WriteLine("Первое число самое большое"); !!!!!!!!!
if (num1 < num2)
{
    Console.WriteLine("Первое число меньше второго"); !!!!!!!
}
else if (num2 > num3)
{
    Console.WriteLine("Второе число больше третьего");
}
Console.WriteLine("Второе число самое большое"); !!!!!!!!!!
if (num2 < num3)
{
    Console.WriteLine("Второе число меньше третьего"); !!!!!!!
}
Console.WriteLine("Третьте число самое большое"); !!!!!!
Console.WriteLine();