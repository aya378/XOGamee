namespace tProject
{
    partial class Form2
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
            panel1 = new Panel();
            rbtno1 = new RadioButton();
            rbtnx1 = new RadioButton();
            txt_player1 = new TextBox();
            label2 = new Label();
            lbl_player1 = new Label();
            rbtno2 = new RadioButton();
            rbtnx2 = new RadioButton();
            txt_player2 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(rbtno1);
            panel1.Controls.Add(rbtnx1);
            panel1.Controls.Add(txt_player1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbl_player1);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 215);
            panel1.TabIndex = 0;
            // 
            // rbtno1
            // 
            rbtno1.AutoSize = true;
            rbtno1.Location = new Point(277, 93);
            rbtno1.Name = "rbtno1";
            rbtno1.Size = new Size(34, 19);
            rbtno1.TabIndex = 4;
            rbtno1.TabStop = true;
            rbtno1.Text = "O";
            rbtno1.UseVisualStyleBackColor = true;
            rbtno1.CheckedChanged += rbtno1_CheckedChanged;
            // 
            // rbtnx1
            // 
            rbtnx1.AutoSize = true;
            rbtnx1.Location = new Point(186, 93);
            rbtnx1.Name = "rbtnx1";
            rbtnx1.Size = new Size(32, 19);
            rbtnx1.TabIndex = 3;
            rbtnx1.TabStop = true;
            rbtnx1.Text = "X";
            rbtnx1.UseVisualStyleBackColor = true;
            rbtnx1.CheckedChanged += rbtnx1_CheckedChanged;
            // 
            // txt_player1
            // 
            txt_player1.Location = new Point(44, 142);
            txt_player1.Name = "txt_player1";
            txt_player1.Size = new Size(267, 23);
            txt_player1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 69);
            label2.Name = "label2";
            label2.Size = new Size(155, 53);
            label2.TabIndex = 1;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_player1
            // 
            lbl_player1.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold);
            lbl_player1.Location = new Point(3, 11);
            lbl_player1.Name = "lbl_player1";
            lbl_player1.Size = new Size(166, 53);
            lbl_player1.TabIndex = 0;
            lbl_player1.Text = "Player 1";
            // 
            // rbtno2
            // 
            rbtno2.AutoSize = true;
            rbtno2.Location = new Point(274, 93);
            rbtno2.Name = "rbtno2";
            rbtno2.Size = new Size(34, 19);
            rbtno2.TabIndex = 5;
            rbtno2.TabStop = true;
            rbtno2.Text = "O";
            rbtno2.UseVisualStyleBackColor = true;
            rbtno2.CheckedChanged += rbtno2_CheckedChanged;
            // 
            // rbtnx2
            // 
            rbtnx2.AutoSize = true;
            rbtnx2.Location = new Point(186, 93);
            rbtnx2.Name = "rbtnx2";
            rbtnx2.Size = new Size(32, 19);
            rbtnx2.TabIndex = 5;
            rbtnx2.TabStop = true;
            rbtnx2.Text = "X";
            rbtnx2.UseVisualStyleBackColor = true;
            rbtnx2.CheckedChanged += rbtnx2_CheckedChanged;
            // 
            // txt_player2
            // 
            txt_player2.Location = new Point(46, 142);
            txt_player2.Name = "txt_player2";
            txt_player2.Size = new Size(274, 23);
            txt_player2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(155, 53);
            label3.TabIndex = 2;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(153, 53);
            label1.TabIndex = 1;
            label1.Text = "Player 2";
            // 
            // button1
            // 
            button1.BackColor = Color.Orange;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(332, 393);
            button1.Name = "button1";
            button1.Size = new Size(221, 45);
            button1.TabIndex = 2;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(401, 174);
            button2.Name = "button2";
            button2.Size = new Size(98, 49);
            button2.TabIndex = 3;
            button2.Text = "VS";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(rbtno2);
            panel2.Controls.Add(rbtnx2);
            panel2.Controls.Add(txt_player2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(591, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 215);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.Orange;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 459);
            button3.Name = "button3";
            button3.Size = new Size(92, 39);
            button3.TabIndex = 4;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(978, 530);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_player1;
        private TextBox txt_player1;
        private Label label2;
        private TextBox txt_player2;
        private Label label3;
        private Label label1;
        private RadioButton rbtno1;
        private RadioButton rbtnx1;
        private RadioButton rbtno2;
        private RadioButton rbtnx2;
        private Button button1;
        private Button button2;
        private Panel panel2;
        private Button button3;
    }
}