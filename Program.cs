// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] CreateNewArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.Write("Полученный массив выглядит так:  ");
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    
}

int NumberOfEven(int[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if(array[i]%2==0) count = count+1;
    }
    return count;
}



Console.Write($"Задайте размерность массива, заполненного случайными положительными трехзначными числами:  ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateNewArray (arraySize, 100, 999);
ShowArray(newArray);
int numberOfEven = NumberOfEven(newArray);
Console.Write($"Количество чётных чисел в массиве = {numberOfEven}");*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateNewArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив выглядит так:  ");
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    
}

int SumOfElements(int[] array)
{
    int sum = 0;
    for(int i=0; i<array.Length; i=i+2)
        sum = sum + array[i];
    return sum;
}

Console.Write($"Задайте размерность одномерного массива, заполненного случайными числами от 0 до 9:  ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateNewArray (arraySize, 0, 9);
ShowArray(newArray);
int sum = SumOfElements(newArray);
Console.Write($"Сумма элементов, стоящих на нечетных позициях равна {sum}");*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateNewArray(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];
    
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue);
    }
    return newArray;
}

void ShowArray(double[] array)
{
    Console.WriteLine("Полученный массив выглядит так:  ");
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
    
}

double MinMaxDifference(double[] array)
{
    int i=0; 
    double min = array[i];
    double max = array[i];

    while(i<array.Length-1)     
    { 
        if(array[i+1]<min) min=array[i+1];
        if(array[i+1]>max) max=array[i+1];
        i++;
    }
    Console.WriteLine($"Минимальный элемент массива = {min}");
    Console.WriteLine($"Максимальный элемент массива = {max}");
    double sum = max - min;
    return sum;
}

Console.Write($"Задайте размерность одномерного массива, заполненного случайными числами от 1 до 100:  ");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] newArray = CreateNewArray(arraySize, 1, 100);
ShowArray(newArray);
double sum = MinMaxDifference(newArray);
Console.Write($"Разница между максимальным и минимальным элементами массива = {sum}");*/