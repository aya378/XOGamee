namespace tProject
{
    partial class Score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_score = new DataGridView();
            player1 = new Button();
            player2 = new Button();
            txt_player1 = new TextBox();
            txt_player2 = new TextBox();
            score1 = new Button();
            score2 = new Button();
            txt_score1 = new TextBox();
            txt_score2 = new TextBox();
            gDate = new Button();
            dateTimePicker1 = new DateTimePicker();
            btn_delete = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_score).BeginInit();
            SuspendLayout();
            // 
            // dgv_score
            // 
            dgv_score.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_score.Location = new Point(12, 267);
            dgv_score.Name = "dgv_score";
            dgv_score.Size = new Size(559, 251);
            dgv_score.TabIndex = 0;
            dgv_score.RowHeaderMouseDoubleClick += dgv_score_RowHeaderMouseDoubleClick;
            // 
            // player1
            // 
            player1.BackColor = Color.Orange;
            player1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1.Location = new Point(12, 12);
            player1.Name = "player1";
            player1.Size = new Size(215, 45);
            player1.TabIndex = 3;
            player1.Text = "X Player Name";
            player1.UseVisualStyleBackColor = false;
            // 
            // player2
            // 
            player2.BackColor = Color.Orange;
            player2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2.Location = new Point(12, 76);
            player2.Name = "player2";
            player2.Size = new Size(215, 45);
            player2.TabIndex = 4;
            player2.Text = "O Player Name";
            player2.UseVisualStyleBackColor = false;
            // 
            // txt_player1
            // 
            txt_player1.Location = new Point(242, 28);
            txt_player1.Name = "txt_player1";
            txt_player1.Size = new Size(155, 23);
            txt_player1.TabIndex = 5;
            // 
            // txt_player2
            // 
            txt_player2.Location = new Point(242, 88);
            txt_player2.Name = "txt_player2";
            txt_player2.Size = new Size(155, 23);
            txt_player2.TabIndex = 6;
            // 
            // score1
            // 
            score1.BackColor = Color.Orange;
            score1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score1.Location = new Point(443, 12);
            score1.Name = "score1";
            score1.Size = new Size(215, 45);
            score1.TabIndex = 7;
            score1.Text = "X Player Score";
            score1.UseVisualStyleBackColor = false;
            // 
            // score2
            // 
            score2.BackColor = Color.Orange;
            score2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score2.Location = new Point(443, 76);
            score2.Name = "score2";
            score2.Size = new Size(215, 45);
            score2.TabIndex = 8;
            score2.Text = "O Player Score";
            score2.UseVisualStyleBackColor = false;
            // 
            // txt_score1
            // 
            txt_score1.Location = new Point(674, 28);
            txt_score1.Name = "txt_score1";
            txt_score1.Size = new Size(155, 23);
            txt_score1.TabIndex = 9;
            // 
            // txt_score2
            // 
            txt_score2.Location = new Point(674, 88);
            txt_score2.Name = "txt_score2";
            txt_score2.Size = new Size(155, 23);
            txt_score2.TabIndex = 10;
            // 
            // gDate
            // 
            gDate.BackColor = Color.Orange;
            gDate.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gDate.Location = new Point(12, 144);
            gDate.Name = "gDate";
            gDate.Size = new Size(147, 45);
            gDate.TabIndex = 11;
            gDate.Text = "Game Date";
            gDate.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(197, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Orange;
            btn_delete.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(795, 154);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(95, 45);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(601, 154);
            button1.Name = "button1";
            button1.Size = new Size(148, 45);
            button1.TabIndex = 14;
            button1.Text = "New Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 216);
            button2.Name = "button2";
            button2.Size = new Size(147, 45);
            button2.TabIndex = 15;
            button2.Text = "Scores";
            button2.UseVisualStyleBackColor = false;
            // 
            // Score
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(978, 530);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(dateTimePicker1);
            Controls.Add(gDate);
            Controls.Add(txt_score2);
            Controls.Add(txt_score1);
            Controls.Add(score2);
            Controls.Add(score1);
            Controls.Add(txt_player2);
            Controls.Add(txt_player1);
            Controls.Add(player2);
            Controls.Add(player1);
            Controls.Add(dgv_score);
            Name = "Score";
            Text = "Score";
            Load += Score_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_score;
        private Button player1;
        private Button player2;
        private TextBox txt_player1;
        private TextBox txt_player2;
        private Button score1;
        private Button score2;
        private TextBox txt_score1;
        private TextBox txt_score2;
        private Button gDate;
        private DateTimePicker dateTimePicker1;
        private Button btn_delete;
        private Button button1;
        private Button button2;
    }
}