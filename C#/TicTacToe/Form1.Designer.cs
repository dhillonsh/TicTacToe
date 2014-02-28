namespace TicTacToe
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RetryButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(3, 37);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(85, 60);
            this.Button1.TabIndex = 0;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(3, 117);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(85, 60);
            this.Button4.TabIndex = 1;
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(3, 200);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(85, 60);
            this.Button7.TabIndex = 2;
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(107, 37);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(85, 60);
            this.Button2.TabIndex = 3;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(107, 117);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(85, 60);
            this.Button5.TabIndex = 4;
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(107, 200);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(85, 60);
            this.Button8.TabIndex = 5;
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(216, 37);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(85, 60);
            this.Button3.TabIndex = 6;
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(216, 117);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(85, 60);
            this.Button6.TabIndex = 7;
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(216, 200);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(85, 60);
            this.Button9.TabIndex = 8;
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Location = new System.Drawing.Point(114, 6);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(0, 13);
            this.MainLabel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(66, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // RetryButton
            // 
            this.RetryButton.Location = new System.Drawing.Point(216, 290);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(84, 31);
            this.RetryButton.TabIndex = 11;
            this.RetryButton.Text = "Play Again!";
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Visible = false;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreLabel.Location = new System.Drawing.Point(6, 299);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(0, 13);
            this.ScoreLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.TicTacToe_Board;
            this.ClientSize = new System.Drawing.Size(315, 322);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Label ScoreLabel;
    }
}

