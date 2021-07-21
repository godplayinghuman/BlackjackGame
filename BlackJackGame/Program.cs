﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackClassLibrary;

namespace BlackJackGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            string[] menuChoices =
           {
                //string of menu choices for the menu
                "Play BlackJack",
                "Shuffle and Show Deck",
                "Exit",
            };

            int menuSelection = 0;
            //var to hold selection
            var deck = new Deck();
            Hand player = new Hand();
            Hand dealer = new Hand();

            while (menuSelection != 3)
            {
                ReadChoice("Select an option:", menuChoices, out menuSelection);
                switch (menuSelection)
                {
                    case 1:
                        //Play Blackjack

                        int playerStart = 1;

                        while (playerStart != 2)
                        {
                            //play




                            ReadChoice("Play again?", new string[] { "Yes", "No\t" }, out playerStart);
                        }


                        break;
                    case 2:
                        //Shuffle and show deck
                        deck.Shuffle();
                        var temp = new BlackjackHand(true);
                        for (int i = 0; i < 52; i++)
                        {
                            ICard card = deck.Deal();
                            //Console.WriteLine(card.Suit + " " + card.Face);
                            temp.AddCard(card);
                        }
                        
                        temp.Draw(Console.CursorLeft, Console.CursorTop);

                        Console.ReadKey(false);

                        break;
                }


            }
        }
        public static int ReadInteger(string prompt, int min, int max)
        {
            int outPut;
            Console.WriteLine(prompt);
            string number = Console.ReadLine();
            //here i could declare "int" after out & remove line 137
            bool test = Int32.TryParse(number, out outPut);
            //here we are parsing number since Console.Read can only initially accept strings
            while (test == false && outPut > min && outPut < max)
            {
                Console.WriteLine("Enter a valid int: ");
                number = Console.ReadLine();
                test = Int32.TryParse(number, out outPut);
                //loops while test = false  to ensure user input is an integer
            }
            return outPut;
            //returns outPut once test is = to true and the user input is an integer
        }

        public static void ReadString(string prompt, ref string outPut)
        {
            Console.WriteLine(prompt);
            outPut = Console.ReadLine();
            //writes prompt, sets outPut = to user input
        }

        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            Console.WriteLine(prompt);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
                //{i} writes numbers for all the options, for goes through the array of options
            }
            selection = ReadInteger("Please select an option: ", 1, options.Length);
            //sets selection = to the user selection

            
        }


    }
}
