// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введи начальное значение: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введи конечное значение: ");
int N = int.Parse(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine($"Натуральные числа от {M} до {N}: ");
Console.WriteLine(PrintNumbers(M, N));
//____________________________________________________________________________________________



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введи начальное значение: ");
// int M = int.Parse(Console.ReadLine());

// Console.WriteLine("Введи конечное значение: ");
// int N = int.Parse(Console.ReadLine());

// int PrintNumbers(int start, int end)
// {
//     if (start == end) return start;
//     return (start + PrintNumbers(start + 1, end));
// }

// Console.WriteLine($"Сумма натуральных чисел в интервале от {M} до {N}: ");
// Console.WriteLine(PrintNumbers(M, N));
//____________________________________________________________________________________________




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

// Console.WriteLine("Введи первую переменную функции Аккермана: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введи вторую переменную функции Аккермана: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int AkkermanFunction(int m, int n)
// {
//     if (m == 0 && n > 0) return n + 1;
//     if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
//     if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
//     return AkkermanFunction(m, n);
// }

// Console.WriteLine($"Значение функции Аккермана = {AkkermanFunction(m, n)}");
//____________________________________________________________________________________________