// напишите цикл, который принимает на вход два числа А и B ивозводит число А в натуральную степень B.

Main();

void Main ()
{
    int A = IntRead("A");
    int B = IntRead("B");
    
    if(nullExponenta(B))
    {
        System.Console.WriteLine($"число {A} в степени {B} равно {Power(A,B)}");
    }

}

bool nullExponenta(int B)
{
    if(B < 0)
    {
        System.Console.WriteLine("число степени не должно быть отрицательным");
        return false;
    }
    return true;
}

int Power(int a, int b)
{
    int a1 = 1;
    for (int i = 0; i < b; i++)
    {
        a1 *= a;
    }
    return a1;
}

int IntRead(string argument)
{
    int number;
    System.Console.WriteLine($"введите число {argument}:");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("это не число!!!");
    }
    return number;
}