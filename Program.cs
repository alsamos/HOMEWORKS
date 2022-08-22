// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumbersFromMToN(int m, int n)
{
    if(m!=n) ShowNumbersFromMToN(m, n-1);
    Console.Write(n+" ");
}

Console.Write("Введите целое число больше нуля: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно целое число больше нуля: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m>n) ShowNumbersFromMToN (n,m); 
else ShowNumbersFromMToN (m,n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfElementsBetweenMAndN (int a, int b)
{
      if (a==b) return b;
      else return a+SumOfElementsBetweenMAndN(a+1, b);
}

Console.Write("Введите целое число больше нуля: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно целое число больше нуля: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
if(m>n) result = SumOfElementsBetweenMAndN (n, m);
else result = SumOfElementsBetweenMAndN (m, n);
Console.Write(result);
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if(m==0) return n+1;
    else if ((m>0) && (n==0)) return Akkerman(m-1, 1);
    else if ((m>0) && (n>0)) return Akkerman(m-1, Akkerman(m, n-1));
    else return n+1;
}

Console.Write("Введите целое число больше нуля:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно целое число больше нуля:  ");
int n = Convert.ToInt32(Console.ReadLine());
int akkerman = Akkerman(m, n);
Console.WriteLine($"Функция Аккермана A ({m},{n}) = {akkerman}");
*/
