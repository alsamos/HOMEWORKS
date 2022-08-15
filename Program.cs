// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] Create2DArray(int m, int n)
{
    double[,] newArray = new double[m,n];
    Random rand = new Random();
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newArray[i,j] = Math.Round(rand.Next(-10,10) + rand.NextDouble(),1);     
        }    
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:  ");
int columns = Convert.ToInt32(Console.ReadLine());

Show2dArray(Create2DArray(rows,columns));*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newArray[i,j] = new Random().Next(1,10);     
        }    
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MeaningOfCertainElement(int[,] array, int row, int column)
{
    int result = 0;
    if(row>array.GetLength(0) || column>array.GetLength(1)) Console.WriteLine($"Элемента {row}й строки {column}го столбца не существует");
    else result = array[row-1,column-1]; 
    return result;
}

Console.WriteLine("Задан двумерный массив размерностью 4*5.");
Console.WriteLine("Введите позицию элемента массива, значение которого хотите узнать:");
Console.Write("- Номер строки:  ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("- Номер столбца:  ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = CreateRandom2DArray(4,5);
Show2dArray(array);
int meaning = MeaningOfCertainElement(array, r, c);
Console.WriteLine($"Значение элемента массива ({r},{c}) равно {meaning}");*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newArray[i,j] = new Random().Next(1,10);     
        }    
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray(double[] array)
{
    for(int i=0; i < array.Length; i++)
        Console.Write(array[i]+ "  ");

        Console.WriteLine();
}

double[] MathAverageOfColumns(int[,] array, int n)
{
    double sum = 0;
    double[] newArray = new double[n];
    for(int j=0; j<array.GetLength(1); j++) 
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
    newArray[j] = sum / array.GetLength(1);
    sum = 0;
    }
    return newArray;
}

Console.Write("Введите количество строк двумерного массива:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива:  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2DArray(rows, columns);
Show2dArray(array);
double[] average = MathAverageOfColumns(array, columns);
Console.Write("Среднее арифметическое каждого столбца:  ");
ShowArray(average);*/