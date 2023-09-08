using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_OOP_Number_Guesser
{
    internal class Generate
    {
        public int secretNumber;
        public int startingNumber;
        public void SecretNumber(int numberMin, int numberMax)
        {
            Random number = new Random();
            secretNumber = number.Next(numberMin, numberMax + 1);
        }
        public int Player()
        {
            Random player = new Random();
            return (startingNumber = player.Next(1, 2 + 1));
        }
    }
}
