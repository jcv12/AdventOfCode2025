using System;
using System.IO;


class Program
{
    static void Main()
    {
        string filePath = "example.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        int location = 50;

        //we found trhe file yay
        //read in each line and we will parse it out then return, we are going to keep track of the numbers outside the function :/ bad system design
        foreach (string line in File.ReadLines(filePath))
        {

            location = parseInput(line, location);
            Console.WriteLine($"This click was: {location}");


        }
    }


    static int parseInput(string inputValue, int currentLocation)
    {
        char firstCharacter = inputValue[0]; //Grab the first character, L means Left, R means Right
        string stringNumber = inputValue.Substring(1); //Grab the number of clicks they want us to move
        int finalDestination = 0;

        //Console.WriteLine(inputValue);

        if (firstCharacter == 'L')
        {
            //Console.WriteLine("Moving Left: " + stringNumber);

            finalDestination = currentLocation - int.Parse(stringNumber); // Moving to the left

            if (finalDestination < 0)
            {
                //Console.WriteLine("This is negative so we need to reset to 100");
                finalDestination = 100 + finalDestination;

            }

            //Console.WriteLine($"Destination: {finalDestination}");

            return finalDestination;
        }


        if (firstCharacter == 'R')
        {

            finalDestination = currentLocation + int.Parse(stringNumber); // Moving to the right

            if (finalDestination > 99)
            {
                //Console.WriteLine("This is over 99 so we need to reset to the bottom numbers");
                finalDestination = finalDestination - 100;
            }
            

            return finalDestination;
        }

        else
        {
            return 0;
        }


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


