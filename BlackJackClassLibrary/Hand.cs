using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
    public class Hand
    {
        protected List<ICard> _cards = new List<ICard>();
        
        public virtual void AddCard(ICard card)
        {
            _cards.Add(card);
        }

        public virtual void Draw(int x, int y)
        {
           
                for (int i = 0; i < _cards.Count; i++)
                {
                    _cards[i].Draw(x + (5*i), y);
                }
            
        }

    }
}
