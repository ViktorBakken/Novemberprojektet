using System;
using System.Collections.Generic;
using System.Text;


class Klasser
{
    private static Random randGen = new Random(); // Slump generatorn

    public static bool restartGame = false; // Bool that can be used when restarting the game

    public static int IsInt(string intake) // check if the intake is an int
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

    public static string ChoiseCorrect(string[] correctAnswears) //Forces the user to write one of the correct answears
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
    } //Forces the user to write one of the correct answears

    public static string ChoiseIsNot(string[] wrongAnswears, string answear) //Forces the user to not write one of the wrong answears
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
    } //Forces the user to not write one of the wrong answears


    public static void WriteLine(string text, bool ignoreReadLine) //Skriver ut en string
    {
        Console.WriteLine(text);

        if (ignoreReadLine == false)
        {
            Console.ReadLine();
        }
    } //Skriver ut en string


    public static void Write(string text, bool ignoreReadLine) //Writes out the text with "Console.Write();" and also it can ignore "ReadLine()"
    {
        Console.Write(text);

        if (ignoreReadLine == false)
        {
            Console.ReadLine();
        }
    } //Writes out the text with "Console.Write();" and also it can ignore "ReadLine()"


    public static int RandInt(int num1, int num2) //Randomises an int
    {
        int retVal; // retVal = return value

        retVal = randGen.Next(num1, num2 + 1);

        return retVal;
    }//Randomises an int


    public static string RandString(string[] total) //Randomises an string from an array
    {
        int retVal; //retVal = return value

        retVal = randGen.Next(0, total.Length);

        return total[retVal];
    } //Randomises an string from an array
}

