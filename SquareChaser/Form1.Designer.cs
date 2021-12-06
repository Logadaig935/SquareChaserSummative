namespace SquareChaser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.x2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(448, 308);
            this.winLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(300, 80);
            this.winLabel.TabIndex = 3;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p2ScoreLabel.Location = new System.Drawing.Point(705, 14);
            this.p2ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(60, 40);
            this.p2ScoreLabel.TabIndex = 4;
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p1ScoreLabel.Location = new System.Drawing.Point(430, 14);
            this.p1ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(60, 40);
            this.p1ScoreLabel.TabIndex = 5;
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // x2Label
            // 
            this.x2Label.BackColor = System.Drawing.Color.Transparent;
            this.x2Label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2Label.ForeColor = System.Drawing.Color.LawnGreen;
            this.x2Label.Location = new System.Drawing.Point(560, 14);
            this.x2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.x2Label.Name = "x2Label";
            this.x2Label.Size = new System.Drawing.Size(60, 40);
            this.x2Label.TabIndex = 6;
            this.x2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 923);
            this.Controls.Add(this.x2Label);
            this.Controls.Add(this.p1ScoreLabel);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.winLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label x2Label;
    }
}

