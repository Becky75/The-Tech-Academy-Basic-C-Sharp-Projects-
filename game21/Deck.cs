using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game21
{
    public class Deck
    {
        public Deck()
        {
            //craetes a deck of cards
            Cards = new List<Card>();
 
            for (int i= 0; i<13; i++)
            {
                for(int j =0; j<4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {

            //this will shuffle deck mulitpule times
            for (int i = 0; i < times; i++)

            {

                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }

                Cards = TempList;

            }



        }
    }
 }
