// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Task1()     //  Вариант где надо вводить самому число

{

    Console.WriteLine("Введите трехначное число");
    int numberA = Convert.ToInt32(Console.ReadLine());
    int secondc = 1;
    if (numberA > 999 || numberA < 99)
    {
        Console.WriteLine("Число не трехначное");
    }
    else
    {
        Console.WriteLine("Вторая цифра {0} ", secondc = (numberA / 10) % 10);
    }
}


void Task2()  // Вариант где число рандомит
{
    Random rnd = new Random();

    int number = rnd.Next(99, 1000);
    Console.WriteLine("Выпало число {0}", number);
    int secondc = 1;
    Console.WriteLine("Вторая цифра {0} ", secondc = (number / 10) % 10);
}

Task1();