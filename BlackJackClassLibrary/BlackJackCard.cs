using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
    public class BlackJackCard : Card
    {
        public int Value { get; set; }
        public bool aceIsCounted = false;

        public BlackJackCard(CardFace _face, CardSuit _suit) : base(_face, _suit)
        {
            switch (_face)
            {
                case CardFace.A:
                    Value = 11;
                    break;
                case CardFace._2:
                    Value = 2;
                    break;
                case CardFace._3:
                    Value = 3;
                    break;
                case CardFace._4:
                    Value = 4;
                    break;
                case CardFace._5:
                    Value = 5;
                    break;
                case CardFace._6:
                    Value = 6;
                    break;
                case CardFace._7:
                    Value = 7;
                    break;
                case CardFace._8:
                    Value = 8;
                    break;
                case CardFace._9:
                    Value = 9;
                    break;
                case CardFace._10:
                    Value = 10;
                    break;
                case CardFace._J:
                    Value = 10;
                    break;
                case CardFace._Q:
                    Value = 10;
                    break;
                case CardFace._K:
                    Value = 10;
                    break;
            }
        }






    }
}
