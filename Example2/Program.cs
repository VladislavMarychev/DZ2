// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
int third = 1;
    if (numberA > 999)
    {
    numberA /= 10;
    }
    if (numberA < 100)
    {
        Console.WriteLine("Маленькое число");
    }
    else
{
third = numberA % 10;
}

Console.WriteLine("Цифра {0}" , third);