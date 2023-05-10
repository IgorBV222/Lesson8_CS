using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite; 

namespace OperatorOverloading
{
    class Staff
    {
        public Staff()
        {
            this.coins = 0;
            this.name = "Player";
        }
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _coin;

        public int coins
        {
            get { return _coin; }
            set { _coin = value; }
        }
        public static bool operator < (Staff player1, Staff player2)
        {
            return player1._coin < player2._coin;
        }
        public static bool operator > (Staff player1, Staff player2)
        {
            return player1._coin > player2._coin;
        }
        public static Staff operator + (Staff player1, Staff player2)
        {
            Staff sum_player = new Staff();
            sum_player._coin = player1._coin + player2._coin;
            sum_player._name = $"{player1._name} and {player2._name} ";
            return sum_player;
        }
        public static int operator * (Staff player1, Staff player2)
        {
            return player1.coins + player2.coins;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var player01 = new Staff();
            var player02 = new Staff();
            player01.coins = 9;
            player01.name = "Бофур";
            player02.coins = 12;
            player02.name = "Бильбо";
            Console.WriteLine("Игрок {0} - {1} монет\nИгрок {2} - {3} монет", player01.name, player01.coins, player02.name, player02.coins);
            if (player01 > player02)
            {
                Console.WriteLine("Игрок {0} богаче игрока {1}", player01.name, player02.name);
            }
            else
            {
                Console.WriteLine("Игрок {1} богаче игрока {0}", player01.name, player02.name);
            }

        }
    }
}
