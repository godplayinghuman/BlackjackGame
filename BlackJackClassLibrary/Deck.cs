using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
    public class Deck
    {
        List<ICard> _cards = new List<ICard>();

        public Deck()
        {
            CreateDeck();
        }
        public ICard Deal()
        {
            if (_cards.Count <= 0)
            {
                CreateDeck();
            }
            var cardToDeal = _cards[0];
            _cards.Remove(cardToDeal);
            return cardToDeal;
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            int i = _cards.Count;
            while (i > 1)
            {
                i--;
                int k = rnd.Next(i + 1);
                ICard value = _cards[k];
                _cards[k] = _cards[i];
                _cards[i] = value;
            }
         

        }
        private void CreateDeck()
        {
            foreach (CardFace face in Enum.GetValues(typeof(CardFace)))
            {
                foreach(CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    _cards.Add(CardFactory.CreateBlackjackCard(face, suit));
                }
            }

        }

    }
}
