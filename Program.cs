//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// 645 78 32679
//1. Программа для Первого и второго условия
int n = 78;

if(n > 99 & n <= 999 )
{
    Console.WriteLine( n % 10);
}
else
{
    Console.WriteLine ("третьей цифры нет");
}

//2. Программа для третьего условия

int x = 32679;

if(x > 99 )
{
    Console.WriteLine( (x / 100) % 10);
}
else
{
    Console.WriteLine ("третьей цифры нет");
}

//3. Решение для всех случаев

int z = 32679;
        Console.WriteLine(z>99 ? z.ToString()[2] : "третьей цифры нет");
        Console.ReadKey(true);


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a1 = 1;
Console.WriteLine("1 - Понедельник");
int a2 = 2;
Console.WriteLine("2 - Вторник");
int a3 = 3;
Console.WriteLine("3 - Среда");
int a4 = 4;
Console.WriteLine("4 - Четверг");
int a5 = 5;
Console.WriteLine("5 - Пятница");
int a6 = 6;
Console.WriteLine("6 - Суббота");
int a7 = 7;
Console.WriteLine("7 - Воскресенье");
if ( num < 6 )
{
    Console.WriteLine($"{num} - рабочий день");
}
else
{
    Console.WriteLine($"{num} - выходной день");
}