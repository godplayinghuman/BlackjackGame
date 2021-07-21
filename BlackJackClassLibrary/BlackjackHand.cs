using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
    public class BlackjackHand : Hand
    {
        public int score { get; set; }
        public bool isDealer = false;

        public BlackjackHand(bool _isDealer = false) : base()
        {
            isDealer = _isDealer;
        }

        public override void AddCard(ICard card)
        {
            base.AddCard(card);

            if (card is BlackJackCard)
            {
                BlackJackCard bjcard = card as BlackJackCard;

                //card is blackjack card, it has score, add score
                if (score + bjcard.Value> 21)
                {
                    // check if the hand contains an ace, if so subtract 10
                    foreach (BlackJackCard cardInHand in _cards)
                    {
                        if (cardInHand.Value == 11 && !cardInHand.aceIsCounted && score + bjcard.Value > 21)
                        {
                            score -= 10;
                            cardInHand.aceIsCounted = true;
                        } // *A* 9 3 10 
                    }
                }
                score += bjcard.Value;
            }


        }

        public override void Draw(int x, int y)
        {
            if (isDealer != true) //hand is a normal hand, draw as normal
            {
                base.Draw(x, y);
            }
            else //hand is dealer, hide first then draw the rest
            {
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("     ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write('\t');

                for (int i = 1; i < _cards.Count; i++)
                {
                    _cards[i].Draw(x + (5 * i), y);
                }
            }


        }


    }
}
