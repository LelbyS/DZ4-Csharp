// напишите программу, которая на вход принимает число и выдает сумму цифр числа.

Main();

void Main ()
{
    int num = IntRead("N");

    System.Console.WriteLine($"сумма цифр числа {num} равна {Summ(num)}");

}

int Summ(int num)
{
    int summ = 0;
    for (int i = num; i > 0; i = i/10)
    {
        summ = summ + i%10;
    }
    return summ;
}

int IntRead(string argument)
{
    int number;
    System.Console.WriteLine($"введите число {argument}");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("Это не число!!!");
    }
    return number;
}