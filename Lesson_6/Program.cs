// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Задай количество цифр в массиве:");

int arraySize = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[arraySize];
int i = 0;

Console.WriteLine("Введи числа массива:");

while (i < arraySize)
{
    userArray[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine();

Console.WriteLine($"Введенный массив: [{String.Join("; ", userArray)}]");

int count = 0;

for (int index = 0; index < arraySize; index++)
{
    if (userArray[index] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел в массиве = {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Находим координаты точки пересечения отрезков A и B по формулам: x = (b2 - b1)/(k1 - k2); y = k1x + b1");

// System.Console.WriteLine("Введи переменную (k1) первого отрезка A: ");
// double firstСoordinateA = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Введи переменную (b1) первого отрезка A: ");
// double secondСoordinateA = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Введи переменную (k2) второго отрезка B: ");
// double firstСoordinateB = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Введи переменную (b2) второго отрезка B: ");
// double secondСoordinateB = Convert.ToDouble(Console.ReadLine());

// double x = (secondСoordinateB - secondСoordinateA) / (firstСoordinateA - firstСoordinateB); 
// double y = firstСoordinateA * x + secondСoordinateA;

// Console.WriteLine($"Координаты точки пересечения отрезков А и Б = x({x}); y({y})");