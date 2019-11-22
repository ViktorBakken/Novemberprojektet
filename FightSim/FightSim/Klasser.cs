using System;
using System.Collections.Generic;
using System.Text;


class Klasser
{
    private static Random randGen = new Random(); // Slump generatorn

    public static bool restartGame = false; // Bool that can be used when restarting the game

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
    } // check if the intake is an int

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
    } // forces the user to write one of the correct answears

    public static string ChoiseIsNot(string[] wrongAnswears, string answear)
    {
        bool whileAnswearWrong = true;

        while (whileAnswearWrong == true)
        {
            bool wrong = false;
            for (int i = 0; i < wrongAnswears.Length; i++)
            {
                if (answear == wrongAnswears[i])
                {
                    if (answear == "")
                    {
                        Klasser.WriteLine("You can't leave it blank!!", true);
                    }
                    else
                    {
                        Klasser.WriteLine("You can't write that!", true);
                    }
                    
                    Klasser.Write("New name: ", true);
                    answear = Console.ReadLine();
                    wrong = true;
                    break;
                }

                if (wrong == false)
                {
                    whileAnswearWrong = false;
                }
            }
        }
        return answear;
    } // forces the user to not write one of the wrong answears


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

