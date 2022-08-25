int day;

day=int.Parse(Console.ReadLine());

if(day <= 7){
    if(day <=5 )
    {
        Console.WriteLine("рабочий");
    }
    else
    {
        Console.WriteLine("выходной");
    }
}
else 
{
    Console.WriteLine("не является днём недели");
}