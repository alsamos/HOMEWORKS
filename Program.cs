// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newArray[i,j] = new Random().Next(1,9);     
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

int[,] FromMaxToMin(int[,] array, int repeat)
{
    for(int count=0; count<repeat-1; count++)
    {
        for(int i=0; i<array.GetLength(0); i++)
            {
                for(int j=0; j<array.GetLength(1)-1; j++) 
                {
                    int minValue=array[i,j+1], maxValue=array[i,j];
                    if(array[i,j]<array[i,j+1]) 
                    { 
                        array[i,j]=minValue;
                        array[i,j+1]=maxValue;
                    }
                }
            }
    }    
    return array;
}

Console.Write("Введите количество строк двумерного массива:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива:  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newArray = CreateRandom2DArray(rows, columns);
Show2dArray(newArray);
newArray = FromMaxToMin(newArray, columns);
Show2dArray(newArray);*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newArray[i,j] = new Random().Next(1,9);     
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

int FindTheMinRow(int[,] array)
{
    int iMin = 0; 
    Console.WriteLine("Суммы элементов массива построчно:");
    for(int i=0; i<array.GetLength(0); i++)
            {
                for(int j=0; j<array.GetLength(1)-1; j++) 
                {
                    array[i,0] = array[i,0] + array[i,j+1];
                }
                Console.WriteLine(array[i,0]);
                if(array[i,0]<array[iMin,0]) iMin=i;
            }   
    return iMin;
}

int[,] newArray = CreateRandom2DArray(8, 4);
Show2dArray(newArray);
int minRow = FindTheMinRow(newArray);
Console.WriteLine();
Console.WriteLine($"{minRow+1}я строка");*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2DArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newArray[i,j] = new Random().Next(1,9);     
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

int[,] MultiplyArray1Array2(int[,] array1, int[,] array2, int rows, int columns)
{
    int[,] resultArray = new int[rows, columns];
    for(int i=0; i<resultArray.GetLength(0); i++)
    {
        for(int j=0; j<resultArray.GetLength(1); j++)
        {
            resultArray[i,j] = array1[i,j]*array2[i,j];
        }
    }
    return resultArray;
}

int m=4, n=4;
int[,] newArray1 = CreateRandom2DArray(m, n);
Show2dArray(newArray1);
int[,] newArray2 = CreateRandom2DArray(m, n);
Show2dArray(newArray2);
int[,] resultArray = MultiplyArray1Array2(newArray1, newArray2, m, n);
Show2dArray(resultArray);*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[] UniqueNumbersArray(int combinations)
{
    int[] uniqueArray = new int[combinations];
    
    for(int i=0; i<combinations; i++)
        {
            int temp = new Random().Next(10,99);
            for(int j=0; j<combinations; j++)
            {
                if(uniqueArray[j] == temp) temp = new Random().Next(10,99);
            }
            uniqueArray[i] = temp;
        }
    return uniqueArray;
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    
}

int[,,] CreateRandom3dArray(int[] uniqueArray, int l, int m, int n)
{
    int[,,] newArray = new int[l,m,n]; 
    int count = 0;
    for(int i=0; i<l; i++)
    {
        for(int j=0; j<m; j++)
        {
            for(int k=0; k<n; k++)
            {
                newArray[i,j,k] = uniqueArray[count];
                count++;
            }
        }    
    }
    return newArray;
}

void Show3dArray(int[,,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
            Console.Write($"{array[i,j,k]} ({i},{j},{k})  ");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
}

int rows = 4, columns = 4, matrixes = 4;
int [] uniqueArray = UniqueNumbersArray(rows*columns*matrixes);
Console.WriteLine("Набор неповторяющихся двузначных чисел для заполнения трехмерного массива:");
ShowArray(uniqueArray);
Console.WriteLine();
Console.WriteLine("Полученный трехмерный массив:");
int[,,] newArray = CreateRandom3dArray(uniqueArray, rows,columns,matrixes);
Show3dArray(newArray);*/

// Задача 62. Заполните спирально массив 4 на 4.
/*
int[,] CreateSpiral2dArray(int n, int m)
{
    int[,] newArray = new int[n,m];
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, visits = m;
 
            for (int i = 0; i < newArray.Length; i++) 
            {
            newArray[row, col] = i + 1;
            if (--visits == 0) 
              {
                visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
                int temp = dx;
                dx = -dy;
                dy = temp;
                dirChanges++;
              }
 
            col += dx;
            row += dy;
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

int m=4, n=4;
int[,] newArray = CreateSpiral2dArray(n, m);
Show2dArray(newArray);*/
