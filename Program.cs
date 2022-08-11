// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Вариант решения 1:
/*
int[] CreateNewArray(int size)
{
    int[] newArray = new int[size];

    for(int i=0; i<size; i++)
    {
        Console.Write($"Введите {i+1}е целое число:  ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.Write("Вы ввели следующие числа:  ");
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + ", ");
}

int NumberOfPositive(int[] array)
{
    int sum=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>0) sum=sum+1;
    }
    return sum;
}

Console.Write($"Сколько чисел вы хотите ввести?  ");
int number = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateNewArray(number);
ShowArray(newArray);
int sum = NumberOfPositive(newArray);
Console.Write($"Вы ввели {sum} чисел больше 0");*/

//Вариант решения 2:
/*
int ShowNumbers(int M)
{
    int sum = 0;
    for(int i=1; i<=M; i++)
    {
        Console.Write($"Введите {i}е целое число:  ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number>0) sum=sum+1;
    }
    return sum;
}
Console.Write($"Сколько чисел вы хотите ввести?  ");
int number = Convert.ToInt32(Console.ReadLine());
int positive = ShowNumbers(number);
Console.Write($"Введено {positive} чисел больше нуля");*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
/*
double FindX (double b1, double k1, double b2, double k2)
{
    double x = (b2-b1) / (k1-k2);
    return x;
}

double FindY (double x, double b1, double k1)
{
    double y = k1*x+b1;
    return y;
}

Console.Write($"Введите значение b1  ");
double numberb1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите значение k1  ");
double numberk1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите значение b2  ");
double numberb2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"Введите значение k2  ");
double numberk2 = Convert.ToDouble(Console.ReadLine());
double crossX = FindX (numberb1, numberk1, numberb2, numberk2);
double crossY = FindY (crossX, numberb1, numberk1);
Console.Write($"Координаты точки пересечения двух прямых: ({crossX}; {crossY})");*/

