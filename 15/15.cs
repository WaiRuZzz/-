int a;
int b;
int c;
a=1;
b=6;
c=7;
Console.WriteLine("введите  число 1-7: ");
a = Convert.ToInt32(Console.ReadLine());
if (a < 6)
{
Console.WriteLine($" {a} будний день");
}
else if (a == 6)
{
    Console.WriteLine($" {b} выходной день");
}
else if (a == 7)
{
    Console.WriteLine($" {c} выходной день");
}