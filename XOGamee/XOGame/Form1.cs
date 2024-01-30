using Business;
using Business.Models;
namespace tProject
{
    public partial class Form1 : Form
    {
        bool isTurn = true;
        int Turn_Count = 0;
        int scoreX;
        int scoreY;

        private Form2 f2;

        public string text_X
        {
            set
            {
                lbl_x.Text = value;
            }
            get
            {
                return lbl_x.Text;
            }
        }

        public string text_o
        {
            set
            {
                lbl_o.Text = value;
            }
            get
            {
                return lbl_o.Text;
            }
        }

        #region enable buttons
        void enable_buttons(bool show)
        {

            btn1.Enabled = show;
            btn2.Enabled = show;
            btn3.Enabled = show;
            btn4.Enabled = show;
            btn5.Enabled = show;
            btn6.Enabled = show;
            btn7.Enabled = show;
            btn8.Enabled = show;
            btn9.Enabled = show;
        }
        #endregion

        #region reset colors
        private void reset_colorsText()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn1.BackColor = Color.White;
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
        }
        #endregion

        string winnersymbol1 = "";
        string winnersymbol2 = "";
        private string[,] board;

        public Form1(string playerText1, string playerText2, string symbol1, string symbol2)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            if (symbol1 == "X")
            {
                text_X = playerText1;
                text_o = playerText2;
                winnersymbol1 = symbol1;
                winnersymbol2 = symbol2;
            }
            else
            {
                text_o = playerText1;
                text_X = playerText2;
                winnersymbol2 = symbol1;
                winnersymbol1 = symbol2;
            }
            board = new string[3, 3];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f2 = new Form2();
        }

        #region check winner
        private void winner()
        {
            updateBoard();
            string winnerSymbol = "";
            bool isWinner = false;
            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (btn1.Text != ""))
            {
                isWinner = true;
                winnerSymbol = btn1.Text;
                enable_buttons(false);
            }
            else if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (btn1.Text != ""))
            {
                isWinner = true;
                winnerSymbol = btn1.Text;
                enable_buttons(false);
            }
            else if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (btn1.Text != ""))
            {
                isWinner = true;
                winnerSymbol = btn1.Text;
                enable_buttons(false);
            }


            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (btn3.Text != ""))
            {
                isWinner = true;
                winnerSymbol = btn3.Text;
                enable_buttons(false);
            }
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (btn2.Text != ""))
            {
                isWinner = true;
                winnerSymbol = btn2.Text;
                enable_buttons(false);
            }
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (btn3.Text != ""))
            {
                isWinner = true;
                winnerSymbol = btn3.Text;
                enable_buttons(false);
            }


            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (btn4.Text != ""))
            {
                isWinner = true;
                winnerSymbol = btn4.Text;
                enable_buttons(false);
            }
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (btn7.Text != ""))
            {
                isWinner = true;
                winnerSymbol = btn7.Text;
                enable_buttons(false);
            }

            if (isWinner)
            {
                string winnerName = "";
                string winningSymbol = "";
                if (winnerSymbol == "O")
                {
                    winnerName = text_o;
                    winningSymbol = winnersymbol2;
                    scoreY++;
                }

                else if (winnerSymbol == "X")
                {
                    winnerName = text_X;
                    winningSymbol = winnersymbol1;
                    scoreX++;

                }

                MessageBox.Show($"{winnerName} who playes with {winningSymbol} wins", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateScore();
            }
            else if (Turn_Count == 9)
            {
                MessageBox.Show("It is a Draw,", "Restar thr Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region updateScore
        private void updateScore()
        {
            score1.Text = scoreX.ToString();
            score2.Text = scoreY.ToString();
        }
        #endregion

        #region update board
        string boardString = "";
        private void updateBoard()
        {
            board[0, 0] = btn1.Text;
            board[0, 1] = btn2.Text;
            board[0, 2] = btn3.Text;
            board[1, 0] = btn4.Text;
            board[1, 1] = btn5.Text;
            board[1, 2] = btn6.Text;
            board[2, 0] = btn7.Text;
            board[2, 1] = btn8.Text;
            board[2, 2] = btn9.Text;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    boardString += board[row, col] + " ";
                }
                boardString += "\n";
            }
            // MessageBox.Show("Updated Board:\n" + boardString);
        }

        #endregion

        #region buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isTurn)
            {
                b.Text = "X";
                b.BackColor = Color.PowderBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.AliceBlue;
            }
            isTurn = !isTurn;
            b.Enabled = false;
            Turn_Count++;

            winner();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isTurn)
            {
                b.Text = "X";
                b.BackColor = Color.PowderBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.AliceBlue;
            }
            isTurn = !isTurn;
            b.Enabled = false;
            Turn_Count++;

            winner();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isTurn)
            {
                b.Text = "X";
                b.BackColor = Color.PowderBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.AliceBlue;
            }
            isTurn = !isTurn;
            b.Enabled = false;
            Turn_Count++;

            winner();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isTurn)
            {
                b.Text = "X";
                b.BackColor = Color.PowderBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.AliceBlue;
            }
            isTurn = !isTurn;
            b.Enabled = false;
            Turn_Count++;

            winner();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isTurn)
            {
                b.Text = "X";
                b.BackColor = Color.PowderBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.AliceBlue;
            }
            isTurn = !isTurn;
            b.Enabled = false;
            Turn_Count++;

            winner();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isTurn)
            {
                b.Text = "X";
                b.BackColor = Color.PowderBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.AliceBlue;
            }
            isTurn = !isTurn;
            b.Enabled = false;
            Turn_Count++;

            winner();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isTurn)
            {
                b.Text = "X";
                b.BackColor = Color.PowderBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.AliceBlue;
            }
            isTurn = !isTurn;
            b.Enabled = false;
            Turn_Count++;

            winner();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isTurn)
            {
                b.Text = "X";
                b.BackColor = Color.PowderBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.AliceBlue;
            }
            isTurn = !isTurn;
            b.Enabled = false;
            Turn_Count++;

            winner();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isTurn)
            {
                b.Text = "X";
                b.BackColor = Color.PowderBlue;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.AliceBlue;
            }
            isTurn = !isTurn;
            b.Enabled = false;
            Turn_Count++;

            winner();
        }
        #endregion

        #region reset
        private void button11_Click(object sender, EventArgs e)
        {
            reset_colorsText();
            enable_buttons(true);
            btn_newgame.Enabled = true;
            scoreX = 0;
            scoreY = 0;
            updateScore();
            Turn_Count = 0;
            isTurn = true;
        }
        #endregion

        #region exit
        private void button12_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExite;
                iExite = MessageBox.Show("Are You Sure You want to exit?", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExite == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region new Game
        private void btn_newgame_Click(object sender, EventArgs e)
        {
            reset_colorsText();
            enable_buttons(true);
            updateScore();
            Turn_Count = 0;
            isTurn = true;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            
            f2.Hide();
            f2.Close();
            GameProperities Game = new GameProperities
            {

                FirstPlayerName = text_X,
                SecondPlayerName = text_o,
                FirstPlayerScore = score1.Text,
                SecondPlayerScore = score2.Text,
                GameDate = DateTime.Now

            };

            int effectedRows = GameCommands.Insert(Game);
            if (effectedRows > 0)
            {
                MessageBox.Show("Scores saved");
            }

            this.Hide();
            Score s = new Score(text_X, text_o, score1.Text, score2.Text);
            s.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
