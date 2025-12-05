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
        int count = 0;

        //we found trhe file yay
        //read in each line and we will parse it out then return, we are going to keep track of the numbers outside the function :/ bad system design
        foreach (string line in File.ReadLines(filePath))
        {

            location = parseInput(line, location);
            Console.WriteLine($"This click was: {location}");

            if (location == 0)
            {
                count++;
            }

        }
        Console.WriteLine(count);
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
                finalDestination = (finalDestination % 100 + 100) % 100;

            }

            //Console.WriteLine($"Destination: {finalDestination}");

            return finalDestination;
        }


        if (firstCharacter == 'R')
        {

            finalDestination = currentLocation + int.Parse(stringNumber); // Moving to the right

            //found an edge case where the data provides a number like 438 and what this really means is it went into 4 complete rotations so we should really treat this like 48

            if (finalDestination > 99)
            {
                finalDestination = finalDestination % 100;
                //Console.WriteLine("This is over 99 so we need to reset to the bottom numbers");
                //finalDestination = finalDestination - 100;
            }
            

            return finalDestination;
        }

        else
        {
            return 0;
        }


    }


}
