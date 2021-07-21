﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJackClassLibrary
{
    public interface ICard
    {
        CardFace Face { get; }
        CardSuit Suit { get; }

        void Draw(int x, int y);

    }
}
