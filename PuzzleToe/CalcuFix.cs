using PuzzleToe;
using System.Text.RegularExpressions;
namespace BracketQuest
{
    public partial class CalcuFix : Form
    {
        public CalcuFix()
        {
            InitializeComponent();
        }

        // Class attributes
        private String expression;
        private double answer;
        private int attempts;
        private int random_index;
        private bool isWin;

        public bool IsWin
        {
            get { return isWin; }
        }

        // Questions Class
        private Questions QandA;
        // InFix to PostFix class
        private InfixToPostfix inf_to_pf;

        // Random class to get random expression with answer
        private Random random;

        // HelpForm
        private HelpForm helpForm;

        private void Form1_Load(object sender, EventArgs e)
        {
            QandA = new Questions();
            inf_to_pf = new InfixToPostfix();
            attempts = 3;
            random = new Random();
            random_index = random.Next(QandA.Expression.Count);
            attemptLabel.Visible = false;

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string input = inputTxt.Text;
            string pattern = "[a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                MessageBox.Show("Alphabet caught in the input", "Alphabet Catcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToDouble(inf_to_pf.GetValue(input)) == QandA.Answers[random_index])
                {
                    MessageBox.Show("Correct!!", "You Win!");
                    attempts = 3;
                    isWin = true;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Try again!!", "Wrong Answer!");
                    attempts--;
                }

                attemptLabel.Text = "Number Of Attempts Left: " + attempts;
                attemptLabel.Visible = true;

                if (isLoser())
                {
                    MessageBox.Show("Better luck next time!!", "You Lose!");
                    attempts = 3;
                    this.Close();
                }



            }



        }


        // Helper Methods

        public void displayExpression()
        {

            expression = QandA.Expression[random_index];
            answer = QandA.Answers[random_index];

            equationLabel.Text = $" {expression} = {answer}";

        }

        public bool isLoser()
        {
            if (attempts == 0)
            {
                return true;
            }

            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            displayExpression();
            float fontSize = panel1.Width / 11; // You can adjust this ratio as needed
            equationLabel.Font = new Font(equationLabel.Font.FontFamily, fontSize, equationLabel.Font.Style);
            equationLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void helpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            helpForm = new HelpForm();

            helpForm.SetHelpText(
                 "The objective of this game is to fix the given arithmetic expression." + Environment.NewLine +
                 "- The answer is already fixed, and the answer of the arithmetic expression must equal the given answer" + Environment.NewLine +
                 "- The arithmetic expression has missing operators or parentheses. Find them and add them to the expression to win the game" + Environment.NewLine +
                 "- You only have 3 attempts to win the game" + Environment.NewLine
             );
            helpForm.ShowDialog();
        }


    }
}