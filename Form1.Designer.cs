namespace Part_8___Hang_Man_Lite_Project
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
            this.imgHang = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstGuessedLetters = new System.Windows.Forms.ListBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).BeginInit();
            this.SuspendLayout();
            // 
            // imgHang
            // 
            this.imgHang.Image = global::Part_8___Hang_Man_Lite_Project.Properties.Resources.hangman_empty;
            this.imgHang.Location = new System.Drawing.Point(18, 59);
            this.imgHang.Name = "imgHang";
            this.imgHang.Size = new System.Drawing.Size(219, 187);
            this.imgHang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHang.TabIndex = 0;
            this.imgHang.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Hand-Man Lite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter a letter to reveal the hidden word. 3 strikes and you are out!";
            // 
            // lstGuessedLetters
            // 
            this.lstGuessedLetters.FormattingEnabled = true;
            this.lstGuessedLetters.Location = new System.Drawing.Point(247, 86);
            this.lstGuessedLetters.Name = "lstGuessedLetters";
            this.lstGuessedLetters.Size = new System.Drawing.Size(138, 134);
            this.lstGuessedLetters.TabIndex = 3;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(247, 226);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(54, 20);
            this.txtGuess.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Used Letters";
            // 
            // btnGuess
            // 
            this.btnGuess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuess.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(307, 226);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(78, 20);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(12, 249);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(392, 73);
            this.lblWord.TabIndex = 7;
            this.lblWord.Text = "_ _ _ _ _ _ _";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lstGuessedLetters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgHang);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstGuessedLetters;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblWord;
    }
}

