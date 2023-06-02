using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_jack_21_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            /*           
            deck.Cards = new List(Card);     
            Card cardOne = new Card();
            cardOne.Face = "Queen";
            cardOne.Suit = "Spades";
            */
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
