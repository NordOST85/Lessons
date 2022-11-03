int Func(int number, int number1)
{
    while (number > 999)
    {

    number1=number / 10;
    number = number1;
    
    }
    return (number % 10);
 }

int number2 = 645;
int number3=0;
if (number2 > 99)
{
    int number4 = Func(number2,number3);
    Console.WriteLine("Третья цифра в числе = " + number4);
}

else
{
 Console.WriteLine("В числе меньше 3-ёх символов!");
}

int number5 = 78;
int number6=0;



if (number5 > 99)
{
    int number7 = Func(number5,number6);
    Console.WriteLine("Третья цифра в числе = " + number7);
}

else
{
 Console.WriteLine("В числе меньше 3-ёх символов!");
}

int number8 = 32679;
int number9=0;

if (number8 > 99)
{
    int number10 = Func(number8,number9);
    Console.WriteLine("Третья цифра в числе = " + number10);
}

else
{
 Console.WriteLine("В числе меньше 3-ёх символов!");
}