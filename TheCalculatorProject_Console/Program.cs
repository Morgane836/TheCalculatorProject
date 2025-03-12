// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a, b;
a=int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

int sum = new Addition().Add(a, b);

Console.Write($"{a} + {b} = {sum}");

public class Addition
{
    public int Add(int a, int b)
    {
        return a;// + b;
    }
}
