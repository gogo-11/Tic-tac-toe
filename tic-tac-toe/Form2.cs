using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class FormGameUnderway : Form
    {
        public bool coinTossBool;
        internal char playerOneCharacter;
        internal char playerTwoCharacter;
        internal string playerOneColor;
        internal string playerTwoColor;
        public bool playerMove;
        private Color colorPlayerOne;
        private Color colorPlayerTwo;
        private const int MATRIX_ROWS = 3;
        private const int MATRIX_COLS = 3;
        public string[,] gameMatrixCheck = new string[MATRIX_ROWS, MATRIX_COLS];
        private int playerOneResult;
        private int playerTwoResult;
        private int drawCounter;
        private int gameCounter;
        bool answer = false;

        public FormGameUnderway()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            playerOneResult = 0;
            playerTwoResult = 0;
            drawCounter = 0;
            gameCounter = 1;
        }
        
        //
        private void buttonMatrix(Button buttonExample, bool playerMoveOne, char playerOC,char playerTC, Color playerColorO, Color playerColorT)
        {
            Button b1 = buttonExample;
            if(b1.Text.Equals("X")|| b1.Text.Equals("O"))
            {
                MessageBox.Show("You are not allowed to select a button that has already been selected!");
            }
            else
            {
                if (playerMove)
                {
                    textBoxPlayerTurn.Text = "Second player's turn";
                    b1.Text = playerOneCharacter.ToString();
                    b1.ForeColor = colorPlayerOne;
                    this.panelPlayOrder.BackColor = colorPlayerTwo;
                    this.textBoxPlayerTurn.BackColor = colorPlayerTwo;
                    this.playerMove = false;
                }
                else
                {
                    textBoxPlayerTurn.Text = "First player's turn";
                    b1.Text = playerTwoCharacter.ToString();
                    b1.ForeColor = colorPlayerTwo;
                    this.panelPlayOrder.BackColor = colorPlayerOne;
                    this.textBoxPlayerTurn.BackColor = colorPlayerOne;
                    this.playerMove = true;
                }
            }
        }        

        private void resetForNewGame ()
        {
            clearButtonsValues();
            this.button11.Enabled = false;
            this.button12.Enabled = false;
            this.button13.Enabled = false;
            this.button21.Enabled = false;
            this.button22.Enabled = false;
            this.button23.Enabled = false;
            this.button31.Enabled = false;
            this.button32.Enabled = false;
            this.button33.Enabled = false;
            this.buttonCoinToss.Enabled = true;
            this.textBoxResultP1.Enabled = false;
            this.textBoxResultP2.Enabled = false;
            this.textBoxDraws.Enabled = false;
            this.textBoxPlayerTurn.Enabled = false;
            this.textBoxPlayerStarts.Enabled = false;
            this.textBoxGamesCount.Enabled = false;
        }

        private void gameStateCheck ()
        {
            bool counterWin1 = false;
            bool counterWin2 = false;

            //___________________________________________________________________________________________________
            // check row win
            //___________________________________________________________________________________________________
            for(int i = 0; i < 3; i++)
            {
                if ((gameMatrixCheck[i, 0] != null) && (gameMatrixCheck[i, 1] != null) && (gameMatrixCheck[i, 2] != null))
                {
                    if ((gameMatrixCheck[i, 0].Equals(gameMatrixCheck[i, 1]))
                    && (gameMatrixCheck[i, 1].Equals(gameMatrixCheck[i, 2])))
                    {
                        if (gameMatrixCheck[i, 0].Equals(playerOneCharacter.ToString()))
                        {
                            counterWin1 = true;
                        }
                        else if (gameMatrixCheck[i, 0].Equals(playerTwoCharacter.ToString()))
                        {
                            counterWin2 = true;
                        }
                    }
                }
            }

            /*if ((gameMatrixCheck[0, 0] != null) && (gameMatrixCheck[0, 1] != null) && (gameMatrixCheck[0, 2] != null))
            {
                if ((gameMatrixCheck[0, 0].Equals(gameMatrixCheck[0, 1])) 
                    && (gameMatrixCheck[0, 1].Equals(gameMatrixCheck[0, 2])))
                {
                    if (gameMatrixCheck[0, 0].Equals(playerOneCharacter.ToString()))
                    {
                        counterWin1 = true;
                    }
                    else if (gameMatrixCheck[0, 0].Equals(playerTwoCharacter.ToString()))
                    {
                        counterWin2 = true;
                    }
                }
            }
            if ((gameMatrixCheck[1, 0] != null) && (gameMatrixCheck[1, 1] != null) && (gameMatrixCheck[1, 2] != null))
            {
                if ((gameMatrixCheck[1, 0].Equals(gameMatrixCheck[1, 1])) && (gameMatrixCheck[1, 1].Equals(gameMatrixCheck[1, 2])))
                {
                    if (gameMatrixCheck[1, 0].Equals(playerOneCharacter.ToString()))
                    {
                        counterWin1 = true;
                    }
                    else if (gameMatrixCheck[1, 0].Equals(playerTwoCharacter.ToString()))
                    {
                        counterWin2 = true;
                    }
                } 
            }
            if ((gameMatrixCheck[2, 0] != null) && (gameMatrixCheck[2, 1] != null) && (gameMatrixCheck[2, 2] != null))
            {
            if ((gameMatrixCheck[2, 0].Equals(gameMatrixCheck[2, 1])) && (gameMatrixCheck[2, 1].Equals(gameMatrixCheck[2, 2])))
                {
                    if (gameMatrixCheck[2, 0].Equals(playerOneCharacter.ToString()))
                    {
                        counterWin1 = true;
                    }
                    else if (gameMatrixCheck[2, 0].Equals(playerTwoCharacter.ToString()))
                    {
                        counterWin2 = true;
                    }
                }
            }*/
            //___________________________________________________________________________________________________
            // проверка за победа по колона
            //___________________________________________________________________________________________________

            if ((gameMatrixCheck[0, 0] != null) && (gameMatrixCheck[1, 0] != null) && (gameMatrixCheck[2, 0] != null))
            {
                if ((gameMatrixCheck[0, 0].Equals(gameMatrixCheck[1, 0])) && (gameMatrixCheck[1, 0].Equals(gameMatrixCheck[2, 0])))
                {
                    if (gameMatrixCheck[0, 0].Equals(playerOneCharacter.ToString()))
                    {
                        counterWin1 = true;
                    }
                    else if (gameMatrixCheck[0, 0].Equals(playerTwoCharacter.ToString()))
                    {
                        counterWin2 = true;
                    }
                }
            }
            if ((gameMatrixCheck[0, 1] != null) && (gameMatrixCheck[1, 1] != null) && (gameMatrixCheck[2, 1] != null))
            {
                if ((gameMatrixCheck[0, 1].Equals(gameMatrixCheck[1, 1])) && (gameMatrixCheck[1, 1].Equals(gameMatrixCheck[2, 1])))
                {
                    if (gameMatrixCheck[0, 1].Equals(playerOneCharacter.ToString()))
                    {
                        counterWin1 = true;
                    }
                    else if (gameMatrixCheck[0, 1].Equals(playerTwoCharacter.ToString()))
                    {
                        counterWin2 = true;
                    }
                }
            }
            if ((gameMatrixCheck[0, 2] != null) && (gameMatrixCheck[1, 2] != null) && (gameMatrixCheck[2, 2] != null))
            {
                if ((gameMatrixCheck[0, 2].Equals(gameMatrixCheck[1, 2])) && (gameMatrixCheck[1, 2].Equals(gameMatrixCheck[2, 2])))
                {
                    if (gameMatrixCheck[0, 2].Equals(playerOneCharacter.ToString()))
                    {
                        counterWin1 = true;
                    }
                    else if (gameMatrixCheck[0, 2].Equals(playerTwoCharacter.ToString()))
                    {
                        counterWin2 = true;
                    }
                }
            }
            //___________________________________________________________________________________________________
            // проверка за победа по диагонал
            //___________________________________________________________________________________________________
            if ((gameMatrixCheck[0, 0] != null) && (gameMatrixCheck[1, 1] != null) && (gameMatrixCheck[2, 2] != null))
            {
                if ((gameMatrixCheck[0, 0].Equals(gameMatrixCheck[1, 1])) && (gameMatrixCheck[1, 1].Equals(gameMatrixCheck[2, 2])))
                {
                    if (gameMatrixCheck[0, 0].Equals(playerOneCharacter.ToString()))
                    {
                        counterWin1 = true;
                    }
                    else if (gameMatrixCheck[0, 0].Equals(playerTwoCharacter.ToString()))
                    {
                        counterWin2 = true;
                    }
                }
            }
            if ((gameMatrixCheck[0, 2] != null) && (gameMatrixCheck[1, 1] != null) && (gameMatrixCheck[2, 0] != null))
            {
                if ((gameMatrixCheck[0, 2].Equals(gameMatrixCheck[1, 1])) && (gameMatrixCheck[1, 1].Equals(gameMatrixCheck[2, 0])))
                {
                    if (gameMatrixCheck[0, 2].Equals(playerOneCharacter.ToString()))
                    {
                        counterWin1 = true;
                    }
                    else if (gameMatrixCheck[0, 2].Equals(playerTwoCharacter.ToString()))
                    {
                        counterWin2 = true;
                    }
                }
            }


            if (counterWin1)
            {
                MessageBox.Show("Player one wins");
                playerOneResult++;
                textBoxResultP1.Text = playerOneResult.ToString();
                gameCounter++;
                textBoxGamesCount.Text = gameCounter.ToString();
                textBoxPlayerTurn.Text = "";
                Array.Clear(gameMatrixCheck, 0, gameMatrixCheck.Length);
                clearButtonsValues();
                counterWin1 = false;
                return;
            } 
            else if (counterWin2)
            {
                MessageBox.Show("Player two wins");
                playerTwoResult++;
                textBoxResultP2.Text = playerTwoResult.ToString();
                gameCounter++;
                textBoxGamesCount.Text = gameCounter.ToString();
                textBoxPlayerTurn.Text = "";
                Array.Clear(gameMatrixCheck, 0, gameMatrixCheck.Length); //gameMatrixCheck = null;
                clearButtonsValues();
                counterWin2 = false;
                return;
            }
            bool flag = false;
            for (int i = 0; i < MATRIX_ROWS; i++)
            {
                for (int j = 0; j < MATRIX_COLS; j++)
                {
                    if (gameMatrixCheck[i, j] == null)
                    {
                        flag = true;
                    }
                }
            }
            if (!flag)
            {
                MessageBox.Show("Game ended in a draw.");
                gameCounter++;
                textBoxGamesCount.Text = gameCounter.ToString();
                drawCounter++;
                textBoxDraws.Text = drawCounter.ToString();
                textBoxPlayerTurn.Text = "";
                Array.Clear(gameMatrixCheck, 0, gameMatrixCheck.Length);
                clearButtonsValues();
            }
        }

        private void clearButtonsValues ()
        {
            this.button11.Text = "";
            this.button12.Text = "";
            this.button13.Text = "";
            this.button21.Text = "";
            this.button22.Text = "";
            this.button23.Text = "";
            this.button31.Text = "";
            this.button32.Text = "";
            this.button33.Text = "";

        }

        private void buttonCoinToss_Click(object sender, EventArgs e)
        {
            //хвърля се ези тура
            Random r1 = new Random();
            int coinHeadsTails = r1.Next(0,2);
            if (coinHeadsTails == 0)
            {
                coinTossBool = true;
                textBoxCoinTossResult.Text = "Heads";
                this.textBoxCoinTossResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.textBoxCoinTossResult.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            } else
            {
                coinTossBool = false;
                textBoxCoinTossResult.Text = "Tails";
                this.textBoxCoinTossResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.textBoxCoinTossResult.Font = new System.Drawing.Font("Square721 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }
            this.button11.Enabled = true;
            this.button12.Enabled = true;
            this.button13.Enabled = true;
            this.button21.Enabled = true;
            this.button22.Enabled = true;
            this.button23.Enabled = true;
            this.button31.Enabled = true;
            this.button32.Enabled = true;
            this.button33.Enabled = true;
            this.buttonCoinToss.Enabled = false;
            this.textBoxResultP1.Enabled = true;
            this.textBoxResultP2.Enabled = true;
            this.textBoxDraws.Enabled = true;
            this.textBoxPlayerTurn.Enabled = true;
            this.textBoxPlayerStarts.Enabled = true;
            this.textBoxGamesCount.Enabled = true;

            //присвоява се цвят на фигурката, с която играе съответният играч
            switch (playerOneColor)
            {
                case "red":
                    colorPlayerOne = System.Drawing.Color.Tomato;
                    break;

                case "green":
                    colorPlayerOne = System.Drawing.Color.PaleGreen;
                    break;

                case "blue":
                    colorPlayerOne = System.Drawing.Color.DodgerBlue;
                    break;
            }

            switch (playerTwoColor)
            {
                case "red":
                    colorPlayerTwo = System.Drawing.Color.Tomato;
                    break;

                case "green":
                    colorPlayerTwo = System.Drawing.Color.PaleGreen;
                    break;

                case "blue":
                    colorPlayerTwo = System.Drawing.Color.DodgerBlue;
                    break;
            }

            //определя се кой стартира играта, като се сравни резултата от хвърлянето на монета
            if (coinTossBool)
            {
                textBoxPlayerStarts.Text = "Player one starts the game";
                playerMove = true;
                switch (playerOneColor)
                {
                    case "red":
                        this.panelPlayOrder.BackColor = System.Drawing.Color.Tomato;
                        this.textBoxPlayerTurn.BackColor = System.Drawing.Color.Tomato;
                        textBoxPlayerTurn.Text = "First player's turn";
                        break;

                    case "green":
                        this.panelPlayOrder.BackColor = System.Drawing.Color.PaleGreen;
                        this.textBoxPlayerTurn.BackColor = System.Drawing.Color.PaleGreen;
                        textBoxPlayerTurn.Text = "First player's turn";
                        break;

                    case "blue":
                        this.panelPlayOrder.BackColor = System.Drawing.Color.DodgerBlue;
                        this.textBoxPlayerTurn.BackColor = System.Drawing.Color.DodgerBlue;
                        textBoxPlayerTurn.Text = "First player's turn";
                        break;
                }
            }
            else
            {
                textBoxPlayerStarts.Text = "Player two starts the game";
                playerMove = false;
                switch (playerTwoColor)
                {
                    case "red":
                        this.panelPlayOrder.BackColor = System.Drawing.Color.Tomato;
                        this.textBoxPlayerTurn.BackColor = System.Drawing.Color.Tomato;
                        textBoxPlayerTurn.Text = "Second player's turn";
                        break;

                    case "green":
                        this.panelPlayOrder.BackColor = System.Drawing.Color.PaleGreen;
                        this.textBoxPlayerTurn.BackColor = System.Drawing.Color.PaleGreen;
                        textBoxPlayerTurn.Text = "Second player's turn";
                        break;

                    case "blue":
                        this.panelPlayOrder.BackColor = System.Drawing.Color.DodgerBlue;
                        this.textBoxPlayerTurn.BackColor = System.Drawing.Color.DodgerBlue;
                        textBoxPlayerTurn.Text = "Second player's turn";
                        break;
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonMatrix(button11, playerMove, playerOneCharacter, playerTwoCharacter, colorPlayerOne, colorPlayerTwo);
            gameMatrixCheck[0, 0] = button11.Text;
            gameStateCheck();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buttonMatrix(button12, playerMove, playerOneCharacter, playerTwoCharacter, colorPlayerOne, colorPlayerTwo);
            gameMatrixCheck[0, 1] = button12.Text;
            gameStateCheck();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buttonMatrix(button13, playerMove, playerOneCharacter, playerTwoCharacter, colorPlayerOne, colorPlayerTwo);
            gameMatrixCheck[0, 2] = button13.Text;
            gameStateCheck();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            buttonMatrix(button21, playerMove, playerOneCharacter, playerTwoCharacter, colorPlayerOne, colorPlayerTwo);
            gameMatrixCheck[1, 0] = button21.Text;
            gameStateCheck();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            buttonMatrix(button22, playerMove, playerOneCharacter, playerTwoCharacter, colorPlayerOne, colorPlayerTwo);
            gameMatrixCheck[1, 1] = button22.Text;
            gameStateCheck();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            buttonMatrix(button23, playerMove, playerOneCharacter, playerTwoCharacter, colorPlayerOne, colorPlayerTwo);
            gameMatrixCheck[1, 2] = button23.Text;
            gameStateCheck();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            buttonMatrix(button31, playerMove, playerOneCharacter, playerTwoCharacter, colorPlayerOne, colorPlayerTwo);
            gameMatrixCheck[2, 0] = button31.Text;
            gameStateCheck();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            buttonMatrix(button32, playerMove, playerOneCharacter, playerTwoCharacter, colorPlayerOne, colorPlayerTwo);
            gameMatrixCheck[2, 1] = button32.Text;
            gameStateCheck();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            buttonMatrix(button33, playerMove, playerOneCharacter, playerTwoCharacter, colorPlayerOne, colorPlayerTwo);
            gameMatrixCheck[2, 2] = button33.Text;
            gameStateCheck();
        }

        private void menuItemNewGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemResetRound_Click(object sender, EventArgs e)
        {
            clearButtonsValues();
            Array.Clear(gameMatrixCheck, 0, gameMatrixCheck.Length);
        }

        private void menuItemExitGame_Click(object sender, EventArgs e)
        {
            answer = false;
            answer = MessageBox.Show("Do you want to close the game?", "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes;
            if (answer)
            {
                this.Close();
                MessageBox.Show("You exited the game.\nGoodbye!");
                Environment.Exit(1);
            }
        }
        private void closeButton_Click(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1); 
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStripGame_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
