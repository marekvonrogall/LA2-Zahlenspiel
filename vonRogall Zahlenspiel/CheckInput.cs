using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_OOP_Number_Guesser
{
    internal class CheckInput
    {
        public int countGuesses { get; private set; }
        public int numberMin = 1;
        public int numberMax = 100;
        public string greaterLower;
        public List<int> greaterNumbers = new List<int>();
        public List<int> lowerNumbers = new List<int>();
        public List<int> allNumbers = new List<int>();
        public string listGreaterNumbers;
        public string listLowerNumbers;

        public void Reset()
        {
            countGuesses = 0;
            greaterNumbers.Clear();
            lowerNumbers.Clear();
            allNumbers.Clear();
            listGreaterNumbers = "";
            listLowerNumbers = "";
        }

        public int CheckGuess(string userGuess, int secretNumber)
        {

            int value;
            try
            {
                if (int.TryParse(userGuess, out value)) //IS INTEGER?
                {
                    if (Convert.ToInt32(userGuess) >= numberMin && Convert.ToInt32(userGuess) <= numberMax && allNumbers.Contains(Convert.ToInt32(userGuess)) == false) //IS IN RANGE?
                    {
                        countGuesses++;
                        if (Convert.ToInt32(userGuess) == secretNumber) //IS SECRET NUMBER?
                        {
                            return 1; //WON
                        }
                        else
                        {
                            allNumbers.Add(Convert.ToInt32(userGuess));
                            return (checkGreaterLower(userGuess, secretNumber));

                            /*
                            if (multiplayer == true && Convert.ToInt32(boxEnterNumber.Text) != secretNumber)
                            {
                                if (currentPlayer == 1) { currentPlayer = 2; }
                                else { currentPlayer = 1; }
                                whosPlaying();
                            }*/
                        }
                    }
                    else { throw new Exception("Out of range!"); }
                }
                else { throw new Exception("Das ist keine ganze Zahl!"); }
            }
            catch { }
            return 0; //ERROR
        }

        public void RefreshGuesses()
        {
            listLowerNumbers = "";
            listGreaterNumbers = "";


            foreach (int number in greaterNumbers)
            {
                listGreaterNumbers += ", " + number;
            }

            foreach (int number in lowerNumbers)
            {
                listLowerNumbers += ", " + number;
            }

            if (listGreaterNumbers.Length >= 2) { listGreaterNumbers = listGreaterNumbers.Remove(0, 2); }
            if (listLowerNumbers.Length >= 2) { listLowerNumbers = listLowerNumbers.Remove(0, 2); }
        }

        private int checkGreaterLower(string userGuess, int secretNumber)
        {
            if (Convert.ToInt32(userGuess) > secretNumber)
            {
                greaterLower = "grösser";
                greaterNumbers.Add(Convert.ToInt32(userGuess));
                return 3;
            }
            else
            {
                greaterLower = "kleiner";
                lowerNumbers.Add(Convert.ToInt32(userGuess));
                return 2;
            }
        }

        public bool CheckCustomRange(string minNumber, string maxNumber)
        {
            int value;

            if (int.TryParse(maxNumber, out value) && int.TryParse(minNumber, out value))
            {
                if (Convert.ToInt32(minNumber) <= Convert.ToInt32(maxNumber))
                { numberMin = Convert.ToInt32(minNumber); numberMax = Convert.ToInt32(maxNumber); return true; }
            }
            return false;
        }
    }
}
