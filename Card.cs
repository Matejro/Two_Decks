﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwieTalie
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }

}
