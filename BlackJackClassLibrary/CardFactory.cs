using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
    public static class CardFactory
    {

        public static ICard CreateCard(CardFace face, CardSuit suit)
        {

            return new Card(face, suit);

        }

        public static ICard CreateBlackjackCard(CardFace face, CardSuit suit)
        {

            return new BlackJackCard(face, suit);
            

        }
        

    }
}
