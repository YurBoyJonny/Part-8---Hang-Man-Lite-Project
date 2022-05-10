using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Part_8___Hang_Man_Lite_Project
{
    public partial class HangMan : Form
    {
        string SecretWord = "COMPUTER";
        int GuessTries = 3;
        public HangMan()
        {
            InitializeComponent();
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            txtGuess.Text = txtGuess.Text.ToUpper();

            if (SecretWord != txtGuess.Text)
            {
                imgHang.Image = Properties.Resources.hangman_1;
                GuessTries = GuessTries - 1;
            }
            else if (GuessTries == 2)
            {
                imgHang.Image = Properties.Resources.hangman_2;
                GuessTries = GuessTries - 1;
            }
            if (GuessTries == 1)
            {
                imgHang.Image = Properties.Resources.hangman_dead;
            }
            else if (SecretWord == txtGuess.Text)
            {
                lblWord.Text = txtGuess.Text.ToUpper();
            }

        }
    }
}
