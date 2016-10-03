/*
 * Project Description:
 * Olympic Soccer Tournament
 * The program first displays a menu givning the user two options.
 * The first option prompts the user to enter in the number of teams competing in an olympic soccer tournament.
 * Then for the number of teams entered, prompt the user to enter the name of the team and the number of points the team has scored.
 * Finally, display the results of the tournament.
 * The second option allows the user to quit the program. 
 * The user is able to run the first option as many times as they wish. 
 * 
 * Nathan Marrs
 * IS 403 Section 02
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Console_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            //Declaring integer to store user input
            do
            {
                userInput = DisplayMenu();
                //Calling on method to display menu writtin below
                if (userInput == 1)
                //If user chooses first option on menu then program will be run
                {
                    {
                        string sName;
                        string NumberTeams;
                        string sPoints;
                        int iPoints;
                        int iTeams;
                        int iCount = 0;
                        int iPositionCount = 1;
                        List<SoccerTeam> SoccerTeams = new List<SoccerTeam>();
                        //Declaring variables and creating list of SoccerTeam objects

                        Console.Write("\nHow many teams? ");
                        NumberTeams = Console.ReadLine();
                        //Getting user input to define number of SoccerTeam objects

                        while (!Int32.TryParse(NumberTeams, out iTeams))
                        {
                            Console.Write("Not a valid number, please try again: ");
                            NumberTeams = Console.ReadLine();
                        }
                        //Exception handling to make sure that the number of teams they enter is a valid integer

                        for (int i = 0; i < iTeams; i++)
                        {
                            Console.Write("\nEnter Team " + (i + 1) + "'s name: ");
                            sName = Console.ReadLine();
                            string teamName = UppercaseFirst(sName);
                            //Grabs user input and capitalizes the first letter

                            Console.Write("Enter " + teamName + "'s points: ");
                            sPoints = Console.ReadLine();
                            while (!Int32.TryParse(sPoints, out iPoints))
                            {
                                Console.Write("Not a valid number, please try again: ");
                                sPoints = Console.ReadLine();
                            }
                            //Exception handling to make sure that the number of points they enter is a valid integer
                            int points = iPoints;

                            SoccerTeams.Add(new SoccerTeam(teamName, points));
                        }
                        //Creating new Soccer Team objects and adding them to the list with attributes assigned according to user input

                        Console.WriteLine("\nHere is the sorted list:\n");
                        //Giving user information on what table below is

                        List<SoccerTeam> sortedTeams = SoccerTeams.OrderByDescending(SoccerTeam => SoccerTeam.points).ToList();
                        //Sorting user input by descending point order

                        Console.WriteLine("Position\tName\t\t\t Points\n________\t____\t\t\t ______");
                        //Figure out how to underline properly***

                        foreach (Object SoccerTeam in sortedTeams)
                        {
                            int iPosition = iPositionCount;
                            //Determing posistion number starting at 1 
                            Console.WriteLine(iPosition + "\t\t" + Convert.ToString(sortedTeams[iCount].teamName).PadRight(25, ' ') + Convert.ToString(sortedTeams[iCount].points).PadRight(25, ' '));
                            //Writing out results of each Soccer Team object using proper spacing
                            iCount++;
                            //Moving to next object in list
                            iPositionCount++;
                            //Increasing position number by one
                        }
                        //Foreach statement that prints out each result of each soccer team in the list
                        Console.WriteLine("");
                        //Adding some space between results and menu 
                    }
                }
                else if (userInput != 2 )
                //Exception handling to make sure user enters valid menu choice number
                {
                    Console.WriteLine("\nPlease enter a valid menu choice number\n");
                }
            } while (userInput != 2);
            //do while loop that allows user to use menu as well as exit program successfully 
        }

        static string UppercaseFirst(string s)
        {
             // Check for empty string.
             if (string.IsNullOrEmpty(s))
             {
                return string.Empty;
             }
             // Return char and concat substring.
             return char.ToUpper(s[0]) + s.Substring(1);
        }
        //method that makes the first letter in a string uppercased

        static public int DisplayMenu()
        {
            string result;
            int iresult;
            Console.WriteLine("Olympic Soccer Tournament");
            Console.WriteLine();
            Console.WriteLine("1. Run olympic soccer program");
            Console.WriteLine("2. Exit");
            Console.WriteLine("\nEnter menu item number choice");
            result = Console.ReadLine();
            while (!Int32.TryParse(result, out iresult))
            {
                Console.Write("\nNot a valid number, please try again: ");
                result = Console.ReadLine();
            }
            //Exception handling to make sure that the menu number user enters is a valid integer
            return iresult;
        }
        //method that displays menu and records user menu input
    }
}




