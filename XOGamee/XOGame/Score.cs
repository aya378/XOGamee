using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace tProject
{
    public partial class Score : Form
    {
        public Score(string player1Name, string player2Name, string playerscore1, string playerscore2)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            txt_player1.Text = player1Name;
            txt_player2.Text = player2Name;
            txt_score1.Text = playerscore1;
            txt_score2.Text = playerscore2;
            btn_delete.Visible = false;
        }


        private void Score_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Hide();
            f.Close();
            dgv_score.DataSource = GameCommands.Select();
            dgv_score.Columns["Id"].Visible = false;
        }
        int currentId = 0;
        private void dgv_score_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dgv_score.SelectedRows[0];
            currentId = (int)row.Cells["Id"].Value;
            txt_player1.Text = row.Cells["PlayerXName"].Value.ToString();
            txt_score1.Text = row.Cells["PlayerXScore"].Value.ToString();
            txt_player2.Text = row.Cells["PlayerOName"].Value.ToString();
            txt_score2.Text = row.Cells["PlayerOScore"].Value.ToString();
            btn_delete.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (currentId > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete these Players?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int effectedRows = GameCommands.Delete(currentId);
                    if (effectedRows > 0)
                    {
                        MessageBox.Show("Data deleted");
                        dgv_score.Rows.RemoveAt(dgv_score.SelectedRows[0].Index);
                        currentId = 0;
                        txt_player1.Text = "";
                        txt_player2.Text = "";
                        txt_score1.Text = "";
                        txt_score2.Text = "";
                    }
                }
                btn_delete.Visible = false;
            }

            else
            {
                MessageBox.Show("Please select a record to delete");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
    

