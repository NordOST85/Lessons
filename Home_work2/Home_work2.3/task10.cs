Console.WriteLine("Введи трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num /= 10;
num %= 10;

Console.WriteLine("вторая цифра этого числа: " +num);

