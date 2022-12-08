using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro.Models
{
    internal class Player
    {
        public string Name { get; set; }
        public int Luck { get; set; }
        public int Morale { get; set; }
        public int Balance { get; set; }

        public int ToDice()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);

        }

        public bool PlaceABet()
        {
           if(Balance<100)
            {
                MessageBox.Show("Sorry,There is no Balance to Bet");
                return false;
            }
            else
            {
                Balance -= 100;
                return true;
            }

        }

    }
}
