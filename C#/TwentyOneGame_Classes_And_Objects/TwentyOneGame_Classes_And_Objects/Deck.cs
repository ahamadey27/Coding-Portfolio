using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
               for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //casting to Face j
                    card.Suit = (Suit)j;
                    Cards.Add(card);

                }
            }
           
        }

        public void Shuffle(int times = 1)
        {
            Random random = new Random();
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
