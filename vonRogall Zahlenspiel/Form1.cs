using LA_OOP_Number_Guesser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vonRogall_Zahlenspiel
{
    public partial class Form1 : Form
    {
        Generate generate = new Generate();
        CheckInput userInput = new CheckInput();
        Leaderboard score = new Leaderboard();

        public Form1()
        {
            InitializeComponent();
            gameInterface.Hide();
            labelInfoOptions.Hide();
            comboBoxStartingPlayer.SelectedIndex = 0;
            buttonStyle();
        }

        private void Reset()
        {
            userInput.Reset();
            labelInfo.Text = "warten auf Input...";
            textBoxUserInput.Text = "";
            labelCountGuesses.Text = "Aktuelle Rateversuche: 0";
            boxLowerNumbers.Text = "";
            boxGreaterNumbers.Text = "";
            generate.SecretNumber(userInput.numberMin, userInput.numberMax);
            if (score.multiplayer == true) { score.selectStartingPlayer(this.comboBoxStartingPlayer); }
            score.currentPlayer(score.startingPlayer, userInput.countGuesses);
            labelCurrentPlayer.Text = "Spieler " + score.usernameCurrentPlayer + " ist dran.";
        }

        private void buttonGuess_Click(object sender, EventArgs e) { Guess(); }

        private void Guess()
        {
            switch (userInput.CheckGuess(textBoxUserInput.Text, generate.secretNumber))
            {
                case 0:
                    labelInfo.Text = "Fehlerhafte Eingabe getätigt."; //error
                    break;
                case 1:
                    gameWon(); //won
                    break;
                case 2:
                    labelInfo.Text = textBoxUserInput.Text + " ist kleiner als die gesuchte Zahl"; //userInput kleiner
                    if (score.multiplayer == true) { score.currentPlayer(score.startingPlayer, userInput.countGuesses); } //WER HAT DIESE EINGABE GETÄTIGT
                    labelCurrentPlayer.Text = "Spieler " + score.usernameCurrentPlayer + " ist dran.";
                    break;
                case 3:
                    labelInfo.Text = textBoxUserInput.Text + " ist grösser als die gesuchte Zahl"; //userInput grösser
                    if (score.multiplayer == true) { score.currentPlayer(score.startingPlayer, userInput.countGuesses); } //WER HAT DIESE EINGABE GETÄTIGT
                    labelCurrentPlayer.Text = "Spieler " + score.usernameCurrentPlayer + " ist dran.";
                    break;
            }

            labelCountGuesses.Text = "Aktuelle Rateversuche: " + userInput.countGuesses;

            userInput.RefreshGuesses();
            boxGreaterNumbers.Text = userInput.listGreaterNumbers;
            boxLowerNumbers.Text = userInput.listLowerNumbers;
        }
        private void gameWon()
        {
            score.calculateLeaderboard(userInput.countGuesses, userInput.numberMin, userInput.numberMax);

            labelInfo.Text = score.usernameCurrentPlayer + " hat die Zahl erraten.";
            labelCurrentPlayer.Text = score.usernameCurrentPlayer + " hat gewonnen und hat " + score.points + " Punkt(e) erzielt!";
            buttonAgain.Enabled = true;
            gridViewLeaderboard.Rows.Add("...", score.usernameCurrentPlayer, score.gamemode, userInput.countGuesses, generate.secretNumber, userInput.numberMin + " - " + userInput.numberMax, score.points);
            gridViewLeaderboard.Sort(this.gridViewLeaderboard.Columns["leaderboardPoints"], ListSortDirection.Descending);
            for (int i = 0; i < gridViewLeaderboard.Rows.Count; i++)
            {
                gridViewLeaderboard.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            labelCustomRangeForm.Text = textBoxMinNumber.Text + " - " + textBoxMaxNumber.Text;
            if (score.multiplayer == true) { score.selectStartingPlayer(this.comboBoxStartingPlayer); }
            score.currentPlayer(score.startingPlayer, userInput.countGuesses);
            labelCurrentPlayer.Text = "Spieler " + score.usernameCurrentPlayer + " ist dran.";
            gameInterface.Show();
            groupBoxOptions.Enabled = false;
            labelInfoOptions.Show();
            buttonAgain.Enabled = false;
            generate.SecretNumber(userInput.numberMin, userInput.numberMax);
            textBoxNamePlayer1.Enabled = false;
            labelNamePlayer1.Enabled = false;
            textBoxNamePlayer2.Enabled = false;
            labelNamePlayer2.Enabled = false;
            buttonBack.Enabled = true;
        }

        private void CustomRangeFalse(object sender, EventArgs e) { textBoxMinNumber.Enabled = false; textBoxMaxNumber.Enabled = false; userInput.numberMin = 1; userInput.numberMax = 100; labelCustomRangeForm.Text = "1-100"; }
        private void CustomRangeTrue(object sender, EventArgs e) { textBoxMinNumber.Enabled = true; textBoxMaxNumber.Enabled = true; userInput.CheckCustomRange(textBoxMinNumber.Text, textBoxMaxNumber.Text); }

        private void MinChanged(object sender, EventArgs e)
        {
            if (userInput.CheckCustomRange(textBoxMinNumber.Text, textBoxMaxNumber.Text) == true) { EnablePlayButton(); }
            else { DisablePlayButton(); }
        }

        private void MaxChanged(object sender, EventArgs e)
        {
            if (userInput.CheckCustomRange(textBoxMinNumber.Text, textBoxMaxNumber.Text) == true) { EnablePlayButton(); }
            else { DisablePlayButton(); }
        }
        private void DisablePlayButton()
        {
            buttonPlay.Enabled = false; buttonPlay.Text = "Ungültige Einstellungen: Spielen nicht möglich.";
            buttonPlay.BackColor = Color.Salmon;
        }

        private void EnablePlayButton()
        {
            buttonPlay.Enabled = true; buttonPlay.Text = "Spiel beginnen";
            buttonPlay.BackColor = Color.PaleGreen;
        }

        private void buttonStyle()
        {
            buttonAgain.Enabled = false;
            buttonBack.Enabled = false;
            if (score.multiplayer == true)
            {
                this.buttonPlay.Size = new Size(130, 104);
                textBoxNamePlayer2.Enabled = true;
                labelNamePlayer2.Enabled = true;
            }
            else
            {
                this.buttonPlay.Size = new Size(130, 130);
                textBoxNamePlayer2.Enabled = false;
                labelNamePlayer2.Enabled = false;
            }
        }

        private void radioMultiplayer_CheckedChanged(object sender, EventArgs e) { score.setGamemode(this.radioMultiplayer); buttonStyle(); }
        private void radioSingleplayer_CheckedChanged(object sender, EventArgs e) { score.setGamemode(this.radioSingleplayer); buttonStyle(); }
        private void namePlayer1Changed(object sender, EventArgs e) { score.usernamesChanged(this.textBoxNamePlayer1); }
        private void namePlayer2Changed(object sender, EventArgs e) { score.usernamesChanged(this.textBoxNamePlayer2); }

        private void EnterPressedGuess(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Guess(); }
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            groupBoxOptions.Hide();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            groupBoxOptions.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            gameInterface.Hide();
            groupBoxOptions.Enabled = true;
            labelInfoOptions.Hide();
            textBoxNamePlayer1.Enabled = true;
            labelNamePlayer1.Enabled = true;
            textBoxNamePlayer2.Enabled = true;
            labelNamePlayer2.Enabled = true;
            Reset();
            buttonBack.Enabled = false;
        }

        private void buttonAgain_Click(object sender, EventArgs e)
        {
            buttonAgain.Enabled = false;
            Reset();
        }
    }
}
