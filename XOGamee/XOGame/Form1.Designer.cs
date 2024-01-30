namespace tProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            score1 = new Label();
            score2 = new Label();
            btn_newgame = new Button();
            button11 = new Button();
            button12 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            lbl_o = new Label();
            lbl_x = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(345, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 50);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(87, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 40);
            label1.TabIndex = 15;
            label1.Text = "XO Game";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btn9);
            panel3.Controls.Add(btn8);
            panel3.Controls.Add(btn7);
            panel3.Controls.Add(btn6);
            panel3.Controls.Add(btn5);
            panel3.Controls.Add(btn4);
            panel3.Controls.Add(btn3);
            panel3.Controls.Add(btn2);
            panel3.Controls.Add(btn1);
            panel3.Font = new Font("Segoe UI", 96F);
            panel3.Location = new Point(13, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 433);
            panel3.TabIndex = 1;
            // 
            // btn9
            // 
            btn9.BackColor = Color.WhiteSmoke;
            btn9.Font = new Font("Segoe UI Symbol", 66F, FontStyle.Italic);
            btn9.Location = new Point(291, 287);
            btn9.Name = "btn9";
            btn9.Size = new Size(138, 135);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.WhiteSmoke;
            btn8.Font = new Font("Segoe UI Symbol", 66F, FontStyle.Italic);
            btn8.Location = new Point(147, 287);
            btn8.Name = "btn8";
            btn8.Size = new Size(138, 135);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.WhiteSmoke;
            btn7.Font = new Font("Segoe UI Symbol", 66F, FontStyle.Italic);
            btn7.Location = new Point(3, 287);
            btn7.Name = "btn7";
            btn7.Size = new Size(138, 135);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.WhiteSmoke;
            btn6.Font = new Font("Segoe UI Symbol", 66F, FontStyle.Italic);
            btn6.Location = new Point(291, 144);
            btn6.Name = "btn6";
            btn6.Size = new Size(138, 135);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.WhiteSmoke;
            btn5.Font = new Font("Segoe UI Symbol", 66F, FontStyle.Italic);
            btn5.Location = new Point(147, 146);
            btn5.Name = "btn5";
            btn5.Size = new Size(138, 135);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.WhiteSmoke;
            btn4.Font = new Font("Segoe UI Symbol", 66F, FontStyle.Italic);
            btn4.Location = new Point(3, 146);
            btn4.Name = "btn4";
            btn4.Size = new Size(138, 135);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.WhiteSmoke;
            btn3.Font = new Font("Segoe UI Symbol", 66F, FontStyle.Italic);
            btn3.Location = new Point(291, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(138, 135);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.WhiteSmoke;
            btn2.Font = new Font("Segoe UI Symbol", 66F, FontStyle.Italic);
            btn2.Location = new Point(147, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(138, 135);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.WhiteSmoke;
            btn1.Font = new Font("Segoe UI Symbol", 66F, FontStyle.Italic);
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(138, 135);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // score1
            // 
            score1.BackColor = Color.White;
            score1.BorderStyle = BorderStyle.Fixed3D;
            score1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score1.ForeColor = Color.Black;
            score1.Location = new Point(747, 13);
            score1.Name = "score1";
            score1.Size = new Size(159, 64);
            score1.TabIndex = 0;
            score1.Text = "0";
            score1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // score2
            // 
            score2.BackColor = Color.White;
            score2.BorderStyle = BorderStyle.Fixed3D;
            score2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score2.ForeColor = Color.Black;
            score2.Location = new Point(747, 113);
            score2.Name = "score2";
            score2.Size = new Size(159, 64);
            score2.TabIndex = 3;
            score2.Text = "0";
            score2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_newgame
            // 
            btn_newgame.BackColor = Color.Orange;
            btn_newgame.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_newgame.Location = new Point(467, 198);
            btn_newgame.Name = "btn_newgame";
            btn_newgame.Size = new Size(485, 79);
            btn_newgame.TabIndex = 9;
            btn_newgame.Text = "New Game";
            btn_newgame.UseVisualStyleBackColor = false;
            btn_newgame.Click += btn_newgame_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Orange;
            button11.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(467, 365);
            button11.Name = "button11";
            button11.Size = new Size(235, 78);
            button11.TabIndex = 10;
            button11.Text = "Reset";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Orange;
            button12.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(708, 365);
            button12.Name = "button12";
            button12.Size = new Size(244, 78);
            button12.TabIndex = 11;
            button12.Text = "Exit";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(467, 283);
            button1.Name = "button1";
            button1.Size = new Size(485, 76);
            button1.TabIndex = 12;
            button1.Text = "Save Scores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lbl_o);
            panel2.Controls.Add(lbl_x);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(score2);
            panel2.Controls.Add(score1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btn_newgame);
            panel2.Location = new Point(12, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 456);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lbl_o
            // 
            lbl_o.AutoSize = true;
            lbl_o.BackColor = Color.Transparent;
            lbl_o.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lbl_o.Location = new Point(535, 128);
            lbl_o.Name = "lbl_o";
            lbl_o.Size = new Size(133, 40);
            lbl_o.TabIndex = 14;
            lbl_o.Text = "Player O";
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.BackColor = Color.Transparent;
            lbl_x.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            lbl_x.Location = new Point(535, 23);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new Size(130, 40);
            lbl_x.TabIndex = 13;
            lbl_x.Text = "Player X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(982, 537);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Label score1;
        private Label score2;
        private Button btn_newgame;
        private Button button11;
        private Button button12;
        private Button button1;
        private Panel panel2;
        private Label lbl_o;
        private Label lbl_x;
        private Label label1;
    }
}
