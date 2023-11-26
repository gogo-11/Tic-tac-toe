namespace tic_tac_toe
{
    public partial class FormPrepareForGame : Form
    {

        public char playerOneCharacter { get; set; }
        public string playerOneColor { get; set; }
        public char playerTwoCharacter { get; set; }
        public string playerTwoColor { get; set; }

        public FormPrepareForGame()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreen.Checked)
            {
                radioButtonGreenPlayerTwo.Enabled = false;
                radioButtonGreenPlayerTwo.ForeColor = Color.Gray;
            } else
            {
                radioButtonGreenPlayerTwo.Enabled = true;
                radioButtonGreenPlayerTwo.ForeColor = Color.Green;
            }
            
        }

        private void radioButtonGreenPlayerTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreenPlayerTwo.Checked)
            {
                radioButtonGreen.Enabled = false;
                radioButtonGreen.ForeColor = Color.Gray;
            }
            else
            {
                radioButtonGreen.Enabled = true;
                radioButtonGreen.ForeColor = Color.Green;
            }
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked)
            {
                radioButtonRedPlayerTwo.Enabled = false;
                radioButtonRedPlayerTwo.ForeColor = Color.Gray;
            }
            else
            {
                radioButtonRedPlayerTwo.Enabled = true;
                radioButtonRedPlayerTwo.ForeColor = Color.Red;
            }
        }
        
        private void radioButtonRedPlayerTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRedPlayerTwo.Checked)
            {
                radioButtonRed.Enabled = false;
                radioButtonRed.ForeColor = Color.Gray;
            }
            else
            {
                radioButtonRed.Enabled = true;
                radioButtonRed.ForeColor = Color.Red;
            }
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlue.Checked)
            {
                radioButtonBluePlayerTwo.Enabled = false;
                radioButtonBluePlayerTwo.ForeColor = Color.Gray;
            }
            else
            {
                radioButtonBluePlayerTwo.Enabled = true;
                radioButtonBluePlayerTwo.ForeColor = Color.Blue;
            }
        }
        
        private void radioButtonBluePlayerTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBluePlayerTwo.Checked)
            {
                radioButtonBlue.Enabled = false;
                radioButtonBlue.ForeColor = Color.Gray;
            }
            else
            {
                radioButtonBlue.Enabled = true;
                radioButtonBlue.ForeColor = Color.Blue;
            }
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            FormGameUnderway game1 = new FormGameUnderway();
            this.Hide();
            game1.Closed += (s, args) => this.Show();
            game1.Show();



            if (radioChooseX.Checked)
            {
                game1.playerOneCharacter = 'X';
                game1.playerTwoCharacter = 'O';
            } else
            {
                game1.playerOneCharacter = 'O';
                game1.playerTwoCharacter = 'X';
            }

            if (radioButtonRed.Checked)
            {
                game1.playerOneColor = "red";
            } else if (radioButtonBlue.Checked)
            {
                game1.playerOneColor = "blue";

            } else if (radioButtonGreen.Checked)
            {
                game1.playerOneColor = "green";
            } else
            {
                game1.playerOneColor = "red";
            }

            if (radioButtonRedPlayerTwo.Checked)
            {
                game1.playerTwoColor = "red";
            }
            else if (radioButtonBluePlayerTwo.Checked)
            {
                game1.playerTwoColor = "blue";

            }
            else if (radioButtonGreenPlayerTwo.Checked)
            {
                game1.playerTwoColor = "green";
            }
            else
            {
                game1.playerTwoColor = "red";
            }
            MessageBox.Show("New game underway.\nToss a coin to start!");
        }

        private void groupBoxChooseColor1_Enter(object sender, EventArgs e)
        {

        }

        private void formPrepareForGame_Load(object sender, EventArgs e)
        {

        }
    }
}