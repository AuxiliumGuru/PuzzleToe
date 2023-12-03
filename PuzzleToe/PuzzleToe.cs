
namespace PuzzleToe
{
    public partial class PuzzleToe : Form
    {
        public PuzzleToe()
        {
            InitializeComponent();
        }

        private TicTacToe.TicTactoe gameForm;
        private About aboutForm;

        private void startBtn_Click(object sender, EventArgs e)
        {
            gameForm = new TicTacToe.TicTactoe();

            gameForm.Show();
            this.Hide();

        }



        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            aboutForm = new About();
            aboutForm.Show();

        }
    }
}