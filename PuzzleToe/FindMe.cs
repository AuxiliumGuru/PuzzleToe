using System.Security.Cryptography;
using System.Xml;

namespace ClickMe
{
    public partial class FindMe : Form
    {
        public FindMe()
        {
            InitializeComponent();
        }
        Random random = new Random();

        Stage stage = new Stage();
        int[] currStage;
        StageForm stagePic = new StageForm();


        Button[] btnArray = new Button[16];
        List<int[]> stages = new List<int[]>();

        private int attempts = 7;
        private int num_winning_tiles = 4;
        private bool isWin = false;

        public bool IsWin
        {
            get { return isWin; }
        }


        private void FindMe_Load(object sender, EventArgs e)
        {
            btnArray[0] = btn1;
            btnArray[1] = btn2;
            btnArray[2] = btn3;
            btnArray[3] = btn4;

            btnArray[4] = btn5;
            btnArray[5] = btn6;
            btnArray[6] = btn7;
            btnArray[7] = btn8;


            btnArray[8] = btn9;
            btnArray[9] = btn10;
            btnArray[10] = btn11;
            btnArray[11] = btn12;

            btnArray[12] = btn13;
            btnArray[13] = btn14;
            btnArray[14] = btn15;
            btnArray[15] = btn16;


            stages.Add(new int[16]
            {
                0, 0, 0, 0,
                0, 0, 1, 0,
                0, 1, 1, 0,
                0, 0, 1, 0
            });



            attemptLbl.Text = attemptLbl.Text + attempts.ToString();

            setGameStage();
        }


        public void setGameStage()
        {
            int random_stage_num = random.Next(0, stage.Stages.Count());

            stagePic.setPic(stage.Images[random_stage_num]);
            currStage = stage.setStage(random_stage_num);
        }

        public void btn_click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            int currButton = Convert.ToInt32(b.Name[3..]);
            //bool isTrue = false;

            //MessageBox.Show(currButton.ToString(), "debug")

            if (currStage[currButton - 1] == 1)
            {
                num_winning_tiles--;
                attempts--;
                b.Text = "1";
                b.BackColor = Color.Green;
                b.Enabled = false;

            }
            else
            {
                attempts--;
                b.Text = "0";
                b.BackColor = Color.Gray;
                b.Enabled = false;
            }

            attemptLbl.Text = "Number of Attempts: " + attempts.ToString();

            if (isWinner())
            {
                isWin = true;
                MessageBox.Show("Congratulations!!", "You win!");
                //resetBoard();
                this.Close();
            }

            if (isLoser())
            {
                isWin = false;
                MessageBox.Show("Try again later!!", "You lose!");
                //resetBoard();
                this.Close();
            }


        }

        //public void resetBoard()
        //{
        //    foreach (var b in btnArray)
        //    {
        //        b.Text = "";
        //        b.BackColor = Color.White;
        //        b.Enabled = true;
        //    }

        //    num_winning_tiles = 4;
        //    attempts = 7;
        //    attemptLbl.Text = "Number of Attempts: " + attempts.ToString();

        //    setGameStage();

        //}

        public bool isLoser()
        {
            if (attempts == 0)
            {
                return true;
            }

            return false;
        }
        public bool isWinner()
        {

            if (num_winning_tiles == 0)
            {
                return true;
            }

            return false;

        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            stagePic.ShowDialog();

        }


    }
}