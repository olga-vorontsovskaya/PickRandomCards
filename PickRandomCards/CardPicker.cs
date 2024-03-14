using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }
        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
        private static string RandomSuit()
        {
            // get random number from 1 to 3
            int value = random.Next(1, 5);
            // if it is 1
            if (value == 1) return "Spades";
            // if it is 2
            if (value == 2) return "Hearts";
            // if it is 3
            if (value == 3) return "Clubs";
            // if execution is continues, then return string Diamonds
            return "Diamonds";
        }
    }
}
