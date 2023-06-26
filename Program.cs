// Урок 8. Двумерные массивы. Продолжение

// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.WriteLine("Введите колличество строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите колличество столбцов массива");
// int colums = Convert.ToInt32(Console.ReadLine());

// int [,] arr = new int [rows, colums];

// void FillArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             int maxPosition = j;
//             for (int k = j+1; k < array.GetLength(1); k++)
//             {
//                 if(array[i, k] > array[i, maxPosition])
//                 {
//                     maxPosition = k;
//                 }
//             }
//             int temp = array[i, j];
//             array[i, j] = array[i, maxPosition];
//             array[i, maxPosition] = temp;
//         }
//     }
// }


// FillArray(arr);
// PrintArray(arr);
// SelectionSort(arr);
// Console.WriteLine("_____");
// PrintArray(arr);


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка


Console.WriteLine("Введите колличество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива");
int colums = Convert.ToInt32(Console.ReadLine());

int [,] arr = new int [rows, colums];

void FillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [] sumString = new int[arr.GetLength(0)];
int min = int.MaxValue;
int minIndex = 0;


void Sum(int[,] array, int [] array1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        array1[i] = sum;
    }
}

void MinimunSum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {minIndex}");
}

FillArray(arr);
PrintArray(arr);
Sum(arr, sumString);
MinimunSum(sumString);
