namespace vonRogall_Zahlenspiel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.backGroundBox = new System.Windows.Forms.PictureBox();
            this.SidePanelBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonLeaderboard = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.labelEnterNumber = new System.Windows.Forms.Label();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.labelLowerNumbers = new System.Windows.Forms.Label();
            this.labelGreaterNumbers = new System.Windows.Forms.Label();
            this.boxGreaterNumbers = new System.Windows.Forms.RichTextBox();
            this.boxLowerNumbers = new System.Windows.Forms.RichTextBox();
            this.labelCustomRangeForm = new System.Windows.Forms.Label();
            this.labelCustomRangeFormTitle = new System.Windows.Forms.Label();
            this.labelCountGuesses = new System.Windows.Forms.Label();
            this.labelCurrentPlayer = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelCustomNumberRange = new System.Windows.Forms.Panel();
            this.labelMaxNumber = new System.Windows.Forms.Label();
            this.labelMinNumber = new System.Windows.Forms.Label();
            this.textBoxMaxNumber = new System.Windows.Forms.TextBox();
            this.textBoxMinNumber = new System.Windows.Forms.TextBox();
            this.labelCustomRange = new System.Windows.Forms.Label();
            this.radioCustomRangeNo = new System.Windows.Forms.RadioButton();
            this.radioCustomRangeTrue = new System.Windows.Forms.RadioButton();
            this.radioMultiplayer = new System.Windows.Forms.RadioButton();
            this.radioSingleplayer = new System.Windows.Forms.RadioButton();
            this.panelGamemode = new System.Windows.Forms.Panel();
            this.labelGamemode = new System.Windows.Forms.Label();
            this.labelNamePlayer1 = new System.Windows.Forms.Label();
            this.textBoxNamePlayer1 = new System.Windows.Forms.TextBox();
            this.labelNamePlayer2 = new System.Windows.Forms.Label();
            this.textBoxNamePlayer2 = new System.Windows.Forms.TextBox();
            this.labelInfoOptions = new System.Windows.Forms.Label();
            this.labelLeaderboard = new System.Windows.Forms.Label();
            this.gridViewLeaderboard = new System.Windows.Forms.DataGridView();
            this.leaderboardRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderboardUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderboardGamemode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderboardCountGuesses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderboardSecretNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderboardNumberRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaderboardPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxOptions = new System.Windows.Forms.Panel();
            this.gameInterface = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.comboBoxStartingPlayer = new System.Windows.Forms.ComboBox();
            this.labelZahlenspiel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidePanelBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCustomNumberRange.SuspendLayout();
            this.panelGamemode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLeaderboard)).BeginInit();
            this.groupBoxOptions.SuspendLayout();
            this.gameInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // backGroundBox
            // 
            this.backGroundBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.backGroundBox.Location = new System.Drawing.Point(0, 0);
            this.backGroundBox.Name = "backGroundBox";
            this.backGroundBox.Size = new System.Drawing.Size(1314, 667);
            this.backGroundBox.TabIndex = 0;
            this.backGroundBox.TabStop = false;
            // 
            // SidePanelBoxLeft
            // 
            this.SidePanelBoxLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.SidePanelBoxLeft.Location = new System.Drawing.Point(0, 0);
            this.SidePanelBoxLeft.Name = "SidePanelBoxLeft";
            this.SidePanelBoxLeft.Size = new System.Drawing.Size(200, 667);
            this.SidePanelBoxLeft.TabIndex = 1;
            this.SidePanelBoxLeft.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.pictureBox1.Location = new System.Drawing.Point(225, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 255);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.pictureBox2.Location = new System.Drawing.Point(225, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1062, 332);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Location = new System.Drawing.Point(36, 185);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(130, 130);
            this.buttonOptions.TabIndex = 6;
            this.buttonOptions.Text = "Optionen";
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonLeaderboard
            // 
            this.buttonLeaderboard.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeaderboard.Location = new System.Drawing.Point(36, 25);
            this.buttonLeaderboard.Name = "buttonLeaderboard";
            this.buttonLeaderboard.Size = new System.Drawing.Size(130, 130);
            this.buttonLeaderboard.TabIndex = 7;
            this.buttonLeaderboard.Text = "Leaderboard";
            this.buttonLeaderboard.UseVisualStyleBackColor = false;
            this.buttonLeaderboard.Click += new System.EventHandler(this.buttonLeaderboard_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Location = new System.Drawing.Point(36, 347);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(130, 104);
            this.buttonPlay.TabIndex = 8;
            this.buttonPlay.Text = "Spiel starten";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.MistyRose;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(36, 513);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(130, 130);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Beenden";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonGuess
            // 
            this.buttonGuess.BackColor = System.Drawing.Color.Snow;
            this.buttonGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGuess.Location = new System.Drawing.Point(729, 46);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(309, 27);
            this.buttonGuess.TabIndex = 12;
            this.buttonGuess.Text = "Raten!";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.AutoSize = true;
            this.labelEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEnterNumber.ForeColor = System.Drawing.Color.White;
            this.labelEnterNumber.Location = new System.Drawing.Point(725, 20);
            this.labelEnterNumber.Name = "labelEnterNumber";
            this.labelEnterNumber.Size = new System.Drawing.Size(211, 20);
            this.labelEnterNumber.TabIndex = 11;
            this.labelEnterNumber.Text = "Geben Sie hier Ihre Zahl ein:";
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.textBoxUserInput.Location = new System.Drawing.Point(942, 20);
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(96, 20);
            this.textBoxUserInput.TabIndex = 2;
            this.textBoxUserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterPressedGuess);
            // 
            // labelLowerNumbers
            // 
            this.labelLowerNumbers.AutoSize = true;
            this.labelLowerNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLowerNumbers.ForeColor = System.Drawing.Color.White;
            this.labelLowerNumbers.Location = new System.Drawing.Point(24, 135);
            this.labelLowerNumbers.Name = "labelLowerNumbers";
            this.labelLowerNumbers.Size = new System.Drawing.Size(328, 20);
            this.labelLowerNumbers.TabIndex = 6;
            this.labelLowerNumbers.Text = "Zahlen, die kleiner sind als die geuschte Zahl:";
            // 
            // labelGreaterNumbers
            // 
            this.labelGreaterNumbers.AutoSize = true;
            this.labelGreaterNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelGreaterNumbers.ForeColor = System.Drawing.Color.White;
            this.labelGreaterNumbers.Location = new System.Drawing.Point(380, 135);
            this.labelGreaterNumbers.Name = "labelGreaterNumbers";
            this.labelGreaterNumbers.Size = new System.Drawing.Size(335, 20);
            this.labelGreaterNumbers.TabIndex = 5;
            this.labelGreaterNumbers.Text = "Zahlen, die grösser sind als die geuschte Zahl:";
            // 
            // boxGreaterNumbers
            // 
            this.boxGreaterNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.boxGreaterNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.boxGreaterNumbers.ForeColor = System.Drawing.Color.White;
            this.boxGreaterNumbers.Location = new System.Drawing.Point(384, 158);
            this.boxGreaterNumbers.Name = "boxGreaterNumbers";
            this.boxGreaterNumbers.Size = new System.Drawing.Size(335, 156);
            this.boxGreaterNumbers.TabIndex = 4;
            this.boxGreaterNumbers.Text = "";
            // 
            // boxLowerNumbers
            // 
            this.boxLowerNumbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.boxLowerNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.boxLowerNumbers.ForeColor = System.Drawing.Color.White;
            this.boxLowerNumbers.Location = new System.Drawing.Point(26, 158);
            this.boxLowerNumbers.Name = "boxLowerNumbers";
            this.boxLowerNumbers.Size = new System.Drawing.Size(335, 156);
            this.boxLowerNumbers.TabIndex = 3;
            this.boxLowerNumbers.Text = "";
            // 
            // labelCustomRangeForm
            // 
            this.labelCustomRangeForm.AutoSize = true;
            this.labelCustomRangeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCustomRangeForm.ForeColor = System.Drawing.Color.White;
            this.labelCustomRangeForm.Location = new System.Drawing.Point(18, 46);
            this.labelCustomRangeForm.Name = "labelCustomRangeForm";
            this.labelCustomRangeForm.Size = new System.Drawing.Size(58, 20);
            this.labelCustomRangeForm.TabIndex = 17;
            this.labelCustomRangeForm.Text = "1 - 100";
            // 
            // labelCustomRangeFormTitle
            // 
            this.labelCustomRangeFormTitle.AutoSize = true;
            this.labelCustomRangeFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelCustomRangeFormTitle.ForeColor = System.Drawing.Color.White;
            this.labelCustomRangeFormTitle.Location = new System.Drawing.Point(19, 22);
            this.labelCustomRangeFormTitle.Name = "labelCustomRangeFormTitle";
            this.labelCustomRangeFormTitle.Size = new System.Drawing.Size(237, 24);
            this.labelCustomRangeFormTitle.TabIndex = 16;
            this.labelCustomRangeFormTitle.Text = "Gesetzte Zahlenspanne:";
            // 
            // labelCountGuesses
            // 
            this.labelCountGuesses.AutoSize = true;
            this.labelCountGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCountGuesses.ForeColor = System.Drawing.Color.White;
            this.labelCountGuesses.Location = new System.Drawing.Point(19, 98);
            this.labelCountGuesses.Name = "labelCountGuesses";
            this.labelCountGuesses.Size = new System.Drawing.Size(186, 20);
            this.labelCountGuesses.TabIndex = 15;
            this.labelCountGuesses.Text = "Aktuelle Rateversuche: 0";
            // 
            // labelCurrentPlayer
            // 
            this.labelCurrentPlayer.AutoSize = true;
            this.labelCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelCurrentPlayer.ForeColor = System.Drawing.Color.White;
            this.labelCurrentPlayer.Location = new System.Drawing.Point(19, 74);
            this.labelCurrentPlayer.Name = "labelCurrentPlayer";
            this.labelCurrentPlayer.Size = new System.Drawing.Size(256, 24);
            this.labelCurrentPlayer.TabIndex = 14;
            this.labelCurrentPlayer.Text = "Spieler X ist an der Reihe.";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(725, 76);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(137, 20);
            this.labelInfo.TabIndex = 13;
            this.labelInfo.Text = "warten auf Input...";
            // 
            // panelCustomNumberRange
            // 
            this.panelCustomNumberRange.Controls.Add(this.labelMaxNumber);
            this.panelCustomNumberRange.Controls.Add(this.labelMinNumber);
            this.panelCustomNumberRange.Controls.Add(this.textBoxMaxNumber);
            this.panelCustomNumberRange.Controls.Add(this.textBoxMinNumber);
            this.panelCustomNumberRange.Controls.Add(this.labelCustomRange);
            this.panelCustomNumberRange.Controls.Add(this.radioCustomRangeNo);
            this.panelCustomNumberRange.Controls.Add(this.radioCustomRangeTrue);
            this.panelCustomNumberRange.Location = new System.Drawing.Point(198, 23);
            this.panelCustomNumberRange.Name = "panelCustomNumberRange";
            this.panelCustomNumberRange.Size = new System.Drawing.Size(667, 120);
            this.panelCustomNumberRange.TabIndex = 11;
            // 
            // labelMaxNumber
            // 
            this.labelMaxNumber.AutoSize = true;
            this.labelMaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMaxNumber.ForeColor = System.Drawing.Color.White;
            this.labelMaxNumber.Location = new System.Drawing.Point(220, 67);
            this.labelMaxNumber.Name = "labelMaxNumber";
            this.labelMaxNumber.Size = new System.Drawing.Size(42, 20);
            this.labelMaxNumber.TabIndex = 11;
            this.labelMaxNumber.Text = "Max:";
            // 
            // labelMinNumber
            // 
            this.labelMinNumber.AutoSize = true;
            this.labelMinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMinNumber.ForeColor = System.Drawing.Color.White;
            this.labelMinNumber.Location = new System.Drawing.Point(220, 40);
            this.labelMinNumber.Name = "labelMinNumber";
            this.labelMinNumber.Size = new System.Drawing.Size(38, 20);
            this.labelMinNumber.TabIndex = 10;
            this.labelMinNumber.Text = "Min:";
            // 
            // textBoxMaxNumber
            // 
            this.textBoxMaxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.textBoxMaxNumber.Enabled = false;
            this.textBoxMaxNumber.Location = new System.Drawing.Point(278, 67);
            this.textBoxMaxNumber.Name = "textBoxMaxNumber";
            this.textBoxMaxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxNumber.TabIndex = 9;
            this.textBoxMaxNumber.Text = "100";
            this.textBoxMaxNumber.TextChanged += new System.EventHandler(this.MaxChanged);
            // 
            // textBoxMinNumber
            // 
            this.textBoxMinNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.textBoxMinNumber.Enabled = false;
            this.textBoxMinNumber.Location = new System.Drawing.Point(278, 40);
            this.textBoxMinNumber.Name = "textBoxMinNumber";
            this.textBoxMinNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinNumber.TabIndex = 8;
            this.textBoxMinNumber.Text = "1";
            this.textBoxMinNumber.TextChanged += new System.EventHandler(this.MinChanged);
            // 
            // labelCustomRange
            // 
            this.labelCustomRange.AutoSize = true;
            this.labelCustomRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomRange.ForeColor = System.Drawing.Color.White;
            this.labelCustomRange.Location = new System.Drawing.Point(51, 6);
            this.labelCustomRange.Name = "labelCustomRange";
            this.labelCustomRange.Size = new System.Drawing.Size(362, 24);
            this.labelCustomRange.TabIndex = 7;
            this.labelCustomRange.Text = "Eigene Zahlenspannweite festlegen?:";
            // 
            // radioCustomRangeNo
            // 
            this.radioCustomRangeNo.AutoSize = true;
            this.radioCustomRangeNo.Checked = true;
            this.radioCustomRangeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioCustomRangeNo.ForeColor = System.Drawing.Color.White;
            this.radioCustomRangeNo.Location = new System.Drawing.Point(54, 65);
            this.radioCustomRangeNo.Name = "radioCustomRangeNo";
            this.radioCustomRangeNo.Size = new System.Drawing.Size(139, 24);
            this.radioCustomRangeNo.TabIndex = 6;
            this.radioCustomRangeNo.TabStop = true;
            this.radioCustomRangeNo.Text = "Nein (Standard)";
            this.radioCustomRangeNo.UseVisualStyleBackColor = true;
            this.radioCustomRangeNo.CheckedChanged += new System.EventHandler(this.CustomRangeFalse);
            // 
            // radioCustomRangeTrue
            // 
            this.radioCustomRangeTrue.AutoSize = true;
            this.radioCustomRangeTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioCustomRangeTrue.ForeColor = System.Drawing.Color.White;
            this.radioCustomRangeTrue.Location = new System.Drawing.Point(55, 38);
            this.radioCustomRangeTrue.Name = "radioCustomRangeTrue";
            this.radioCustomRangeTrue.Size = new System.Drawing.Size(44, 24);
            this.radioCustomRangeTrue.TabIndex = 5;
            this.radioCustomRangeTrue.Text = "Ja";
            this.radioCustomRangeTrue.UseVisualStyleBackColor = true;
            this.radioCustomRangeTrue.CheckedChanged += new System.EventHandler(this.CustomRangeTrue);
            // 
            // radioMultiplayer
            // 
            this.radioMultiplayer.AutoSize = true;
            this.radioMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMultiplayer.ForeColor = System.Drawing.Color.White;
            this.radioMultiplayer.Location = new System.Drawing.Point(6, 61);
            this.radioMultiplayer.Name = "radioMultiplayer";
            this.radioMultiplayer.Size = new System.Drawing.Size(109, 24);
            this.radioMultiplayer.TabIndex = 6;
            this.radioMultiplayer.Text = "Mehrspieler";
            this.radioMultiplayer.UseVisualStyleBackColor = true;
            this.radioMultiplayer.CheckedChanged += new System.EventHandler(this.radioMultiplayer_CheckedChanged);
            // 
            // radioSingleplayer
            // 
            this.radioSingleplayer.AutoSize = true;
            this.radioSingleplayer.Checked = true;
            this.radioSingleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSingleplayer.ForeColor = System.Drawing.Color.White;
            this.radioSingleplayer.Location = new System.Drawing.Point(6, 38);
            this.radioSingleplayer.Name = "radioSingleplayer";
            this.radioSingleplayer.Size = new System.Drawing.Size(116, 24);
            this.radioSingleplayer.TabIndex = 5;
            this.radioSingleplayer.TabStop = true;
            this.radioSingleplayer.Text = "Einzelspieler";
            this.radioSingleplayer.UseVisualStyleBackColor = true;
            this.radioSingleplayer.CheckedChanged += new System.EventHandler(this.radioSingleplayer_CheckedChanged);
            // 
            // panelGamemode
            // 
            this.panelGamemode.Controls.Add(this.labelGamemode);
            this.panelGamemode.Controls.Add(this.radioMultiplayer);
            this.panelGamemode.Controls.Add(this.radioSingleplayer);
            this.panelGamemode.Location = new System.Drawing.Point(22, 23);
            this.panelGamemode.Name = "panelGamemode";
            this.panelGamemode.Size = new System.Drawing.Size(152, 120);
            this.panelGamemode.TabIndex = 10;
            // 
            // labelGamemode
            // 
            this.labelGamemode.AutoSize = true;
            this.labelGamemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGamemode.ForeColor = System.Drawing.Color.White;
            this.labelGamemode.Location = new System.Drawing.Point(3, 6);
            this.labelGamemode.Name = "labelGamemode";
            this.labelGamemode.Size = new System.Drawing.Size(126, 24);
            this.labelGamemode.TabIndex = 7;
            this.labelGamemode.Text = "Spielmodus:";
            // 
            // labelNamePlayer1
            // 
            this.labelNamePlayer1.AutoSize = true;
            this.labelNamePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNamePlayer1.ForeColor = System.Drawing.Color.White;
            this.labelNamePlayer1.Location = new System.Drawing.Point(25, 160);
            this.labelNamePlayer1.Name = "labelNamePlayer1";
            this.labelNamePlayer1.Size = new System.Drawing.Size(121, 20);
            this.labelNamePlayer1.TabIndex = 10;
            this.labelNamePlayer1.Text = "Name Spieler 1:";
            // 
            // textBoxNamePlayer1
            // 
            this.textBoxNamePlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.textBoxNamePlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamePlayer1.Location = new System.Drawing.Point(172, 160);
            this.textBoxNamePlayer1.Name = "textBoxNamePlayer1";
            this.textBoxNamePlayer1.Size = new System.Drawing.Size(155, 20);
            this.textBoxNamePlayer1.TabIndex = 7;
            this.textBoxNamePlayer1.Text = "DefaultPlayer1Name";
            this.textBoxNamePlayer1.TextChanged += new System.EventHandler(this.namePlayer1Changed);
            // 
            // labelNamePlayer2
            // 
            this.labelNamePlayer2.AutoSize = true;
            this.labelNamePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNamePlayer2.ForeColor = System.Drawing.Color.White;
            this.labelNamePlayer2.Location = new System.Drawing.Point(25, 186);
            this.labelNamePlayer2.Name = "labelNamePlayer2";
            this.labelNamePlayer2.Size = new System.Drawing.Size(121, 20);
            this.labelNamePlayer2.TabIndex = 9;
            this.labelNamePlayer2.Text = "Name Spieler 2:";
            // 
            // textBoxNamePlayer2
            // 
            this.textBoxNamePlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(167)))));
            this.textBoxNamePlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamePlayer2.Location = new System.Drawing.Point(172, 186);
            this.textBoxNamePlayer2.Name = "textBoxNamePlayer2";
            this.textBoxNamePlayer2.Size = new System.Drawing.Size(155, 20);
            this.textBoxNamePlayer2.TabIndex = 8;
            this.textBoxNamePlayer2.Text = "DefaultPlayer2Name";
            this.textBoxNamePlayer2.TextChanged += new System.EventHandler(this.namePlayer2Changed);
            // 
            // labelInfoOptions
            // 
            this.labelInfoOptions.AutoSize = true;
            this.labelInfoOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.labelInfoOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoOptions.ForeColor = System.Drawing.Color.Salmon;
            this.labelInfoOptions.Location = new System.Drawing.Point(26, 220);
            this.labelInfoOptions.Name = "labelInfoOptions";
            this.labelInfoOptions.Size = new System.Drawing.Size(326, 15);
            this.labelInfoOptions.TabIndex = 12;
            this.labelInfoOptions.Text = "Hinweis: Optionen sind während dem Spiel eingeschränkt.";
            // 
            // labelLeaderboard
            // 
            this.labelLeaderboard.AutoSize = true;
            this.labelLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.labelLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLeaderboard.ForeColor = System.Drawing.Color.White;
            this.labelLeaderboard.Location = new System.Drawing.Point(231, 27);
            this.labelLeaderboard.Name = "labelLeaderboard";
            this.labelLeaderboard.Size = new System.Drawing.Size(93, 20);
            this.labelLeaderboard.TabIndex = 15;
            this.labelLeaderboard.Text = "Highscores:";
            // 
            // gridViewLeaderboard
            // 
            this.gridViewLeaderboard.AllowUserToAddRows = false;
            this.gridViewLeaderboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.gridViewLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaderboardRank,
            this.leaderboardUsername,
            this.leaderboardGamemode,
            this.leaderboardCountGuesses,
            this.leaderboardSecretNumber,
            this.leaderboardNumberRange,
            this.leaderboardPoints});
            this.gridViewLeaderboard.Location = new System.Drawing.Point(225, 50);
            this.gridViewLeaderboard.Name = "gridViewLeaderboard";
            this.gridViewLeaderboard.Size = new System.Drawing.Size(1062, 230);
            this.gridViewLeaderboard.TabIndex = 14;
            // 
            // leaderboardRank
            // 
            this.leaderboardRank.HeaderText = "Platzierung";
            this.leaderboardRank.Name = "leaderboardRank";
            // 
            // leaderboardUsername
            // 
            this.leaderboardUsername.HeaderText = "Spielername";
            this.leaderboardUsername.Name = "leaderboardUsername";
            this.leaderboardUsername.Width = 300;
            // 
            // leaderboardGamemode
            // 
            this.leaderboardGamemode.HeaderText = "1P / 2P";
            this.leaderboardGamemode.Name = "leaderboardGamemode";
            // 
            // leaderboardCountGuesses
            // 
            this.leaderboardCountGuesses.HeaderText = "Benötigte Versuche";
            this.leaderboardCountGuesses.Name = "leaderboardCountGuesses";
            this.leaderboardCountGuesses.Width = 120;
            // 
            // leaderboardSecretNumber
            // 
            this.leaderboardSecretNumber.HeaderText = "Gesuchte Zahl";
            this.leaderboardSecretNumber.Name = "leaderboardSecretNumber";
            this.leaderboardSecretNumber.Width = 140;
            // 
            // leaderboardNumberRange
            // 
            this.leaderboardNumberRange.HeaderText = "Spannweite";
            this.leaderboardNumberRange.Name = "leaderboardNumberRange";
            this.leaderboardNumberRange.Width = 139;
            // 
            // leaderboardPoints
            // 
            this.leaderboardPoints.HeaderText = "Punkte";
            this.leaderboardPoints.Name = "leaderboardPoints";
            this.leaderboardPoints.Width = 120;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.groupBoxOptions.Controls.Add(this.labelInfoOptions);
            this.groupBoxOptions.Controls.Add(this.panelCustomNumberRange);
            this.groupBoxOptions.Controls.Add(this.panelGamemode);
            this.groupBoxOptions.Controls.Add(this.textBoxNamePlayer2);
            this.groupBoxOptions.Controls.Add(this.labelNamePlayer1);
            this.groupBoxOptions.Controls.Add(this.labelNamePlayer2);
            this.groupBoxOptions.Controls.Add(this.textBoxNamePlayer1);
            this.groupBoxOptions.Location = new System.Drawing.Point(225, 25);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(1062, 255);
            this.groupBoxOptions.TabIndex = 16;
            // 
            // gameInterface
            // 
            this.gameInterface.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.gameInterface.Controls.Add(this.labelLowerNumbers);
            this.gameInterface.Controls.Add(this.labelCustomRangeFormTitle);
            this.gameInterface.Controls.Add(this.labelGreaterNumbers);
            this.gameInterface.Controls.Add(this.textBoxUserInput);
            this.gameInterface.Controls.Add(this.boxGreaterNumbers);
            this.gameInterface.Controls.Add(this.labelEnterNumber);
            this.gameInterface.Controls.Add(this.boxLowerNumbers);
            this.gameInterface.Controls.Add(this.buttonBack);
            this.gameInterface.Controls.Add(this.buttonAgain);
            this.gameInterface.Controls.Add(this.buttonGuess);
            this.gameInterface.Controls.Add(this.labelCustomRangeForm);
            this.gameInterface.Controls.Add(this.labelInfo);
            this.gameInterface.Controls.Add(this.labelCurrentPlayer);
            this.gameInterface.Controls.Add(this.labelCountGuesses);
            this.gameInterface.Location = new System.Drawing.Point(225, 311);
            this.gameInterface.Name = "gameInterface";
            this.gameInterface.Size = new System.Drawing.Size(1062, 332);
            this.gameInterface.TabIndex = 17;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.MintCream;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(738, 158);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(300, 70);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Zurück";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAgain
            // 
            this.buttonAgain.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgain.Location = new System.Drawing.Point(738, 244);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(300, 70);
            this.buttonAgain.TabIndex = 9;
            this.buttonAgain.Text = "Nochmal Spielen";
            this.buttonAgain.UseVisualStyleBackColor = false;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // comboBoxStartingPlayer
            // 
            this.comboBoxStartingPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartingPlayer.FormattingEnabled = true;
            this.comboBoxStartingPlayer.Items.AddRange(new object[] {
            "Zufall entscheidet",
            "Spieler 1 beginnt",
            "Spieler 2 beginnt"});
            this.comboBoxStartingPlayer.Location = new System.Drawing.Point(36, 456);
            this.comboBoxStartingPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStartingPlayer.Name = "comboBoxStartingPlayer";
            this.comboBoxStartingPlayer.Size = new System.Drawing.Size(130, 21);
            this.comboBoxStartingPlayer.TabIndex = 18;
            // 
            // labelZahlenspiel
            // 
            this.labelZahlenspiel.AutoSize = true;
            this.labelZahlenspiel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(75)))), ((int)(((byte)(71)))));
            this.labelZahlenspiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZahlenspiel.ForeColor = System.Drawing.Color.White;
            this.labelZahlenspiel.Location = new System.Drawing.Point(675, 450);
            this.labelZahlenspiel.Name = "labelZahlenspiel";
            this.labelZahlenspiel.Size = new System.Drawing.Size(164, 31);
            this.labelZahlenspiel.TabIndex = 19;
            this.labelZahlenspiel.Text = "Zahlenspiel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 667);
            this.Controls.Add(this.gameInterface);
            this.Controls.Add(this.labelZahlenspiel);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.comboBoxStartingPlayer);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.labelLeaderboard);
            this.Controls.Add(this.gridViewLeaderboard);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonLeaderboard);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SidePanelBoxLeft);
            this.Controls.Add(this.backGroundBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.backGroundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SidePanelBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCustomNumberRange.ResumeLayout(false);
            this.panelCustomNumberRange.PerformLayout();
            this.panelGamemode.ResumeLayout(false);
            this.panelGamemode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLeaderboard)).EndInit();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.gameInterface.ResumeLayout(false);
            this.gameInterface.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backGroundBox;
        private System.Windows.Forms.PictureBox SidePanelBoxLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonLeaderboard;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label labelEnterNumber;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Label labelLowerNumbers;
        private System.Windows.Forms.Label labelGreaterNumbers;
        private System.Windows.Forms.RichTextBox boxGreaterNumbers;
        private System.Windows.Forms.RichTextBox boxLowerNumbers;
        private System.Windows.Forms.Label labelCustomRangeForm;
        private System.Windows.Forms.Label labelCustomRangeFormTitle;
        private System.Windows.Forms.Label labelCountGuesses;
        private System.Windows.Forms.Label labelCurrentPlayer;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelCustomNumberRange;
        private System.Windows.Forms.Label labelMaxNumber;
        private System.Windows.Forms.Label labelMinNumber;
        private System.Windows.Forms.TextBox textBoxMaxNumber;
        private System.Windows.Forms.TextBox textBoxMinNumber;
        private System.Windows.Forms.Label labelCustomRange;
        private System.Windows.Forms.RadioButton radioCustomRangeNo;
        private System.Windows.Forms.RadioButton radioCustomRangeTrue;
        private System.Windows.Forms.RadioButton radioMultiplayer;
        private System.Windows.Forms.RadioButton radioSingleplayer;
        private System.Windows.Forms.Panel panelGamemode;
        private System.Windows.Forms.Label labelGamemode;
        private System.Windows.Forms.Label labelNamePlayer1;
        private System.Windows.Forms.TextBox textBoxNamePlayer1;
        private System.Windows.Forms.Label labelNamePlayer2;
        private System.Windows.Forms.TextBox textBoxNamePlayer2;
        private System.Windows.Forms.Label labelInfoOptions;
        private System.Windows.Forms.Label labelLeaderboard;
        private System.Windows.Forms.DataGridView gridViewLeaderboard;
        private System.Windows.Forms.Panel groupBoxOptions;
        private System.Windows.Forms.Panel gameInterface;
        private System.Windows.Forms.Button buttonAgain;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxStartingPlayer;
        private System.Windows.Forms.Label labelZahlenspiel;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderboardRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderboardUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderboardGamemode;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderboardCountGuesses;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderboardSecretNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderboardNumberRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaderboardPoints;
    }
}

