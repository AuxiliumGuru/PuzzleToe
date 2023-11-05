

namespace TicTacToe
{
    public partial class TicTactoe : Form
    {
        public TicTactoe()
        {
            InitializeComponent();
        }

        // Wordle Form

        Wordle.Wordle wordleForm;

        //String playerMove;
        int currentMove = 0;
        

        private void tictactoe_Load(object sender, EventArgs e)
        {
            tile1Btn.Enabled = false;
            tile2Btn.Enabled = false;
            tile3Btn.Enabled = false;
            tile4Btn.Enabled = false;
            tile5Btn.Enabled = false;
            tile6Btn.Enabled = false;
            tile7Btn.Enabled = false;
            tile8Btn.Enabled = false;
            tile9Btn.Enabled = false;
        }
        // <-- Properties Method -->
        private void tile1Btn_Click(object sender, EventArgs e)
        {
            wordleForm = new Wordle.Wordle();
            wordleForm.ShowDialog();

            if (wordleForm.IsWin)
            {
                tile1Btn.Text = getPiece();
                getCurrentMove();
                tile1Btn.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                }
            }

            else
            {
                getCurrentMove();
                
            }
            
        }

        private void tile2Btn_Click(object sender, EventArgs e)
        {
            wordleForm = new Wordle.Wordle();
            wordleForm.ShowDialog();

            if (wordleForm.IsWin)
            {
                tile1Btn.Text = getPiece();
                getCurrentMove();
                tile1Btn.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                }
            }

            else
            {
                getCurrentMove();
            }
        }

        private void tile3Btn_Click(object sender, EventArgs e)
        {
            wordleForm = new Wordle.Wordle();

            wordleForm.ShowDialog();

            if (wordleForm.IsWin)
            {
                tile1Btn.Text = getPiece();
                getCurrentMove();
                tile1Btn.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                }
            }

            else
            {
                getCurrentMove();
            }
        }

        private void tile4Btn_Click(object sender, EventArgs e)
        {
            wordleForm = new Wordle.Wordle();
            wordleForm.ShowDialog();

            if (wordleForm.IsWin)
            {
                tile1Btn.Text = getPiece();
                getCurrentMove();
                tile1Btn.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                }
            }

            else
            {
                getCurrentMove();
            }
        }

        private void tile5Btn_Click(object sender, EventArgs e)
        {
            wordleForm = new Wordle.Wordle();
            wordleForm.ShowDialog();

            if (wordleForm.IsWin)
            {
                tile1Btn.Text = getPiece();
                getCurrentMove();
                tile1Btn.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                }
            }

            else
            {
                getCurrentMove();
            }
        }

        private void tile6Btn_Click(object sender, EventArgs e)
        {
            wordleForm = new Wordle.Wordle();
            wordleForm.ShowDialog();

            if (wordleForm.IsWin)
            {
                tile1Btn.Text = getPiece();
                getCurrentMove();
                tile1Btn.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                }
            }

            else
            {
                getCurrentMove();
            }
        }

        private void tile7Btn_Click(object sender, EventArgs e)
        {
            wordleForm = new Wordle.Wordle();
            wordleForm.ShowDialog();

            if (wordleForm.IsWin)
            {
                tile1Btn.Text = getPiece();
                getCurrentMove();
                tile1Btn.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                }
            }

            else
            {
                getCurrentMove();
            }
        }

        private void tile8Btn_Click(object sender, EventArgs e)
        {
            wordleForm = new Wordle.Wordle();
            wordleForm.ShowDialog();

            if (wordleForm.IsWin)
            {
                tile1Btn.Text = getPiece();
                getCurrentMove();
                tile1Btn.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                }
            }

            else
            {
                getCurrentMove();
            }
        }

        private void tile9Btn_Click(object sender, EventArgs e)
        {
            wordleForm = new Wordle.Wordle();
            wordleForm.ShowDialog();

            if (wordleForm.IsWin)
            {
                tile1Btn.Text = getPiece();
                getCurrentMove();
                tile1Btn.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                }
            }

            else
            {
                getCurrentMove();
            }
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            tile1Btn.Text = "";
            tile2Btn.Text = "";
            tile3Btn.Text = "";
            tile4Btn.Text = "";
            tile5Btn.Text = "";
            tile6Btn.Text = "";
            tile7Btn.Text = "";
            tile8Btn.Text = "";
            tile9Btn.Text = "";

            tile1Btn.Enabled = true;
            tile2Btn.Enabled = true;
            tile3Btn.Enabled = true;
            tile4Btn.Enabled = true;
            tile5Btn.Enabled = true;
            tile6Btn.Enabled = true;
            tile7Btn.Enabled = true;
            tile8Btn.Enabled = true;
            tile9Btn.Enabled = true;


           
        }

        // <-- Helper Method -->
        private String getPiece()
        {

            return (currentMove == 1) ? "O" : "X";
        }

        private void getCurrentMove()
        {
           currentMove = (currentMove == 1) ? 0 : 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        // Draw Verification

        private bool isDraw()
        {
            return (
                !string.IsNullOrEmpty(tile1Btn.Text) &&
                !string.IsNullOrEmpty(tile2Btn.Text) &&
                !string.IsNullOrEmpty(tile3Btn.Text) &&
                !string.IsNullOrEmpty(tile4Btn.Text) &&
                !string.IsNullOrEmpty(tile5Btn.Text) &&
                !string.IsNullOrEmpty(tile6Btn.Text) &&
                !string.IsNullOrEmpty(tile7Btn.Text) &&
                !string.IsNullOrEmpty(tile8Btn.Text) &&
                !string.IsNullOrEmpty(tile9Btn.Text) &&
                !isWinner()
                );
        }

        private String getDrawMessage()
        {
            resetBoard();
            return "Draw";
        }
        // Winner Verification

        private bool isWinner()
        {
            if (verifyCombinationO() || verifyCombinationX())
            {
                return true;
            }

            return false;
        }

        private String getWinnerMessage()
        {
            String winner = verifyCombinationO() ? "O wins" : "X wins";
            resetBoard();
            return winner;
        }

        private void resetBoard()
        {
            newGameBtn_Click(this, EventArgs.Empty);
        }


        // Helper Methods
        private bool verifyCombinationO()
        {
            return verifyHorizontal_O() || verifyVertical_O() || verifyDiagonal_O();
        }

        private bool verifyCombinationX()
        {
            return verifyHorizontal_X() || verifyVertical_X() || verifyDiagonal_X();
        }



        //  -- O piece --
        private bool verifyHorizontal_O()
        {
            return (
                (tile1Btn.Text.Equals("O") && tile2Btn.Text.Equals("O") && tile3Btn.Text.Equals("O")) ||
                (tile4Btn.Text.Equals("O") && tile5Btn.Text.Equals("O") && tile6Btn.Text.Equals("O")) ||
                (tile7Btn.Text.Equals("O") && tile8Btn.Text.Equals("O") && tile9Btn.Text.Equals("O"))
                );
        }
        private bool verifyVertical_O()
        {
            return (
                (tile1Btn.Text.Equals("O") && tile4Btn.Text.Equals("O") && tile7Btn.Text.Equals("O")) ||
                (tile2Btn.Text.Equals("O") && tile5Btn.Text.Equals("O") && tile8Btn.Text.Equals("O")) ||
                (tile3Btn.Text.Equals("O") && tile6Btn.Text.Equals("O") && tile9Btn.Text.Equals("O"))
                );
        }

        private bool verifyDiagonal_O()
        {
            return (
               (tile1Btn.Text.Equals("O") && tile5Btn.Text.Equals("O") && tile9Btn.Text.Equals("O")) ||
               (tile3Btn.Text.Equals("O") && tile5Btn.Text.Equals("O") && tile7Btn.Text.Equals("O"))
               );
        }

        // -- X piece --
        private bool verifyHorizontal_X()
        {
            return (
                (tile1Btn.Text.Equals("X") && tile2Btn.Text.Equals("X") && tile3Btn.Text.Equals("X")) ||
                (tile4Btn.Text.Equals("X") && tile5Btn.Text.Equals("X") && tile6Btn.Text.Equals("X")) ||
                (tile7Btn.Text.Equals("X") && tile8Btn.Text.Equals("X") && tile9Btn.Text.Equals("X"))
                );
        }
        private bool verifyVertical_X()
        {
            return (
                (tile1Btn.Text.Equals("X") && tile4Btn.Text.Equals("X") && tile7Btn.Text.Equals("X")) ||
                (tile2Btn.Text.Equals("X") && tile5Btn.Text.Equals("X") && tile8Btn.Text.Equals("X")) ||
                (tile3Btn.Text.Equals("X") && tile6Btn.Text.Equals("X") && tile9Btn.Text.Equals("X"))
                );
        }

        private bool verifyDiagonal_X()
        {
            return (
               (tile1Btn.Text.Equals("X") && tile5Btn.Text.Equals("X") && tile9Btn.Text.Equals("X")) ||
               (tile3Btn.Text.Equals("X") && tile5Btn.Text.Equals("X") && tile7Btn.Text.Equals("X"))
               );
        }

    }
}