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
            Twenty_One_Game game = new Twenty_One_Game();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            Game.ListPlayers();
            Console.ReadLine();


            //Game game = new Twenty_One_Game();

            /*List<Game> games = new List<Game>();
            Twenty_One_Game game = new Twenty_One_Game();
            games.Add(game);

            Game game = new Game();
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0}, timesShuffled");
            Console.ReadLine();
            */
            /*Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);*/

            /*
            Twenty_One_Game game = new Twenty_One_Game();
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();
            */

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            /*Game game = new Game();
            game.Dealer = "Jesse";
            game.Name = "TwentyOne";
            Deck deck = new Deck();
            deck.Shuffle(3);
            */


            /*           
            deck.Cards = new List(Card);     
            Card cardOne = new Card();
            cardOne.Face = "Queen";
            cardOne.Suit = "Spades";
            */

        }
        /*
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
                return deck;
            }
        }
        */
    }
}
