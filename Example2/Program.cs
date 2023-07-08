// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Add(string message)
{
    System.Console.WriteLine(message);
    int numberA = Convert.ToInt32(Console.ReadLine());
    return numberA;

}

int num = Add(" Введите число  ");

 while (num > 999)
    {
        num = num / 10;
        return num % 10;
    }

if ((num / 100) == 0)
{
    Console.WriteLine("Число {0} не трехзначное " ,num);
}

Console.WriteLine( num );
