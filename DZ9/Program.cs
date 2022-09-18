// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


// int ReadData(string line) // Запрос данных пользователя.
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }


// string NumMN(int m, int n) // Рекурсия от М до Н.
// {
//     if (m >= n) return n.ToString();
//     return m + ", " + NumMN(m + 1, n);
// }


// void PrintData(string prefix, string num) // Вывод результата.
// {
//     Console.WriteLine(prefix + num);
// }

// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");
// string res = (m < n) ? (NumMN(m, n)):(NumMN(n, m));
// if (m < 0 || n < 0)
// {
//     Console.WriteLine("Вы ввели некорректное число");
// }
// else PrintData($"Натуральные числа от {m} до {n}: ", res);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }


// int SumMN(int m, int n) // Подсчёт суммы элементов от M до N.
// {
//     if (m >= n) return n;
//     return m + SumMN(m + 1, n);
// }

// void PrintData(string num)
// {
//     Console.WriteLine(num);
// }

// int m = ReadData("Введите число M: ");
// int n = ReadData("Введите число N: ");
// int sum = 0;
// if (m < n) sum = SumMN(m, n);
// else sum = SumMN(n, m);
// PrintData($"Сумма элементов от {m} до {n} равна {sum}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int ReadData(string line)
// {
//     Console.Write(line);
//     return int.Parse(Console.ReadLine());
// }

// int Akkerman(int m, int n) //Вычисление функции Аккермана.
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//     else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// int m = ReadData("Введите положительное число M: ");
// int n = ReadData("Введите положительное число N: ");
// Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

