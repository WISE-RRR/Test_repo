// // // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandomArray(int m, int n)
// {
//     double[,] array = new double[m, n];
//     for (int i = 0; i < m; i++)
//         for (int j = 0; j < n; j++)
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//     return array;
// }

// void ShowRealArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = CreateRandomArray(m, n);
// ShowRealArray(array);


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// void CreateRandomArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(10, 100);
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// Console.Write("Введите номер строки: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[7, 7];
// CreateRandomArray(array);

// if (m > array.GetLength(0) || n > array.GetLength(1))
// {
//     Console.WriteLine("Такого элемента нет в данном массиве");
// }
// else
// {
//     Console.WriteLine($"Значение элемента строки {m} и столбца {n} равно {array[m - 1, n - 1]}");
// }
// Console.WriteLine("");
// ShowArray(array);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(10, 100);
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[m, n];
// CreateArray(numbers);

// Console.WriteLine("Среднее арифметическое столбцов массива: ");
// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     int avarage = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         avarage = (avarage + numbers[i, j]);
//     }
//     avarage = avarage / m;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();
// Console.WriteLine();
// ShowArray(numbers);

