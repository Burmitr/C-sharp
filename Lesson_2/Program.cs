// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Result(int num)
{
    int second = num / 10;
    return second % 10;
}
Console.Write(Result(num));



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)
// {
//     int Result(int num)
//     {
//       return num % 10;
//     }
//     Console.Write(Result(num));
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет!");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите номер дня недели: ");
// int dayOfWeek = Convert.ToInt16(Console.ReadLine());

// if (dayOfWeek >=1 && dayOfWeek <=7)
// {
//     if (dayOfWeek >=1 && dayOfWeek <=5)
//     {
//         Console.WriteLine("Это будний день.");
//     }
//     else
//     {
//        Console.WriteLine("Это выходной день.");
//     }
// }
// else
// {
//     Console.Write("!Введён неверный номер дня недели!");
// }

