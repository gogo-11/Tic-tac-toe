namespace tic_tac_toe
{
    partial class FormPrepareForGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrepareForGame));
            this.labelPlayerOne = new System.Windows.Forms.Label();
            this.labelPlayerTwo = new System.Windows.Forms.Label();
            this.groupBoxChooseCharacter = new System.Windows.Forms.GroupBox();
            this.radioChooseO = new System.Windows.Forms.RadioButton();
            this.radioChooseX = new System.Windows.Forms.RadioButton();
            this.labelTicTacToe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxChooseColor1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxChooseColor2 = new System.Windows.Forms.GroupBox();
            this.radioButtonBluePlayerTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonRedPlayerTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonGreenPlayerTwo = new System.Windows.Forms.RadioButton();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.groupBoxChooseCharacter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxChooseColor1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxChooseColor2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlayerOne
            // 
            this.labelPlayerOne.AutoSize = true;
            this.labelPlayerOne.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerOne.Location = new System.Drawing.Point(137, 20);
            this.labelPlayerOne.Name = "labelPlayerOne";
            this.labelPlayerOne.Size = new System.Drawing.Size(118, 26);
            this.labelPlayerOne.TabIndex = 0;
            this.labelPlayerOne.Text = "Player one";
            // 
            // labelPlayerTwo
            // 
            this.labelPlayerTwo.AutoSize = true;
            this.labelPlayerTwo.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerTwo.Location = new System.Drawing.Point(136, 10);
            this.labelPlayerTwo.Name = "labelPlayerTwo";
            this.labelPlayerTwo.Size = new System.Drawing.Size(120, 26);
            this.labelPlayerTwo.TabIndex = 1;
            this.labelPlayerTwo.Text = "Player two";
            // 
            // groupBoxChooseCharacter
            // 
            this.groupBoxChooseCharacter.Controls.Add(this.radioChooseO);
            this.groupBoxChooseCharacter.Controls.Add(this.radioChooseX);
            this.groupBoxChooseCharacter.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxChooseCharacter.Location = new System.Drawing.Point(11, 85);
            this.groupBoxChooseCharacter.Name = "groupBoxChooseCharacter";
            this.groupBoxChooseCharacter.Size = new System.Drawing.Size(143, 74);
            this.groupBoxChooseCharacter.TabIndex = 2;
            this.groupBoxChooseCharacter.TabStop = false;
            this.groupBoxChooseCharacter.Text = "Choose character";
            // 
            // radioChooseO
            // 
            this.radioChooseO.AutoSize = true;
            this.radioChooseO.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioChooseO.Location = new System.Drawing.Point(91, 27);
            this.radioChooseO.Name = "radioChooseO";
            this.radioChooseO.Size = new System.Drawing.Size(46, 30);
            this.radioChooseO.TabIndex = 1;
            this.radioChooseO.TabStop = true;
            this.radioChooseO.Text = "O";
            this.radioChooseO.UseVisualStyleBackColor = true;
            // 
            // radioChooseX
            // 
            this.radioChooseX.AutoSize = true;
            this.radioChooseX.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioChooseX.Location = new System.Drawing.Point(6, 26);
            this.radioChooseX.Name = "radioChooseX";
            this.radioChooseX.Size = new System.Drawing.Size(43, 30);
            this.radioChooseX.TabIndex = 0;
            this.radioChooseX.TabStop = true;
            this.radioChooseX.Text = "X";
            this.radioChooseX.UseVisualStyleBackColor = true;
            // 
            // labelTicTacToe
            // 
            this.labelTicTacToe.AutoSize = true;
            this.labelTicTacToe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTicTacToe.Font = new System.Drawing.Font("Ravie", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTicTacToe.Location = new System.Drawing.Point(0, 0);
            this.labelTicTacToe.Name = "labelTicTacToe";
            this.labelTicTacToe.Size = new System.Drawing.Size(406, 59);
            this.labelTicTacToe.TabIndex = 3;
            this.labelTicTacToe.Text = "TIC-TAC-TOE";
            this.labelTicTacToe.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTicTacToe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 72);
            this.panel1.TabIndex = 4;
            // 
            // groupBoxChooseColor1
            // 
            this.groupBoxChooseColor1.Controls.Add(this.radioButtonBlue);
            this.groupBoxChooseColor1.Controls.Add(this.radioButtonRed);
            this.groupBoxChooseColor1.Controls.Add(this.radioButtonGreen);
            this.groupBoxChooseColor1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxChooseColor1.Location = new System.Drawing.Point(160, 85);
            this.groupBoxChooseColor1.Name = "groupBoxChooseColor1";
            this.groupBoxChooseColor1.Size = new System.Drawing.Size(253, 74);
            this.groupBoxChooseColor1.TabIndex = 5;
            this.groupBoxChooseColor1.TabStop = false;
            this.groupBoxChooseColor1.Text = "Choose color";
            this.groupBoxChooseColor1.Enter += new System.EventHandler(this.groupBoxChooseColor1_Enter);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonBlue.Location = new System.Drawing.Point(184, 32);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(63, 24);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Enabled = false;
            this.radioButtonRed.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonRed.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(102, 32);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(56, 24);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Checked = true;
            this.radioButtonGreen.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGreen.ForeColor = System.Drawing.Color.Green;
            this.radioButtonGreen.Location = new System.Drawing.Point(6, 32);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(75, 24);
            this.radioButtonGreen.TabIndex = 0;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBoxChooseCharacter);
            this.panel2.Controls.Add(this.groupBoxChooseColor1);
            this.panel2.Controls.Add(this.labelPlayerOne);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 199);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBoxChooseColor2);
            this.panel3.Controls.Add(this.labelPlayerTwo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 137);
            this.panel3.TabIndex = 7;
            // 
            // groupBoxChooseColor2
            // 
            this.groupBoxChooseColor2.Controls.Add(this.radioButtonBluePlayerTwo);
            this.groupBoxChooseColor2.Controls.Add(this.radioButtonRedPlayerTwo);
            this.groupBoxChooseColor2.Controls.Add(this.radioButtonGreenPlayerTwo);
            this.groupBoxChooseColor2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxChooseColor2.Location = new System.Drawing.Point(75, 39);
            this.groupBoxChooseColor2.Name = "groupBoxChooseColor2";
            this.groupBoxChooseColor2.Size = new System.Drawing.Size(253, 74);
            this.groupBoxChooseColor2.TabIndex = 6;
            this.groupBoxChooseColor2.TabStop = false;
            this.groupBoxChooseColor2.Text = "Choose color";
            // 
            // radioButtonBluePlayerTwo
            // 
            this.radioButtonBluePlayerTwo.AutoSize = true;
            this.radioButtonBluePlayerTwo.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonBluePlayerTwo.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonBluePlayerTwo.Location = new System.Drawing.Point(184, 32);
            this.radioButtonBluePlayerTwo.Name = "radioButtonBluePlayerTwo";
            this.radioButtonBluePlayerTwo.Size = new System.Drawing.Size(63, 24);
            this.radioButtonBluePlayerTwo.TabIndex = 2;
            this.radioButtonBluePlayerTwo.Text = "Blue";
            this.radioButtonBluePlayerTwo.UseVisualStyleBackColor = true;
            this.radioButtonBluePlayerTwo.CheckedChanged += new System.EventHandler(this.radioButtonBluePlayerTwo_CheckedChanged);
            // 
            // radioButtonRedPlayerTwo
            // 
            this.radioButtonRedPlayerTwo.AutoSize = true;
            this.radioButtonRedPlayerTwo.Checked = true;
            this.radioButtonRedPlayerTwo.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonRedPlayerTwo.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRedPlayerTwo.Location = new System.Drawing.Point(102, 32);
            this.radioButtonRedPlayerTwo.Name = "radioButtonRedPlayerTwo";
            this.radioButtonRedPlayerTwo.Size = new System.Drawing.Size(56, 24);
            this.radioButtonRedPlayerTwo.TabIndex = 1;
            this.radioButtonRedPlayerTwo.TabStop = true;
            this.radioButtonRedPlayerTwo.Text = "Red";
            this.radioButtonRedPlayerTwo.UseVisualStyleBackColor = true;
            this.radioButtonRedPlayerTwo.CheckedChanged += new System.EventHandler(this.radioButtonRedPlayerTwo_CheckedChanged);
            // 
            // radioButtonGreenPlayerTwo
            // 
            this.radioButtonGreenPlayerTwo.AutoSize = true;
            this.radioButtonGreenPlayerTwo.Enabled = false;
            this.radioButtonGreenPlayerTwo.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonGreenPlayerTwo.ForeColor = System.Drawing.Color.Green;
            this.radioButtonGreenPlayerTwo.Location = new System.Drawing.Point(6, 32);
            this.radioButtonGreenPlayerTwo.Name = "radioButtonGreenPlayerTwo";
            this.radioButtonGreenPlayerTwo.Size = new System.Drawing.Size(75, 24);
            this.radioButtonGreenPlayerTwo.TabIndex = 0;
            this.radioButtonGreenPlayerTwo.Text = "Green";
            this.radioButtonGreenPlayerTwo.UseVisualStyleBackColor = true;
            this.radioButtonGreenPlayerTwo.CheckedChanged += new System.EventHandler(this.radioButtonGreenPlayerTwo_CheckedChanged);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStartGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartGame.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStartGame.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonStartGame.Location = new System.Drawing.Point(0, 407);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(426, 36);
            this.buttonStartGame.TabIndex = 8;
            this.buttonStartGame.Text = "Play";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // FormPrepareForGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(426, 443);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrepareForGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game settings | Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.formPrepareForGame_Load);
            this.groupBoxChooseCharacter.ResumeLayout(false);
            this.groupBoxChooseCharacter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxChooseColor1.ResumeLayout(false);
            this.groupBoxChooseColor1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxChooseColor2.ResumeLayout(false);
            this.groupBoxChooseColor2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelPlayerOne;
        private Label labelPlayerTwo;
        private GroupBox groupBoxChooseCharacter;
        private RadioButton radioChooseO;
        private RadioButton radioChooseX;
        private Label labelTicTacToe;
        private Panel panel1;
        private GroupBox groupBoxChooseColor1;
        private Panel panel2;
        private RadioButton radioButtonRed;
        private RadioButton radioButtonGreen;
        private RadioButton radioButtonBlue;
        private Panel panel3;
        private GroupBox groupBoxChooseColor2;
        private RadioButton radioButtonBluePlayerTwo;
        private RadioButton radioButtonRedPlayerTwo;
        private RadioButton radioButtonGreenPlayerTwo;
        private Button buttonStartGame;
    }
}