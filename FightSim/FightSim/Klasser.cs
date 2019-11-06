using System;
using System.Collections.Generic;
using System.Text;


class Klasser
{
    private static Random randGen = new Random(); // Slump generatorn

    public static int IsInt(string intake)
    {
        intake = intake.Trim();
        int amount;
        bool isInt = int.TryParse(intake, out amount);

        while (isInt == false)
        {
            WriteLine("Write a number!", false);
            Console.ReadLine().Trim();
            isInt = int.TryParse(intake, out amount);
        }

        return amount;
    }

    public static string ChoiseCorrect(string[] correctAnswears)
    {
        string answear = "";
        bool wrongInput = true;

        while (wrongInput == true)
        {
            answear = Console.ReadLine().ToLower().Trim();

            for (int i = 0; i < correctAnswears.Length; i++)
            {
                if (answear == correctAnswears[i])
                {
                    wrongInput = false;
                    break;
                }
            }

            if (wrongInput == true)
            {
                Klasser.WriteLine("Wrong input, Write something else", true);
            }

        }

        return answear;
    }

    public static void WriteLine(string text, bool ignoreReadLine)
    {
        Console.WriteLine(text);

        if (ignoreReadLine == false)
        {
            Console.ReadLine();
        }
    } //Skriver ut en string


    public static void Write(string text, bool ignoreReadLine)
    {
        Console.Write(text);

        if (ignoreReadLine == false)
        {
            Console.ReadLine();
        }
    } //Skriver ut med "Console.Write();" och denna metod ger chansen att ignorera "ReadLine"


    public static int RandInt(int num1, int num2)
    {
        int retVal; // retVal = return value

        retVal = randGen.Next(num1, num2 + 1);

        return retVal;
    }//Slumpar mellan två ints


    public static string RandString(string[] total)
    {
        int retVal; //retVal = return value

        retVal = randGen.Next(0, total.Length);

        return total[retVal];
    } //Slumpar en string från en string array
}

