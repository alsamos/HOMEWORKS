//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*int ShowSecondDigit(int num)
{
    int num2 = num / 10 % 10;
    return num2;
}

Console.Write("Введите трехзначное число:   ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ShowSecondDigit(number);

Console.WriteLine($"Вторая цифра введенного числа {result}");*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*int ResultThirdDigit(int num)
{
    while(num>999) 
        {
        num = num/10;
        }
    int result = num %10;
    return result;
}

Console.WriteLine("Введите число:   ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99)
{
    int thirddigit = ResultThirdDigit(number);
    Console.WriteLine($"Третья цифра введенного числа - {thirddigit}");
} 
else Console.WriteLine("Третьей цифры нет");*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

/*void WeekEndOrNot(int num)
{
    if(num>0 && num<5) Console.WriteLine($"День недели, обозначенный цифрой {num} не является выходным");
    if(num>5 && num<8) Console.WriteLine($"День недели, обозначенный цифрой {num} является выходным");
    if(num<1 || num>7) Console.WriteLine($"Цифра {num} не обозначает какой-либо день недели");
}

Console.WriteLine("Введите цифру, обозначающую день недели:   ");
int number = Convert.ToInt32(Console.ReadLine());
WeekEndOrNot(number);*/

