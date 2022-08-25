int result = new Random().Next(1,1000001);
if ((result % 7 == 0) & (result % 23 == 0))
{
    Console.WriteLine("Кратно!!!");
}
else
{
    Console.WriteLine("Не кратно!");
}

Console.WriteLine(result);