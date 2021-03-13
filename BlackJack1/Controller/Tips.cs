using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack1.Controller
{
    public class Tips
    {
        public Player player;
        public Dealer dealer;
        public static void Insurrance()
        {

        }
        public static void SplitFair()
        {

        }
        public void DoubleDown()
        {

        }
        public void Surrender()
        {
            Dealer dealer = new Dealer();
            Player player = new Player();
            dealer.CheckForWinner();
            if (Status.BlackJack == null && Status.Win == null && Status.Bust == null)
            {
                Console.WriteLine("hhhhhhhhhhhhhhhh");
            }
        }

    }
}
