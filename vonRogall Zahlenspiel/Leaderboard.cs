using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_OOP_Number_Guesser
{
    internal class Leaderboard
    {
        public bool multiplayer;
        public int points;
        public string gamemode;
        public string usernameCurrentPlayer;
        public string username1 = "DefaultPlayer1Name";
        public string username2 = "DefaultPlayer2Name";
        public int startingPlayer = 1;

        public void calculateLeaderboard(int countGuesses, int numberMin, int numberMax)
        {
            points = (numberMax - numberMin) / countGuesses;
            if (multiplayer == true) { gamemode = "2P"; }
            else { gamemode = "1P"; }
        }

        public void currentPlayer(int startingPlayer, int countGuesses)
        {
            int currentlyPlaying = (startingPlayer + countGuesses) % 2;
            switch (currentlyPlaying)
            {
                case 0:
                    usernameCurrentPlayer = username2;
                    break;
                case 1:
                    usernameCurrentPlayer = username1;
                    break;
            }
        }

        public void selectStartingPlayer(System.Windows.Forms.ComboBox comboBox)
        {
            Generate generate = new Generate();
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    startingPlayer = generate.Player();
                    break;
                case 1:
                    startingPlayer = 1;
                    break;
                case 2:
                    startingPlayer = 2;
                    break;
            }
        }

        public void usernamesChanged(System.Windows.Forms.TextBox nameBox)
        {
            if (nameBox.Name == "textBoxNamePlayer1") { username1 = nameBox.Text; }
            else { username2 = nameBox.Text; }
        }

        public void setGamemode(System.Windows.Forms.RadioButton getRadioButton)
        {
            if (getRadioButton.Name == "radioMultiplayer" && getRadioButton.Checked == true) { multiplayer = true; }
            else { multiplayer = false; usernameCurrentPlayer = username1; startingPlayer = 1; }
        }
    }
}
