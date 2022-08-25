int result;
int num = new Random().Next(1,65536);
if (num > 99)
{
    result = num % 10;
    Console.WriteLine(num);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}