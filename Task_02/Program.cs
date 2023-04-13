Console.WriteLine("Enter the first number:");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number:");
Console.Write("c = ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine();

if (a > b && a > c)
{
    Console.WriteLine($"Number a = {a}, b = {b}, c = {c}, and max number is a = {a}");
}
else if (b > a && b > c)
{
    Console.WriteLine($"Number a = {a}, b = {b}, c = {c}, and max number is b = {b}");
}
else if (c > a && c > b)
{
    Console.WriteLine($"Number a = {a}, b = {b}, c = {c}, and max number is c = {c}");
}
else if (a == b && a > c)
{
    Console.WriteLine($"Number a = {a}, b = {b}, c = {c}, and max numbers are a = {a} and b = {b}");
}
else if (a == c && a > b)
{
    Console.WriteLine($"Number a = {a}, b = {b}, c = {c}, and max numbers are a = {a} and c = {c}");
}
else if (b == c && b > a)
{
    Console.WriteLine($"Number a = {a}, b = {b}, c = {c}, and max numbers are b = {b} and c = {c}");
}
else
{
    Console.WriteLine($"All numbers are equals, a = {a}, b = {b}, c = {c}");
}