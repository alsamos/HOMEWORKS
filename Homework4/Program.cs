// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int NumberToDegree(int a, int b)
{
    int result = a;
    for (int i=2; i<=b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Write("Введите целое число:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите степень, в которую возвести число {number}:  ");
int degree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат возведения числа {number} в степень {degree} равен {NumberToDegree(number, degree)}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfDigits(int a)
{    
    int sum = 0; int count = 0;
    while (a > 0)
    {
        sum = sum + a%10;
        a = a/10;
        count++;
    }
    return sum;
}

Console.Write("Введите целое число:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} равна {SumOfDigits(number)}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateNewArray(int size)
{
    int[] newArray = new int[size];

    for(int i=0; i<size; i++)
    {
        Console.Write($"Введите {i+1}й элемент массива:  ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.Write("Полученный массив выглядит так:  ");
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + ", ");
}

Console.Write($"Задайте количество элементов массива:  ");
int number = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateNewArray(number);
ShowArray(newArray);
*/
