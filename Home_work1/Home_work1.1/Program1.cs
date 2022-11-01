Console.WriteLine("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > num1)
{
max = num2;
}
if (num3 > num2)
{
max = num3;
}
Console.WriteLine(max);    