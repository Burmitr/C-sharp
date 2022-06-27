//Домашнее задание.

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write(number1 + " > " + number2);
}
else
{
    Console.Write(number1 + " < " + number2);
}



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введи три числа");

// Console.WriteLine("Первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = Math.Max(num1, Math.Max(num2, num3));

// Console.WriteLine("Максимальное число: " + max);



//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введи число: ");

// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine("Число четное!");
// }
// else
// {
//     Console.WriteLine("Число НЕчетное!");
// }



//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Введи число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int num2 = 0;

// while (num2 < n-1)
// {
//     num2 = num2 + 2;
    
//     Console.Write(num2 + " ");
// }
