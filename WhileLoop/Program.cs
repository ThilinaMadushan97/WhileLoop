Random randm = new Random();

int i = randm.Next(1,10);
Console.WriteLine($"First number is {i}");

while (i != 7)
{
    Console.WriteLine(i);
    i = randm.Next(1,10);
}
Console.WriteLine($"Current number is {i}");