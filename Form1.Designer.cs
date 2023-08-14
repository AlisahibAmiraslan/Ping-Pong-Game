namespace PingPongGame
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
            components = new System.ComponentModel.Container();
            playground = new Panel();
            points_lbl = new Label();
            score_lbl = new Label();
            ball = new PictureBox();
            racket = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            gameover_lbl = new Label();
            playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)racket).BeginInit();
            SuspendLayout();
            // 
            // playground
            // 
            playground.Controls.Add(gameover_lbl);
            playground.Controls.Add(points_lbl);
            playground.Controls.Add(score_lbl);
            playground.Controls.Add(ball);
            playground.Controls.Add(racket);
            playground.Dock = DockStyle.Fill;
            playground.Location = new Point(0, 0);
            playground.Name = "playground";
            playground.Size = new Size(800, 450);
            playground.TabIndex = 0;
            // 
            // points_lbl
            // 
            points_lbl.AutoSize = true;
            points_lbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            points_lbl.Location = new Point(147, 18);
            points_lbl.Name = "points_lbl";
            points_lbl.Size = new Size(40, 46);
            points_lbl.TabIndex = 3;
            points_lbl.Text = "0";
            // 
            // score_lbl
            // 
            score_lbl.AutoSize = true;
            score_lbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            score_lbl.Location = new Point(9, 10);
            score_lbl.Name = "score_lbl";
            score_lbl.Size = new Size(148, 54);
            score_lbl.TabIndex = 2;
            score_lbl.Text = "Score: ";
            // 
            // ball
            // 
            ball.BackColor = Color.Crimson;
            ball.Location = new Point(243, 90);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // racket
            // 
            racket.BackColor = Color.Black;
            racket.Location = new Point(286, 387);
            racket.Name = "racket";
            racket.Size = new Size(200, 20);
            racket.TabIndex = 0;
            racket.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // gameover_lbl
            // 
            gameover_lbl.Anchor = AnchorStyles.None;
            gameover_lbl.AutoSize = true;
            gameover_lbl.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gameover_lbl.Location = new Point(333, 39);
            gameover_lbl.Name = "gameover_lbl";
            gameover_lbl.Size = new Size(408, 324);
            gameover_lbl.TabIndex = 4;
            gameover_lbl.Text = "Game Over !!!\r\n\r\nF1 = Restart\r\nEsc = Exit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playground);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            playground.ResumeLayout(false);
            playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)racket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel playground;
        private PictureBox ball;
        private PictureBox racket;
        private System.Windows.Forms.Timer timer1;
        private Label score_lbl;
        private Label points_lbl;
        private Label gameover_lbl;
    }
}