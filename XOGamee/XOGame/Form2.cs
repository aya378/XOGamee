using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tProject
{

    public partial class Form2 : Form
    {
        public string player1
        {
            set
            {
                txt_player1.Text = value;

            }
            get
            {
                return txt_player1.Text;
            }
        }

        public string player2
        {
            set
            {
                txt_player2.Text = value;

            }
            get
            {
                return txt_player2.Text;
            }
        }
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            rbtnx1.Enabled = true;
            rbtno1.Enabled = true;
            rbtno2.Enabled = true;
            rbtno2.Enabled = true;
        }

        #region buttons check
        private void rbtnx1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnx1.Checked && !rbtno2.Checked)
            {
                rbtno2.Enabled = true;
                rbtno2.Checked = true;
                rbtno1.Checked = false;

            }
        }

        private void rbtno1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtno1.Checked && !rbtnx2.Checked)
            {
                rbtnx2.Enabled = true;
                rbtnx2.Checked = true;
                rbtnx1.Checked = false;
            }
        }

        private void rbtnx2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnx2.Checked && !rbtno1.Checked)
            {
                rbtno2.Enabled = true;
                rbtno2.Checked = false;
                rbtno1.Checked = true;
            }
        }

        private void rbtno2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtno2.Checked && !rbtnx1.Checked)
            {
                rbtnx1.Checked = true;
                rbtnx2.Enabled = true;
                rbtnx2.Checked = false;
                rbtno1.Checked = false;
            }
        }

        #endregion

        string firstPlayerSymbol = " ";
        string secondPlayerSymbol = " ";
        public void button1_Click(object sender, EventArgs e)
        {
            #region checking for inputs

            if (string.IsNullOrWhiteSpace(player1) || string.IsNullOrWhiteSpace(player2))
            {
                MessageBox.Show("Please enter both player's names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rbtnx1.Checked && !rbtno1.Checked)
            {
                MessageBox.Show("Please select a symbol for Player 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rbtnx2.Checked && !rbtno2.Checked)
            {
                MessageBox.Show("Please select a symbol for Player 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            #region getting symbols
            if (rbtnx1.Checked)
            {
                firstPlayerSymbol = "X";
            }
            else if (rbtno1.Checked)
            {
                firstPlayerSymbol = "O";
            }
            if (rbtnx2.Checked)
            {
                secondPlayerSymbol = "X";
            }
            else if (rbtno2.Checked)
            {
                secondPlayerSymbol = "O";
            }
            #endregion

            DialogResult result = MessageBox.Show($"{player1} playes with {firstPlayerSymbol} \n {player2} playes with {secondPlayerSymbol}", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Form1 f1 = new Form1(player1, player2, firstPlayerSymbol, secondPlayerSymbol);
                f1.ShowDialog();
                this.Close();
            }

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExite;
                iExite = MessageBox.Show("Are You Sure You want to exit?", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExite == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }
    }
}
