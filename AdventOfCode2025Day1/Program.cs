using System;
using System.IO;


class Program
{
    static void Main()
    {
        string filePath = "ExampleInput.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }


        //we found trhe file yay

        foreach(string line in File.ReadLines(filePath))
        {
            parseInput(line);
        }
    }





    static void parseInput(string inputValue)
    {
        char firstCharacter = inputValue[0]; //Grab the first character, L means Left, R means Right
        string stringNumber = inputValue.Substring(1); //Grab the number of clicks they want us to move

        Console.WriteLine(inputValue);

        if (firstCharacter == 'L')
        {
            moveLeft(int.Parse(stringNumber));
        }


        if (firstCharacter == 'R')
        {
            moveRight(int.Parse(stringNumber));
        }


    }


    static void moveLeft(int travelDistance)
    {
        Console.WriteLine("Moving Left: " + travelDistance);
    }


    static void moveRight(int travelDistance)
    {
        Console.WriteLine("Moving Right: " + travelDistance);
    }



}





//int startingLocation = 50;
//int directionTravel = 68;
//int result = 0;
//int finalLocation = 0;

//result = startingLocation - directionTravel;

//Console.WriteLine(result);

//if (result < 0)
//{
//    Console.WriteLine("This is negative so we need to reset to 100");
//    finalLocation = 100 + result;
//    Console.WriteLine($"This click was: {finalLocation}");
//}


//parseInput("L68");




//static void parseInput(string inputValue)
//{
//    char firstCharacter = inputValue[0]; //Grab the first character, L means Left, R means Right
//    string stringNumber = inputValue.Substring(1); //Grab the number of clicks they want us to move

//    Console.WriteLine(inputValue);

//    if (firstCharacter == 'L')
//    {
//        moveLeft(int.Parse(stringNumber));
//    }


//    if (firstCharacter == 'R')
//    {
//        moveRight(int.Parse(stringNumber));
//    }


//}


//static void moveLeft(int travelDistance)
//{
//    Console.WriteLine("Moving Left: " + travelDistance);
//}


//static void moveRight(int travelDistance)
//{
//    Console.WriteLine("Moving Right: " + travelDistance);
//}


