int a = 1;
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine( ));
for (int i = a; i <= n; i++)
{
if (i % 2 == 0)
{
Console.Write(i + " ");
}
}
Console.ReadKey();