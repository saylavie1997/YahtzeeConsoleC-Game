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
using System.Collections.Generic;
namespace MyYatzy
{
    public class Game
    {
        // GAME 1 Objects 
        public static Random rnd = new Random();
        public static int dice1 = rnd.Next(1, 7);
        public static int dice2 = rnd.Next(1, 7);
        public static int dice3 = rnd.Next(1, 7);
        public static int dice4 = rnd.Next(1, 7);
        public static int dice5 = rnd.Next(1, 7);
        public static int dice6 = rnd.Next(1, 7);

        public static string[] Status = { nostatus, nostatus, nostatus, nostatus, nostatus, nostatus };
        public static string status = "S";
        public static string nostatus = "N";


        public static int dice1_2 = rnd.Next(1, 7);
        public static int dice2_2 = rnd.Next(1, 7);
        public static int dice3_2 = rnd.Next(1, 7);
        public static int dice4_2 = rnd.Next(1, 7);
        public static int dice5_2 = rnd.Next(1, 7);
        public static int dice6_2 = rnd.Next(1, 7);

        public static int dice1_3 = rnd.Next(1, 7);
        public static int dice2_3 = rnd.Next(1, 7);
        public static int dice3_3 = rnd.Next(1, 7);
        public static int dice4_3 = rnd.Next(1, 7);
        public static int dice5_3 = rnd.Next(1, 7);
        public static int dice6_3 = rnd.Next(1, 7);

        public static int dice1_4 = 0;
        public static int dice2_4 = 0;
        public static int dice3_4 = 0;
        public static int dice4_4 = 0;
        public static int dice5_4 = 0;
        public static int dice6_4 = 0;

        public static int[] diceRound1 = { dice1, dice2, dice3, dice4, dice5, dice6 };
        public static int[] diceRound2 = { dice1_2, dice2_2, dice3_2, dice4_2, dice5_2, dice6_2 };
        public static int[] diceRound3 = { dice1_3, dice2_3, dice3_3, dice4_3, dice5_3, dice6_3 };
        public static int[] Score = { dice1_4, dice2_4, dice3_4, dice4_4, dice5_4, dice6_4 };

        public static int[] Aces = { 0, 0, 0, 0, 0, 0 };
        public static int[] Twos = { 0, 0, 0, 0, 0, 0 };
        public static int[] Thress = { 0, 0, 0, 0, 0, 0 };
        public static int[] Fours = { 0, 0, 0, 0, 0, 0 };
        public static int[] Fives = { 0, 0, 0, 0, 0, 0 };
        public static int[] Sixes = { 0, 0, 0, 0, 0, 0 };


        // GAME 2 Objects
        public static int g2dice1 = rnd.Next(1, 7);
        public static int g2dice2 = rnd.Next(1, 7);
        public static int g2dice3 = rnd.Next(1, 7);
        public static int g2dice4 = rnd.Next(1, 7);
        public static int g2dice5 = rnd.Next(1, 7);
        public static int g2dice6 = rnd.Next(1, 7);

        public static int g2dice1_2 = rnd.Next(1, 7);
        public static int g2dice2_2 = rnd.Next(1, 7);
        public static int g2dice3_2 = rnd.Next(1, 7);
        public static int g2dice4_2 = rnd.Next(1, 7);
        public static int g2dice5_2 = rnd.Next(1, 7);
        public static int g2dice6_2 = rnd.Next(1, 7);

        public static int g2dice1_3 = rnd.Next(1, 7);
        public static int g2dice2_3 = rnd.Next(1, 7);
        public static int g2dice3_3 = rnd.Next(1, 7);
        public static int g2dice4_3 = rnd.Next(1, 7);
        public static int g2dice5_3 = rnd.Next(1, 7);
        public static int g2dice6_3 = rnd.Next(1, 7);

        public static string g2status = "S";
        public static string g2nostatus = "N";

        public static int g2dice1_4 = 0;
        public static int g2dice2_4 = 0;
        public static int g2dice3_4 = 0;
        public static int g2dice4_4 = 0;
        public static int g2dice5_4 = 0;
        public static int g2dice6_4 = 0;

        public static int[] g2diceRound1 = { g2dice1, g2dice2, g2dice3, g2dice4, g2dice5, g2dice6 };
        public static int[] g2diceRound2 = { g2dice1_2, g2dice2_2, g2dice3_2, g2dice4_2, g2dice5_2, g2dice6_2 };
        public static int[] g2diceRound3 = { g2dice1_3, g2dice2_3, g2dice3_3, g2dice4_3, g2dice5_3, g2dice6_3 };
        public static int[] g2Score = { g2dice1_4, g2dice2_4, g2dice3_4, g2dice4_4, g2dice5_4, g2dice6_4 };

        public static string[] g2Status = { g2nostatus, g2nostatus, g2nostatus, g2nostatus, g2nostatus, g2nostatus };

        public static int[] g2Aces = { 0, 0, 0, 0, 0, 0 };
        public static int[] g2Twos = { 0, 0, 0, 0, 0, 0 };
        public static int[] g2Thress = { 0, 0, 0, 0, 0, 0 };
        public static int[] g2Fours = { 0, 0, 0, 0, 0, 0 };
        public static int[] g2Fives = { 0, 0, 0, 0, 0, 0 };
        public static int[] g2Sixes = { 0, 0, 0, 0, 0, 0 };

        // GAME 3 Objects
        public static int g3dice1 = rnd.Next(1, 7);
        public static int g3dice2 = rnd.Next(1, 7);
        public static int g3dice3 = rnd.Next(1, 7);
        public static int g3dice4 = rnd.Next(1, 7);
        public static int g3dice5 = rnd.Next(1, 7);
        public static int g3dice6 = rnd.Next(1, 7);

        public static int g3dice1_2 = rnd.Next(1, 7);
        public static int g3dice2_2 = rnd.Next(1, 7);
        public static int g3dice3_2 = rnd.Next(1, 7);
        public static int g3dice4_2 = rnd.Next(1, 7);
        public static int g3dice5_2 = rnd.Next(1, 7);
        public static int g3dice6_2 = rnd.Next(1, 7);

        public static int g3dice1_3 = rnd.Next(1, 7);
        public static int g3dice2_3 = rnd.Next(1, 7);
        public static int g3dice3_3 = rnd.Next(1, 7);
        public static int g3dice4_3 = rnd.Next(1, 7);
        public static int g3dice5_3 = rnd.Next(1, 7);
        public static int g3dice6_3 = rnd.Next(1, 7);

        public static string g3status = "S";
        public static string g3nostatus = "N";

        public static int g3dice1_4 = 0;
        public static int g3dice2_4 = 0;
        public static int g3dice3_4 = 0;
        public static int g3dice4_4 = 0;
        public static int g3dice5_4 = 0;
        public static int g3dice6_4 = 0;

        public static int[] g3diceRound1 = { g3dice1, g3dice2, g3dice3, g3dice4, g3dice5, g3dice6 };
        public static int[] g3diceRound2 = { g3dice1_2, g3dice2_2, g3dice3_2, g3dice4_2, g3dice5_2, g3dice6_2 };
        public static int[] g3diceRound3 = { g3dice1_3, g3dice2_3, g3dice3_3, g3dice4_3, g3dice5_3, g3dice6_3 };
        public static int[] g3Score = { g3dice1_4, g3dice2_4, g3dice3_4, g3dice4_4, g3dice5_4, g3dice6_4 };

        public static string[] g3Status = { g3nostatus, g3nostatus, g3nostatus, g3nostatus, g3nostatus, g3nostatus };

        public static int[] g3Aces = { 0, 0, 0, 0, 0, 0 };
        public static int[] g3Twos = { 0, 0, 0, 0, 0, 0 };
        public static int[] g3Thress = { 0, 0, 0, 0, 0, 0 };
        public static int[] g3Fours = { 0, 0, 0, 0, 0, 0 };
        public static int[] g3Fives = { 0, 0, 0, 0, 0, 0 };
        public static int[] g3Sixes = { 0, 0, 0, 0, 0, 0 };

        // GAME 4 Objects
        public static int g4dice1 = rnd.Next(1, 7);
        public static int g4dice2 = rnd.Next(1, 7);
        public static int g4dice3 = rnd.Next(1, 7);
        public static int g4dice4 = rnd.Next(1, 7);
        public static int g4dice5 = rnd.Next(1, 7);
        public static int g4dice6 = rnd.Next(1, 7);

        public static int g4dice1_2 = rnd.Next(1, 7);
        public static int g4dice2_2 = rnd.Next(1, 7);
        public static int g4dice3_2 = rnd.Next(1, 7);
        public static int g4dice4_2 = rnd.Next(1, 7);
        public static int g4dice5_2 = rnd.Next(1, 7);
        public static int g4dice6_2 = rnd.Next(1, 7);

        public static int g4dice1_3 = rnd.Next(1, 7);
        public static int g4dice2_3 = rnd.Next(1, 7);
        public static int g4dice3_3 = rnd.Next(1, 7);
        public static int g4dice4_3 = rnd.Next(1, 7);
        public static int g4dice5_3 = rnd.Next(1, 7);
        public static int g4dice6_3 = rnd.Next(1, 7);

        public static string g4status = "S";
        public static string g4nostatus = "N";

        public static int g4dice1_4 = 0;
        public static int g4dice2_4 = 0;
        public static int g4dice3_4 = 0;
        public static int g4dice4_4 = 0;
        public static int g4dice5_4 = 0;
        public static int g4dice6_4 = 0;

        public static int[] g4diceRound1 = { g4dice1, g4dice2, g4dice3, g4dice4, g4dice5, g4dice6 };
        public static int[] g4diceRound2 = { g4dice1_2, g4dice2_2, g4dice3_2, g4dice4_2, g4dice5_2, g4dice6_2 };
        public static int[] g4diceRound3 = { g4dice1_3, g4dice2_3, g4dice3_3, g4dice4_3, g4dice5_3, g4dice6_3 };
        public static int[] g4Score = { g4dice1_4, g4dice2_4, g4dice3_4, g4dice4_4, g4dice5_4, g4dice6_4 };

        public static string[] g4Status = { g4nostatus, g4nostatus, g4nostatus, g4nostatus, g4nostatus, g4nostatus };

        public static int[] g43ofkind = { 0, 0, 0 };
        public static int[] g44ofkind = { 0, 0, 0, 0 };
        public static int[] g4YAYZY = { 0, 0, 0, 0, 0, 0 };
        public static int[] g4YAYZYBONUS = { 0, 0, 0, 0, 0, 0 };
        public static int[] g4SmallS = { 0, 0, 0, 0, 0, 0 };
        public static int[] g4BigS = { 0, 0, 0, 0, 0 };
        public static int[] g4FHouse = { 0, 0, 0, 0, 0 };
        public static int[] g4CHANCE = { g4Score[0] + g4Score[1] + g4Score[2] + g4Score[3] + g4Score[4] + g4Score[5] };


        // GAME 5 Objects
        public static int g5dice1 = rnd.Next(1, 7);
        public static int g5dice2 = rnd.Next(1, 7);
        public static int g5dice3 = rnd.Next(1, 7);
        public static int g5dice4 = rnd.Next(1, 7);
        public static int g5dice5 = rnd.Next(1, 7);
        public static int g5dice6 = rnd.Next(1, 7);

        public static int g5dice1_2 = rnd.Next(1, 7);
        public static int g5dice2_2 = rnd.Next(1, 7);
        public static int g5dice3_2 = rnd.Next(1, 7);
        public static int g5dice4_2 = rnd.Next(1, 7);
        public static int g5dice5_2 = rnd.Next(1, 7);
        public static int g5dice6_2 = rnd.Next(1, 7);

        public static int g5dice1_3 = rnd.Next(1, 7);
        public static int g5dice2_3 = rnd.Next(1, 7);
        public static int g5dice3_3 = rnd.Next(1, 7);
        public static int g5dice4_3 = rnd.Next(1, 7);
        public static int g5dice5_3 = rnd.Next(1, 7);
        public static int g5dice6_3 = rnd.Next(1, 7);

        public static string g5status = "S";
        public static string g5nostatus = "N";

        public static int g5dice1_4 = 0;
        public static int g5dice2_4 = 0;
        public static int g5dice3_4 = 0;
        public static int g5dice4_4 = 0;
        public static int g5dice5_4 = 0;
        public static int g5dice6_4 = 0;

        public static int[] g5diceRound1 = { g5dice1, g5dice2, g5dice3, g5dice4, g5dice5, g5dice6 };
        public static int[] g5diceRound2 = { g5dice1_2, g5dice2_2, g5dice3_2, g5dice4_2, g5dice5_2, g5dice6_2 };
        public static int[] g5diceRound3 = { g5dice1_3, g5dice2_3, g5dice3_3, g5dice4_3, g5dice5_3, g5dice6_3 };
        public static int[] g5Score = { g5dice1_4, g5dice2_4, g5dice3_4, g5dice4_4, g5dice5_4, g5dice6_4 };

        public static string[] g5Status = { g5nostatus, g5nostatus, g5nostatus, g5nostatus, g5nostatus, g5nostatus };

        public static int[] g53ofkind = { 0, 0, 0 };
        public static int[] g54ofkind = { 0, 0, 0, 0 };
        public static int[] g5YAYZY = { 0, 0, 0, 0, 0, 0 };
        public static int[] g5YAYZYBONUS = { 0, 0, 0, 0, 0, 0 };
        public static int[] g5SmallS = { 0, 0, 0, 0, 0, 0 };
        public static int[] g5BigS = { 0, 0, 0, 0, 0 };
        public static int[] g5FHouse = { 0, 0, 0, 0, 0 };
        public static int[] g5CHANCE = { g5Score[0] + g5Score[1] + g5Score[2] + g5Score[3] + g5Score[4] + g5Score[5] };

        // GAME 6 Objects
        public static int g6dice1 = rnd.Next(1, 7);
        public static int g6dice2 = rnd.Next(1, 7);
        public static int g6dice3 = rnd.Next(1, 7);
        public static int g6dice4 = rnd.Next(1, 7);
        public static int g6dice5 = rnd.Next(1, 7);
        public static int g6dice6 = rnd.Next(1, 7);

        public static int g6dice1_2 = rnd.Next(1, 7);
        public static int g6dice2_2 = rnd.Next(1, 7);
        public static int g6dice3_2 = rnd.Next(1, 7);
        public static int g6dice4_2 = rnd.Next(1, 7);
        public static int g6dice5_2 = rnd.Next(1, 7);
        public static int g6dice6_2 = rnd.Next(1, 7);

        public static int g6dice1_3 = rnd.Next(1, 7);
        public static int g6dice2_3 = rnd.Next(1, 7);
        public static int g6dice3_3 = rnd.Next(1, 7);
        public static int g6dice4_3 = rnd.Next(1, 7);
        public static int g6dice5_3 = rnd.Next(1, 7);
        public static int g6dice6_3 = rnd.Next(1, 7);

        public static string g6status = "S";
        public static string g6nostatus = "N";

        public static int g6dice1_4 = 0;
        public static int g6dice2_4 = 0;
        public static int g6dice3_4 = 0;
        public static int g6dice4_4 = 0;
        public static int g6dice5_4 = 0;
        public static int g6dice6_4 = 0;

        public static int[] g6diceRound1 = { g6dice1, g6dice2, g6dice3, g6dice4, g6dice5, g6dice6 };
        public static int[] g6diceRound2 = { g6dice1_2, g6dice2_2, g6dice3_2, g6dice4_2, g6dice5_2, g6dice6_2 };
        public static int[] g6diceRound3 = { g6dice1_3, g6dice2_3, g6dice3_3, g6dice4_3, g6dice5_3, g6dice6_3 };
        public static int[] g6Score = { g6dice1_4, g6dice2_4, g6dice3_4, g6dice4_4, g6dice5_4, g6dice6_4 };

        public static string[] g6Status = { g6nostatus, g6nostatus, g6nostatus, g6nostatus, g6nostatus, g6nostatus };

        public static int[] g63ofkind = { 0, 0, 0 };
        public static int[] g64ofkind = { 0, 0, 0, 0 };
        public static int[] g6YAYZY = { 0, 0, 0, 0, 0, 0 };
        public static int[] g6YAYZYBONUS = { 0, 0, 0, 0, 0, 0 };
        public static int[] g6SmallS = { 0, 0, 0, 0, 0, 0 };
        public static int[] g6BigS = { 0, 0, 0, 0, 0 };
        public static int[] g6FHouse = { 0, 0, 0, 0, 0 };
        public static int[] g6CHANCE = { g6Score[0] + g6Score[1] + g6Score[2] + g6Score[3] + g6Score[4] + g6Score[5] };




        // Sub-Classes of SuperClas "GAME"

        public class Game1 : Game
        {
            // GAME 1 Round 1
            public static void ROUND1()
            {


                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                         GAME 1 ROUND 1");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |  Dice 1 =| " + diceRound1[0] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 2 =| " + diceRound1[1] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 3 =| " + diceRound1[2] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 4 =| " + diceRound1[3] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 5 =| " + diceRound1[4] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 6 =| " + diceRound1[5] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound2[0] = dice1;
                            Score[0] = dice1;
                            Status[0] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound2[1] = dice2;
                            Score[1] = dice2;
                            Status[1] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound2[2] = dice3;
                            Score[2] = dice3;
                            Status[2] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound2[3] = dice4;
                            Score[3] = dice4;
                            Status[3] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound2[4] = dice5;
                            Score[4] = dice5;
                            Status[4] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound2[5] = dice6;
                            Score[5] = dice6;
                            Status[5] = status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.R);

                }


            }

            // GAME 1 Round 2
            public static void ROUND2()
            {
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                         GAME 1 ROUND 2");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + Status[0] + "  Dice 1 =|" + diceRound2[0] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[1] + "  Dice 2 =|" + diceRound2[1] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[2] + "  Dice 3 =|" + diceRound2[2] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[3] + "  Dice 4 =|" + diceRound2[3] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[4] + "  Dice 5 =|" + diceRound2[4] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[5] + "  Dice 6 =|" + diceRound2[5] + "|         ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");

                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" ");
                    Console.ReadKey();


                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound3[0] = diceRound2[0];
                            Score[0] = diceRound3[0];
                            Status[0] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound3[1] = diceRound2[1];
                            Score[1] = diceRound3[1];
                            Status[1] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound3[2] = diceRound2[2];
                            Score[2] = diceRound3[2];
                            Status[2] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound3[3] = diceRound2[3];
                            Score[3] = diceRound3[3];
                            Status[3] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound3[4] = diceRound2[4];
                            Score[4] = diceRound3[4];
                            Status[4] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            diceRound3[5] = diceRound2[5];
                            Score[5] = diceRound3[5];
                            Status[5] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.R);
                }
            }

            // GAME 1 Round 3
            public static void ROUND3()
            {
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {


                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                             GAME 1 ROUND 3");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + Status[0] + "  Dice 1 =|" + diceRound3[0] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[1] + "  Dice 2 =|" + diceRound3[1] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[2] + "  Dice 3 =|" + diceRound3[2] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[3] + "  Dice 4 =|" + diceRound3[3] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[4] + "  Dice 5 =|" + diceRound3[4] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + Status[5] + "  Dice 6 =|" + diceRound3[5] + "|         ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");

                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" ");
                    Console.ReadKey();


                    do
                    {

                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 1 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            Score[0] = diceRound3[0];
                            Status[0] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 1 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            Score[1] = diceRound3[1];
                            Status[1] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 1 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            Score[2] = diceRound3[2];
                            Status[2] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 1 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            Score[3] = diceRound3[3];
                            Status[3] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 1 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            Score[4] = diceRound3[4];
                            Status[4] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 1");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            Score[5] = diceRound3[5];
                            Status[5] = status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 1  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.F);


                }



            }

            // GAME 1 FINISHED
            public static void GAME1_Finished()
            {
                if (Console.ReadKey().Key == ConsoleKey.F)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                     GAME 1 HAS FINISHED");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" You have saved the values of ");
                    Console.WriteLine(" ");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   | Dice 1 =|" + Score[0] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 2 =|" + Score[1] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 3 =|" + Score[2] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 4 =|" + Score[3] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 5 =|" + Score[4] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 6 =|" + Score[5] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" To view and input values into the Scoreboard,");
                    Console.WriteLine(" input S Twice into the terminal.  ");
                    Console.WriteLine("  ");
                    Console.WriteLine("  ");

                    if (Score[0] == 0)
                    {

                    }
                    else if (Score[0] == 1)
                    {
                        Aces[0] = Score[0];
                    }
                    else if (Score[0] == 2)
                    {
                        Twos[0] = Score[0];
                    }
                    else if (Score[0] == 3)
                    {
                        Thress[0] = Score[0];
                    }
                    else if (Score[0] == 4)
                    {
                        Fours[0] = Score[0];
                    }
                    else if (Score[0] == 5)
                    {
                        Fives[0] = Score[0];
                    }
                    else if (Score[0] == 6)
                    {
                        Sixes[0] = Score[0];
                    }


                    if (Score[1] == 0)
                    {

                    }
                    else if (Score[1] == 1)
                    {
                        Aces[1] = Score[1];
                    }
                    else if (Score[1] == 2)
                    {
                        Twos[1] = Score[1];
                    }
                    else if (Score[1] == 3)
                    {
                        Thress[1] = Score[1];
                    }
                    else if (Score[1] == 4)
                    {
                        Fours[1] = Score[1];
                    }
                    else if (Score[1] == 5)
                    {
                        Fives[1] = Score[1];
                    }
                    else if (Score[1] == 6)
                    {

                    }


                    if (Score[2] == 0)
                    {

                    }
                    else if (Score[2] == 1)
                    {
                        Aces[2] = Score[2];
                    }
                    else if (Score[2] == 2)
                    {
                        Twos[2] = Score[2];
                    }
                    else if (Score[2] == 3)
                    {
                        Thress[2] = Score[2];
                    }
                    else if (Score[2] == 4)
                    {
                        Fours[2] = Score[2];
                    }
                    else if (Score[2] == 5)
                    {
                        Fives[2] = Score[2];
                    }
                    else if (Score[2] == 6)
                    {
                        Sixes[2] = Score[2];
                    }


                    if (Score[3] == 0)
                    {

                    }
                    else if (Score[3] == 1)
                    {
                        Aces[3] = Score[3];
                    }
                    else if (Score[3] == 2)
                    {
                        Twos[3] = Score[3];
                    }
                    else if (Score[3] == 3)
                    {
                        Thress[3] = Score[3];
                    }
                    else if (Score[3] == 4)
                    {
                        Fours[3] = Score[3];
                    }
                    else if (Score[3] == 5)
                    {
                        Fives[3] = Score[3];
                    }
                    else if (Score[3] == 6)
                    {
                        Sixes[3] = Score[3];
                    }


                    if (Score[4] == 0)
                    {

                    }
                    else if (Score[4] == 1)
                    {
                        Aces[4] = Score[4];
                    }
                    else if (Score[4] == 2)
                    {
                        Twos[4] = Score[4];
                    }
                    else if (Score[4] == 3)
                    {
                        Thress[4] = Score[4];
                    }
                    else if (Score[4] == 4)
                    {
                        Fours[4] = Score[4];
                    }
                    else if (Score[4] == 5)
                    {
                        Fives[4] = Score[4];
                    }
                    else if (Score[4] == 6)
                    {
                        Sixes[4] = Score[4];
                    }


                    if (Score[5] == 0)
                    {

                    }
                    else if (Score[5] == 1)
                    {
                        Aces[5] = Score[5];
                    }
                    else if (Score[5] == 2)
                    {
                        Twos[5] = Score[5];
                    }
                    else if (Score[5] == 3)
                    {
                        Thress[5] = Score[5];
                    }
                    else if (Score[5] == 4)
                    {
                        Fours[5] = Score[5];
                    }
                    else if (Score[5] == 5)
                    {
                        Fives[5] = Score[5];
                    }
                    else if (Score[5] == 6)
                    {
                        Sixes[5] = Score[5];
                    }

                    Console.Read();
                    int ACE = Aces[0] + Aces[1] + Aces[2] + Aces[3] + Aces[4] + Aces[5];
                    int TWO = Twos[0] + Twos[1] + Twos[2] + Twos[2] + Twos[4] + Twos[5];
                    int THREE = Thress[0] + Thress[1] + Thress[2] + Thress[3] + Thress[4] + Thress[5];
                    int FOUR = Fours[0] + Fours[1] + Fours[2] + Fours[3] + Fours[4] + Fours[5];
                    int FIVE = Fives[0] + Fives[1] + Fives[2] + Fives[3] + Fives[4] + Fives[5];
                    int SIX = Sixes[0] + Sixes[1] + Sixes[2] + Sixes[3] + Sixes[4] + Sixes[5];

                    Console.ReadKey();
                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        List<string> nos = new List<string>();
                        nos.Add(" _______________________________________________________");

                        nos.Add("|   UPPER SECTION    |   |GAME 1|    |GAME 2|    |GAME 3|");
                        nos.Add("|____________________|___|______|____|______|____|______|");
                        nos.Add("|____________________|___|______|____|______|____|______|");
                        nos.Add("|Aces                |   |" + ACE + "              0           0      ");
                        nos.Add("|____________________|___|_______________________________");
                        nos.Add("|Twos                |   |" + TWO + "              0           0      ");
                        nos.Add("|____________________|___|_______________________________");
                        nos.Add("|Thress              |   |" + THREE + "              0           0      ");
                        nos.Add("|____________________|___|_______________________________");
                        nos.Add("|Fours               |   |" + FOUR + "              0           0      ");
                        nos.Add("|____________________|___|_______________________________");
                        nos.Add("|Fives               |   |" + FIVE + "              0           0      ");
                        nos.Add("|____________________|___|_______________________________");
                        nos.Add("|Sixes               |   |" + SIX + "              0           0      ");
                        nos.Add("|____________________|___|_______________________________");
                        nos.Add("|____________________|___|_______________________________");
                        nos.Add("|Bonus               |   |0              0           0  ");
                        nos.Add("|____________________|___|_______________________________");
                        nos.Add("|Total Score         |   |0              0           0     ");
                        nos.Add("|____________________|___|_______________________________");

                        foreach (string i in nos)
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Game 1 has FINISHED, please input R Twice, to Start ROUND 2");
                        Console.WriteLine("__________________________________________________________");
                        Console.ReadLine();
                    }







                }

            }

        }

        public class Game2 : Game
        {
            // Game 2 Round 1
            public static void ROUND1()
            {
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                             GAME 2 ROUND 1");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |  Dice 1 =| " + g2diceRound1[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 2 =| " + g2diceRound1[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 3 =| " + g2diceRound1[2] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 4 =| " + g2diceRound1[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 5 =| " + g2diceRound1[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |  Dice 6 =| " + g2diceRound1[5] + " |        ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.ReadKey();
                }

                do
                {
                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("You have saved Dice 1");
                        Console.WriteLine("Do you want to save another dice?");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" - Or press RR to begin round 2 ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        g2diceRound2[0] = g2dice1;
                        g2Score[0] = g2dice1;
                        g2Status[0] = g2status;
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("You have saved Dice 2");
                        Console.WriteLine("Do you want to save another dice?");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" - Or press RR to begin round 2 ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        g2diceRound2[1] = g2dice2;
                        g2Score[1] = g2dice2;
                        g2Status[1] = g2status;
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D3)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("You have saved Dice 3");
                        Console.WriteLine("Do you want to save another dice?");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" - Or press RR to begin round 2 ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        g2diceRound2[2] = g2dice3;
                        g2Score[2] = g2dice3;
                        g2Status[2] = g2status;
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D4)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("You have saved Dice 4");
                        Console.WriteLine("Do you want to save another dice?");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" - Or press RR to begin round 2 ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        g2diceRound2[3] = g2dice4;
                        g2Score[3] = g2dice4;
                        g2Status[3] = g2status;
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D5)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("You have saved Dice 5");
                        Console.WriteLine("Do you want to save another dice?");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" - Or press RR to begin round 2 ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        g2diceRound2[4] = g2dice5;
                        g2Score[4] = g2dice5;
                        g2Status[4] = g2status;
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D6)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine("You have saved Dice 6");
                        Console.WriteLine("Do you want to save another dice?");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" - Or press RR to begin round 2 ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        g2diceRound2[5] = g2dice6;
                        g2Score[5] = g2dice6;
                        g2Status[5] = g2status;

                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("___________________________________________");
                        Console.WriteLine(" - Press RR to begin round 2 ");
                        Console.WriteLine("___________________________________________");
                    }

                } while (Console.ReadKey().Key != ConsoleKey.R);
            }

            // Game 2 Round 2
            public static void ROUND2()
            {
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                         GAME 2 ROUND 2");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g2Status[0] + "  Dice 1 =|" + g2diceRound2[0] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[1] + "  Dice 2 =|" + g2diceRound2[1] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[2] + "  Dice 3 =|" + g2diceRound2[2] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[3] + "  Dice 4 =|" + g2diceRound2[3] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[4] + "  Dice 5 =|" + g2diceRound2[4] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[5] + "  Dice 6 =|" + g2diceRound2[5] + "|         ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");

                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g2diceRound3[0] = g2diceRound2[0];
                            g2Score[0] = g2diceRound3[0];
                            g2Status[0] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g2diceRound3[1] = g2diceRound2[1];
                            g2Score[1] = g2diceRound3[1];
                            g2Status[1] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g2diceRound3[2] = g2diceRound2[2];
                            g2Score[2] = g2diceRound3[2];
                            g2Status[2] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g2diceRound3[3] = g2diceRound2[3];
                            g2Score[3] = g2diceRound3[3];
                            g2Status[3] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g2diceRound3[4] = g2diceRound2[4];
                            g2Score[4] = g2diceRound3[4];
                            g2Status[4] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g2diceRound3[5] = g2diceRound2[5];
                            g2Score[5] = g2diceRound3[5];
                            g2Status[5] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }
                    } while (Console.ReadKey().Key != ConsoleKey.R);
                }
            }

            // GAME 2 Round 3
            public static void ROUND3()
            {
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                         GAME 2 ROUND 3");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g2Status[0] + "  Dice 1 =|" + g2diceRound3[0] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[1] + "  Dice 2 =|" + g2diceRound3[1] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[2] + "  Dice 3 =|" + g2diceRound3[2] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[3] + "  Dice 4 =|" + g2diceRound3[3] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[4] + "  Dice 5 =|" + g2diceRound3[4] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g2Status[5] + "  Dice 6 =|" + g2diceRound3[5] + "|         ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");

                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________");
                    Console.ReadKey();

                    do
                    {

                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g2Score[0] = g2diceRound3[0];
                            g2Status[0] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g2Score[1] = g2diceRound3[1];
                            g2Status[1] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g2Score[2] = g2diceRound3[2];
                            g2Status[2] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 2 ");
                            Console.WriteLine("__________________________________________ ");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g2Score[3] = g2diceRound3[3];
                            g2Status[3] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 2 ");
                            Console.WriteLine("__________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g2Score[4] = g2diceRound3[4];
                            g2Status[4] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 2");
                            Console.WriteLine("__________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g2Score[5] = g2diceRound3[5];
                            g2Status[5] = g2status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 2  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.F);
                }
            }

            //GAME 2 Finished
            public static void GAME2_Finished()
            {
                if (Console.ReadKey().Key == ConsoleKey.F)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                     GAME 2 HAS FINISHED");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" You have saved the values of ");
                    Console.WriteLine(" ");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   | Dice 1 =|" + g2Score[0] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 2 =|" + g2Score[1] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 3 =|" + g2Score[2] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 4 =|" + g2Score[3] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 5 =|" + g2Score[4] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 6 =|" + g2Score[5] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" To view and input values into the Scoreboard,");
                    Console.WriteLine(" input S into the terminal.  ");
                    Console.WriteLine("  ");



                    if (g2Score[0] == 0)
                    {

                    }
                    else if (g2Score[0] == 1)
                    {
                        g2Aces[0] = g2Score[0];
                    }
                    else if (g2Score[0] == 2)
                    {
                        g2Twos[0] = g2Score[0];
                    }
                    else if (g2Score[0] == 3)
                    {
                        g2Thress[0] = g2Score[0];
                    }
                    else if (g2Score[0] == 4)
                    {
                        g2Fours[0] = g2Score[0];
                    }
                    else if (g2Score[0] == 5)
                    {
                        g2Fives[0] = g2Score[0];
                    }
                    else if (g2Score[0] == 6)
                    {
                        g2Sixes[0] = g2Score[0];
                    }


                    if (g2Score[1] == 0)
                    {

                    }
                    else if (g2Score[1] == 1)
                    {
                        g2Aces[1] = g2Score[1];
                    }
                    else if (g2Score[1] == 2)
                    {
                        g2Twos[1] = g2Score[1];
                    }
                    else if (g2Score[1] == 3)
                    {
                        g2Thress[1] = g2Score[1];
                    }
                    else if (g2Score[1] == 4)
                    {
                        g2Fours[1] = g2Score[1];
                    }
                    else if (g2Score[1] == 5)
                    {
                        g2Fives[1] = g2Score[1];
                    }
                    else if (g2Score[1] == 6)
                    {

                    }


                    if (g2Score[2] == 0)
                    {

                    }
                    else if (g2Score[2] == 1)
                    {
                        g2Aces[2] = g2Score[2];
                    }
                    else if (g2Score[2] == 2)
                    {
                        g2Twos[2] = g2Score[2];
                    }
                    else if (g2Score[2] == 3)
                    {
                        g2Thress[2] = g2Score[2];
                    }
                    else if (g2Score[2] == 4)
                    {
                        g2Fours[2] = g2Score[2];
                    }
                    else if (g2Score[2] == 5)
                    {
                        g2Fives[2] = g2Score[2];
                    }
                    else if (g2Score[2] == 6)
                    {
                        g2Sixes[2] = g2Score[2];
                    }


                    if (g2Score[3] == 0)
                    {

                    }
                    else if (g2Score[3] == 1)
                    {
                        g2Aces[3] = g2Score[3];
                    }
                    else if (g2Score[3] == 2)
                    {
                        g2Twos[3] = g2Score[3];
                    }
                    else if (g2Score[3] == 3)
                    {
                        g2Thress[3] = g2Score[3];
                    }
                    else if (g2Score[3] == 4)
                    {
                        g2Fours[3] = g2Score[3];
                    }
                    else if (g2Score[3] == 5)
                    {
                        g2Fives[3] = g2Score[3];
                    }
                    else if (g2Score[3] == 6)
                    {
                        g2Sixes[3] = g2Score[3];
                    }


                    if (g2Score[4] == 0)
                    {

                    }
                    else if (g2Score[4] == 1)
                    {
                        g2Aces[4] = g2Score[4];
                    }
                    else if (g2Score[4] == 2)
                    {
                        g2Twos[4] = g2Score[4];
                    }
                    else if (g2Score[4] == 3)
                    {
                        g2Thress[4] = g2Score[4];
                    }
                    else if (g2Score[4] == 4)
                    {
                        g2Fours[4] = g2Score[4];
                    }
                    else if (g2Score[4] == 5)
                    {
                        g2Fives[4] = g2Score[4];
                    }
                    else if (g2Score[4] == 6)
                    {
                        g2Sixes[4] = g2Score[4];
                    }


                    if (g2Score[5] == 0)
                    {

                    }
                    else if (g2Score[5] == 1)
                    {
                        g2Aces[5] = g2Score[5];
                    }
                    else if (g2Score[5] == 2)
                    {
                        g2Twos[5] = g2Score[5];
                    }
                    else if (g2Score[5] == 3)
                    {
                        g2Thress[5] = g2Score[5];
                    }
                    else if (g2Score[5] == 4)
                    {
                        g2Fours[5] = g2Score[5];
                    }
                    else if (g2Score[5] == 5)
                    {
                        g2Fives[5] = g2Score[5];
                    }
                    else if (g2Score[5] == 6)
                    {
                        g2Sixes[5] = g2Score[5];
                    }



                    int ACE = Aces[0] + Aces[1] + Aces[2] + Aces[3] + Aces[4] + Aces[5];
                    int TWO = Twos[0] + Twos[1] + Twos[2] + Twos[2] + Twos[4] + Twos[5];
                    int THREE = Thress[0] + Thress[1] + Thress[2] + Thress[3] + Thress[4] + Thress[5];
                    int FOUR = Fours[0] + Fours[1] + Fours[2] + Fours[3] + Fours[4] + Fours[5];
                    int FIVE = Fives[0] + Fives[1] + Fives[2] + Fives[3] + Fives[4] + Fives[5];
                    int SIX = Sixes[0] + Sixes[1] + Sixes[2] + Sixes[3] + Sixes[4] + Sixes[5];
                    int g2ACE = g2Aces[0] + g2Aces[1] + g2Aces[2] + g2Aces[3] + g2Aces[4] + g2Aces[5];
                    int g2TWO = g2Twos[0] + g2Twos[1] + g2Twos[2] + g2Twos[2] + g2Twos[4] + g2Twos[5];
                    int g2THREE = g2Thress[0] + g2Thress[1] + g2Thress[2] + g2Thress[3] + g2Thress[4] + g2Thress[5];
                    int g2FOUR = g2Fours[0] + g2Fours[1] + g2Fours[2] + g2Fours[3] + g2Fours[4] + g2Fours[5];
                    int g2FIVE = g2Fives[0] + g2Fives[1] + g2Fives[2] + g2Fives[3] + g2Fives[4] + g2Fives[5];
                    int g2SIX = g2Sixes[0] + g2Sixes[1] + g2Sixes[2] + g2Sixes[3] + g2Sixes[4] + g2Sixes[5];



                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        List<string> g2nos = new List<string>();
                        g2nos.Add(" ");
                        g2nos.Add(" _______________________________________________________");
                        g2nos.Add("|   UPPER SECTION    |   |   GAME 1|    GAME 2|    GAME 3|");
                        g2nos.Add("|____________________|___|_________|__________|__________|");
                        g2nos.Add("|____________________|___|_______________________________");
                        g2nos.Add("|Aces                |   |  " + ACE + "         " + g2ACE + "         0          ");
                        g2nos.Add("|____________________|___|_______________________________");
                        g2nos.Add("|Twos                |   |  " + TWO + "         " + g2TWO + "         0          ");
                        g2nos.Add("|____________________|___|_______________________________");
                        g2nos.Add("|Thress              |   |  " + THREE + "         " + g2THREE + "         0          ");
                        g2nos.Add("|____________________|___|_______________________________");
                        g2nos.Add("|Fours               |   |  " + FOUR + "         " + g2FOUR + "         0          ");
                        g2nos.Add("|____________________|___|_______________________________");
                        g2nos.Add("|Fives               |   |  " + FIVE + "         " + g2FIVE + "         0          ");
                        g2nos.Add("|____________________|___|_______________________________");
                        g2nos.Add("|Sixes               |   |  " + SIX + "         " + g2SIX + "         0          ");
                        g2nos.Add("|____________________|___|_______________________________");
                        g2nos.Add("|Bonus               |   |                               ");
                        g2nos.Add("|____________________|___|_______________________________");
                        g2nos.Add("|Total Score         |   |                               ");
                        g2nos.Add("|____________________|___|_______________________________");

                        foreach (string i in g2nos)
                        {
                            Console.WriteLine(i);
                        }

                    }
                    Console.WriteLine("");
                    Console.WriteLine("GAME 2 has FINISHED, please input R to Start GAME 3");
                    Console.WriteLine("__________________________________________________________");
                    Console.WriteLine("");


                }

            }
        }

        public class Game3 : Game
        {
            // Game 3 Round 1
            public static void ROUND1()
            {

                try
                {
                    if (Console.ReadKey().Key == ConsoleKey.R)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(" ________________________________________________________________ ");
                        Console.WriteLine("                         GAME 3 ROUND 1");
                        Console.WriteLine("                    _______________________");
                        Console.WriteLine("                   |  Dice 1 =| " + g3diceRound1[0] + " |        ");
                        Console.WriteLine("                   |_______________________");
                        Console.WriteLine("                   |  Dice 2 =| " + g3diceRound1[1] + " |        ");
                        Console.WriteLine("                   |_______________________");
                        Console.WriteLine("                   |  Dice 3 =| " + g3diceRound1[2] + " |        ");
                        Console.WriteLine("                   |_______________________");
                        Console.WriteLine("                   |  Dice 4 =| " + g3diceRound1[3] + " |        ");
                        Console.WriteLine("                   |_______________________");
                        Console.WriteLine("                   |  Dice 5 =| " + g3diceRound1[4] + " |        ");
                        Console.WriteLine("                   |_______________________");
                        Console.WriteLine("                   |  Dice 6 =| " + g3diceRound1[5] + " |        ");
                        Console.WriteLine("                   |_______________________");

                        Console.WriteLine(" ");
                        Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                        Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                        Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                        Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                        Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                        Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                        Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                        Console.WriteLine(" ");
                        Console.WriteLine("  - You can hold multiple dices,");
                        Console.WriteLine("    but only one dice at the time. ");
                        Console.WriteLine(" ");
                        Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                        Console.WriteLine("    otherwise they will reroll. ");
                        Console.WriteLine(" ");
                        Console.ReadKey();

                        do
                        {
                            if (Console.ReadKey().Key == ConsoleKey.D1)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine("You have saved Dice 1");
                                Console.WriteLine("Do you want to save another dice?");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" - Or press RRR to begin round 2 ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                g3diceRound2[0] = g3dice1;
                                g3Score[0] = g3dice1;
                                g3Status[0] = g3status;
                            }
                            else if (Console.ReadKey().Key == ConsoleKey.D2)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine("You have saved Dice 2");
                                Console.WriteLine("Do you want to save another dice?");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" - Or press RRR to begin round 2 ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                g3diceRound2[1] = g3dice2;
                                g3Score[1] = g3dice2;
                                g3Status[1] = g3status;
                            }
                            else if (Console.ReadKey().Key == ConsoleKey.D3)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine("You have saved Dice 3");
                                Console.WriteLine("Do you want to save another dice?");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" - Or press RRR to begin round 2 ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                g3diceRound2[2] = g3dice3;
                                g3Score[2] = g3dice3;
                                g3Status[2] = g3status;
                            }
                            else if (Console.ReadKey().Key == ConsoleKey.D4)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine("You have saved Dice 4");
                                Console.WriteLine("Do you want to save another dice?");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" - Or press RRR to begin round 2 ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                g3diceRound2[3] = g3dice4;
                                g3Score[3] = g3dice4;
                                g3Status[3] = g3status;
                            }
                            else if (Console.ReadKey().Key == ConsoleKey.D5)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine("You have saved Dice 5");
                                Console.WriteLine("Do you want to save another dice?");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" - Or press RRR to begin round 2 ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                g3diceRound2[4] = g3dice5;
                                g3Score[4] = g3dice5;
                                g3Status[4] = g3status;
                            }
                            else if (Console.ReadKey().Key == ConsoleKey.D6)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine("You have saved Dice 6");
                                Console.WriteLine("Do you want to save another dice?");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" - Or press RRR to begin round 2 ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                                g3diceRound2[5] = g3dice6;
                                g3Score[5] = g3dice6;
                                g3Status[5] = g3status;

                            }
                            else if (Console.ReadKey().Key == ConsoleKey.D0)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" - Press RRR to begin round 2 ");
                                Console.WriteLine("___________________________________________");
                                Console.WriteLine(" ");
                                Console.WriteLine(" ");
                            }

                        } while (Console.ReadKey().Key != ConsoleKey.R);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.GetType() + " : " + ex.Message);
                } while (Console.ReadKey().Key != ConsoleKey.R) ;

            }

            // Game 3 Round 2
            public static void ROUND2()
            {
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                          GAME 3 ROUND 2");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g3Status[0] + "  Dice 1 =|" + g3diceRound2[0] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[1] + "  Dice 2 =|" + g3diceRound2[1] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[2] + "  Dice 3 =|" + g3diceRound2[2] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[3] + "  Dice 4 =|" + g3diceRound2[3] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[4] + "  Dice 5 =|" + g3diceRound2[4] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[5] + "  Dice 6 =|" + g3diceRound2[5] + "|         ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");

                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g3diceRound3[0] = g3diceRound2[0];
                            g3Score[0] = g3diceRound3[0];
                            g3Status[0] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g3diceRound3[1] = g3diceRound2[1];
                            g3Score[1] = g3diceRound3[1];
                            g3Status[1] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g3diceRound3[2] = g3diceRound2[2];
                            g3Score[2] = g3diceRound3[2];
                            g3Status[2] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g3diceRound3[3] = g3diceRound2[3];
                            g3Score[3] = g3diceRound3[3];
                            g3Status[3] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g3diceRound3[4] = g3diceRound2[4];
                            g3Score[4] = g3diceRound3[4];
                            g3Status[4] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g3diceRound3[5] = g3diceRound2[5];
                            g3Score[5] = g3diceRound3[5];
                            g3Status[5] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.R);
                }
            }

            // Game 3 Round 3
            public static void ROUND3()
            {
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                          GAME 3 ROUND 3");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g3Status[0] + "  Dice 1 =|" + g3diceRound3[0] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[1] + "  Dice 2 =|" + g3diceRound3[1] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[2] + "  Dice 3 =|" + g3diceRound3[2] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[3] + "  Dice 4 =|" + g3diceRound3[3] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[4] + "  Dice 5 =|" + g3diceRound3[4] + "|         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g3Status[5] + "  Dice 6 =|" + g3diceRound3[5] + "|         ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");

                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________");
                    Console.ReadKey();

                    do
                    {

                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g3Score[0] = g3diceRound3[0];
                            g3Status[0] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g3Score[1] = g3diceRound3[1];
                            g3Status[1] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g3Score[2] = g3diceRound3[2];
                            g3Status[2] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g3Score[3] = g3diceRound3[3];
                            g3Status[3] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g3Score[4] = g3diceRound3[4];
                            g3Status[4] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 3");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g3Score[5] = g3diceRound3[5];
                            g3Status[5] = g3status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 3  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.F);
                }
            }

            //GAME 3 Finished
            public static void GAME3_Finished()
            {
                if (Console.ReadKey().Key == ConsoleKey.F)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                     GAME 3 HAS FINISHED");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" You have saved the values of ");
                    Console.WriteLine(" ");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   | Dice 1 =|" + g3Score[0] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 2 =|" + g3Score[1] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 3 =|" + g3Score[2] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 4 =|" + g3Score[3] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 5 =|" + g3Score[4] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   | Dice 6 =|" + g3Score[5] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" To view and input values into the Scoreboard,");
                    Console.WriteLine(" input S into the terminal.  ");
                    Console.WriteLine("  ");



                    if (g3Score[0] == 0)
                    {

                    }
                    else if (g3Score[0] == 1)
                    {
                        g3Aces[0] = g3Score[0];
                    }
                    else if (g3Score[0] == 2)
                    {
                        g3Twos[0] = g3Score[0];
                    }
                    else if (g3Score[0] == 3)
                    {
                        g3Thress[0] = g3Score[0];
                    }
                    else if (g3Score[0] == 4)
                    {
                        g3Fours[0] = g3Score[0];
                    }
                    else if (g3Score[0] == 5)
                    {
                        g3Fives[0] = g3Score[0];
                    }
                    else if (g3Score[0] == 6)
                    {
                        g3Sixes[0] = g3Score[0];
                    }


                    if (g3Score[1] == 0)
                    {

                    }
                    else if (g3Score[1] == 1)
                    {
                        g3Aces[1] = g3Score[1];
                    }
                    else if (g3Score[1] == 2)
                    {
                        g3Twos[1] = g3Score[1];
                    }
                    else if (g3Score[1] == 3)
                    {
                        g3Thress[1] = g3Score[1];
                    }
                    else if (g3Score[1] == 4)
                    {
                        g3Fours[1] = g3Score[1];
                    }
                    else if (g3Score[1] == 5)
                    {
                        g3Fives[1] = g3Score[1];
                    }
                    else if (g3Score[1] == 6)
                    {

                    }


                    if (g3Score[2] == 0)
                    {

                    }
                    else if (g3Score[2] == 1)
                    {
                        g3Aces[2] = g3Score[2];
                    }
                    else if (g3Score[2] == 2)
                    {
                        g3Twos[2] = g3Score[2];
                    }
                    else if (g3Score[2] == 3)
                    {
                        g3Thress[2] = g3Score[2];
                    }
                    else if (g3Score[2] == 4)
                    {
                        g3Fours[2] = g3Score[2];
                    }
                    else if (g3Score[2] == 5)
                    {
                        g3Fives[2] = g3Score[2];
                    }
                    else if (g3Score[2] == 6)
                    {
                        g3Sixes[2] = g3Score[2];
                    }


                    if (g3Score[3] == 0)
                    {

                    }
                    else if (g3Score[3] == 1)
                    {
                        g3Aces[3] = g3Score[3];
                    }
                    else if (g3Score[3] == 2)
                    {
                        g3Twos[3] = g3Score[3];
                    }
                    else if (g3Score[3] == 3)
                    {
                        g3Thress[3] = g3Score[3];
                    }
                    else if (g3Score[3] == 4)
                    {
                        g3Fours[3] = g3Score[3];
                    }
                    else if (g3Score[3] == 5)
                    {
                        g3Fives[3] = g3Score[3];
                    }
                    else if (g3Score[3] == 6)
                    {
                        g3Sixes[3] = g3Score[3];
                    }


                    if (g3Score[4] == 0)
                    {

                    }
                    else if (g3Score[4] == 1)
                    {
                        g3Aces[4] = g3Score[4];
                    }
                    else if (g3Score[4] == 2)
                    {
                        g3Twos[4] = g3Score[4];
                    }
                    else if (g3Score[4] == 3)
                    {
                        g3Thress[4] = g3Score[4];
                    }
                    else if (g3Score[4] == 4)
                    {
                        g3Fours[4] = g3Score[4];
                    }
                    else if (g3Score[4] == 5)
                    {
                        g3Fives[4] = g3Score[4];
                    }
                    else if (g3Score[4] == 6)
                    {
                        g3Sixes[4] = g3Score[4];
                    }


                    if (g3Score[5] == 0)
                    {

                    }
                    else if (g3Score[5] == 1)
                    {
                        g3Aces[5] = g3Score[5];
                    }
                    else if (g3Score[5] == 2)
                    {
                        g3Twos[5] = g3Score[5];
                    }
                    else if (g3Score[5] == 3)
                    {
                        g3Thress[5] = g3Score[5];
                    }
                    else if (g3Score[5] == 4)
                    {
                        g3Fours[5] = g3Score[5];
                    }
                    else if (g3Score[5] == 5)
                    {
                        g3Fives[5] = g3Score[5];
                    }
                    else if (g3Score[5] == 6)
                    {
                        g3Sixes[5] = g3Score[5];
                    }






                    int ACE = Aces[0] + Aces[1] + Aces[2] + Aces[3] + Aces[4] + Aces[5];
                    int TWO = Twos[0] + Twos[1] + Twos[2] + Twos[2] + Twos[4] + Twos[5];
                    int THREE = Thress[0] + Thress[1] + Thress[2] + Thress[3] + Thress[4] + Thress[5];
                    int FOUR = Fours[0] + Fours[1] + Fours[2] + Fours[3] + Fours[4] + Fours[5];
                    int FIVE = Fives[0] + Fives[1] + Fives[2] + Fives[3] + Fives[4] + Fives[5];
                    int SIX = Sixes[0] + Sixes[1] + Sixes[2] + Sixes[3] + Sixes[4] + Sixes[5];
                    int g2ACE = g2Aces[0] + g2Aces[1] + g2Aces[2] + g2Aces[3] + g2Aces[4] + g2Aces[5];
                    int g2TWO = g2Twos[0] + g2Twos[1] + g2Twos[2] + g2Twos[2] + g2Twos[4] + g2Twos[5];
                    int g2THREE = g2Thress[0] + g2Thress[1] + g2Thress[2] + g2Thress[3] + g2Thress[4] + g2Thress[5];
                    int g2FOUR = g2Fours[0] + g2Fours[1] + g2Fours[2] + g2Fours[3] + g2Fours[4] + g2Fours[5];
                    int g2FIVE = g2Fives[0] + g2Fives[1] + g2Fives[2] + g2Fives[3] + g2Fives[4] + g2Fives[5];
                    int g2SIX = g2Sixes[0] + g2Sixes[1] + g2Sixes[2] + g2Sixes[3] + g2Sixes[4] + g2Sixes[5];
                    int g3ACE = g3Aces[0] + g3Aces[1] + g3Aces[2] + g3Aces[3] + g3Aces[4] + g3Aces[5];
                    int g3TWO = g3Twos[0] + g3Twos[1] + g3Twos[2] + g3Twos[2] + g3Twos[4] + g3Twos[5];
                    int g3THREE = g3Thress[0] + g3Thress[1] + g3Thress[2] + g3Thress[3] + g3Thress[4] + g3Thress[5];
                    int g3FOUR = g3Fours[0] + g3Fours[1] + g3Fours[2] + g3Fours[3] + g3Fours[4] + g3Fours[5];
                    int g3FIVE = g3Fives[0] + g3Fives[1] + g3Fives[2] + g3Fives[3] + g3Fives[4] + g3Fives[5];
                    int g3SIX = g3Sixes[0] + g3Sixes[1] + g3Sixes[2] + g3Sixes[3] + g3Sixes[4] + g3Sixes[5];



                    int TotalUpper = ACE + g2ACE + g3ACE + TWO + g2TWO + g3TWO + THREE + g2THREE + g3THREE + FOUR + g2FOUR + g3FOUR + FIVE + g2FIVE + g3FIVE + SIX + g2SIX + g3SIX;
                    int BonusUpper = 0;




                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        if (1 == 1)
                        {
                            switch (BonusUpper)
                            {
                                case 1:
                                    if (TotalUpper <= 64)
                                    {
                                        Console.WriteLine(BonusUpper == 0);
                                    };
                                    break;

                                case 2:
                                    if (TotalUpper >= 65)
                                    {
                                        Console.WriteLine(BonusUpper == 50);
                                    };
                                    break;
                            }





                            Console.ReadLine();

                            List<string> g3nos = new List<string>();
                            g3nos.Add(" ");
                            g3nos.Add(" _______________________________________________________");
                            g3nos.Add("|   UPPER SECTION    |   |   GAME 1|    GAME 2|    GAME 3|");
                            g3nos.Add("|____________________|___|_________|__________|__________|");
                            g3nos.Add("|____________________|___|_______________________________|");
                            g3nos.Add("|Aces                |   |" + ACE + "         " + g2ACE + "          " + g3ACE + "            ");
                            g3nos.Add("|____________________|___|_______________________________");
                            g3nos.Add("|Twos                |   |" + TWO + "         " + g2TWO + "          " + g3TWO + "            ");
                            g3nos.Add("|____________________|___|_______________________________");
                            g3nos.Add("|Thress              |   |" + THREE + "         " + g2THREE + "          " + g3THREE + "          ");
                            g3nos.Add("|____________________|___|_______________________________");
                            g3nos.Add("|Fours               |   |" + FOUR + "         " + g2FOUR + "          " + g3FOUR + "           ");
                            g3nos.Add("|____________________|___|_______________________________");
                            g3nos.Add("|Fives               |   |" + FIVE + "         " + g2FIVE + "          " + g3FIVE + "           ");
                            g3nos.Add("|____________________|___|_______________________________");
                            g3nos.Add("|Sixes               |   |" + SIX + "         " + g2SIX + "          " + g3SIX + "            ");
                            g3nos.Add("|____________________|___|_______________________________");
                            g3nos.Add("|Bonus               |   |              " + BonusUpper + "           ");
                            g3nos.Add("|____________________|___|_______________________________");
                            g3nos.Add("|Total Score         |   |            " + TotalUpper + " + " + BonusUpper + "                    ");
                            g3nos.Add("|____________________|___|_______________________________");



                            foreach (string i in g3nos)
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("GAME 3 has FINISHED, please input LL to Start playing the LOWER SECTION");
                    Console.WriteLine("______________________________________________________________________________");

                }
            }

        }

        public class Game4 : Game
        {
            // Game 4 Round 1
            public static void ROUND1()
            {
                if (Console.ReadKey().Key == ConsoleKey.R)
                {


                    // Game 4 Round 1
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                         GAME 4 ROUND 1");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g4Status[0] + "  Dice 1 =| " + g4diceRound1[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[1] + "  Dice 2 =| " + g4diceRound1[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[2] + "  Dice 3 =| " + g4diceRound1[2] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[3] + "  Dice 4 =| " + g4diceRound1[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[4] + "  Dice 5 =| " + g4diceRound1[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[5] + "  Dice 6 =| " + g4diceRound1[5] + " |        ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g4diceRound2[0] = g4dice1;
                            g4Score[0] = g4dice1;
                            g4Status[0] = g4status;


                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g4diceRound2[1] = g4dice2;
                            g4Score[1] = g4dice2;
                            g4Status[1] = g4status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g4diceRound2[2] = g4dice3;
                            g4Score[2] = g4dice3;
                            g4Status[2] = g4status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g4diceRound2[3] = g4dice4;
                            g4Score[4] = g4dice4;
                            g4Status[4] = g4status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g4diceRound2[4] = g4dice5;
                            g4Score[4] = g4dice5;
                            g4Status[4] = g4status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g4diceRound2[5] = g4dice6;
                            g4Score[5] = g4dice6;
                            g4Status[5] = g4status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press RR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.R);
                }
            }

            // Game 4 Round 2
            public static void ROUND2()
            {
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                          GAME 4 ROUND 2");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g4Status[0] + "  Dice 1 =| " + g4diceRound2[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[1] + "  Dice 2 =| " + g4diceRound2[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[2] + "  Dice 3 =| " + g4diceRound2[2] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[3] + "  Dice 4 =| " + g4diceRound2[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[4] + "  Dice 5 =| " + g4diceRound2[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[5] + "  Dice 6 =| " + g4diceRound2[5] + " |        ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g4diceRound3[0] = g4diceRound2[0];
                            g4Score[0] = g4diceRound2[0];
                            g4Status[0] = g4status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4diceRound3[1] = g4diceRound2[1];
                            g4Score[1] = g4diceRound2[1];
                            g4Status[1] = g4status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4diceRound3[2] = g4diceRound2[2];
                            g4Score[2] = g4diceRound2[2];
                            g4Status[2] = g4status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4diceRound3[3] = g4diceRound2[3];
                            g4Score[3] = g4diceRound2[3];
                            g4Status[3] = g4status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4diceRound3[4] = g4diceRound2[4];
                            g4Score[4] = g4diceRound2[4];
                            g4Status[4] = g4status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Or press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4diceRound3[5] = g4diceRound2[5];
                            g4Score[5] = g4diceRound2[5];
                            g4Status[5] = g4status;


                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press RR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.R);
                }
            }

            // Game 4 Round 3
            public static void ROUND3()
            {
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                         GAME 4 ROUND 3");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g4Status[0] + "  Dice 1 =| " + g4diceRound3[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[1] + "  Dice 2 =| " + g4diceRound3[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[2] + "  Dice 3 =| " + g4diceRound3[2] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[3] + "  Dice 4 =| " + g4diceRound3[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[4] + "  Dice 5 =| " + g4diceRound3[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g4Status[5] + "  Dice 6 =| " + g4diceRound3[5] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can play the CHANCE by HOLDING ALL DICES, AND PRESS C multiply times into the terminal");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 4  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g4Score[0] = g4diceRound3[0];
                            g4Status[0] = g4status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine(" - Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 4  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4Score[1] = g4diceRound3[1];
                            g4Status[1] = g4status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("_________________3__________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 4  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4Score[2] = g4diceRound3[2];
                            g4Status[2] = g4status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 4  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4Score[3] = g4diceRound3[3];
                            g4Status[3] = g4status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 4  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4Score[4] = g4diceRound3[4];
                            g4Status[4] = g4status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 4  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g4Score[5] = g4diceRound3[5];
                            g4Status[5] = g4status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" - Press FF to finish Game 4  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.C)
                        {
                            Console.WriteLine(" You have played the CHANCE  ");
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");

                            if (g4Status[0] == g4status && g4Status[1] == g4status && g4Status[2] == g4status && g4Status[3] == g4status && g4Status[4] == g4status && g4Status[5] == g4status)
                            {
                           
                                List<string> nos1 = new List<string>();
                                nos1.Add(" _______________________________________________________");
                                nos1.Add("|   Lower SECTION    |   |GAME 4|    |GAME 5|    |GAME 6|");
                                nos1.Add("|____________________|___|______|____|______|____|______|");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|3 of a kind         |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|4 of a kind         |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Full House          |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Small Straight      |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Big Straight        |0               0           0     ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|YAHTZEE             |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Chance              |" + g4CHANCE + "            0           0     ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|YAHTZEE Bonus       |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Total Upper SECTION |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Total Lower SECTION |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|       TOTAL        |                0                  ");
                                nos1.Add("|____________________|__________________________________");


                                foreach (string i in nos1)
                                {
                                    Console.WriteLine(i);
                                }
                                Console.WriteLine("");
                                Console.WriteLine("GAME 4 has FINISHED, please input RR to Start GAME 5");
                                Console.WriteLine("__________________________________________________________");
                                Console.ReadKey();
                            }

                        }
                    }
                    while (Console.ReadKey().Key != ConsoleKey.F);

                }

            }

            // GAME 4 Finished
            public static void GAME4_Finished()
            {
                //??


                if (Console.ReadKey().Key == ConsoleKey.F)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                     GAME 4 HAS FINISHED");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" You have saved the values of ");
                    Console.WriteLine(" ");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g4Status[0] + "  Dice 1 =|" + g4Score[0] + " |         ");
                    Console.WriteLine("                   |________________________");
                    Console.WriteLine("                   |" + g4Status[1] + "  Dice 2 =|" + g4Score[1] + " |         ");
                    Console.WriteLine("                   |________________________");
                    Console.WriteLine("                   |" + g4Status[2] + "  Dice 3 =|" + g4Score[2] + " |         ");
                    Console.WriteLine("                   |________________________");
                    Console.WriteLine("                   |" + g4Status[3] + "  Dice 4 =|" + g4Score[3] + " |         ");
                    Console.WriteLine("                   |________________________");
                    Console.WriteLine("                   |" + g4Status[4] + "  Dice 5 =|" + g4Score[4] + " |         ");
                    Console.WriteLine("                   |________________________");
                    Console.WriteLine("                   |" + g4Status[5] + "  Dice 6 =|" + g4Score[5] + " |         ");
                    Console.WriteLine("                   |________________________");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" input 3 multiply times, to ACTIVATE 3ofKind  ");
                    Console.WriteLine(" input 4 multiply times, to ACTIVATE 4ofKind  ");
                    Console.WriteLine(" input 5 multiply times, to ACTIVATE Full House  ");
                    Console.WriteLine(" input 6 multiply times, to ACTIVATE Small Straight  ");
                    Console.WriteLine(" input 7 multiply times, to ACTIVATE Big Straight ");
                    Console.WriteLine(" input 8 multiply times, to move on ");
                    Console.WriteLine("  ");
                    int[] g4CHANCE = { g4Score[0] + g4Score[1] + g4Score[2] + g4Score[3] + g4Score[4] + g4Score[5] };
                    int ACT4 = 0;

                    Console.ReadKey();

                    //3 OF KIND
                    if (Console.ReadKey().Key == ConsoleKey.D3)
                    {
                        Console.WriteLine("  ");
                        ACT4 = 1;
                        g44ofkind[0] = 0;
                        g4FHouse[0] = 0;
                        g4SmallS[0] = 0;
                        g4BigS[0] = 0;
                        //3ofkind

                        //3ofKind
                        if (ACT4 == 0)
                        {
                            g43ofkind[0] = 0;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status || g4Score[1] == 1 && g4Status[1] == g4status && g4Score[2] == 1 && g4Status[2] == g4status || g4Score[3] == 1 && g4Status[3] == g4status && g4Score[4] == 1 && g4Status[4] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 3;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status || g4Score[2] == 1 && g4Status[2] == g4status && g4Score[1] == 1 && g4Status[1] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 3; ;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status || g4Score[3] == 1 && g4Status[3] == g4status && g4Score[1] == 1 && g4Status[1] == g4status || g4Score[2] == 1 && g4Status[2] == g4status && g4Score[4] == 1 && g4Status[4] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 3;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && g4Score[1] == 1 && g4Status[1] == g4status || g4Score[2] == 1 && g4Status[2] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 3;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && g4Score[1] == 1 && g4Status[1] == g4status || g4Score[3] == 1 && g4Status[3] == g4status && g4Score[2] == 1 && g4Status[2] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 3;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status || g4Score[1] == 2 && g4Status[1] == g4status && g4Score[2] == 2 && g4Status[2] == g4status || g4Score[3] == 2 && g4Status[3] == g4status && g4Score[4] == 2 && g4Status[4] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 6;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status || g4Score[2] == 2 && g4Status[2] == g4status && g4Score[1] == 2 && g4Status[1] == g4status || g4Score[4] == 2 && g4Status[4] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 6; ;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status || g4Score[3] == 2 && g4Status[3] == g4status && g4Score[1] == 2 && g4Status[1] == g4status || g4Score[2] == 2 && g4Status[2] == g4status && g4Score[4] == 2 && g4Status[4] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 6;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status || g4Score[4] == 2 && g4Status[4] == g4status && g4Score[1] == 2 && g4Status[1] == g4status || g4Score[2] == 2 && g4Status[2] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 6;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[1] == 2 && g4Status[1] == g4status || g4Score[3] == 2 && g4Status[3] == g4status && g4Score[2] == 2 && g4Status[2] == g4status || g4Score[4] == 2 && g4Status[4] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 6;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status || g4Score[1] == 3 && g4Status[1] == g4status && g4Score[2] == 3 && g4Status[2] == g4status || g4Score[3] == 3 && g4Status[3] == g4status && g4Score[4] == 3 && g4Status[4] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 9;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status || g4Score[2] == 3 && g4Status[2] == g4status && g4Score[1] == 3 && g4Status[1] == g4status || g4Score[4] == 3 && g4Status[4] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 9;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status || g4Score[3] == 3 && g4Status[3] == g4status && g4Score[1] == 3 && g4Status[1] == g4status || g4Score[2] == 3 && g4Status[2] == g4status && g4Score[4] == 3 && g4Status[4] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 9;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status || g4Score[4] == 3 && g4Status[4] == g4status && g4Score[1] == 3 && g4Status[1] == g4status || g4Score[2] == 3 && g4Status[2] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 9;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[1] == 3 && g4Status[1] == g4status || g4Score[3] == 3 && g4Status[3] == g4status && g4Score[2] == 3 && g4Status[2] == g4status || g4Score[4] == 3 && g4Status[4] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 9;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status || g4Score[1] == 4 && g4Status[1] == g4status && g4Score[2] == 4 && g4Status[2] == g4status || g4Score[3] == 4 && g4Status[3] == g4status && g4Score[4] == 4 && g4Status[4] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 12;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status || g4Score[2] == 4 && g4Status[2] == g4status && g4Score[1] == 4 && g4Status[1] == g4status || g4Score[4] == 4 && g4Status[4] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 12;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status || g4Score[3] == 4 && g4Status[3] == g4status && g4Score[1] == 4 && g4Status[1] == g4status || g4Score[2] == 4 && g4Status[2] == g4status && g4Score[4] == 4 && g4Status[4] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 12;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status || g4Score[4] == 4 && g4Status[4] == g4status && g4Score[1] == 4 && g4Status[1] == g4status || g4Score[2] == 4 && g4Status[2] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 12;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[1] == 4 && g4Status[1] == g4status || g4Score[3] == 4 && g4Status[3] == g4status && g4Score[2] == 4 && g4Status[2] == g4status || g4Score[4] == 4 && g4Status[4] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 12;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status || g4Score[1] == 5 && g4Status[1] == g4status && g4Score[2] == 5 && g4Status[2] == g4status || g4Score[3] == 5 && g4Status[3] == g4status && g4Score[4] == 5 && g4Status[4] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 15;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status || g4Score[2] == 5 && g4Status[2] == g4status && g4Score[1] == 5 && g4Status[1] == g4status || g4Score[4] == 5 && g4Status[4] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 15;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status || g4Score[3] == 5 && g4Status[3] == g4status && g4Score[1] == 5 && g4Status[1] == g4status || g4Score[2] == 5 && g4Status[2] == g4status && g4Score[4] == 5 && g4Status[4] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 15;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status || g4Score[4] == 5 && g4Status[4] == g4status && g4Score[1] == 5 && g4Status[1] == g4status || g4Score[2] == 5 && g4Status[2] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 15;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[1] == 5 && g4Status[1] == g4status || g4Score[3] == 5 && g4Status[3] == g4status && g4Score[2] == 5 && g4Status[2] == g4status || g4Score[4] == 5 && g4Status[4] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 15;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status || g4Score[1] == 6 && g4Status[1] == g4status && g4Score[2] == 6 && g4Status[2] == g4status || g4Score[3] == 6 && g4Status[3] == g4status && g4Score[4] == 6 && g4Status[4] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 18;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status || g4Score[2] == 6 && g4Status[2] == g4status && g4Score[1] == 6 && g4Status[1] == g4status || g4Score[4] == 6 && g4Status[4] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 18;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status || g4Score[3] == 6 && g4Status[3] == g4status && g4Score[1] == 6 && g4Status[1] == g4status || g4Score[2] == 6 && g4Status[2] == g4status && g4Score[4] == 6 && g4Status[4] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 18;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status || g4Score[4] == 6 && g4Status[4] == g4status && g4Score[1] == 6 && g4Status[1] == g4status || g4Score[2] == 6 && g4Status[2] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 18;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[1] == 6 && g4Status[1] == g4status || g4Score[3] == 6 && g4Status[3] == g4status && g4Score[2] == 6 && g4Status[2] == g4status || g4Score[4] == 6 && g4Status[4] == g4status && ACT4 == 1)
                        {
                            g43ofkind[0] = 18;
                        }

                    }

                    // 4 OF KIND
                    else if (Console.ReadKey().Key == ConsoleKey.D4)
                    {
                        Console.WriteLine("  ");
                        ACT4 = 2;
                        g43ofkind[0] = 0;
                        g4FHouse[0] = 0;
                        g4SmallS[0] = 0;
                        g4BigS[0] = 0;
                        //4ofkind



                        //4ofKind
                        if (ACT4 == 0)


                        {
                            g44ofkind[0] = 0;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && g4Score[1] == 1 && g4Status[1] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && g4Score[2] == 1 && g4Status[2] == g4status && g4Score[3] == 1 && g4Status[3] == g4status && ACT4 == 2)
                        {
                            g44ofkind[0] = 4;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[1] == 2 && g4Status[1] == g4status || g4Score[4] == 2 && g4Status[4] == g4status && g4Score[2] == 2 && g4Status[2] == g4status && g4Score[3] == 2 && g4Status[3] == g4status && ACT4 == 2)
                        {
                            g44ofkind[0] = 8;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[1] == 3 && g4Status[1] == g4status || g4Score[4] == 3 && g4Status[4] == g4status && g4Score[2] == 3 && g4Status[2] == g4status && g4Score[3] == 3 && g4Status[3] == g4status && ACT4 == 2)
                        {
                            g44ofkind[0] = 12;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[1] == 4 && g4Status[1] == g4status || g4Score[4] == 4 && g4Status[4] == g4status && g4Score[2] == 4 && g4Status[2] == g4status && g4Score[3] == 4 && g4Status[3] == g4status && ACT4 == 2)
                        {
                            g44ofkind[0] = 16;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[1] == 5 && g4Status[1] == g4status || g4Score[4] == 5 && g4Status[4] == g4status && g4Score[2] == 5 && g4Status[2] == g4status && g4Score[3] == 5 && g4Status[3] == g4status && ACT4 == 2)
                        {
                            g44ofkind[0] = 20;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[1] == 6 && g4Status[1] == g4status || g4Score[4] == 6 && g4Status[4] == g4status && g4Score[2] == 6 && g4Status[2] == g4status && g4Score[3] == 6 && g4Status[3] == g4status && ACT4 == 2)
                        {
                            g44ofkind[0] = 24;
                        }

                    }

                    //FULL HOUSE
                    else if (Console.ReadKey().Key == ConsoleKey.D5)
                    {
                        Console.WriteLine("  ");
                        ACT4 = 3;
                        g44ofkind[0] = 0;
                        g43ofkind[0] = 0;
                        g4SmallS[0] = 0;
                        g4BigS[0] = 0;
                        //full house
                        //Full House
                        if (ACT4 == 0)
                        {
                            g4FHouse[0] = 0;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status && g4Score[1] == 1 && g4Status[1] == g4status && g4Score[2] == 1 && g4Status[2] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[4] == 2 && g4Status[4] == g4status && g4Score[5] == 2 && g4Status[5] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 7;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status && g4Score[1] == 1 && g4Status[1] == g4status && g4Score[2] == 1 && g4Status[2] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[4] == 3 && g4Status[4] == g4status && g4Score[5] == 3 && g4Status[5] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 9;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status && g4Score[1] == 1 && g4Status[1] == g4status && g4Score[2] == 1 && g4Status[2] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[4] == 4 && g4Status[4] == g4status && g4Score[5] == 4 && g4Status[5] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 11;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status && g4Score[1] == 1 && g4Status[1] == g4status && g4Score[2] == 1 && g4Status[2] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[4] == 5 && g4Status[4] == g4status && g4Score[5] == 5 && g4Status[5] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 13;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status && g4Score[1] == 1 && g4Status[1] == g4status && g4Score[2] == 1 && g4Status[2] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[4] == 6 && g4Status[4] == g4status && g4Score[5] == 6 && g4Status[5] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 15;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status && g4Score[1] == 2 && g4Status[1] == g4status && g4Score[2] == 2 && g4Status[2] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && g4Score[5] == 1 && g4Status[5] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 8;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status && g4Score[1] == 2 && g4Status[1] == g4status && g4Score[2] == 2 && g4Status[2] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[4] == 3 && g4Status[4] == g4status && g4Score[5] == 3 && g4Status[5] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 12;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status && g4Score[1] == 2 && g4Status[1] == g4status && g4Score[2] == 2 && g4Status[2] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && g4Score[5] == 4 && g4Status[5] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 14;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status && g4Score[1] == 2 && g4Status[1] == g4status && g4Score[2] == 2 && g4Status[2] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[4] == 5 && g4Status[4] == g4status && g4Score[5] == 5 && g4Status[5] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 16;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status && g4Score[1] == 2 && g4Status[1] == g4status && g4Score[2] == 2 && g4Status[2] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[4] == 6 && g4Status[4] == g4status && g4Score[5] == 6 && g4Status[5] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 18;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status && g4Score[1] == 3 && g4Status[1] == g4status && g4Score[2] == 3 && g4Status[2] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && g4Score[5] == 1 && g4Status[5] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 11;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status && g4Score[1] == 3 && g4Status[1] == g4status && g4Score[2] == 3 && g4Status[2] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[4] == 2 && g4Status[4] == g4status && g4Score[5] == 2 && g4Status[5] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 13;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status && g4Score[1] == 3 && g4Status[1] == g4status && g4Score[2] == 3 && g4Status[2] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[4] == 4 && g4Status[4] == g4status && g4Score[5] == 4 && g4Status[5] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 17;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status && g4Score[1] == 3 && g4Status[1] == g4status && g4Score[2] == 3 && g4Status[2] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[4] == 5 && g4Status[4] == g4status && g4Score[5] == 5 && g4Status[5] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 19;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status && g4Score[1] == 3 && g4Status[1] == g4status && g4Score[2] == 3 && g4Status[2] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[4] == 6 && g4Status[4] == g4status && g4Score[5] == 6 && g4Status[5] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 21;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status && g4Score[1] == 4 && g4Status[1] == g4status && g4Score[2] == 4 && g4Status[2] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && g4Score[5] == 1 && g4Status[5] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 14;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status && g4Score[1] == 4 && g4Status[1] == g4status && g4Score[2] == 4 && g4Status[2] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[4] == 2 && g4Status[4] == g4status && g4Score[5] == 2 && g4Status[5] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 16;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status && g4Score[1] == 4 && g4Status[1] == g4status && g4Score[2] == 4 && g4Status[2] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[4] == 3 && g4Status[4] == g4status && g4Score[5] == 3 && g4Status[5] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 18;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status && g4Score[1] == 4 && g4Status[1] == g4status && g4Score[2] == 4 && g4Status[2] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[4] == 5 && g4Status[4] == g4status && g4Score[5] == 5 && g4Status[5] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 22;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status && g4Score[1] == 4 && g4Status[1] == g4status && g4Score[2] == 4 && g4Status[2] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[4] == 6 && g4Status[4] == g4status && g4Score[5] == 6 && g4Status[5] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 24;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status && g4Score[1] == 5 && g4Status[1] == g4status && g4Score[2] == 5 && g4Status[2] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && g4Score[5] == 1 && g4Status[5] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 17;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status && g4Score[1] == 5 && g4Status[1] == g4status && g4Score[2] == 5 && g4Status[2] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[4] == 2 && g4Status[4] == g4status && g4Score[5] == 2 && g4Status[5] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 19;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status && g4Score[1] == 5 && g4Status[1] == g4status && g4Score[2] == 5 && g4Status[2] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[4] == 3 && g4Status[4] == g4status && g4Score[5] == 3 && g4Status[5] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 21;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status && g4Score[1] == 5 && g4Status[1] == g4status && g4Score[2] == 5 && g4Status[2] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[4] == 4 && g4Status[4] == g4status && g4Score[5] == 4 && g4Status[5] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 23;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status && g4Score[1] == 5 && g4Status[1] == g4status && g4Score[2] == 5 && g4Status[2] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[4] == 6 && g4Status[4] == g4status && g4Score[5] == 6 && g4Status[5] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 27;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status && g4Score[1] == 6 && g4Status[1] == g4status && g4Score[2] == 6 && g4Status[2] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[3] == 1 && g4Status[3] == g4status || g4Score[4] == 1 && g4Status[4] == g4status && g4Score[5] == 1 && g4Status[5] == g4status || g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 20;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status && g4Score[1] == 6 && g4Status[1] == g4status && g4Score[2] == 6 && g4Status[2] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[4] == 2 && g4Status[4] == g4status && g4Score[5] == 2 && g4Status[5] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 22;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status && g4Score[1] == 6 && g4Status[1] == g4status && g4Score[2] == 6 && g4Status[2] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[4] == 3 && g4Status[4] == g4status && g4Score[5] == 3 && g4Status[5] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 24;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status && g4Score[1] == 6 && g4Status[1] == g4status && g4Score[2] == 6 && g4Status[2] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[4] == 4 && g4Status[4] == g4status && g4Score[5] == 4 && g4Status[5] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 26;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status && g4Score[1] == 6 && g4Status[1] == g4status && g4Score[2] == 6 && g4Status[2] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[4] == 5 && g4Status[4] == g4status && g4Score[5] == 5 && g4Status[5] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 3)
                        {
                            g4FHouse[0] = 28;
                        }

                    }

                    //SMALL
                    else if (Console.ReadKey().Key == ConsoleKey.D6)
                    {
                        Console.WriteLine("  ");
                        ACT4 = 4;
                        g44ofkind[0] = 0;
                        g43ofkind[0] = 0;
                        g4FHouse[0] = 0;
                        g4BigS[0] = 0;
                        // small

                        //Small straight
                        if (ACT4 == 0)
                        {
                            g4SmallS[0] = 0;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status && g4Score[1] == 5 && g4Status[1] == g4status && g4Status[2] == g4status && g4Score[2] == 4 && g4Score[3] == 3 && g4Status[3] == g4status && g4Score[4] == 2 && g4Status[4] == g4status && g4Score[5] == 1 && g4Status[5] == g4status && ACT4 == 4)
                        {
                            g4SmallS[0] = 21;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status && g4Score[1] == 4 && g4Status[1] == g4status && g4Status[2] == g4status && g4Score[2] == 3 && g4Score[3] == 2 && g4Status[3] == g4status && g4Score[4] == 1 && g4Status[4] == g4status && g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 4)
                        {
                            g4SmallS[0] = 21;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status && g4Score[1] == 3 && g4Status[1] == g4status && g4Status[2] == g4status && g4Score[2] == 2 && g4Score[3] == 1 && g4Status[3] == g4status && g4Score[4] == 6 && g4Status[4] == g4status && g4Score[5] == 5 && g4Status[5] == g4status & ACT4 == 4)
                        {
                            g4SmallS[0] = 21;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status && g4Score[1] == 2 && g4Status[1] == g4status && g4Status[2] == g4status && g4Score[2] == 1 && g4Score[3] == 6 && g4Status[3] == g4status && g4Score[4] == 5 && g4Status[4] == g4status && g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 4)
                        {
                            g4SmallS[0] = 21;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status && g4Score[1] == 1 && g4Status[1] == g4status && g4Status[2] == g4status && g4Score[2] == 6 && g4Score[3] == 5 && g4Status[3] == g4status && g4Score[4] == 4 && g4Status[4] == g4status && g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 4)
                        {
                            g4SmallS[0] = 21;
                        }
                        else if (g4Score[0] == 1 && g4Status[0] == g4status && g4Score[1] == 6 && g4Status[1] == g4status && g4Status[2] == g4status && g4Score[2] == 5 && g4Score[3] == 4 && g4Status[3] == g4status && g4Score[4] == 5 && g4Status[4] == g4status && g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 4)
                        {
                            g4SmallS[0] = 21;
                        }


                    }

                    // BIG
                    else if (Console.ReadKey().Key == ConsoleKey.D7)
                    {
                        Console.WriteLine("  ");
                        ACT4 = 5;
                        g44ofkind[0] = 0;
                        g43ofkind[0] = 0;
                        g4FHouse[0] = 0;
                        g4SmallS[0] = 0;
                        //big



                        // big straight
                        if (ACT4 == 0)
                        {
                            g4BigS[0] = 0;
                        }
                        else if (g4Score[0] == 2 && g4Status[0] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Status[1] == g4status && g4Score[1] == 3 || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[2] == 4 && g4Status[2] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[3] == 5 && g4Status[3] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[4] == 6 && g4Status[4] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && ACT4 == 5)
                        {
                            g4BigS[0] = 20;
                        }
                        else if (g4Score[0] == 3 && g4Status[0] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Status[1] == g4status && g4Score[1] == 4 || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[2] == 5 && g4Status[2] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[3] == 6 && g4Status[3] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[4] == 2 && g4Status[4] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && ACT4 == 5)
                        {
                            g4BigS[0] = 20;
                        }
                        else if (g4Score[0] == 4 && g4Status[0] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Status[1] == g4status && g4Score[1] == 5 || g4Score[5] == 5 && g4Status[5] == g4status && g4Score[2] == 6 && g4Status[2] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[3] == 2 && g4Status[3] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[4] == 3 && g4Status[4] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && ACT4 == 5)
                        {
                            g4BigS[0] = 20;
                        }
                        else if (g4Score[0] == 5 && g4Status[0] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && g4Status[1] == g4status && g4Score[1] == 6 || g4Score[5] == 6 && g4Status[5] == g4status && g4Score[2] == 2 && g4Status[2] == g4status || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[3] == 3 && g4Status[3] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[4] == 4 && g4Status[4] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && ACT4 == 5)
                        {
                            g4BigS[0] = 20;
                        }
                        else if (g4Score[0] == 6 && g4Status[0] == g4status || g4Score[5] == 6 && g4Status[5] == g4status && g4Status[1] == g4status && g4Score[1] == 2 || g4Score[5] == 2 && g4Status[5] == g4status && g4Score[2] == 3 && g4Status[2] == g4status || g4Score[5] == 3 && g4Status[5] == g4status && g4Score[3] == 4 && g4Status[3] == g4status || g4Score[5] == 4 && g4Status[5] == g4status && g4Score[4] == 5 && g4Status[4] == g4status || g4Score[5] == 5 && g4Status[5] == g4status && ACT4 == 5)
                        {
                            g4BigS[0] = 20;
                        }

                    }

                    //MOVE ON
                    else if (Console.ReadKey().Key == ConsoleKey.D8)
                    {
                        Console.WriteLine("  ");
                        ACT4 = 0;
                        g44ofkind[0] = 0;
                        g43ofkind[0] = 0;
                        g4FHouse[0] = 0;
                        g4SmallS[0] = 0;
                        g4BigS[0] = 0;
                        //NULL
                    }


                    // YATZY
                    if (g4Score[0] == 0)
                    {
                        g4YAYZY[0] = 0;
                    }
                    else if (g4Score[0] == 1 && g4Status[0] == g4status && g4Score[1] == 1 && g4Status[1] == g4status && g4Score[2] == 1 && g4Status[2] == g4status && g4Score[3] == 1 && g4Status[3] == g4status && g4Score[4] == 1 && g4Status[4] == g4status && g4Score[5] == 1 && g4Status[5] == g4status)
                    {
                        g4YAYZY[0] = 6;
                    }
                    else if (g4Score[0] == 2 && g4Status[0] == g4status && g4Score[1] == 2 && g4Status[1] == g4status && g4Score[2] == 2 && g4Status[2] == g4status && g4Score[3] == 2 && g4Status[3] == g4status && g4Score[4] == 2 && g4Status[4] == g4status && g4Score[5] == 2 && g4Status[5] == g4status)
                    {
                        g4YAYZY[0] = 12;
                    }
                    else if (g4Score[0] == 3 && g4Status[0] == g4status && g4Score[1] == 3 && g4Status[1] == g4status && g4Score[2] == 3 && g4Status[2] == g4status && g4Score[3] == 3 && g4Status[3] == g4status && g4Score[4] == 3 && g4Status[4] == g4status && g4Score[5] == 3 && g4Status[5] == g4status)
                    {
                        g4YAYZY[0] = 18;
                    }
                    else if (g4Score[0] == 4 && g4Status[0] == g4status && g4Score[1] == 4 && g4Status[1] == g4status && g4Score[2] == 4 && g4Status[2] == g4status && g4Score[3] == 4 && g4Status[3] == g4status && g4Score[4] == 4 && g4Status[4] == g4status && g4Score[5] == 4 && g4Status[5] == g4status)
                    {
                        g4YAYZY[0] = 24;
                    }
                    else if (g4Score[0] == 5 && g4Status[0] == g4status && g4Score[1] == 5 && g4Status[1] == g4status && g4Score[2] == 5 && g4Status[2] == g4status && g4Score[3] == 5 && g4Status[3] == g4status && g4Score[4] == 5 && g4Status[4] == g4status && g4Score[5] == 5 && g4Status[5] == g4status)
                    {
                        g4YAYZY[0] = 30;
                    }
                    else if (g4Score[0] == 6 && g4Status[0] == g4status && g4Score[1] == 6 && g4Status[1] == g4status && g4Score[2] == 6 && g4Status[2] == g4status && g4Score[3] == 6 && g4Status[3] == g4status && g4Score[4] == 6 && g4Status[4] == g4status && g4Score[5] == 6 && g4Status[5] == g4status)
                    {
                        g4YAYZY[0] = 36;
                    }

                    // YATZY BONUS
                    if (g4YAYZY[0] == 0)
                    {
                        g4YAYZYBONUS[0] = 0;
                    }
                    else if (g4YAYZY[0] != 0)
                    {
                        g4YAYZYBONUS[0] = 50;
                    }



                    Console.WriteLine(" To view and input values into the Scoreboard,");
                    Console.WriteLine(" input SS into the terminal.  ");
                    Console.WriteLine("  ");
                    Console.ReadKey();


                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        List<string> nos = new List<string>();
                        nos.Add(" _______________________________________________________");
                        nos.Add("|   Lower SECTION    |   |GAME 4|    |GAME 5|    |GAME 6|");
                        nos.Add("|____________________|___|______|____|______|____|______|");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|3 of a kind         |   " + g43ofkind[0] + "            0           0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|4 of a kind         |   " + g44ofkind[0] + "            0           0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Full House          |    " + g4FHouse[0] + "           0           0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Small Straight      |    " + g4SmallS[0] + "           0           0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Big Straight        |    " + g4BigS[0] + "           0           0     ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|YAHTZEE             |    " + g4YAYZY[0] + "           0           0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Chance              |    " + g4CHANCE + "            0           0     ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|YAHTZEE Bonus       |    " + g4YAYZYBONUS[0] + "           0           0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Total Upper SECTION |                0                  ");
                        nos.Add("|____________________|__________________________________");

                        foreach (string i in nos)
                        {
                            Console.WriteLine(i);
                        }

                        Console.WriteLine("");
                        Console.WriteLine("GAME 4 has FINISHED, please input RRR to Start GAME 5");
                        Console.WriteLine("__________________________________________________________");
                        Console.WriteLine("  ");
                        Console.ReadKey();
                    }
                }


            }
        }

        public class Game5 : Game
        {
            // Game 5 Round 1
            public static void ROUND1()
            {
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    // Game 5 Round 1
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                          GAME 5 ROUND 1");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g5Status[0] + "  Dice 1 =| " + g5diceRound1[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[1] + "  Dice 2 =| " + g5diceRound1[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[2] + "  Dice 3 =| " + g5diceRound1[2] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[3] + "  Dice 4 =| " + g5diceRound1[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[4] + "  Dice 5 =| " + g5diceRound1[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[5] + "  Dice 6 =| " + g5diceRound1[5] + " |        ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound2[0] = g5dice1;
                            g5Score[0] = g5dice1;
                            g5Status[0] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound2[1] = g5dice2;
                            g5Score[1] = g5dice2;
                            g5Status[1] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound2[2] = g5dice3;
                            g5Score[2] = g5dice3;
                            g5Status[2] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound2[3] = g5dice4;
                            g5Score[3] = g5dice4;
                            g5Status[3] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound2[4] = g5dice5;
                            g5Score[4] = g5dice5;
                            g5Status[4] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound2[5] = g5dice6;
                            g5Score[5] = g5dice6;
                            g5Status[5] = g5status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.R);
                }
            }

            // Game 5 Round 2
            public static void ROUND2()
            {
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                             GAME 5 ROUND 2");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g5Status[0] + "  Dice 1 =| " + g5diceRound2[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[1] + "  Dice 2 =| " + g5diceRound2[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[2] + "  Dice 3 =| " + g5diceRound2[2] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[3] + "  Dice 4 =| " + g5diceRound2[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[4] + "  Dice 5 =| " + g5diceRound2[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[5] + "  Dice 6 =| " + g5diceRound2[5] + " |        ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound3[0] = g5dice1;
                            g5Score[0] = g5dice1;
                            g5Status[0] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound3[1] = g5dice2;
                            g5Score[1] = g5dice2;
                            g5Status[1] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound3[2] = g5dice3;
                            g5Score[2] = g5dice3;
                            g5Status[2] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound3[3] = g5dice4;
                            g5Score[3] = g5dice4;
                            g5Status[3] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound3[4] = g5dice5;
                            g5Score[4] = g5dice5;
                            g5Status[4] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g5diceRound3[5] = g5dice6;
                            g5Score[5] = g5dice6;
                            g5Status[5] = g5status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.R);
                }
            }

            // Game 5 Round 3
            public static void ROUND3()
            {
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                             GAME 5 ROUND 3");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g5Status[0] + "  Dice 1 =| " + g5diceRound3[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[1] + "  Dice 2 =| " + g5diceRound3[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[2] + "  Dice 3 =| " + g5diceRound3[2] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[3] + "  Dice 4 =| " + g5diceRound3[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[4] + "  Dice 5 =| " + g5diceRound3[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[5] + "  Dice 6 =| " + g5diceRound3[5] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine(" ");
                    Console.WriteLine($"   • PRESS 0 multiply times, to to start next round.");
                    Console.WriteLine($"   • PRESS 1 multiply times, to hold dice 1.    ");
                    Console.WriteLine($"   • PRESS 2 multiply times, to hold dice 2.    ");
                    Console.WriteLine($"   • PRESS 3 multiply times, to hold dice 3.    ");
                    Console.WriteLine($"   • PRESS 4 multiply times, to hold dice 4.    ");
                    Console.WriteLine($"   • PRESS 5 multiply times, to hold dice 5.    ");
                    Console.WriteLine($"   • PRESS 6 multiply times, to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can play the CHANCE by inputting C into the terminal");
                    Console.ReadKey();

                    do
                    {

                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FFF to finish Game 5  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g5Score[0] = g5dice1;
                            g5Status[0] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FFF to finish Game 5  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g5Score[1] = g5dice2;
                            g5Status[1] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FFF to finish Game 5  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g5Score[2] = g5dice3;
                            g5Status[2] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FFF to finish Game 5  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g5Score[3] = g5dice4;
                            g5Status[3] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FFF to finish Game 5  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g5Score[4] = g5dice5;
                            g5Status[4] = g5status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FFF to finish Game 5  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g5Score[5] = g5dice6;
                            g5Status[5] = g5status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FFF to finish Game 5  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.C)
                        {
                            Console.WriteLine(" You have played the CHANCE and saved all the dices ");
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");

                            if (g5Status[0] == g5status && g5Status[1] == g5status && g5Status[2] == g5status && g5Status[3] == g5status && g5Status[4] == g5status && g5Status[5] == g5status)
                            {

                                List<string> nos1 = new List<string>();
                                nos1.Add(" _______________________________________________________");
                                nos1.Add("|   Lower SECTION    |   |GAME 4|    |GAME 5|    |GAME 6|");
                                nos1.Add("|____________________|___|______|____|______|____|______|");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|3 of a kind         |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|4 of a kind         |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Full House          |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Small Straight      |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Big Straight        |0               0           0     ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|YAHTZEE             |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Chance              |0               " + g5CHANCE + "            0     ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|YAHTZEE Bonus       |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Total Upper SECTION |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Total Lower SECTION |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|       TOTAL        |                0                  ");
                                nos1.Add("|____________________|__________________________________");


                                foreach (string i in nos1)
                                {
                                    Console.WriteLine(i);
                                }
                            }

                            Console.WriteLine("");
                            Console.WriteLine("GAME 5 has FINISHED, please input FF to Start GAME 6");
                            Console.WriteLine("__________________________________________________________");
                            Console.ReadKey();
                        }
                    } while (Console.ReadKey().Key != ConsoleKey.F);
                }
            }

            // GAME 5 Finished
            public static void GAME5_Finished()
            {
                int ACT5 = 0;
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.F)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                     GAME 5 HAS FINISHED");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" You have saved the values of ");
                    Console.WriteLine(" ");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g5Status[0] + "  Dice 1 =|" + g5Score[0] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[1] + "  Dice 2 =|" + g5Score[1] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[2] + "  Dice 3 =|" + g5Score[2] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[3] + "  Dice 4 =|" + g5Score[3] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[4] + "  Dice 5 =|" + g5Score[4] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g5Status[5] + "  Dice 6 =|" + g5Score[5] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" PRESS 3 multiply times, to ACTIVATE 3ofKind  ");
                    Console.WriteLine(" PRESS 4 multiply times, to ACTIVATE 4ofKind  ");
                    Console.WriteLine(" PRESS 5 multiply times, to ACTIVATE Full House  ");
                    Console.WriteLine(" PRESS 6 multiply times, to ACTIVATE Small Straight  ");
                    Console.WriteLine(" PRESS 7 multiply times, to ACTIVATE Big Straight ");
                    Console.WriteLine(" PRESS 8 multiply times, to move on ");
                    Console.WriteLine("  ");
                    Console.ReadKey();

                    //ACTIVATOR
                    //3 OF KIND
                    if (Console.ReadKey().Key == ConsoleKey.D3)
                    {
                        Console.WriteLine("  ");
                        ACT5 = 1;
                        g54ofkind[0] = 0;
                        g5FHouse[0] = 0;
                        g5SmallS[0] = 0;
                        g5BigS[0] = 0;
                        //3ofkind

                        //3ofKind
                        if (ACT5 == 0)
                        {
                            g53ofkind[0] = 0;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status || g5Score[1] == 1 && g5Status[1] == g5status && g5Score[2] == 1 && g5Status[2] == g5status || g5Score[3] == 1 && g5Status[3] == g5status && g5Score[4] == 1 && g5Status[4] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 3;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status || g5Score[2] == 1 && g5Status[2] == g5status && g5Score[1] == 1 && g5Status[1] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 3; ;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status || g5Score[3] == 1 && g5Status[3] == g5status && g5Score[1] == 1 && g5Status[1] == g5status || g5Score[2] == 1 && g5Status[2] == g5status && g5Score[4] == 1 && g5Status[4] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 3;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && g5Score[1] == 1 && g5Status[1] == g5status || g5Score[2] == 1 && g5Status[2] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 3;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && g5Score[1] == 1 && g5Status[1] == g5status || g5Score[3] == 1 && g5Status[3] == g5status && g5Score[2] == 1 && g5Status[2] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 3;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status || g5Score[1] == 2 && g5Status[1] == g5status && g5Score[2] == 2 && g5Status[2] == g5status || g5Score[3] == 2 && g5Status[3] == g5status && g5Score[4] == 2 && g5Status[4] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 6;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status || g5Score[2] == 2 && g5Status[2] == g5status && g5Score[1] == 2 && g5Status[1] == g5status || g5Score[4] == 2 && g5Status[4] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 6; ;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status || g5Score[3] == 2 && g5Status[3] == g5status && g5Score[1] == 2 && g5Status[1] == g5status || g5Score[2] == 2 && g5Status[2] == g5status && g5Score[4] == 2 && g5Status[4] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 6;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status || g5Score[4] == 2 && g5Status[4] == g5status && g5Score[1] == 2 && g5Status[1] == g5status || g5Score[2] == 2 && g5Status[2] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 6;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[1] == 2 && g5Status[1] == g5status || g5Score[3] == 2 && g5Status[3] == g5status && g5Score[2] == 2 && g5Status[2] == g5status || g5Score[4] == 2 && g5Status[4] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 6;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status || g5Score[1] == 3 && g5Status[1] == g5status && g5Score[2] == 3 && g5Status[2] == g5status || g5Score[3] == 3 && g5Status[3] == g5status && g5Score[4] == 3 && g5Status[4] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 9;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status || g5Score[2] == 3 && g5Status[2] == g5status && g5Score[1] == 3 && g5Status[1] == g5status || g5Score[4] == 3 && g5Status[4] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 9;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status || g5Score[3] == 3 && g5Status[3] == g5status && g5Score[1] == 3 && g5Status[1] == g5status || g5Score[2] == 3 && g5Status[2] == g5status && g5Score[4] == 3 && g5Status[4] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 9;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status || g5Score[4] == 3 && g5Status[4] == g5status && g5Score[1] == 3 && g5Status[1] == g5status || g5Score[2] == 3 && g5Status[2] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 9;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[1] == 3 && g5Status[1] == g5status || g5Score[3] == 3 && g5Status[3] == g5status && g5Score[2] == 3 && g5Status[2] == g5status || g5Score[4] == 3 && g5Status[4] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 9;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status || g5Score[1] == 4 && g5Status[1] == g5status && g5Score[2] == 4 && g5Status[2] == g5status || g5Score[3] == 4 && g5Status[3] == g5status && g5Score[4] == 4 && g5Status[4] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 12;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status || g5Score[2] == 4 && g5Status[2] == g5status && g5Score[1] == 4 && g5Status[1] == g5status || g5Score[4] == 4 && g5Status[4] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 12;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status || g5Score[3] == 4 && g5Status[3] == g5status && g5Score[1] == 4 && g5Status[1] == g5status || g5Score[2] == 4 && g5Status[2] == g5status && g5Score[4] == 4 && g5Status[4] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 12;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status || g5Score[4] == 4 && g5Status[4] == g5status && g5Score[1] == 4 && g5Status[1] == g5status || g5Score[2] == 4 && g5Status[2] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 12;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[1] == 4 && g5Status[1] == g5status || g5Score[3] == 4 && g5Status[3] == g5status && g5Score[2] == 4 && g5Status[2] == g5status || g5Score[4] == 4 && g5Status[4] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 12;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status || g5Score[1] == 5 && g5Status[1] == g5status && g5Score[2] == 5 && g5Status[2] == g5status || g5Score[3] == 5 && g5Status[3] == g5status && g5Score[4] == 5 && g5Status[4] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 15;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status || g5Score[2] == 5 && g5Status[2] == g5status && g5Score[1] == 5 && g5Status[1] == g5status || g5Score[4] == 5 && g5Status[4] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 15;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status || g5Score[3] == 5 && g5Status[3] == g5status && g5Score[1] == 5 && g5Status[1] == g5status || g5Score[2] == 5 && g5Status[2] == g5status && g5Score[4] == 5 && g5Status[4] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 15;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status || g5Score[4] == 5 && g5Status[4] == g5status && g5Score[1] == 5 && g5Status[1] == g5status || g5Score[2] == 5 && g5Status[2] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 15;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[1] == 5 && g5Status[1] == g5status || g5Score[3] == 5 && g5Status[3] == g5status && g5Score[2] == 5 && g5Status[2] == g5status || g5Score[4] == 5 && g5Status[4] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 15;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status || g5Score[1] == 6 && g5Status[1] == g5status && g5Score[2] == 6 && g5Status[2] == g5status || g5Score[3] == 6 && g5Status[3] == g5status && g5Score[4] == 6 && g5Status[4] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 18;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status || g5Score[2] == 6 && g5Status[2] == g5status && g5Score[1] == 6 && g5Status[1] == g5status || g5Score[4] == 6 && g5Status[4] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 18;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status || g5Score[3] == 6 && g5Status[3] == g5status && g5Score[1] == 6 && g5Status[1] == g5status || g5Score[2] == 6 && g5Status[2] == g5status && g5Score[4] == 6 && g5Status[4] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 18;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status || g5Score[4] == 6 && g5Status[4] == g5status && g5Score[1] == 6 && g5Status[1] == g5status || g5Score[2] == 6 && g5Status[2] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 18;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[1] == 6 && g5Status[1] == g5status || g5Score[3] == 6 && g5Status[3] == g5status && g5Score[2] == 6 && g5Status[2] == g5status || g5Score[4] == 6 && g5Status[4] == g5status && ACT5 == 1)
                        {
                            g53ofkind[0] = 18;
                        }

                    }

                    // 4 OF KIND
                    else if (Console.ReadKey().Key == ConsoleKey.D4)
                    {
                        Console.WriteLine("  ");
                        ACT5 = 2;
                        g53ofkind[0] = 0;
                        g5FHouse[0] = 0;
                        g5SmallS[0] = 0;
                        g5BigS[0] = 0;
                        //4ofkind



                        //4ofKind
                        if (ACT5 == 0)
                        {
                            g54ofkind[0] = 0;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && g5Score[1] == 1 && g5Status[1] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && g5Score[2] == 1 && g5Status[2] == g5status && g5Score[3] == 1 && g5Status[3] == g5status && ACT5 == 2)
                        {
                            g54ofkind[0] = 4;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[1] == 2 && g5Status[1] == g5status || g5Score[4] == 2 && g5Status[4] == g5status && g5Score[2] == 2 && g5Status[2] == g5status && g5Score[3] == 2 && g5Status[3] == g5status && ACT5 == 2)
                        {
                            g54ofkind[0] = 8;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[1] == 3 && g5Status[1] == g5status || g5Score[4] == 3 && g5Status[4] == g5status && g5Score[2] == 3 && g5Status[2] == g5status && g5Score[3] == 3 && g5Status[3] == g5status && ACT5 == 2)
                        {
                            g54ofkind[0] = 12;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[1] == 4 && g5Status[1] == g5status || g5Score[4] == 4 && g5Status[4] == g5status && g5Score[2] == 4 && g5Status[2] == g5status && g5Score[3] == 4 && g5Status[3] == g5status && ACT5 == 2)
                        {
                            g54ofkind[0] = 16;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[1] == 5 && g5Status[1] == g5status || g5Score[4] == 5 && g5Status[4] == g5status && g5Score[2] == 5 && g5Status[2] == g5status && g5Score[3] == 5 && g5Status[3] == g5status && ACT5 == 2)
                        {
                            g54ofkind[0] = 20;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[1] == 6 && g5Status[1] == g5status || g5Score[4] == 6 && g5Status[4] == g5status && g5Score[2] == 6 && g5Status[2] == g5status && g5Score[3] == 6 && g5Status[3] == g5status && ACT5 == 2)
                        {
                            g54ofkind[0] = 24;
                        }

                    }

                    //FULL HOUSE
                    else if (Console.ReadKey().Key == ConsoleKey.D5)
                    {
                        Console.WriteLine("  ");
                        ACT5 = 3;
                        g54ofkind[0] = 0;
                        g53ofkind[0] = 0;
                        g5SmallS[0] = 0;
                        g5BigS[0] = 0;
                        //full house
                        //Full House
                        if (ACT5 == 0)
                        {
                            g5FHouse[0] = 0;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status && g5Score[1] == 1 && g5Status[1] == g5status && g5Score[2] == 1 && g5Status[2] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[4] == 2 && g5Status[4] == g5status && g5Score[5] == 2 && g5Status[5] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 7;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status && g5Score[1] == 1 && g5Status[1] == g5status && g5Score[2] == 1 && g5Status[2] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[4] == 3 && g5Status[4] == g5status && g5Score[5] == 3 && g5Status[5] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 9;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status && g5Score[1] == 1 && g5Status[1] == g5status && g5Score[2] == 1 && g5Status[2] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[4] == 4 && g5Status[4] == g5status && g5Score[5] == 4 && g5Status[5] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 11;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status && g5Score[1] == 1 && g5Status[1] == g5status && g5Score[2] == 1 && g5Status[2] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[4] == 5 && g5Status[4] == g5status && g5Score[5] == 5 && g5Status[5] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 13;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status && g5Score[1] == 1 && g5Status[1] == g5status && g5Score[2] == 1 && g5Status[2] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[4] == 6 && g5Status[4] == g5status && g5Score[5] == 6 && g5Status[5] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 15;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status && g5Score[1] == 2 && g5Status[1] == g5status && g5Score[2] == 2 && g5Status[2] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && g5Score[5] == 1 && g5Status[5] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 8;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status && g5Score[1] == 2 && g5Status[1] == g5status && g5Score[2] == 2 && g5Status[2] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[4] == 3 && g5Status[4] == g5status && g5Score[5] == 3 && g5Status[5] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 12;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status && g5Score[1] == 2 && g5Status[1] == g5status && g5Score[2] == 2 && g5Status[2] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && g5Score[5] == 4 && g5Status[5] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 14;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status && g5Score[1] == 2 && g5Status[1] == g5status && g5Score[2] == 2 && g5Status[2] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[4] == 5 && g5Status[4] == g5status && g5Score[5] == 5 && g5Status[5] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 16;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status && g5Score[1] == 2 && g5Status[1] == g5status && g5Score[2] == 2 && g5Status[2] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[4] == 6 && g5Status[4] == g5status && g5Score[5] == 6 && g5Status[5] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 18;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status && g5Score[1] == 3 && g5Status[1] == g5status && g5Score[2] == 3 && g5Status[2] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && g5Score[5] == 1 && g5Status[5] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 11;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status && g5Score[1] == 3 && g5Status[1] == g5status && g5Score[2] == 3 && g5Status[2] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[4] == 2 && g5Status[4] == g5status && g5Score[5] == 2 && g5Status[5] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 13;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status && g5Score[1] == 3 && g5Status[1] == g5status && g5Score[2] == 3 && g5Status[2] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[4] == 4 && g5Status[4] == g5status && g5Score[5] == 4 && g5Status[5] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 17;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status && g5Score[1] == 3 && g5Status[1] == g5status && g5Score[2] == 3 && g5Status[2] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[4] == 5 && g5Status[4] == g5status && g5Score[5] == 5 && g5Status[5] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 19;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status && g5Score[1] == 3 && g5Status[1] == g5status && g5Score[2] == 3 && g5Status[2] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[4] == 6 && g5Status[4] == g5status && g5Score[5] == 6 && g5Status[5] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 21;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status && g5Score[1] == 4 && g5Status[1] == g5status && g5Score[2] == 4 && g5Status[2] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && g5Score[5] == 1 && g5Status[5] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 14;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status && g5Score[1] == 4 && g5Status[1] == g5status && g5Score[2] == 4 && g5Status[2] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[4] == 2 && g5Status[4] == g5status && g5Score[5] == 2 && g5Status[5] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 16;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status && g5Score[1] == 4 && g5Status[1] == g5status && g5Score[2] == 4 && g5Status[2] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[4] == 3 && g5Status[4] == g5status && g5Score[5] == 3 && g5Status[5] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 18;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status && g5Score[1] == 4 && g5Status[1] == g5status && g5Score[2] == 4 && g5Status[2] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[4] == 5 && g5Status[4] == g5status && g5Score[5] == 5 && g5Status[5] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 22;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status && g5Score[1] == 4 && g5Status[1] == g5status && g5Score[2] == 4 && g5Status[2] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[4] == 6 && g5Status[4] == g5status && g5Score[5] == 6 && g5Status[5] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 24;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status && g5Score[1] == 5 && g5Status[1] == g5status && g5Score[2] == 5 && g5Status[2] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && g5Score[5] == 1 && g5Status[5] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 17;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status && g5Score[1] == 5 && g5Status[1] == g5status && g5Score[2] == 5 && g5Status[2] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[4] == 2 && g5Status[4] == g5status && g5Score[5] == 2 && g5Status[5] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 19;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status && g5Score[1] == 5 && g5Status[1] == g5status && g5Score[2] == 5 && g5Status[2] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[4] == 3 && g5Status[4] == g5status && g5Score[5] == 3 && g5Status[5] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 21;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status && g5Score[1] == 5 && g5Status[1] == g5status && g5Score[2] == 5 && g5Status[2] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[4] == 4 && g5Status[4] == g5status && g5Score[5] == 4 && g5Status[5] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 23;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status && g5Score[1] == 5 && g5Status[1] == g5status && g5Score[2] == 5 && g5Status[2] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[4] == 6 && g5Status[4] == g5status && g5Score[5] == 6 && g5Status[5] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 27;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status && g5Score[1] == 6 && g5Status[1] == g5status && g5Score[2] == 6 && g5Status[2] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[3] == 1 && g5Status[3] == g5status || g5Score[4] == 1 && g5Status[4] == g5status && g5Score[5] == 1 && g5Status[5] == g5status || g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 20;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status && g5Score[1] == 6 && g5Status[1] == g5status && g5Score[2] == 6 && g5Status[2] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[4] == 2 && g5Status[4] == g5status && g5Score[5] == 2 && g5Status[5] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 22;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status && g5Score[1] == 6 && g5Status[1] == g5status && g5Score[2] == 6 && g5Status[2] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[4] == 3 && g5Status[4] == g5status && g5Score[5] == 3 && g5Status[5] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 24;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status && g5Score[1] == 6 && g5Status[1] == g5status && g5Score[2] == 6 && g5Status[2] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[4] == 4 && g5Status[4] == g5status && g5Score[5] == 4 && g5Status[5] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 26;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status && g5Score[1] == 6 && g5Status[1] == g5status && g5Score[2] == 6 && g5Status[2] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[4] == 5 && g5Status[4] == g5status && g5Score[5] == 5 && g5Status[5] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 3)
                        {
                            g5FHouse[0] = 28;
                        }

                    }

                    //SMALL
                    else if (Console.ReadKey().Key == ConsoleKey.D6)
                    {
                        Console.WriteLine("  ");
                        ACT5 = 4;
                        g54ofkind[0] = 0;
                        g53ofkind[0] = 0;
                        g5FHouse[0] = 0;
                        g5BigS[0] = 0;
                        // small

                        //Small straight
                        if (ACT5 == 0)
                        {
                            g5SmallS[0] = 0;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status && g5Score[1] == 5 && g5Status[1] == g5status && g5Status[2] == g5status && g5Score[2] == 4 && g5Score[3] == 3 && g5Status[3] == g5status && g5Score[4] == 2 && g5Status[4] == g5status && g5Score[5] == 1 && g5Status[5] == g5status && ACT5 == 4)
                        {
                            g5SmallS[0] = 21;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status && g5Score[1] == 4 && g5Status[1] == g5status && g5Status[2] == g5status && g5Score[2] == 3 && g5Score[3] == 2 && g5Status[3] == g5status && g5Score[4] == 1 && g5Status[4] == g5status && g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 4)
                        {
                            g5SmallS[0] = 21;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status && g5Score[1] == 3 && g5Status[1] == g5status && g5Status[2] == g5status && g5Score[2] == 2 && g5Score[3] == 1 && g5Status[3] == g5status && g5Score[4] == 6 && g5Status[4] == g5status && g5Score[5] == 5 && g5Status[5] == g5status & ACT5 == 4)
                        {
                            g5SmallS[0] = 21;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status && g5Score[1] == 2 && g5Status[1] == g5status && g5Status[2] == g5status && g5Score[2] == 1 && g5Score[3] == 6 && g5Status[3] == g5status && g5Score[4] == 5 && g5Status[4] == g5status && g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 4)
                        {
                            g5SmallS[0] = 21;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status && g5Score[1] == 1 && g5Status[1] == g5status && g5Status[2] == g5status && g5Score[2] == 6 && g5Score[3] == 5 && g5Status[3] == g5status && g5Score[4] == 4 && g5Status[4] == g5status && g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 4)
                        {
                            g5SmallS[0] = 21;
                        }
                        else if (g5Score[0] == 1 && g5Status[0] == g5status && g5Score[1] == 6 && g5Status[1] == g5status && g5Status[2] == g5status && g5Score[2] == 5 && g5Score[3] == 4 && g5Status[3] == g5status && g5Score[4] == 5 && g5Status[4] == g5status && g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 4)
                        {
                            g5SmallS[0] = 21;
                        }


                    }

                    // BIG
                    else if (Console.ReadKey().Key == ConsoleKey.D7)
                    {
                        Console.WriteLine("  ");
                        ACT5 = 5;
                        g54ofkind[0] = 0;
                        g53ofkind[0] = 0;
                        g5FHouse[0] = 0;
                        g5SmallS[0] = 0;
                        //big



                        // big straight
                        if (ACT5 == 0)
                        {
                            g5BigS[0] = 0;
                        }
                        else if (g5Score[0] == 2 && g5Status[0] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Status[1] == g5status && g5Score[1] == 3 || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[2] == 4 && g5Status[2] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[3] == 5 && g5Status[3] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[4] == 6 && g5Status[4] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && ACT5 == 5)
                        {
                            g5BigS[0] = 20;
                        }
                        else if (g5Score[0] == 3 && g5Status[0] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Status[1] == g5status && g5Score[1] == 4 || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[2] == 5 && g5Status[2] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[3] == 6 && g5Status[3] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[4] == 2 && g5Status[4] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && ACT5 == 5)
                        {
                            g5BigS[0] = 20;
                        }
                        else if (g5Score[0] == 4 && g5Status[0] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Status[1] == g5status && g5Score[1] == 5 || g5Score[5] == 5 && g5Status[5] == g5status && g5Score[2] == 6 && g5Status[2] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[3] == 2 && g5Status[3] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[4] == 3 && g5Status[4] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && ACT5 == 5)
                        {
                            g5BigS[0] = 20;
                        }
                        else if (g5Score[0] == 5 && g5Status[0] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && g5Status[1] == g5status && g5Score[1] == 6 || g5Score[5] == 6 && g5Status[5] == g5status && g5Score[2] == 2 && g5Status[2] == g5status || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[3] == 3 && g5Status[3] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[4] == 4 && g5Status[4] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && ACT5 == 5)
                        {
                            g5BigS[0] = 20;
                        }
                        else if (g5Score[0] == 6 && g5Status[0] == g5status || g5Score[5] == 6 && g5Status[5] == g5status && g5Status[1] == g5status && g5Score[1] == 2 || g5Score[5] == 2 && g5Status[5] == g5status && g5Score[2] == 3 && g5Status[2] == g5status || g5Score[5] == 3 && g5Status[5] == g5status && g5Score[3] == 4 && g5Status[3] == g5status || g5Score[5] == 4 && g5Status[5] == g5status && g5Score[4] == 5 && g5Status[4] == g5status || g5Score[5] == 5 && g5Status[5] == g5status && ACT5 == 5)
                        {
                            g5BigS[0] = 20;
                        }

                    }

                    //MOVE ON
                    else if (Console.ReadKey().Key == ConsoleKey.D8)
                    {
                        Console.WriteLine("  ");
                        ACT5 = 0;
                        g54ofkind[0] = 0;
                        g53ofkind[0] = 0;
                        g5FHouse[0] = 0;
                        g5SmallS[0] = 0;
                        g5BigS[0] = 0;
                        //NULL
                    }


                    // YATZY
                    if (g5Score[0] == 0)
                    {
                        g5YAYZY[0] = 0;
                    }
                    else if (g5Score[0] == 1 && g5Status[0] == g5status && g5Score[1] == 1 && g5Status[1] == g5status && g5Score[2] == 1 && g5Status[2] == g5status && g5Score[3] == 1 && g5Status[3] == g5status && g5Score[4] == 1 && g5Status[4] == g5status && g5Score[5] == 1 && g5Status[5] == g5status)
                    {
                        g5YAYZY[0] = 6;
                    }
                    else if (g5Score[0] == 2 && g5Status[0] == g5status && g5Score[1] == 2 && g5Status[1] == g5status && g5Score[2] == 2 && g5Status[2] == g5status && g5Score[3] == 2 && g5Status[3] == g5status && g5Score[4] == 2 && g5Status[4] == g5status && g5Score[5] == 2 && g5Status[5] == g5status)
                    {
                        g5YAYZY[0] = 12;
                    }
                    else if (g5Score[0] == 3 && g5Status[0] == g5status && g5Score[1] == 3 && g5Status[1] == g5status && g5Score[2] == 3 && g5Status[2] == g5status && g5Score[3] == 3 && g5Status[3] == g5status && g5Score[4] == 3 && g5Status[4] == g5status && g5Score[5] == 3 && g5Status[5] == g5status)
                    {
                        g5YAYZY[0] = 18;
                    }
                    else if (g5Score[0] == 4 && g5Status[0] == g5status && g5Score[1] == 4 && g5Status[1] == g5status && g5Score[2] == 4 && g5Status[2] == g5status && g5Score[3] == 4 && g5Status[3] == g5status && g5Score[4] == 4 && g5Status[4] == g5status && g5Score[5] == 4 && g5Status[5] == g5status)
                    {
                        g5YAYZY[0] = 24;
                    }
                    else if (g5Score[0] == 5 && g5Status[0] == g5status && g5Score[1] == 5 && g5Status[1] == g5status && g5Score[2] == 5 && g5Status[2] == g5status && g5Score[3] == 5 && g5Status[3] == g5status && g5Score[4] == 5 && g5Status[4] == g5status && g5Score[5] == 5 && g5Status[5] == g5status)
                    {
                        g5YAYZY[0] = 30;
                    }
                    else if (g5Score[0] == 6 && g5Status[0] == g5status && g5Score[1] == 6 && g5Status[1] == g5status && g5Score[2] == 6 && g5Status[2] == g5status && g5Score[3] == 6 && g5Status[3] == g5status && g5Score[4] == 6 && g5Status[4] == g5status && g5Score[5] == 6 && g5Status[5] == g5status)
                    {
                        g5YAYZY[0] = 36;
                    }

                    // YATZY BONUS
                    if (g5YAYZY[0] == 0)
                    {
                        g5YAYZYBONUS[0] = 0;
                    }
                    else if (g5YAYZY[0] != 0)
                    {
                        g5YAYZYBONUS[0] = 50;
                    }

                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" To view and input values into the Scoreboard,");
                    Console.WriteLine(" input SS into the terminal.  ");
                    Console.WriteLine("  ");

                    Console.ReadKey();
                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        int[] g4CHANCE = { g4Score[0] + g4Score[1] + g4Score[2] + g4Score[3] + g4Score[4] + g4Score[5] };
                        List<string> nos = new List<string>();
                        nos.Add(" _______________________________________________________");
                        nos.Add("|   Lower SECTION    |   |GAME 4|    |GAME 5|    |GAME 6|");
                        nos.Add("|____________________|___|______|____|______|____|______|");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|3 of a kind         |   " + g43ofkind[0] + "             " + g53ofkind[0] + "          0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|4 of a kind         |   " + g44ofkind[0] + "             " + g54ofkind[0] + "          0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Full House          |    " + g43ofkind[0] + "           " + g53ofkind[0] + "           0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Small Straight      |    " + g4SmallS[0] + "           " + g5SmallS[0] + "          0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Big Straight        |    " + g4BigS[0] + "           " + g5BigS[0] + "           0     ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|YAHTZEE             |    " + g4YAYZY[0] + "             " + g5YAYZY[0] + "           0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Chance              |    " + g4CHANCE + "            " + g5CHANCE[0] + "            0     ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|YAHTZEE Bonus       |    " + g5YAYZYBONUS[0] + "            " + g5YAYZYBONUS[0] + "           0      ");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|____________________|__________________________________");
                        nos.Add("|Total Upper SECTION |                0                 ");
                        nos.Add("|____________________|__________________________________");


                        foreach (string i in nos)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("GAME 5 has FINISHED, please input RRR to Start GAME 6");
                    Console.WriteLine("__________________________________________________________");
                    Console.ReadKey();
                }
            }

        }

        public class Game6 : Game
        {

            // GAME 6 Round 1
            public static void ROUND1()
            {
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {

                    // Game 6 Round 1
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                             GAME 6 ROUND 1");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g6Status[0] + "  Dice 1 =| " + g6diceRound1[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[1] + "  Dice 2 =| " + g6diceRound1[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[2] + "  Dice 3 =| " + g6diceRound1[2] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[3] + "  Dice 4 =| " + g6diceRound1[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[4] + "  Dice 5 =| " + g6diceRound1[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[5] + "  Dice 6 =| " + g6diceRound1[5] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine(" ");
                    Console.WriteLine($"   • Input 0 to and R to start next round.");
                    Console.WriteLine($"   • Input 1 to hold dice 1.    ");
                    Console.WriteLine($"   • Input 2 to hold dice 2.    ");
                    Console.WriteLine($"   • Input 3 to hold dice 3.    ");
                    Console.WriteLine($"   • Input 4 to hold dice 4.    ");
                    Console.WriteLine($"   • Input 5 to hold dice 5.    ");
                    Console.WriteLine($"   • Input 6 to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound2[0] = g6dice1;
                            g6Score[0] = g6dice1;
                            g6Status[0] = g6status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound2[1] = g6dice2;
                            g6Score[1] = g6dice2;
                            g6Status[1] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound2[2] = g6dice3;
                            g6Score[2] = g6dice3;
                            g6Status[2] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound2[3] = g6dice4;
                            g6Score[3] = g6dice4;
                            g6Status[3] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound2[4] = g6dice5;
                            g6Score[4] = g6dice5;
                            g6Status[4] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound2[5] = g6dice6;
                            g6Score[5] = g6dice6;
                            g6Status[5] = g6status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press RRR to begin round 2 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.R);

                }
            }

            // GAME 6 Round 2
            public static void ROUND2()
            {
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                             GAME 6 ROUND 2");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g6Status[0] + "  Dice 1 =| " + g6diceRound2[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[1] + "  Dice 2 =| " + g6diceRound2[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[2] + "  Dice 3 =| " + g6diceRound2[2] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[3] + "  Dice 4 =| " + g6diceRound2[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[4] + "  Dice 5 =| " + g6diceRound2[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[5] + "  Dice 6 =| " + g6diceRound2[5] + " |        ");
                    Console.WriteLine("                   |_______________________");

                    Console.WriteLine(" ");
                    Console.WriteLine($"   • Input 0 to and R to start next round.");
                    Console.WriteLine($"   • Input 1 to hold dice 1.    ");
                    Console.WriteLine($"   • Input 2 to hold dice 2.    ");
                    Console.WriteLine($"   • Input 3 to hold dice 3.    ");
                    Console.WriteLine($"   • Input 4 to hold dice 4.    ");
                    Console.WriteLine($"   • Input 5 to hold dice 5.    ");
                    Console.WriteLine($"   • Input 6 to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound3[0] = g6diceRound2[0];
                            g6Score[0] = g6diceRound2[0];
                            g6Status[0] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound3[1] = g6diceRound2[1];
                            g6Score[1] = g6diceRound2[1];

                            g6Status[1] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound3[2] = g6diceRound2[2];
                            g6Score[2] = g6diceRound2[2];
                            g6Status[2] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound3[3] = g6diceRound2[3];
                            g6Score[3] = g6diceRound2[3];
                            g6Status[3] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound3[4] = g6diceRound2[4];
                            g6Score[4] = g6diceRound2[4];
                            g6Status[4] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("Or press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            g6diceRound3[5] = g6diceRound2[5];
                            g6Score[5] = g6diceRound2[5];
                            g6Status[5] = g6status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press RRR to begin round 3 ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.R);
                }
            }

            // GAME 6 Round 3
            public static void ROUND3()
            {
                Console.ReadKey();
                if (Console.ReadKey().Key == ConsoleKey.R)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(" ________________________________________________________________ ");
                    Console.WriteLine("                             GAME 6 ROUND 3");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g6Status[0] + "  Dice 1 =| " + g6diceRound3[0] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[1] + "  Dice 2 =| " + g6diceRound3[1] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[2] + "  Dice 3 =| " + g6diceRound3[2] + " |       ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[3] + "  Dice 4 =| " + g6diceRound3[3] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[4] + "  Dice 5 =| " + g6diceRound3[4] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[5] + "  Dice 6 =| " + g6diceRound3[5] + " |        ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine(" ");
                    Console.WriteLine($"   • Input 0 to and R to start next round.");
                    Console.WriteLine($"   • Input 1 to hold dice 1.    ");
                    Console.WriteLine($"   • Input 2 to hold dice 2.    ");
                    Console.WriteLine($"   • Input 3 to hold dice 3.    ");
                    Console.WriteLine($"   • Input 4 to hold dice 4.    ");
                    Console.WriteLine($"   • Input 5 to hold dice 5.    ");
                    Console.WriteLine($"   • Input 6 to hold dice 6.    ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can hold multiple dices,");
                    Console.WriteLine("    but only one dice at the time. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You have to hold all your dices EVERY ROUND,");
                    Console.WriteLine("    otherwise they will reroll. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("  - You can play the CHANCE by inputting C into the terminal");
                    Console.ReadKey();

                    do
                    {
                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 1");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FF to finish Game 6  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g6Score[0] = g6diceRound3[0];
                            g6Status[0] = g6status;


                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 2");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FF to finish Game 6  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g6Score[1] = g6diceRound3[1];
                            g6Status[1] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D3)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 3");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FF to finish Game 6  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g6Score[2] = g6diceRound3[2];
                            g6Status[2] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D4)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 4");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FF to finish Game 6  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g6Score[3] = g6diceRound3[3];
                            g6Status[3] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 5");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FF to finish Game 6  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g6Score[4] = g6diceRound3[4];
                            g6Status[4] = g6status;
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D6)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine("You have saved Dice 6");
                            Console.WriteLine("Do you want to save another dice?");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FF to finish Game 6  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            g6Score[5] = g6diceRound3[5];
                            g6Status[5] = g6status;

                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" Press FF to finish Game 6  ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.C)
                        {
                            Console.WriteLine(" You have played the CHANCE and saved all the dices ");
                            Console.WriteLine(" ");
                            Console.WriteLine("___________________________________________");
                            Console.WriteLine(" ");

                            if (g5Status[0] == g5status && g5Status[1] == g5status && g5Status[2] == g5status && g5Status[3] == g5status && g5Status[4] == g5status && g5Status[5] == g5status)
                            {

                                List<string> nos1 = new List<string>();
                                nos1.Add(" _______________________________________________________");
                                nos1.Add("|   Lower SECTION    |   |GAME 4|    |GAME 5|    |GAME 6|");
                                nos1.Add("|____________________|___|______|____|______|____|______|");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|3 of a kind         |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|4 of a kind         |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Full House          |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Small Straight      |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Big Straight        |0               0           0     ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|YAHTZEE             |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Chance              |0               0           " + g5CHANCE + "      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|YAHTZEE Bonus       |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Total Upper SECTION |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|Total Lower SECTION |0               0           0      ");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|____________________|__________________________________");
                                nos1.Add("|       TOTAL        |                0                  ");
                                nos1.Add("|____________________|__________________________________");



                                foreach (string i in nos1)
                                {
                                    Console.WriteLine(i);
                                }
                            }

                            Console.WriteLine("");
                            Console.WriteLine("GAME 6 has FINISHED, please input FF ");
                            Console.WriteLine("__________________________________________________________");
                            Console.ReadKey();
                        }

                    } while (Console.ReadKey().Key != ConsoleKey.F);
                }

            }

            // GAME 6 Finished 
            public static void GAME6_Finished()
            {
                int ACT6 = 0;
                if (Console.ReadKey().Key == ConsoleKey.F)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine("                     GAME 6 HAS FINISHED");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" You have saved the values of ");
                    Console.WriteLine(" ");
                    Console.WriteLine("                    _______________________");
                    Console.WriteLine("                   |" + g6Status[0] + "  Dice 1 =|" + g6Score[0] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[1] + "  Dice 2 =|" + g6Score[1] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[2] + "  Dice 3 =|" + g6Score[2] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[3] + "  Dice 4 =|" + g6Score[3] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[4] + "  Dice 5 =|" + g6Score[4] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("                   |" + g6Status[5] + "  Dice 6 =|" + g6Score[5] + "  |         ");
                    Console.WriteLine("                   |_______________________");
                    Console.WriteLine("___________________________________________________________ ");
                    Console.WriteLine(" input 3 into to ACTIVATE 3ofKind  ");
                    Console.WriteLine(" input 4 into to ACTIVATE 4ofKind  ");
                    Console.WriteLine(" input 5 into to ACTIVATE Full House  ");
                    Console.WriteLine(" input 6 into to ACTIVATE Small Straight  ");
                    Console.WriteLine(" input 7 into to ACTIVATE Big Straight ");
                    Console.WriteLine(" input 8 into to move on ");
                    Console.WriteLine("  ");
                    Console.ReadKey();


                    //ACTIVATOR
                    //3 OF KIND
                    if (Console.ReadKey().Key == ConsoleKey.D3)
                    {
                        Console.WriteLine("  ");
                        ACT6 = 1;
                        g64ofkind[0] = 0;
                        g6FHouse[0] = 0;
                        g6SmallS[0] = 0;
                        g6BigS[0] = 0;
                        //3ofkind

                        //3ofKind
                        if (ACT6 == 0)
                        {
                            g63ofkind[0] = 0;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status || g6Score[1] == 1 && g6Status[1] == g6status && g6Score[2] == 1 && g6Status[2] == g6status || g6Score[3] == 1 && g6Status[3] == g6status && g6Score[4] == 1 && g6Status[4] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 3;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status || g6Score[2] == 1 && g6Status[2] == g6status && g6Score[1] == 1 && g6Status[1] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 3; ;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status || g6Score[3] == 1 && g6Status[3] == g6status && g6Score[1] == 1 && g6Status[1] == g6status || g6Score[2] == 1 && g6Status[2] == g6status && g6Score[4] == 1 && g6Status[4] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 3;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && g6Score[1] == 1 && g6Status[1] == g6status || g6Score[2] == 1 && g6Status[2] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 3;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && g6Score[1] == 1 && g6Status[1] == g6status || g6Score[3] == 1 && g6Status[3] == g6status && g6Score[2] == 1 && g6Status[2] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 3;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status || g6Score[1] == 2 && g6Status[1] == g6status && g6Score[2] == 2 && g6Status[2] == g6status || g6Score[3] == 2 && g6Status[3] == g6status && g6Score[4] == 2 && g6Status[4] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 6;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status || g6Score[2] == 2 && g6Status[2] == g6status && g6Score[1] == 2 && g6Status[1] == g6status || g6Score[4] == 2 && g6Status[4] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 6; ;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status || g6Score[3] == 2 && g6Status[3] == g6status && g6Score[1] == 2 && g6Status[1] == g6status || g6Score[2] == 2 && g6Status[2] == g6status && g6Score[4] == 2 && g6Status[4] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 6;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status || g6Score[4] == 2 && g6Status[4] == g6status && g6Score[1] == 2 && g6Status[1] == g6status || g6Score[2] == 2 && g6Status[2] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 6;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[1] == 2 && g6Status[1] == g6status || g6Score[3] == 2 && g6Status[3] == g6status && g6Score[2] == 2 && g6Status[2] == g6status || g6Score[4] == 2 && g6Status[4] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 6;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status || g6Score[1] == 3 && g6Status[1] == g6status && g6Score[2] == 3 && g6Status[2] == g6status || g6Score[3] == 3 && g6Status[3] == g6status && g6Score[4] == 3 && g6Status[4] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 9;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status || g6Score[2] == 3 && g6Status[2] == g6status && g6Score[1] == 3 && g6Status[1] == g6status || g6Score[4] == 3 && g6Status[4] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 9;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status || g6Score[3] == 3 && g6Status[3] == g6status && g6Score[1] == 3 && g6Status[1] == g6status || g6Score[2] == 3 && g6Status[2] == g6status && g6Score[4] == 3 && g6Status[4] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 9;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status || g6Score[4] == 3 && g6Status[4] == g6status && g6Score[1] == 3 && g6Status[1] == g6status || g6Score[2] == 3 && g6Status[2] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 9;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[1] == 3 && g6Status[1] == g6status || g6Score[3] == 3 && g6Status[3] == g6status && g6Score[2] == 3 && g6Status[2] == g6status || g6Score[4] == 3 && g6Status[4] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 9;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status || g6Score[1] == 4 && g6Status[1] == g6status && g6Score[2] == 4 && g6Status[2] == g6status || g6Score[3] == 4 && g6Status[3] == g6status && g6Score[4] == 4 && g6Status[4] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 12;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status || g6Score[2] == 4 && g6Status[2] == g6status && g6Score[1] == 4 && g6Status[1] == g6status || g6Score[4] == 4 && g6Status[4] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 12;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status || g6Score[3] == 4 && g6Status[3] == g6status && g6Score[1] == 4 && g6Status[1] == g6status || g6Score[2] == 4 && g6Status[2] == g6status && g6Score[4] == 4 && g6Status[4] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 12;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status || g6Score[4] == 4 && g6Status[4] == g6status && g6Score[1] == 4 && g6Status[1] == g6status || g6Score[2] == 4 && g6Status[2] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 12;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[1] == 4 && g6Status[1] == g6status || g6Score[3] == 4 && g6Status[3] == g6status && g6Score[2] == 4 && g6Status[2] == g6status || g6Score[4] == 4 && g6Status[4] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 12;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status || g6Score[1] == 5 && g6Status[1] == g6status && g6Score[2] == 5 && g6Status[2] == g6status || g6Score[3] == 5 && g6Status[3] == g6status && g6Score[4] == 5 && g6Status[4] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 15;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status || g6Score[2] == 5 && g6Status[2] == g6status && g6Score[1] == 5 && g6Status[1] == g6status || g6Score[4] == 5 && g6Status[4] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 15;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status || g6Score[3] == 5 && g6Status[3] == g6status && g6Score[1] == 5 && g6Status[1] == g6status || g6Score[2] == 5 && g6Status[2] == g6status && g6Score[4] == 5 && g6Status[4] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 15;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status || g6Score[4] == 5 && g6Status[4] == g6status && g6Score[1] == 5 && g6Status[1] == g6status || g6Score[2] == 5 && g6Status[2] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 15;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[1] == 5 && g6Status[1] == g6status || g6Score[3] == 5 && g6Status[3] == g6status && g6Score[2] == 5 && g6Status[2] == g6status || g6Score[4] == 5 && g6Status[4] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 15;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status || g6Score[1] == 6 && g6Status[1] == g6status && g6Score[2] == 6 && g6Status[2] == g6status || g6Score[3] == 6 && g6Status[3] == g6status && g6Score[4] == 6 && g6Status[4] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 18;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status || g6Score[2] == 6 && g6Status[2] == g6status && g6Score[1] == 6 && g6Status[1] == g6status || g6Score[4] == 6 && g6Status[4] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 18;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status || g6Score[3] == 6 && g6Status[3] == g6status && g6Score[1] == 6 && g6Status[1] == g6status || g6Score[2] == 6 && g6Status[2] == g6status && g6Score[4] == 6 && g6Status[4] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 18;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status || g6Score[4] == 6 && g6Status[4] == g6status && g6Score[1] == 6 && g6Status[1] == g6status || g6Score[2] == 6 && g6Status[2] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 18;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[1] == 6 && g6Status[1] == g6status || g6Score[3] == 6 && g6Status[3] == g6status && g6Score[2] == 6 && g6Status[2] == g6status || g6Score[4] == 6 && g6Status[4] == g6status && ACT6 == 1)
                        {
                            g63ofkind[0] = 18;
                        }

                    }

                    // 4 OF KIND
                    else if (Console.ReadKey().Key == ConsoleKey.D4)
                    {
                        Console.WriteLine("  ");
                        ACT6 = 2;
                        g63ofkind[0] = 0;
                        g6FHouse[0] = 0;
                        g6SmallS[0] = 0;
                        g6BigS[0] = 0;
                        //4ofkind



                        //4ofKind
                        if (ACT6 == 0)
                        {
                            g64ofkind[0] = 0;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && g6Score[1] == 1 && g6Status[1] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && g6Score[2] == 1 && g6Status[2] == g6status && g6Score[3] == 1 && g6Status[3] == g6status && ACT6 == 2)
                        {
                            g64ofkind[0] = 4;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[1] == 2 && g6Status[1] == g6status || g6Score[4] == 2 && g6Status[4] == g6status && g6Score[2] == 2 && g6Status[2] == g6status && g6Score[3] == 2 && g6Status[3] == g6status && ACT6 == 2)
                        {
                            g64ofkind[0] = 8;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[1] == 3 && g6Status[1] == g6status || g6Score[4] == 3 && g6Status[4] == g6status && g6Score[2] == 3 && g6Status[2] == g6status && g6Score[3] == 3 && g6Status[3] == g6status && ACT6 == 2)
                        {
                            g64ofkind[0] = 12;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[1] == 4 && g6Status[1] == g6status || g6Score[4] == 4 && g6Status[4] == g6status && g6Score[2] == 4 && g6Status[2] == g6status && g6Score[3] == 4 && g6Status[3] == g6status && ACT6 == 2)
                        {
                            g64ofkind[0] = 16;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[1] == 5 && g6Status[1] == g6status || g6Score[4] == 5 && g6Status[4] == g6status && g6Score[2] == 5 && g6Status[2] == g6status && g6Score[3] == 5 && g6Status[3] == g6status && ACT6 == 2)
                        {
                            g64ofkind[0] = 20;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[1] == 6 && g6Status[1] == g6status || g6Score[4] == 6 && g6Status[4] == g6status && g6Score[2] == 6 && g6Status[2] == g6status && g6Score[3] == 6 && g6Status[3] == g6status && ACT6 == 2)
                        {
                            g64ofkind[0] = 24;
                        }

                    }

                    //FULL HOUSE
                    else if (Console.ReadKey().Key == ConsoleKey.D5)
                    {
                        Console.WriteLine("  ");
                        ACT6 = 3;
                        g64ofkind[0] = 0;
                        g63ofkind[0] = 0;
                        g6SmallS[0] = 0;
                        g6BigS[0] = 0;
                        //full house
                        //Full House
                        if (ACT6 == 0)
                        {
                            g6FHouse[0] = 0;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status && g6Score[1] == 1 && g6Status[1] == g6status && g6Score[2] == 1 && g6Status[2] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[4] == 2 && g6Status[4] == g6status && g6Score[5] == 2 && g6Status[5] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 7;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status && g6Score[1] == 1 && g6Status[1] == g6status && g6Score[2] == 1 && g6Status[2] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[4] == 3 && g6Status[4] == g6status && g6Score[5] == 3 && g6Status[5] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 9;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status && g6Score[1] == 1 && g6Status[1] == g6status && g6Score[2] == 1 && g6Status[2] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[4] == 4 && g6Status[4] == g6status && g6Score[5] == 4 && g6Status[5] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 11;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status && g6Score[1] == 1 && g6Status[1] == g6status && g6Score[2] == 1 && g6Status[2] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[4] == 5 && g6Status[4] == g6status && g6Score[5] == 5 && g6Status[5] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 13;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status && g6Score[1] == 1 && g6Status[1] == g6status && g6Score[2] == 1 && g6Status[2] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[4] == 6 && g6Status[4] == g6status && g6Score[5] == 6 && g6Status[5] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 15;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status && g6Score[1] == 2 && g6Status[1] == g6status && g6Score[2] == 2 && g6Status[2] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && g6Score[5] == 1 && g6Status[5] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 8;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status && g6Score[1] == 2 && g6Status[1] == g6status && g6Score[2] == 2 && g6Status[2] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[4] == 3 && g6Status[4] == g6status && g6Score[5] == 3 && g6Status[5] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 12;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status && g6Score[1] == 2 && g6Status[1] == g6status && g6Score[2] == 2 && g6Status[2] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && g6Score[5] == 4 && g6Status[5] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 14;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status && g6Score[1] == 2 && g6Status[1] == g6status && g6Score[2] == 2 && g6Status[2] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[4] == 5 && g6Status[4] == g6status && g6Score[5] == 5 && g6Status[5] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 16;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status && g6Score[1] == 2 && g6Status[1] == g6status && g6Score[2] == 2 && g6Status[2] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[4] == 6 && g6Status[4] == g6status && g6Score[5] == 6 && g6Status[5] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 18;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status && g6Score[1] == 3 && g6Status[1] == g6status && g6Score[2] == 3 && g6Status[2] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && g6Score[5] == 1 && g6Status[5] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 11;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status && g6Score[1] == 3 && g6Status[1] == g6status && g6Score[2] == 3 && g6Status[2] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[4] == 2 && g6Status[4] == g6status && g6Score[5] == 2 && g6Status[5] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 13;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status && g6Score[1] == 3 && g6Status[1] == g6status && g6Score[2] == 3 && g6Status[2] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[4] == 4 && g6Status[4] == g6status && g6Score[5] == 4 && g6Status[5] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 17;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status && g6Score[1] == 3 && g6Status[1] == g6status && g6Score[2] == 3 && g6Status[2] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[4] == 5 && g6Status[4] == g6status && g6Score[5] == 5 && g6Status[5] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 19;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status && g6Score[1] == 3 && g6Status[1] == g6status && g6Score[2] == 3 && g6Status[2] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[4] == 6 && g6Status[4] == g6status && g6Score[5] == 6 && g6Status[5] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 21;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status && g6Score[1] == 4 && g6Status[1] == g6status && g6Score[2] == 4 && g6Status[2] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && g6Score[5] == 1 && g6Status[5] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 14;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status && g6Score[1] == 4 && g6Status[1] == g6status && g6Score[2] == 4 && g6Status[2] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[4] == 2 && g6Status[4] == g6status && g6Score[5] == 2 && g6Status[5] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 16;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status && g6Score[1] == 4 && g6Status[1] == g6status && g6Score[2] == 4 && g6Status[2] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[4] == 3 && g6Status[4] == g6status && g6Score[5] == 3 && g6Status[5] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 18;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status && g6Score[1] == 4 && g6Status[1] == g6status && g6Score[2] == 4 && g6Status[2] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[4] == 5 && g6Status[4] == g6status && g6Score[5] == 5 && g6Status[5] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 22;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status && g6Score[1] == 4 && g6Status[1] == g6status && g6Score[2] == 4 && g6Status[2] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[4] == 6 && g6Status[4] == g6status && g6Score[5] == 6 && g6Status[5] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 24;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status && g6Score[1] == 5 && g6Status[1] == g6status && g6Score[2] == 5 && g6Status[2] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && g6Score[5] == 1 && g6Status[5] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 17;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status && g6Score[1] == 5 && g6Status[1] == g6status && g6Score[2] == 5 && g6Status[2] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[4] == 2 && g6Status[4] == g6status && g6Score[5] == 2 && g6Status[5] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 19;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status && g6Score[1] == 5 && g6Status[1] == g6status && g6Score[2] == 5 && g6Status[2] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[4] == 3 && g6Status[4] == g6status && g6Score[5] == 3 && g6Status[5] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 21;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status && g6Score[1] == 5 && g6Status[1] == g6status && g6Score[2] == 5 && g6Status[2] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[4] == 4 && g6Status[4] == g6status && g6Score[5] == 4 && g6Status[5] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 23;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status && g6Score[1] == 5 && g6Status[1] == g6status && g6Score[2] == 5 && g6Status[2] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[4] == 6 && g6Status[4] == g6status && g6Score[5] == 6 && g6Status[5] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 27;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status && g6Score[1] == 6 && g6Status[1] == g6status && g6Score[2] == 6 && g6Status[2] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[3] == 1 && g6Status[3] == g6status || g6Score[4] == 1 && g6Status[4] == g6status && g6Score[5] == 1 && g6Status[5] == g6status || g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 20;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status && g6Score[1] == 6 && g6Status[1] == g6status && g6Score[2] == 6 && g6Status[2] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[4] == 2 && g6Status[4] == g6status && g6Score[5] == 2 && g6Status[5] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 22;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status && g6Score[1] == 6 && g6Status[1] == g6status && g6Score[2] == 6 && g6Status[2] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[4] == 3 && g6Status[4] == g6status && g6Score[5] == 3 && g6Status[5] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 24;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status && g6Score[1] == 6 && g6Status[1] == g6status && g6Score[2] == 6 && g6Status[2] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[4] == 4 && g6Status[4] == g6status && g6Score[5] == 4 && g6Status[5] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 26;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status && g6Score[1] == 6 && g6Status[1] == g6status && g6Score[2] == 6 && g6Status[2] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[4] == 5 && g6Status[4] == g6status && g6Score[5] == 5 && g6Status[5] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 3)
                        {
                            g6FHouse[0] = 28;
                        }

                    }

                    //SMALL
                    else if (Console.ReadKey().Key == ConsoleKey.D6)
                    {
                        Console.WriteLine("  ");
                        ACT6 = 4;
                        g64ofkind[0] = 0;
                        g63ofkind[0] = 0;
                        g6FHouse[0] = 0;
                        g6BigS[0] = 0;
                        // small

                        //Small straight
                        if (ACT6 == 0)
                        {
                            g6SmallS[0] = 0;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status && g6Score[1] == 5 && g6Status[1] == g6status && g6Status[2] == g6status && g6Score[2] == 4 && g6Score[3] == 3 && g6Status[3] == g6status && g6Score[4] == 2 && g6Status[4] == g6status && g6Score[5] == 1 && g6Status[5] == g6status && ACT6 == 4)
                        {
                            g6SmallS[0] = 21;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status && g6Score[1] == 4 && g6Status[1] == g6status && g6Status[2] == g6status && g6Score[2] == 3 && g6Score[3] == 2 && g6Status[3] == g6status && g6Score[4] == 1 && g6Status[4] == g6status && g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 4)
                        {
                            g6SmallS[0] = 21;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status && g6Score[1] == 3 && g6Status[1] == g6status && g6Status[2] == g6status && g6Score[2] == 2 && g6Score[3] == 1 && g6Status[3] == g6status && g6Score[4] == 6 && g6Status[4] == g6status && g6Score[5] == 5 && g6Status[5] == g6status & ACT6 == 4)
                        {
                            g6SmallS[0] = 21;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status && g6Score[1] == 2 && g6Status[1] == g6status && g6Status[2] == g6status && g6Score[2] == 1 && g6Score[3] == 6 && g6Status[3] == g6status && g6Score[4] == 5 && g6Status[4] == g6status && g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 4)
                        {
                            g6SmallS[0] = 21;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status && g6Score[1] == 1 && g6Status[1] == g6status && g6Status[2] == g6status && g6Score[2] == 6 && g6Score[3] == 5 && g6Status[3] == g6status && g6Score[4] == 4 && g6Status[4] == g6status && g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 4)
                        {
                            g6SmallS[0] = 21;
                        }
                        else if (g6Score[0] == 1 && g6Status[0] == g6status && g6Score[1] == 6 && g6Status[1] == g6status && g6Status[2] == g6status && g6Score[2] == 5 && g6Score[3] == 4 && g6Status[3] == g6status && g6Score[4] == 5 && g6Status[4] == g6status && g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 4)
                        {
                            g6SmallS[0] = 21;
                        }


                    }

                    // BIG
                    else if (Console.ReadKey().Key == ConsoleKey.D7)
                    {
                        Console.WriteLine("  ");
                        ACT6 = 5;
                        g64ofkind[0] = 0;
                        g63ofkind[0] = 0;
                        g6FHouse[0] = 0;
                        g6SmallS[0] = 0;
                        //big



                        // big straight
                        if (ACT6 == 0)
                        {
                            g6BigS[0] = 0;
                        }
                        else if (g6Score[0] == 2 && g6Status[0] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Status[1] == g6status && g6Score[1] == 3 || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[2] == 4 && g6Status[2] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[3] == 5 && g6Status[3] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[4] == 6 && g6Status[4] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && ACT6 == 5)
                        {
                            g6BigS[0] = 20;
                        }
                        else if (g6Score[0] == 3 && g6Status[0] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Status[1] == g6status && g6Score[1] == 4 || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[2] == 5 && g6Status[2] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[3] == 6 && g6Status[3] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[4] == 2 && g6Status[4] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && ACT6 == 5)
                        {
                            g6BigS[0] = 20;
                        }
                        else if (g6Score[0] == 4 && g6Status[0] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Status[1] == g6status && g6Score[1] == 5 || g6Score[5] == 5 && g6Status[5] == g6status && g6Score[2] == 6 && g6Status[2] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[3] == 2 && g6Status[3] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[4] == 3 && g6Status[4] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && ACT6 == 5)
                        {
                            g6BigS[0] = 20;
                        }
                        else if (g6Score[0] == 5 && g6Status[0] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && g6Status[1] == g6status && g6Score[1] == 6 || g6Score[5] == 6 && g6Status[5] == g6status && g6Score[2] == 2 && g6Status[2] == g6status || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[3] == 3 && g6Status[3] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[4] == 4 && g6Status[4] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && ACT6 == 5)
                        {
                            g6BigS[0] = 20;
                        }
                        else if (g6Score[0] == 6 && g6Status[0] == g6status || g6Score[5] == 6 && g6Status[5] == g6status && g6Status[1] == g6status && g6Score[1] == 2 || g6Score[5] == 2 && g6Status[5] == g6status && g6Score[2] == 3 && g6Status[2] == g6status || g6Score[5] == 3 && g6Status[5] == g6status && g6Score[3] == 4 && g6Status[3] == g6status || g6Score[5] == 4 && g6Status[5] == g6status && g6Score[4] == 5 && g6Status[4] == g6status || g6Score[5] == 5 && g6Status[5] == g6status && ACT6 == 5)
                        {
                            g6BigS[0] = 20;
                        }

                    }

                    //MOVE ON
                    else if (Console.ReadKey().Key == ConsoleKey.D8)
                    {
                        Console.WriteLine("  ");
                        ACT6 = 0;
                        g64ofkind[0] = 0;
                        g63ofkind[0] = 0;
                        g6FHouse[0] = 0;
                        g6SmallS[0] = 0;
                        g6BigS[0] = 0;
                        //NULL
                    }


                    // YATZY
                    if (g6Score[0] == 0)
                    {
                        g6YAYZY[0] = 0;
                    }
                    else if (g6Score[0] == 1 && g6Status[0] == g6status && g6Score[1] == 1 && g6Status[1] == g6status && g6Score[2] == 1 && g6Status[2] == g6status && g6Score[3] == 1 && g6Status[3] == g6status && g6Score[4] == 1 && g6Status[4] == g6status && g6Score[5] == 1 && g6Status[5] == g6status)
                    {
                        g6YAYZY[0] = 6;
                    }
                    else if (g6Score[0] == 2 && g6Status[0] == g6status && g6Score[1] == 2 && g6Status[1] == g6status && g6Score[2] == 2 && g6Status[2] == g6status && g6Score[3] == 2 && g6Status[3] == g6status && g6Score[4] == 2 && g6Status[4] == g6status && g6Score[5] == 2 && g6Status[5] == g6status)
                    {
                        g6YAYZY[0] = 12;
                    }
                    else if (g6Score[0] == 3 && g6Status[0] == g6status && g6Score[1] == 3 && g6Status[1] == g6status && g6Score[2] == 3 && g6Status[2] == g6status && g6Score[3] == 3 && g6Status[3] == g6status && g6Score[4] == 3 && g6Status[4] == g6status && g6Score[5] == 3 && g6Status[5] == g6status)
                    {
                        g6YAYZY[0] = 18;
                    }
                    else if (g6Score[0] == 4 && g6Status[0] == g6status && g6Score[1] == 4 && g6Status[1] == g6status && g6Score[2] == 4 && g6Status[2] == g6status && g6Score[3] == 4 && g6Status[3] == g6status && g6Score[4] == 4 && g6Status[4] == g6status && g6Score[5] == 4 && g6Status[5] == g6status)
                    {
                        g6YAYZY[0] = 24;
                    }
                    else if (g6Score[0] == 5 && g6Status[0] == g6status && g6Score[1] == 5 && g6Status[1] == g6status && g6Score[2] == 5 && g6Status[2] == g6status && g6Score[3] == 5 && g6Status[3] == g6status && g6Score[4] == 5 && g6Status[4] == g6status && g6Score[5] == 5 && g6Status[5] == g6status)
                    {
                        g6YAYZY[0] = 30;
                    }
                    else if (g6Score[0] == 6 && g6Status[0] == g6status && g6Score[1] == 6 && g6Status[1] == g6status && g6Score[2] == 6 && g6Status[2] == g6status && g6Score[3] == 6 && g6Status[3] == g6status && g6Score[4] == 6 && g6Status[4] == g6status && g6Score[5] == 6 && g6Status[5] == g6status)
                    {
                        g6YAYZY[0] = 36;
                    }

                    // YATZY BONUS
                    if (g6YAYZY[0] == 0)
                    {
                        g6YAYZYBONUS[0] = 0;
                    }
                    else if (g6YAYZY[0] != 0)
                    {
                        g6YAYZYBONUS[0] = 50;
                    }

                }


                Console.WriteLine(" To view and input values into the Scoreboard,");
                Console.WriteLine(" input SS into the terminal.  ");
                Console.WriteLine("  ");


                Console.ReadKey();

                if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    int TotalLower = g43ofkind[0] + g53ofkind[0] + g63ofkind[0] + g44ofkind[0] + g54ofkind[0] + g64ofkind[0] + g4FHouse[0] + g5FHouse[0] + g6FHouse[0] + g4SmallS[0] + g5SmallS[0] + g6SmallS[0] + g4BigS[0] + g5BigS[0] + g6BigS[0] + g4YAYZYBONUS[0] + g5YAYZYBONUS[0] + g6YAYZYBONUS[0];



                    List<string> nos = new List<string>();
                    nos.Add(" _______________________________________________________");
                    nos.Add("|   Lower SECTION    |   |GAME 4|    |GAME 5|    |GAME 6|");
                    nos.Add("|____________________|___|______|____|______|____|______|");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|3 of a kind         |    " + g43ofkind[0] + "           " + g53ofkind[0] + "           " + g63ofkind[0] + "       ");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|4 of a kind         |    " + g44ofkind[0] + "           " + g54ofkind[0] + "           " + g64ofkind[0] + "       ");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|Full House          |    " + g4FHouse[0] + "           " + g5FHouse[0] + "           " + g6FHouse[0] + "       ");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|Small Straight      |    " + g4SmallS[0] + "           " + g6SmallS[0] + "           " + g6SmallS[0] + "      ");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|Big Straight        |    " + g4BigS[0] + "           " + g5BigS[0] + "           " + g6BigS[0] + "     ");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|YAHTZEE             |    " + g4YAYZY[0] + "           " + g5YAYZY[0] + "           " + g6YAYZY[0] + "       ");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|Chance              |    " + g4CHANCE[0] + "           " + g5CHANCE[0] + "            " + g6CHANCE[0] + "      ");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|YAHTZEE Bonus       |    " + g4YAYZYBONUS[0] + "           " + g5YAYZYBONUS[0] + "           " + g6YAYZYBONUS[0] + "      ");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|____________________|__________________________________");
                    nos.Add("|Total LOWER SECTION |           " + TotalLower + "                  ");
                    nos.Add("|____________________|__________________________________");

                    foreach (string i in nos)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("  ");
                Console.WriteLine(" To FINISH THE WHOÆE GAME, plaese input GG into the terminal.");
                Console.WriteLine("  ");
                Console.ReadKey();
            }


        }

        public class GameResult : Game
        {
            public static void TheEnd()
            {
                int ACE = Aces[0] + Aces[1] + Aces[2] + Aces[3] + Aces[4] + Aces[5];
                int TWO = Twos[0] + Twos[1] + Twos[2] + Twos[2] + Twos[4] + Twos[5];
                int THREE = Thress[0] + Thress[1] + Thress[2] + Thress[3] + Thress[4] + Thress[5];
                int FOUR = Fours[0] + Fours[1] + Fours[2] + Fours[3] + Fours[4] + Fours[5];
                int FIVE = Fives[0] + Fives[1] + Fives[2] + Fives[3] + Fives[4] + Fives[5];
                int SIX = Sixes[0] + Sixes[1] + Sixes[2] + Sixes[3] + Sixes[4] + Sixes[5];
                int g2ACE = g2Aces[0] + g2Aces[1] + g2Aces[2] + g2Aces[3] + g2Aces[4] + g2Aces[5];
                int g2TWO = g2Twos[0] + g2Twos[1] + g2Twos[2] + g2Twos[2] + g2Twos[4] + g2Twos[5];
                int g2THREE = g2Thress[0] + g2Thress[1] + g2Thress[2] + g2Thress[3] + g2Thress[4] + g2Thress[5];
                int g2FOUR = g2Fours[0] + g2Fours[1] + g2Fours[2] + g2Fours[3] + g2Fours[4] + g2Fours[5];
                int g2FIVE = g2Fives[0] + g2Fives[1] + g2Fives[2] + g2Fives[3] + g2Fives[4] + g2Fives[5];
                int g2SIX = g2Sixes[0] + g2Sixes[1] + g2Sixes[2] + g2Sixes[3] + g2Sixes[4] + g2Sixes[5];
                int g3ACE = g3Aces[0] + g3Aces[1] + g3Aces[2] + g3Aces[3] + g3Aces[4] + g3Aces[5];
                int g3TWO = g3Twos[0] + g3Twos[1] + g3Twos[2] + g3Twos[2] + g3Twos[4] + g3Twos[5];
                int g3THREE = g3Thress[0] + g3Thress[1] + g3Thress[2] + g3Thress[3] + g3Thress[4] + g3Thress[5];
                int g3FOUR = g3Fours[0] + g3Fours[1] + g3Fours[2] + g3Fours[3] + g3Fours[4] + g3Fours[5];
                int g3FIVE = g3Fives[0] + g3Fives[1] + g3Fives[2] + g3Fives[3] + g3Fives[4] + g3Fives[5];
                int g3SIX = g3Sixes[0] + g3Sixes[1] + g3Sixes[2] + g3Sixes[3] + g3Sixes[4] + g3Sixes[5];

                int TotalUpper = ACE + g2ACE + g3ACE + TWO + g2TWO + g3TWO + THREE + g2THREE + g3THREE + FOUR + g2FOUR + g3FOUR + FIVE + g2FIVE + g3FIVE + SIX + g2SIX + g3SIX;
                int BonusUpper = 0;
                int TotalLower = g43ofkind[0] + g53ofkind[0] + g63ofkind[0] + g44ofkind[0] + g54ofkind[0] + g64ofkind[0] + g4FHouse[0] + g5FHouse[0] + g6FHouse[0] + g4SmallS[0] + g5SmallS[0] + g6SmallS[0] + g4BigS[0] + g5BigS[0] + g6BigS[0] + g4YAYZYBONUS[0] + g5YAYZYBONUS[0] + g6YAYZYBONUS[0];
                int total = TotalUpper + BonusUpper + TotalLower;
               

                //TJEK
                if (Console.ReadKey().Key == ConsoleKey.G)
                {
                    if (1 == 1)
                    {
                        switch (BonusUpper)
                        {
                            case 1:
                                if (TotalUpper <= 64)
                                {
                                    Console.WriteLine(BonusUpper == 0);
                                };
                                break;

                            case 2:
                                if (TotalUpper >= 65)
                                {
                                    Console.WriteLine(BonusUpper == 50);
                                };
                                break;
                        }

                    }

                    List<string> nos = new List<string>();
                    nos.Add(" _______________________________________________________");
                    nos.Add("|   UPPER SECTION    |   |GAME 1|    |GAME 2|    |GAME 3|");
                    nos.Add("|____________________|___|______|____|______|____|______|");
                    nos.Add("|Aces                |   |" + ACE + "             " + g2ACE + "          " + g3ACE + "     ");
                    nos.Add("|____________________|___|______________________________ ");
                    nos.Add("|Twos                |   |" + TWO + "             " + g2TWO + "          " + g3TWO + "     ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Thress              |   |" + THREE + "             " + g2THREE + "          " + g3THREE + "     ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Fours               |   |" + FOUR + "             " + g2FOUR + "          " + g3FOUR + "     ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Fives               |   |" + FIVE + "             " + g2FIVE + "          " + g3FIVE + "     ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Sixes               |   |" + SIX + "             " + g2SIX + "          " + g3SIX + "     ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Bonus               |   |              " + BonusUpper + "           ");
                    nos.Add("|____________________|___|_______________________________");
                    nos.Add("|Total Score         |   |              " + TotalUpper +" + " + BonusUpper + "                    ");
                    nos.Add("|____________________|___|_______________________________");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|   Lower SECTION    |   |GAME 4|    |GAME 5|    |GAME 6|");
                    nos.Add("|____________________|___|______|____|______|____|______|");
                    nos.Add("|3 of a kind         |   |" + g43ofkind[0] + "             " + g53ofkind[0] + "           " + g63ofkind[0] + "        ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|4 of a kind         |   |" + g44ofkind[0] + "             " + g54ofkind[0] + "           " + g64ofkind[0] + "        ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Full House          |   |" + g4FHouse[0] + "             " + g5FHouse[0] + "           " + g6FHouse[0] + "        ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Small Straight      |   |" + g4SmallS[0] + "             " + g5SmallS[0] + "           " + g6SmallS[0] + "        ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Big Straight        |   |" + g4BigS[0] + "             " + g5BigS[0] + "           " + g6BigS[0] + "       ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|YAHTZEE             |   |" + g4YAYZY[0] + "             " + g5YAYZY[0] + "           " + g6YAYZY[0] + "       ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Chance              |   |" + g4CHANCE +   "  " + g4CHANCE + " " + g4CHANCE + "   "); 
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|YAHTZEE Bonus       |   |" + g4YAYZYBONUS[0] + "             " + g5YAYZYBONUS[0] + "           " + g6YAYZYBONUS[0] + "      ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Total Upper SECTION |   |              " + TotalUpper + " + " + BonusUpper + "    ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|Total Lower SECTION |   |              " + TotalLower + "                    ");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|____________________|___|______________________________");
                    nos.Add("|       TOTAL        |   |              " + total+ "                      ");
                    nos.Add("|____________________|___|______________________________");


                    foreach (string i in nos)
                    {
                        Console.WriteLine(i);
                    }


                    Console.WriteLine("");
                    Console.WriteLine("GAME OVER");
                    Console.Read();







                }

            }
        }
    }
}














                

