

using BracketQuest;
using PuzzleToe;
using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    public partial class TicTactoe : Form
    {
        public TicTactoe()
        {
            InitializeComponent();
            InitializeTileArray();
        }
        private HelpForm helpForm;
        private PuzzleToe.PuzzleToe puzzleToeForm;
        private int num_tiles_played_o;
        private int num_tiles_played_x;

        List<Form> sideGameForms = new List<Form>();
        List<Button> tilesArr = new List<Button>();

        // FindMe form
        ClickMe.FindMe findMeForm;

        // Wordle Form
        Wordle.Wordle wordleForm;

        // CalcuFix Form
        CalcuFix calcuFixForm;

        //String playerMove;
        int currentMove = 0;


        private void InitializeTileArray()
        {
            tilesArr.Add(tile1);
            tilesArr.Add(tile2);
            tilesArr.Add(tile3);
            tilesArr.Add(tile4);
            tilesArr.Add(tile5);
            tilesArr.Add(tile6);
            tilesArr.Add(tile7);
            tilesArr.Add(tile8);
            tilesArr.Add(tile9);
        }

        private void tictactoe_Load(object sender, EventArgs e)
        {
            helpLink.BackColor = Color.Transparent;
            turnLabel.BackColor = Color.Transparent;
            // Adding all side games to the sideGameForms list
            sideGameForms.Add(findMeForm);
            sideGameForms.Add(wordleForm);

            // TicTacToe disabling buttos (default)
            foreach (var b in tilesArr)
            {
                b.Enabled = false;
            }

            num_tiles_played_o = 0;
            num_tiles_played_x = 0;
            turnLabel.Visible = false;
        }



        //  -- Side Games --

        public void getSideGames(object sender)
        {

            if (currentMove == 0)
            {
                getSideGame_X(sender);
            }

            else
            {
                getSideGame_O(sender);
            }
        }

        // Side Game Invoking Methods for O and X

        public void getSideGame_O(object sender)
        {
            if (num_tiles_played_o > 2)
            {
                getWordleGame(sender);
            }

            else if (num_tiles_played_o > 1)
            {
                getCalcuFixGame(sender);
            }

            else
            {
                getFindMeGame(sender);
            }
        }

        public void getSideGame_X(object sender)
        {
            if (num_tiles_played_x > 2)
            {
                getWordleGame(sender);
            }

            else if (num_tiles_played_x > 1)
            {
                getCalcuFixGame(sender);
            }

            else
            {
                getFindMeGame(sender);
            }
        }

        // Side Game -> FindMe

        public void getFindMeGame(object sender)
        {
            findMeForm = new ClickMe.FindMe();
            findMeForm.ShowDialog();

            IfSolvedPuzzle(sender, findMeForm.IsWin);
        }

        public void getCalcuFixGame(object sender)
        {
            calcuFixForm = new CalcuFix();
            calcuFixForm.ShowDialog();

            IfSolvedPuzzle(sender, calcuFixForm.IsWin);
        }

        // Side Game -> Wordle

        public void getWordleGame(object sender)
        {
            wordleForm = new Wordle.Wordle();
            wordleForm.ShowDialog();

            IfSolvedPuzzle(sender, wordleForm.IsWin);
        }

        public void IfSolvedPuzzle(object sender, bool IsWin)
        {
            if (IsWin)
            {
                if (currentMove == 0)
                {
                    num_tiles_played_x++;
                }
                else
                {
                    num_tiles_played_o++;
                }

                Button b = (Button)sender;
                b.Text = getPiece();
                getCurrentMove();

                b.Enabled = false;

                if (isWinner())
                {
                    MessageBox.Show(getWinnerMessage());
                    resetBoard();
                }
                else if (isDraw())
                {
                    MessageBox.Show(getDrawMessage());
                    resetBoard();
                }
            }

            else
            {
                getCurrentMove();
            }

            getCurrentTurnLabel();
        }

        // <-- Properties Method -->
        private void tile1Btn_Click(object sender, EventArgs e)
        {
            getSideGames(sender);
        }

        private void tile2Btn_Click(object sender, EventArgs e)
        {
            getSideGames(sender);
        }

        private void tile3Btn_Click(object sender, EventArgs e)
        {
            getSideGames(sender);
        }

        private void tile4Btn_Click(object sender, EventArgs e)
        {
            getSideGames(sender);
        }

        private void tile5Btn_Click(object sender, EventArgs e)
        {
            getSideGames(sender);
        }

        private void tile6Btn_Click(object sender, EventArgs e)
        {
            getSideGames(sender);
        }

        private void tile7Btn_Click(object sender, EventArgs e)
        {
            getSideGames(sender);
        }

        private void tile8Btn_Click(object sender, EventArgs e)
        {
            getSideGames(sender);
        }

        private void tile9Btn_Click(object sender, EventArgs e)
        {
            getSideGames(sender);
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            tile1.Text = "";
            tile2.Text = "";
            tile3.Text = "";
            tile4.Text = "";
            tile5.Text = "";
            tile6.Text = "";
            tile7.Text = "";
            tile8.Text = "";
            tile9.Text = "";

            tile1.Enabled = true;
            tile2.Enabled = true;
            tile3.Enabled = true;
            tile4.Enabled = true;
            tile5.Enabled = true;
            tile6.Enabled = true;
            tile7.Enabled = true;
            tile8.Enabled = true;
            tile9.Enabled = true;

            newGameBtn.Visible = false;

            turnLabel.Visible = true;
            getCurrentTurnLabel();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            puzzleToeForm = new PuzzleToe.PuzzleToe();

            DialogResult result = MessageBox.Show("Are you sure you want to proceed to the main menu?",
                "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                puzzleToeForm.Show();
                this.Hide();
            }


        }

        private void helpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm = new HelpForm();

            helpForm.SetHelpText(
                "This game is like the classic game TicTacToe but with a twist." + Environment.NewLine +
                "- Every placing of X's and O's has a side puzzle to win" + Environment.NewLine +
                "- If you did not complete the side puzzle, you will lose your turn" + Environment.NewLine +
                "- As more tiles are placed within the grid, the side puzzle gets harder" + Environment.NewLine +
                "- The Following are size puzzle based on the number of X's or O's placed:" + Environment.NewLine +
                "\t1. Find Me (0 - 1 tiles)" + Environment.NewLine +
                "\t2. CalcuFix (2 - 3 tiles)" + Environment.NewLine +
                "\t3. Wordle (> 4 tiles)" + Environment.NewLine
            );

            helpForm.ShowDialog();
        }


        // <-- Helper Method -->

        public void getCurrentTurnLabel()
        {
            turnLabel.Text = $"{getPiece()}'s Turn";
        }
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
                !string.IsNullOrEmpty(tile1.Text) &&
                !string.IsNullOrEmpty(tile2.Text) &&
                !string.IsNullOrEmpty(tile3.Text) &&
                !string.IsNullOrEmpty(tile4.Text) &&
                !string.IsNullOrEmpty(tile5.Text) &&
                !string.IsNullOrEmpty(tile6.Text) &&
                !string.IsNullOrEmpty(tile7.Text) &&
                !string.IsNullOrEmpty(tile8.Text) &&
                !string.IsNullOrEmpty(tile9.Text) &&
                !isWinner()
                );
        }

        private String getDrawMessage()
        {
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
            return winner;
        }

        private void resetBoard()
        {
            newGameBtn_Click(this, EventArgs.Empty);
            newGameBtn.Visible = true;
            newGameBtn.Enabled = true;
            turnLabel.Visible = false;
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
                (tile1.Text.Equals("O") && tile2.Text.Equals("O") && tile3.Text.Equals("O")) ||
                (tile4.Text.Equals("O") && tile5.Text.Equals("O") && tile6.Text.Equals("O")) ||
                (tile7.Text.Equals("O") && tile8.Text.Equals("O") && tile9.Text.Equals("O"))
                );
        }
        private bool verifyVertical_O()
        {
            return (
                (tile1.Text.Equals("O") && tile4.Text.Equals("O") && tile7.Text.Equals("O")) ||
                (tile2.Text.Equals("O") && tile5.Text.Equals("O") && tile8.Text.Equals("O")) ||
                (tile3.Text.Equals("O") && tile6.Text.Equals("O") && tile9.Text.Equals("O"))
                );
        }

        private bool verifyDiagonal_O()
        {
            return (
               (tile1.Text.Equals("O") && tile5.Text.Equals("O") && tile9.Text.Equals("O")) ||
               (tile3.Text.Equals("O") && tile5.Text.Equals("O") && tile7.Text.Equals("O"))
               );
        }

        // -- X piece --
        private bool verifyHorizontal_X()
        {
            return (
                (tile1.Text.Equals("X") && tile2.Text.Equals("X") && tile3.Text.Equals("X")) ||
                (tile4.Text.Equals("X") && tile5.Text.Equals("X") && tile6.Text.Equals("X")) ||
                (tile7.Text.Equals("X") && tile8.Text.Equals("X") && tile9.Text.Equals("X"))
                );
        }
        private bool verifyVertical_X()
        {
            return (
                (tile1.Text.Equals("X") && tile4.Text.Equals("X") && tile7.Text.Equals("X")) ||
                (tile2.Text.Equals("X") && tile5.Text.Equals("X") && tile8.Text.Equals("X")) ||
                (tile3.Text.Equals("X") && tile6.Text.Equals("X") && tile9.Text.Equals("X"))
                );
        }

        private bool verifyDiagonal_X()
        {
            return (
               (tile1.Text.Equals("X") && tile5.Text.Equals("X") && tile9.Text.Equals("X")) ||
               (tile3.Text.Equals("X") && tile5.Text.Equals("X") && tile7.Text.Equals("X"))
               );
        }


    }
}