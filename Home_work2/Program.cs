int x = 78;
if(x <= 99)
{
    Console.WriteLine("нет третьей цифры");
}
while (99 < x || x < 999)
{
     Console.WriteLine(x%10);
     if (999 < x || x < 9999)
     {
        x = x / 10;
        Console.WriteLine(x / 10 );
     }
     else
     {
        Console.WriteLine("число не работает, введи другое");
     }
}
