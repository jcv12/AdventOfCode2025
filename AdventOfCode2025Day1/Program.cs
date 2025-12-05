
Console.WriteLine("Hello, World!");

int startingLocation = 0;
int directionTravel = 1;
int result = 0;
int finalLocation = 0;

result = startingLocation - directionTravel;

Console.WriteLine(result);

if (result < 0)
{
    Console.WriteLine("This is negative so we need to reset to 100");
    finalLocation = 100 + result;
    Console.WriteLine($"This click was: {finalLocation}");
}