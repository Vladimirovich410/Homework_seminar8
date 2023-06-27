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

// int [] sumString = new int[arr.GetLength(0)];
// int min = int.MaxValue;
// int minIndex = 0;


// void Sum(int[,] array, int [] array1)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         array1[i] = sum;
//     }
// }

// void MinimunSum(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < min)
//         {
//             min = array[i];
//             minIndex = i;
//         }
//     }
//     Console.WriteLine($"Строка с наименьшей суммой элементов {minIndex}");
// }

// FillArray(arr);
// PrintArray(arr);
// Sum(arr, sumString);
// MinimunSum(sumString);


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.WriteLine("Введите колличество строк массива 1");
// int rows1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите колличество столбцов массива 1");
// int colums1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите колличество строк массива 2");
// int rows2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите колличество столбцов массива 2");
// int colums2 = Convert.ToInt32(Console.ReadLine());

// int [,] arr1 = new int [rows1, colums1];
// int [,] arr2 = new int [rows2, colums2];
// int [,] ResultMatrix = new int [rows1, colums2];
// if(colums1 != rows2)
// {
//     Console.WriteLine("Эти матрицы умножить нельзя!");
// }
// else
// {
//     FillArray(arr1);
//     PrintArray(arr1);
//     FillArray(arr2);
//     PrintArray(arr2);
//     MultiplyMatrix(arr1, arr2, ResultMatrix);
//     PrintArray(ResultMatrix);
// }


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

// void MultiplyMatrix(int [,] array1, int [,] array2, int [,] Res)
// {
//     for (int i = 0; i < Res.GetLength(0); i++)
//     {
//         for (int j = 0; j < Res.GetLength(1); j++)
//         {
//             int result = 0;
//             for (int k = 0; k < array2.GetLength(0); k++)
//             {
//                 result = array1[i,k] * array2[k,j] + result;
//             }
//             Res[i,j] = result;
//         }
//     }
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Console.WriteLine("Введите колличество строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите колличество столбцов массива");
// int colums = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Задайте глубину трёхмерного массива");
// int depth = Convert.ToInt32(Console.ReadLine());

// int [,,] arr = new int [rows, colums, depth];

// void FillArray(int [,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = new Random().Next(10, 100);
//             }
//         }
//     }
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(2); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 Console.Write(array[j,k,i]+" "+"("+j+", "+k+", "+i+")"+" ");
//             }
//         Console.WriteLine();
//         }
//     }

//     Console.WriteLine();
// }

// FillArray(arr);
// PrintArray(arr);



// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] array = new int[4, 4];
int num = 1;
void FillingSpiralArr(int[,] array, int arg)
{
    int i = 0;
    int j = 0;
    while (arg <= 16)
    {
        array[i, j] = arg;
        if (i <= j + 1 && i + j < 3)
            ++j;
        else if (i < j && i + j >= 3)
            ++i;
        else if (i >= j && i + j > 3)
            --j;
        else
            --i;
        arg++;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("D2")} ");
        }
        Console.WriteLine("");
    }
}

FillingSpiralArr(array, num);
PrintArray(array);


