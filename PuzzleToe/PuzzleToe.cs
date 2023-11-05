
namespace PuzzleToe
{
    public partial class PuzzleToe : Form
    {
        public PuzzleToe()
        {
            InitializeComponent();
        }

        TicTacToe.TicTactoe gameForm;

        private void startBtn_Click(object sender, EventArgs e)
        {
            gameForm = new TicTacToe.TicTactoe();

            gameForm.Show();
            this.Hide();

        }
    }
}