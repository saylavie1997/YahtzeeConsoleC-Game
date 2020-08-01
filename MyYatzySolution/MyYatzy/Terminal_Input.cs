/*

Docomentation

This Yatzy program is structured around three .cs files. A file called Program.cs which includes the main method, which is connected to the two other .cs files trough the namespace MyYatzy.
The first three methods in the main, are methods from Terminal_Input.cs, where three classes inheritance from the class Terminal_Input.
The first class is called User_name and creates a method called YathzeeUserName, to produce a stored username.

The second class called Rulebook, produceres a small preview of the rules, and the third class DiceSelection and its method YathzeeChooseDiceType initiate game start, after confirming dice type.
The last method in the Terminal_Input.cs file is called DiceCombinations and starts the preparations for game 4, by outputting text to inform the user of the rules and conditions of the lower section of game 4, 5 and 6. 
From the second file called GAME.cs, have the methods of the turns been stored. This file contains a class called Game where all of the games objects are stored.
Furthermore have there been created six classes called Game1, Game2, Game3, Game4, Game5 and Game6.

These classes inheritance from the Game class with objects, and each game class contains four methods to initiate dice roll, dice hold, the three rounds and the game calculation.
After the first three games have been played will the lower section of the game be played. This section is also played in 3 games with three rounds.
The method DiceCombinations from Terminal_Input.cs is ran after the user has finished game 3, and this method will provide the player with informations regarding the lower section of the game.

 This program is devided into two sections, an upper and a lower section. In the upper section which is played before the lower section, will the player have the oppertunity to get the outcome of  ones/twos/threes/fours/fives/sixes. In the lower section of the game, will the player have the oppertunity to get the outcome of one pair/two pairs/three-of-a-kind/four-of-a-kind, Small straight/large straight,
 Full house and chance. Note: The chance doenst show the right input, it will outprint System.Int32[] instead of the saved value of the dices. If the total score of the upper section is 63 points or above  the player gets a 50 points bonus, otherwise the bounus field will be equal to 0.  
 The player wont be able to drop a holded value, and there is only implemented one dice type, the fair random type.

 The Access Modifiers are declared to be public, becuase there are not any kind of secure or personal data to be stored in the program.
 The static modifier keyword is used to declare variables and methods, becuase the static modifier belongs to the type itself rather than to a specific object.
 There are an usage of the namespaces System; and System.Collections.Generic; The first namespace is used to inhertiate the keywords "Random". "Next" and "new"
 in order to generate random dice faces. The second namespace is used to print out the scoreboard and provides better type safety and performance than non-generic collections.

 */

using System;
namespace MyYatzy
{
    // Welcome and Settings gathering
    public class Terminal_Input
    {
        //Objects
        public static string PLAY = "PLAY";
        public static string RULES = "RULES";
        public static int c1 = 1;
        public static int c2 = 2;
        public static int c3 = 3;

        //SUB-classes of Terminal_Input
        public class User_name : Terminal_Input
        {
            public static void YathzeeUserName()
            {
                // Lader brugeren vælge et username.
                Console.WriteLine("__________________________ ");
                Console.WriteLine("    Enter a username:");
                Console.WriteLine("__________________________ ");
                Console.WriteLine("");

                // Oprettelse af en string variable til at gemme user input og opbavare det i en variable.
                var userName = Console.ReadLine();
                Console.WriteLine(" ");

                // Print the value of the variable (userName), which will be displayed the Terminal
                Console.WriteLine("___________________________________________________________ ");
                Console.WriteLine(" ");
                Console.WriteLine($"             Welcome " + userName + " to the game of Yatzee");
                Console.WriteLine(" ");
                Console.WriteLine("___________________________________________________________ ");
                Console.WriteLine(" ");
            }
        }
        public class Rulebook : Terminal_Input
        {
            public static void YathzeeRules()
            {
                // WHILE STATEMENT to insuce the right input
                try
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($" • Enter RULES TWO Times, to open the rulebook of Yatzee");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________");
                    Console.WriteLine(" ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.GetType() + " : " + ex.Message);
                } while (RULES != Console.ReadLine()) ;

                // IF Statement til at vise reglerne
                if (Console.ReadLine() == RULES)
                {
                    try
                    {
                        //RULES
                        Console.WriteLine("");
                        Console.WriteLine(" ");
                        Console.WriteLine(" - The objective of the game is to score points ");
                        Console.WriteLine("   by rolling six dices to make certain combinations. ");
                        Console.WriteLine("   The dice can be rolled up to three times in a turn");
                        Console.WriteLine("   to try to make various scoring combinations. ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("________________________________");
                        Console.WriteLine("   (PRO TIP) Enable CAPSLOCK  ");
                        Console.WriteLine("________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("___________________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(" • Enter PLAY TWO Times, to begin the game.");
                        Console.WriteLine("");
                        Console.WriteLine("___________________________________________________________");
                        Console.WriteLine("");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.GetType() + " : " + ex.Message);
                    } while (PLAY != Console.ReadLine()) ;

                }

            }

        }
        public class DiceSelection : Terminal_Input
        { 
            public static void YathzeeChooseDiceType()
            {
                // IF Statement til at starte PLAY 

                    if (Console.ReadLine() == PLAY)
                    {

                        Console.WriteLine("___________________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("           You must choose a dice type,");
                        Console.WriteLine("           before the game of Yathzee can begin.");
                        Console.WriteLine("");
                        Console.WriteLine("___________________________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine(" •  Input 1 = The Six-sided Fair dice ");
                        Console.WriteLine("");
                        Console.WriteLine(" •  Input 2 = The Six-sided Non-Fair dice --- THIS IS NOT ACTIVE ---"); 
                        Console.WriteLine("");
                        Console.WriteLine("___________________________________________________________");
                        Console.WriteLine("");
                    }

                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    //Comment
                    Console.WriteLine("                         HOW TO PLAY     ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" ");
                    Console.WriteLine($" - You have 3 rolls per round.       ");
                    Console.WriteLine($" - There are 3 rounds per game.       ");
                    Console.WriteLine(" ");
                    Console.WriteLine($" - You can hold one or muliply dices        ");
                    Console.WriteLine($"   by number of the selected dice.        ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.WriteLine($"   • Input 1 to hold dice 1.    ");
                    Console.WriteLine($"   • Input 2 to hold dice 2.    ");
                    Console.WriteLine($"   • Input 3 to hold dice 3.    ");
                    Console.WriteLine($"   • Input 4 to hold dice 4.    ");
                    Console.WriteLine($"   • Input 5 to hold dice 5.    ");
                    Console.WriteLine($"   • Input 6 to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine("  ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" ");
                    Console.WriteLine("                          Game 1 - Round 1     ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" ");
                    Console.WriteLine($" • Input R to begin rolling process       ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");


                }
            }

        }

        //PREPERATIONS FOR GAME 4
        public static void DiceCombinations()
        {
            Console.ReadKey();
            if (Console.ReadKey().Key == ConsoleKey.L)
            {
                Console.WriteLine("______________________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(" GAME 4, 5 and 6 is played on the LOWER SECTION of the YAYZY Scoreboard");
                Console.WriteLine("");
                Console.WriteLine("______________________________ Dice Combinations______________________________");
                Console.WriteLine("");
                Console.WriteLine(" • 3 of Kind        =     Three similar dices");
                Console.WriteLine(" • 4 of Kind        =     Four similar dices");
                Console.WriteLine(" • Full House       =     Three similar dices AND Two other similar dices");
                Console.WriteLine(" • Small Straight   =     Dice combination of 1,2,3,4,5 AND 6");
                Console.WriteLine(" • Big Straight     =     Dice combination of 2,3,4,5 AND 6");
                Console.WriteLine(" • Chance           =     ALL dices");
                Console.WriteLine(" • YATZY            =     The calulated number of 6 similar dices");
                Console.WriteLine(" • YATZY BONUS      =     A bonus of 50 points, WHEN YAYZY happens");
                Console.WriteLine("");
                Console.WriteLine("______________________________________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  Pres R to begin GAME 4");

            }

        }




    }
}
