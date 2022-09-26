void dz001()
{
// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("______________________");
Console.WriteLine("Задача1");
Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine(number);
int tens = number / 10 % 10;
Console.Write(tens);
}



void dz002()
{
// Напишите программу, которая с помощью деления выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("______________________");
Console.WriteLine("Задача2");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
//int number = 147989;
number = Math.Abs(number); // вызываем математическое пространство имен, берем модуль числа number (в случае отрицатательных)
if (number > 99)
{
    while (number > 999)
    {
    number /= 10;
    }
    Console.WriteLine("Третья цифра числа " + number % 10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
}



void dz003()
{
// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// п проверяет, является ли этот день выходным. 

Console.WriteLine("______________________");
Console.WriteLine("Задача3");

Console.WriteLine("Введите цифру дня недели: ");
int day = int.Parse(Console.ReadLine());
//int day = 6;
if (day > 0 && day < 8)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("день выходной");
    }
    else
    {
        Console.WriteLine("день будний");
    }
}
else
{
    Console.WriteLine("Ввод неверный");
}

}


dz001();
dz002();
dz003();

