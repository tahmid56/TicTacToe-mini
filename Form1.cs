using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_mini_
{
    public partial class TicTacToe : Form
    {
        bool turn = true;
        int turn_count = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void aboutbtn(object sender, EventArgs e)
        {
            MessageBox.Show("By Tahmid","About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            b.Enabled = false;
            turn_count++;
            checkWinner();
            turn = !turn;
        }

        private void checkWinner()
        {
            bool winner = false;
            //horizontal check
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                winner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                winner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                winner = true;
            //vertical check
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                winner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                winner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                winner = true;
            //cross check
            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                winner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                winner = true;


            if (winner)
            {
                disablebutton();
                string player = "";
                if (turn)
                    player = "X";
                else
                    player = "O";
                MessageBox.Show(player+" Wins!!","WINNER!");
            }
            else if(turn_count == 9)
            {
                MessageBox.Show("Draw!!","Notice!");
            }
        }

        private void disablebutton()
        {   try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button) c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }
    }
}
