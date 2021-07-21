using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJackClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {
      

        [TestMethod()]
        public void AddCardTest()
        {
            BlackjackHand hand = new BlackjackHand();
            hand.AddCard(new BlackJackCard(CardFace.A, CardSuit.Spades));
            hand.AddCard(new BlackJackCard(CardFace._8, CardSuit.Spades));
            Assert.AreEqual(19, hand.score);
            hand.AddCard(new BlackJackCard(CardFace._10, CardSuit.Spades));
            Assert.AreEqual(19, hand.score);

        }


    }
}