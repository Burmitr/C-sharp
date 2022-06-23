Console.Write("Введи первое число: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");

int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == number1 * number1)
{
    Console.Write("Второе число = квадрату первого.");
}
else
{
    Console.Write("ОШИБКА!!! Второе число НЕ РАВНО квадрату первого.");
}
