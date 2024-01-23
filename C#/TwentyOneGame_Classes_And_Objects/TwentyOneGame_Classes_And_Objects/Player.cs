using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame_Classes_And_Objects
{
    public class Player
    {
        public Player(string name, int beginningBalace) //simple constructor
        {
            Hand = new List<Card>();
            Balance = beginningBalace;
            Name = name; 
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get {return _hand; } set {_hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }
        public bool Stay { get; set; }


        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You don't have enough to place a bet that size!");
                return false; 
            }
            else
            {
                Balance -= amount; //same as balance equals balance minus amount 
                return true; 
            }
        }
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game; 
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game; 
        }
    }
}
