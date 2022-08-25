string input;
int num, result;

input = Console.ReadLine();
num = Int32.Parse(input);

result = (num % 100) / 10;

Console.WriteLine(result);
