// напишите программу, которая задает массив из 8 элементов и выводит их на экран

Main ();

void Main()
{
    int lenght = IntRead("размер массива");
    int min = IntRead("начало диапозона чисел");
    int max = IntRead("конец диапозона");
    int[] array = GenerateArray(lenght, min, max);
    System.Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i]+"; ");
    }
    System.Console.WriteLine($"{array[array.Length-1]}]");
}

int[] GenerateArray(int lenght, int min, int max)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}


int IntRead(string argument)
{
    int number;
    System.Console.WriteLine($"введите {argument}");
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("это не число!!!");
    }
    return number;
}