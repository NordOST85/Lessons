Console.WriteLine("Введи число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day <= 5) 
{
    Console.WriteLine("Будний день "+ day);
}
if (day == 6 || day == 7) 
{
    Console.WriteLine("Выходной день "+ day);
}