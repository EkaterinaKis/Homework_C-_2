// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine());
// int num = number % 100;
// Console.WriteLine($"Вторая цифра числа {number}: {num/10}");

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// if (number < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while (number > 999) 
//     {
//         number = number / 10;

//     }
//     Console.WriteLine($"Третья цифра числа {number}: {number % 10}");
// }

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите число, обозначающее день недели: ");
// int number = int.Parse(Console.ReadLine());
// if ((number >= 1) && (number <= 7))
// {      
//     if (number <= 5 && number >= 1)
// {
//     Console.WriteLine("День не является выходным");
// }
// else
// {
//     if ((number == 6) || (number == 7)) ;
//     Console.WriteLine("Выходной!");
// }
// }
// else
// {
//     Console.WriteLine("В неделе только 7 дней!");
// }