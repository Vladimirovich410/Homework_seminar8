﻿// Урок 8. Двумерные массивы. Продолжение

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


Console.WriteLine("Введите колличество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите колличество столбцов массива");
int colums = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows, colums];

void FillArray(int [,] arr)
{
    
}