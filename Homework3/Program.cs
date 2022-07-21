// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*bool Palindrom(int num)
{
    int pair1 = num % 10 - num / 10000;
    int pair2 = (num / 10 % 10) - (num % 10000 / 1000);
    if (pair2-pair1==0) return true;
    else return false;
}

Console.Write("Введите пятизначное число:   ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Palindrom(number);
*/



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*double Length (double xa, double ya, double za, double xb, double yb, double zb)
{
    double length = Math.Sqrt((yb - ya) * (yb - ya) + (xb - xa) * (xb - xa) + (zb - za) * (zb - za));
    return length;
}

Console.Write("Введите значение координаты X точки A:  ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки A:  ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки A:  ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты X точки B:  ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки B:  ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки B:  ");
int zb = Convert.ToInt32(Console.ReadLine());

double length = Length (xa, ya, za, xb, yb, zb);
Console.Write($"Расстояние между точками А и В равно {length}");
*/



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*void Numbers (double num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write(current*current*current+ " ");
        current ++;
    }
}

double check;
double number;
Console.Write("Введите целое положительное число:  ");
check = Convert.ToDouble(Console.ReadLine());
if (check<0) number = check * (-1);
else number = check;
Numbers(number);
*/