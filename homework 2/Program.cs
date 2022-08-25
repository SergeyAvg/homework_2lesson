string input;
int num, result;

input = Console.ReadLine();
num = Int32.Parse(input);

if (num > 99)
{
    result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}