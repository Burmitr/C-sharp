// int Factorial (int n)
// {
//     if (n == 1) return 1; // базовый случай выхода из рекурсии
//     return n * Factorial(n-1); // рекурсивный выход
// }
// Console.WriteLine(Factorial(5));


// Задайте значение N.
//Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int N = int.Parse(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start +1, end));
// }

// System.Console.WriteLine(PrintNumbers(1, N));



// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// int M = int.Parse(Console.ReadLine());
// int N = int.Parse(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start + 1, end));
// }

// Console.WriteLine(PrintNumbers(M, N));



// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int number = int.Parse(Console.ReadLine());

// int SumNumbers(int number)
// {
//     if (number == 0) return 0;
//     return (number % 10 + SumNumbers(number / 10));
// }

// Console.WriteLine(SumNumbers(number));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int number = int.Parse(Console.ReadLine());
// int degree = int.Parse(Console.ReadLine());

// int ExponentiationNumber (int number, int degree)
// {
//     if (degree == 0) return 1;
//     if (degree = 1) return number;
//     return (number * ExponentiationNumber(number, degree -1));
// }

// Console.WriteLine(ExponentiationNumber(number, degree));