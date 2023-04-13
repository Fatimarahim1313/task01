Console.WriteLine("Enter the first number:");
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine();
if (a > b)
{
    Console.WriteLine($"Number a = {a} greater than b = {b}");
}
else if (a == b)
{
    Console.WriteLine($"Number a = {a} equals to b = {b}");
}
else
{
    Console.WriteLine($"Number a = {a} less then b = {b}");
}