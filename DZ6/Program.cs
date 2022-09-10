// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write($"Введите некоторое положительное число: ");
// int m = Convert.ToInt32(Console.ReadLine()); // Запрос у пользователя на количество элементов
// int[] massiveNumbers = new int[m];

// void InputNumbers(int m)
// {
//     for (int i = 0; i < m; i++)
//     {
//         Console.Write($"Введите {i + 1}-ое число: ");
//         massiveNumbers[i] = Convert.ToInt32(Console.ReadLine()); // Ввод элементов массива для каждого индекса
//     }
// }

// int Positiv(int[] massiveNumbers)
// {
//     int count = 0;
//     for (int i = 0; i < massiveNumbers.Length; i++)
//     {
//         if (massiveNumbers[i] > 0) count++; // Счётчик положительных элементов
//     }
//     return count;
// }

// InputNumbers(m);

// Console.WriteLine($"Введено положительных чисел: {Positiv(massiveNumbers)} ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// Console.Write("Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (b1 - b2) / (k2 - k1); // Нахождение первой координаты.
// double y = k2 * x + b2;         // Нахождение второй координаты.

// if (k1 == k2 && b1 == b2)
// {
//     Console.Write("Прямые имеют одиннаковые координаты");
// }
// else if (k1 == k2 && b1 != b2)
// {
//     Console.Write("Прямые параллельны");
// }
// else
// {
//     Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
// }

