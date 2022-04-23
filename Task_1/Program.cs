Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int c=1;
for (int i = 1; i <= b; i++)
{
    c=c*a;
}
Console.WriteLine($"{a} в степени {b} равно {c}");

