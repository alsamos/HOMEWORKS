//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*int a, b;

Console.Write("Введите целое число 1:  ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 2:  ");
b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"Первое число ({a}) больше чем второе число ({b})");
}
else
{
    Console.WriteLine($"Второе число ({b}) больше чем первое число ({a})");
}*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*int a, b, c;

Console.Write("Введите целое число 1:  ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 2:  ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 3:  ");
c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c) 
{
    Console.WriteLine($"Первое число ({a}) больше чем второе число ({b}) и третье число ({c})");
}
if (b > a && b > c)
{
    Console.WriteLine($"Второе число ({b}) больше чем первое число ({a}) и третье число ({c})");
}
if (c > a && c > b)
{
    Console.WriteLine($"Третье число ({c}) больше чем первое число ({a}) и второе число ({b})");
}*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

/*int a;

Console.Write("Введите целое число:  ");
a = Convert.ToInt32(Console.ReadLine());

if (a%2==0)
{
    Console.Write($"Число {a} является четным  ");
}
else Console.Write($"Число {a} НЕ является четным  ");*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*Console.Write("Введите целое число:  ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current<=num)
{
    if(current%2==0)
    Console.Write(current + " ");
    current++;
}*/
