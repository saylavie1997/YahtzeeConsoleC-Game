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
    class Program
    {
        static void Main(string[] args)
        {
            //Methods from Terminal_Input
            Terminal_Input.User_name.YathzeeUserName();
            Terminal_Input.Rulebook.YathzeeRules();
            Terminal_Input.DiceSelection.YathzeeChooseDiceType();

            //Methods from GAME
            Game.Game1.ROUND1();
            Game.Game1.ROUND2();
            Game.Game1.ROUND3();
            Game.Game1.GAME1_Finished();
            Game.Game2.ROUND1();
            Game.Game2.ROUND2();
            Game.Game2.ROUND3();
            Game.Game2.GAME2_Finished();
            Game.Game3.ROUND1();
            Game.Game3.ROUND2();
            Game.Game3.ROUND3();
            Game.Game3.GAME3_Finished();
            Terminal_Input.DiceCombinations();
            Game.Game4.ROUND1();
            Game.Game4.ROUND2();
            Game.Game4.ROUND3();
            Game.Game4.GAME4_Finished();
            Game.Game5.ROUND1();
            Game.Game5.ROUND2();
            Game.Game5.ROUND3();
            Game.Game5.GAME5_Finished();
            Game.Game6.ROUND1();
            Game.Game6.ROUND2();
            Game.Game6.ROUND3();
            Game.Game6.GAME6_Finished();
            Game.GameResult.TheEnd();

        }
    }
}
