// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int third = 1;
    while (numberA > 999)
    {
    numberA /= 10;
    
    }
    if (numberA < 100)
    {
        Console.WriteLine("Вы ввели слишком маленькое число");
        return;
    }
    else
{
third = numberA % 10;
}

Console.WriteLine("Третья цифра этого числа {0}" , third);