using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Wordle
{
    public partial class Wordle : Form
    {
        public Wordle()
        {
            InitializeComponent();
            isWin = false;

        }

        // API
        private bool isWin;

        public bool IsWin
        {
            get { return isWin; }
        }
        
        // Class Attributes

        Random random = new Random();
        private int currentButtonIndex = 0;
        private int loopIndex = 0;
        private FiveLetterWords words;
        private String guessWord;
        private List<Button> buttons = new List<Button>();
        private List<Button> pressButtons = new List<Button>();
        private List<char> usedLetters = new List<char>();

        private void Form1_Load(object sender, EventArgs e)
        {

            // Instantiate FiveLetterWords Class
            words = new FiveLetterWords();

            // get random index from words list

            guessWord = words.Words[random.Next(0, words.Words.Count)];

            // Add the input tile buttons to the buttons list
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            buttons.Add(btn4);
            buttons.Add(btn5);
            buttons.Add(btn6);
            buttons.Add(btn7);
            buttons.Add(btn8);
            buttons.Add(btn9);
            buttons.Add(btn10);
            buttons.Add(btn11);
            buttons.Add(btn12);
            buttons.Add(btn13);
            buttons.Add(btn14);
            buttons.Add(btn15);
            buttons.Add(btn16);
            buttons.Add(btn17);
            buttons.Add(btn18);
            buttons.Add(btn19);
            buttons.Add(btn20);

            // Add the press buttons to the pressButtons list
            pressButtons.Add(pressBtn1);
            pressButtons.Add(pressBtn2);
            pressButtons.Add(pressBtn3);
            pressButtons.Add(pressBtn4);
            pressButtons.Add(pressBtn5);
            pressButtons.Add(pressBtn6);
            pressButtons.Add(pressBtn7);
            pressButtons.Add(pressBtn8);
            pressButtons.Add(pressBtn9);
            pressButtons.Add(pressBtn10);
            pressButtons.Add(pressBtn11);
            pressButtons.Add(pressBtn12);
            pressButtons.Add(pressBtn13);
            pressButtons.Add(pressBtn14);
            pressButtons.Add(pressBtn15);
            pressButtons.Add(pressBtn16);
            pressButtons.Add(pressBtn17);
            pressButtons.Add(pressBtn18);
            pressButtons.Add(pressBtn19);
            pressButtons.Add(pressBtn20);
            pressButtons.Add(pressBtn21);
            pressButtons.Add(pressBtn22);
            pressButtons.Add(pressBtn23);
            pressButtons.Add(pressBtn24);
            pressButtons.Add(pressBtn25);
            pressButtons.Add(pressBtn26);


            giveUpBtn.Visible = false;

            // Wire up the KeyPress event for the form.
            this.KeyPress += Buttons_KeyPress;
            this.KeyPreview = true; // Ensure the form receives key events.
        }



        private void getTextButton_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (loopIndex < 5)
            {
                buttons[currentButtonIndex].Text = b.Text.ToUpper();
                currentButtonIndex++;
                loopIndex++;
            }

        }

        private void Buttons_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((loopIndex < 5 && Char.IsLetter(e.KeyChar)) && !usedLetters.Contains(Char.ToUpper(e.KeyChar)))
            {
                buttons[currentButtonIndex].Text = e.KeyChar.ToString().ToUpper();
                currentButtonIndex++;
                loopIndex++;
            }
        }

        private void bckSpace_Click(object sender, EventArgs e)
        {

            if (currentButtonIndex >= 0 && loopIndex >= 0)
            {
                buttons[currentButtonIndex - 1].Text = "";
                currentButtonIndex--;
                loopIndex--;
            }
        }


        private void enterBtn_Click(object sender, EventArgs e)
        {

            giveUpBtn.Visible = true;
            // Check if loopIndex has already 5 inputs
            if (loopIndex == 5)
            {

                // Get the text of the buttons and build the characters to string
                StringBuilder input = new StringBuilder();
                for (int i = 5; i > 0; i--)
                {
                    input.Append(buttons[currentButtonIndex - i].Text);
                }

                // Check for valid input
                if (CheckValidInput(input.ToString().ToUpper(), words))
                {

                    // Proceed further checking if input == word
                    if (isEqual(input.ToString()))
                    {
                        for (int i = 5; i > 0; i--)
                        {
                            //buttons[currentButtonIndex - i].ForeColor = Color.White;
                            buttons[currentButtonIndex - i].BackColor = Color.Green;

                        }
                        MessageBox.Show("You Have Guessed the word!", "You Win!!", MessageBoxButtons.OK);
                        currentButtonIndex = 0;
                        isWin = true;
                        resetBoard();

                        this.Close();
                    }

                    // Otherwise, (check if a char exist || output lose message) and clear the input
                    else
                    {
                        // check the order if a char exist 

                        if (currentButtonIndex <= 20)
                        {
                            checkOrder(input.ToString().ToUpper(), guessWord.ToUpper());
                        }

                        // Message if word is not guessed && currentButtonIndex < 20
                        MessageBox.Show("Guess Again!", "Try Again!!", MessageBoxButtons.OK);

                        // Otherwise, Output lose message
                        if (currentButtonIndex == 20)
                        {
                            MessageBox.Show($"The word was: {guessWord}", "You Lose!!", MessageBoxButtons.OK);
                            resetBoard();
                            currentButtonIndex = 0;
                            isWin = false;
                            this.Close();
                        }

                        // Clear the input every after guess
                        input.Clear();
                    }

                    // Reset the loopIndex ready for another batch of characters
                    loopIndex = 0;

                }


                // If word is not valid, output "not a word" message
                else
                {
                    MessageBox.Show($"{input.ToString()} is not a word", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Otherwise, output "missing input" error
            else
            {
                MessageBox.Show("Missing input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void giveUpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The word was: {guessWord}", "You Lose!!", MessageBoxButtons.OK);
            resetBoard();
            currentButtonIndex = 0;
            isWin = false;
            this.Close();
        }

        // <-- Helper Methods -- >

        /// <summary>
        /// 
        ///  A method to verify if the input of the user is equal to the word 
        ///  given by the program
        ///  
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool isEqual(String input)
        {
            //char[] word = words[0].ToCharArray();


            if (guessWord.Length == input.Length && guessWord.ToUpper().SequenceEqual(input.ToUpper()))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 
        ///     A method to reset the board by changing the 
        ///     buttons' BackColor to white and text to empty string and 
        ///     also generating another randowm word.
        ///     
        /// </summary>
        /// <param name="b"></param>
        private void resetBoard()
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.BackColor = Color.White;
            }

            foreach (Button button in pressButtons)
            {

                button.Enabled = true;
                button.BackColor = Color.White;

            }

            giveUpBtn.Visible = false;
            usedLetters.Clear();

            guessWord = words.Words[random.Next(0, words.Words.Count)];
        }

        /// <summary>
        /// 
        ///     A method to check the order of the char that are within 
        ///     the random word. Also, change backcolor of buttons within
        ///     their respective colors.
        ///     
        ///     BackColor:
        ///         Green == order && exist
        ///         Yellow == !order && exist
        ///         Gray == !order && !exist
        ///         
        ///      
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="word"></param>
        private void checkOrder(String input, String word)
        {

            // Convert input and word to char array
            char[] inputArray = input.ToCharArray();
            char[] wordArray = word.ToCharArray();
            bool found;

            // Traverse through the arrays
            for (int i = 0; i < wordArray.Length; i++)
            {

                found = false;
                // Check if at the same index they are equal
                if (inputArray[i] == wordArray[i])
                {
                    buttons[currentButtonIndex + i - 5].BackColor = Color.Green;
                    continue;
                }

                // Else, find if letter exist
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[i] == wordArray[j])
                    {
                        // if exist, BackColor is changed to Yellow
                        buttons[currentButtonIndex + i - 5].BackColor = Color.Yellow;
                        found = true;
                        break; // Break out of the inner loop
                    }
                }

                // Otherwise, none exist
                if (!found)
                {
                    buttons[currentButtonIndex + i - 5].BackColor = Color.Gray;
                    RemoveUsedLetter(inputArray[i].ToString());
                    usedLetters.Add(inputArray[i]);
                }


            }
        }


        /// <summary>
        /// 
        ///     A method that returns true if input is in the word list.
        ///     Otherwise, return false
        ///     
        /// </summary>
        /// <param name="input"></param>
        /// <param name="word"></param>
        /// <returns></returns>

        private bool CheckValidInput(String input, FiveLetterWords word)
        {

            foreach (String w in word.Words)
            {
                if (w.ToUpper() == input)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        ///     A method that remove the used letter from the input that is not 
        ///     a part of the word by changing the backColor to gray and its
        ///     enabled to false
        ///     
        /// </summary>
        /// <param name="letter"></param>

        private void RemoveUsedLetter(String letter)
        {
            foreach (Button button in pressButtons)
            {
                if (button.Text == letter)
                {
                    button.BackColor = Color.Gray;
                    button.Enabled = !button.Enabled;
                }
            }
        }


    }
}