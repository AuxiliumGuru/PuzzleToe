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
        Random random;

        private void Form1_Load(object sender, EventArgs e)
        {
            QandA = new Questions();
            inf_to_pf = new InfixToPostfix();
            attempts = 3;
            random = new Random();
            random_index = random.Next(QandA.Expression.Count);

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string input = inputTxt.Text;

            if (Convert.ToDouble(inf_to_pf.GetValue(input)) == QandA.Answers[random_index])
            {
                MessageBox.Show("Correct!!", "You Win!");
                //attempts = 3;
                isWin = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Try again!!", "Wrong Answer!");
                attempts--;
            }

            if (isLoser())
            {
                MessageBox.Show("Better luck next time!!", "You Lose!");
                //attempts = 3;
                this.Close();
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
    }
}