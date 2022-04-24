int Summa(int a)
{
    int s = 0;
    int b = a;
    for (int i = 10; i < a * 10; i = i * 10)
    {
        s = s + b % 10;
        b = b / 10;
    }
    return s;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int sum = Summa(a);
Console.WriteLine($"{a} -> {sum}");