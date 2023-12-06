using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleToe
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setAboutText()
        {
            aboutTxt.Text =
            "Welcome to PuzzleToe, where Tic-Tac-Toe meets strategic " +
            "twists and turns. In this game, every X or O placement unveils " +
            "intriguing side quests, transforming the classic into a dynamic " +
            "puzzle-solving experience. The challenge escalates with each move, " +
            "offering more complexity as the board evolves. PuzzleToe isn't just a game; " +
            "it's a journey where wit and strategy collide. Can you navigate the ever-shifting " +
            "puzzle landscape, outsmart your opponent, and emerge victorious in this " +
            "thrilling fusion of tactics and twists? Prepare for a gaming experience where " +
            "every move counts, and every victory is a triumph over the unexpected!" + Environment.NewLine + Environment.NewLine +
            "Developers: " + Environment.NewLine +
            "  Allan Khester Mesa" + Environment.NewLine +
            "  Kenn-Roe Basseg" + Environment.NewLine +
            "  Rey Christian Ramos" + Environment.NewLine +
            "  Xadrian Kyle Pinera" + Environment.NewLine +
            "  Rommel Christian Chua" + Environment.NewLine +
            "  Yves Alcantara" + Environment.NewLine;
            ;

        }

        private void About_Load(object sender, EventArgs e)
        {
            setAboutText();
        }
    }
}
