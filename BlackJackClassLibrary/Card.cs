using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
    
    public class Card : ICard
    {
        CardFace cardface;
        CardSuit cardsuit;
        public Card(CardFace face, CardSuit suit)
        {
            Face = face;
            Suit = suit;
        }


        public CardSuit Suit
        {
            get
            {
                return cardsuit;

            }
            private set
            {
                cardsuit = value;
            }

        }
        public CardFace Face
        {
            get
            {
                return cardface;

            }
            private set
            {
                cardface = value;
            }

        }

        public void Draw(int x, int y)
        {

            //Changes colors appropriately
            Console.BackgroundColor = ConsoleColor.White;
            if (Suit == CardSuit.Hearts || Suit == CardSuit.Diamonds)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            } else {
                Console.ForegroundColor = ConsoleColor.Black;
            }

            char suitToWrite;
            switch (Suit)
            {
                case CardSuit.Spades:
                    suitToWrite = '\u2660';
                    break;
                case CardSuit.Hearts:
                    suitToWrite = '\u2665';
                    break;
                case CardSuit.Clubs:
                    suitToWrite = '\u2663';
                    break;
                default:
                    suitToWrite = '\u2666';
                    break;
            }

            Console.Write(suitToWrite + " " + cardface);

            //Reset colors
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //Add a gap between cards

            Console.Write('\t');

        }

    }
}
