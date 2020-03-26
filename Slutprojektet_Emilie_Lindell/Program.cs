using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Threading;

namespace Slutprojektet_Emilie_Lindell
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "";
            
            // String- En variabel som kan hålla texter/ord.
            Console.WriteLine("Hello! It's time to make your player. First of choose a name for your player.");

            // Console.writeline - Skriver ut en text.
            while (A.Length < 3 || A.Length > 32 || A.All(char.IsDigit) == true)
            { // While-  En loop som körs om när ex ett kriterium inte uppnås.
                A = Console.ReadLine();
                //Console.readline - exempelvis läser in en string eller används för ett avslutande kommando.
                if (A.Length < 3)
                { // if- Ett sätt att sätta krav, ex “if” detta händer så ger det ett specifikt svar men om det inte sker så blir det en “else”, om man ska ha fler så används else if.
                    Console.WriteLine("Too short!");


                }
                else if (A.Length > 32)
                { //x. length - När man vill sätta en limit på längden av något.
                    Console.WriteLine("Too long!");

                }
                else if (A.All(char.IsDigit) == true)
                { //x.ALL(char.IsDigit)- den kollar om stringen innehåller bara siffror.
                    Console.WriteLine("You can't only use numbers!");

                }
                else
                {
                    Console.WriteLine("Great, let's move on shall we?");

                }
            }

            Thread.Sleep(750);
            Console.Clear();

            Console.WriteLine("Oh hello " + A + ", welcome! ");
            Console.WriteLine("So, imagine that your in a pickup line fight with a hot stranger. It's all about winning with the best pick up lines!");
            Console.WriteLine("");
            Console.WriteLine("Please choose your hot stranger;");

            while ()
            {
                B = Console.ReadLine();

                if (B.Length < 3)
                {
                    Console.WriteLine("Too short!");


                }
                else if (B.Length > 32)
                {
                    Console.WriteLine("Too long!");

                }
                else if (B.All(char.IsDigit) == true)
                {
                    Console.WriteLine("You can't only use numbers!");

                }
                else
                {
                    Console.WriteLine("Great, let's go!");

                }
            }
            Thread.Sleep(750);
            Console.Clear();

            Console.WriteLine("You ready? Get your game on cause it's showtime!");
            Thread.Sleep(1000);
            //Thread.sleep - Hur länge man vill vänta till nästa kommando ska köras. (Klasskompis gav mig denna idé)
            Console.WriteLine("5");
            Thread.Sleep(750);
            Console.WriteLine("4");
            Thread.Sleep(750);
            Console.WriteLine("3");
            Thread.Sleep(750);
            Console.WriteLine("2");
            Thread.Sleep(750);
            Console.WriteLine("1");
            Thread.Sleep(750);
            Console.WriteLine(@"
            ╔═══╦════╦═══╦═══╦════╗
            ║╔═╗║╔╗╔╗║╔═╗║╔═╗║╔╗╔╗║
            ║╚══╬╝║║╚╣║ ║║╚═╝╠╝║║╚╝
            ╚══╗║ ║║ ║╚═╝║╔╗╔╝ ║║  
            ║╚═╝║ ║║ ║╔═╗║║║╚╗ ║║  
            ╚═══╝ ╚╝ ╚╝ ╚╩╝╚═╝ ╚╝ ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("LOADING");
            Thread.Sleep(1000);
            Console.WriteLine("*");
            Thread.Sleep(1000);
            Console.WriteLine("*");
            Thread.Sleep(1000);
            Console.WriteLine("*");
            Thread.Sleep(750);
            Console.Clear();
            Thread.Sleep(750);


            int pl1 = 30;
            
            //int- håller heltal
            Random gen = new Random();
            //Radnom x = new Random - När man vill slumpa mellan exemepelvis tal så blir detta generatorn.

            Console.WriteLine("[You both start with 30 HP each]");
            Console.WriteLine("Go ahead, hit them with your pickup line!");

            while (pl1 >= 0 && pl2 >= 0)
            { // > < - större och mindre än, &&- Betyder basically "och"


                Console.WriteLine("It's your turn!");
                string pickup = "";
                int hpp1 = gen.Next(1, 10);
                int hpp2 = gen.Next(1, 10);
                pl1 -= (hpp1);
                pl2 -= (hpp2);
                pickup = Console.ReadLine();
                if (hpp2 == 5)
                {
                    Console.WriteLine("Okay, a little mediocre maybe?");

                }
                else if (hpp2 == 6)
                {
                    Console.WriteLine("Good one!");

                }
                else if (hpp2 == 7)
                {
                    Console.WriteLine("Oooh, yess!");

                }
                else if (hpp2 == 8)
                {
                    Console.WriteLine("Damn, that's a good one!");

                }
                else if (hpp2 == 9)
                {
                    Console.WriteLine("Ooooh daaaaamn");

                }
                else if (hpp2 == 10)
                {
                    Console.WriteLine("OOOH, PICKUP LINE MASTER!");

                }
                else if (hpp2 == 4)
                {
                    Console.WriteLine("it's okay, not that bad?");

                }
                else
                {
                    Console.WriteLine("Sheesh, better luck next round?");
                }
                Console.WriteLine("Damage: " + hpp2);

                Thread.Sleep(500);
                Console.WriteLine(B + " have " + pl2 + " HP left.");
                Console.WriteLine("");
                Thread.Sleep(750);

                Console.WriteLine(B + ", your turn!");
                Thread.Sleep(1000);
                int pickups;
                string pick = "";
                pickups = new Random().Next(15) + 1;
                switch (pickups)
                { // Switch- Skapade en generator med switch för att få in text. Den väljer slumpmässigt mellan de 15 cases. (Hjälp från internet)
                    case 1:
                        pick = "You are more fun than anyone or anything I know, including bubble wrap.";
                        break;
                    case 2:
                        pick = "They say Disneyland is the happiest place on earth. Well apparently, no one has ever been standing next to you.";
                        break;
                    case 3:
                        pick = "Somebody call the cops, because it’s got to be illegal to look that good!";
                        break;
                    case 4:
                        pick = "It's like you better looking everyday that passes! Amazing!";
                        break;
                    case 5:
                        pick = "Are you religious? Cause you’re the answer to all my prayers.";
                        break;
                    case 6:
                        pick = "There is something wrong with my cell phone. It doesn't have your number in it.";
                        break;
                    case 7:
                        pick = "I must be in a museum, because you truly are a work of art.";
                        break;
                    case 8:
                        pick = "Well, here I am. What were your other two wishes?";
                        break;
                    case 9:
                        pick = "Are you a beaver? Cause daaaaaaaaam!";
                        break;
                    case 10:
                        pick = "I'm no photographer, but I can picture us together.";
                        break;
                    case 11:
                        pick = "Are you a parking ticket? ‘Cause you’ve got fine written all over you.";
                        break;
                    case 12:
                        pick = "Is your name Google? Because you've got everything I'm searching for.";
                        break;
                    case 13:
                        pick = "You're hotter than the bottom of my laptop.";
                        break;
                    case 14:
                        pick = "Do you believe in love at first sight, or should I walk by again?";
                        break;
                    case 15:
                        pick = "You must be a keyboard, because you're just my type.";
                        break;


                }
                Console.WriteLine(pick);
                Console.WriteLine("Damage: " + hpp1);
                Console.WriteLine("You have " + pl1 + " HP left.");
                Console.ReadLine();

            }
            Console.Clear();

            if (pl1 > pl2)
            {
                Console.WriteLine("Congrats, you won the epic pickup line fight with a stranger! Success!");

            }
            else if (pl1 == pl2)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Guess the two of you are on the same level, maybe a date comes next?");

            }
            else
            {
                Console.WriteLine("Better luck next time buddy!");
                Console.WriteLine("Maybe go home and practice a little?");

            }
            Console.ReadLine();


        }
    }
}
