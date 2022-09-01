namespace MSSABlackJack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DealerCard1 = new System.Windows.Forms.PictureBox();
            this.PlayerCard1 = new System.Windows.Forms.PictureBox();
            this.PlayerCard2 = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.hitMeButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SurrenderButton = new System.Windows.Forms.Button();
            this.SplitButton = new System.Windows.Forms.Button();
            this.DoubleButton = new System.Windows.Forms.Button();
            this.PlayerCard3 = new System.Windows.Forms.PictureBox();
            this.PlayerCard4 = new System.Windows.Forms.PictureBox();
            this.PlayerCard5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // DealerCard1
            // 
            this.DealerCard1.Location = new System.Drawing.Point(368, 29);
            this.DealerCard1.Name = "DealerCard1";
            this.DealerCard1.Size = new System.Drawing.Size(60, 92);
            this.DealerCard1.TabIndex = 11;
            this.DealerCard1.TabStop = false;
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.Location = new System.Drawing.Point(157, 202);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(60, 92);
            this.PlayerCard1.TabIndex = 12;
            this.PlayerCard1.TabStop = false;
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.Location = new System.Drawing.Point(170, 214);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(60, 92);
            this.PlayerCard2.TabIndex = 13;
            this.PlayerCard2.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Red;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(12, 395);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Deal";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // hitMeButton
            // 
            this.hitMeButton.BackColor = System.Drawing.Color.Red;
            this.hitMeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hitMeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hitMeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.hitMeButton.ForeColor = System.Drawing.Color.White;
            this.hitMeButton.Location = new System.Drawing.Point(174, 395);
            this.hitMeButton.Name = "hitMeButton";
            this.hitMeButton.Size = new System.Drawing.Size(75, 23);
            this.hitMeButton.TabIndex = 3;
            this.hitMeButton.Text = "Hit";
            this.hitMeButton.UseVisualStyleBackColor = false;
            this.hitMeButton.Click += new System.EventHandler(this.hitMeButton_Click);
            // 
            // StandButton
            // 
            this.StandButton.BackColor = System.Drawing.Color.Red;
            this.StandButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StandButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.StandButton.ForeColor = System.Drawing.Color.White;
            this.StandButton.Location = new System.Drawing.Point(93, 395);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(75, 23);
            this.StandButton.TabIndex = 2;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = false;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click1);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(713, 395);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // SurrenderButton
            // 
            this.SurrenderButton.BackColor = System.Drawing.Color.Red;
            this.SurrenderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SurrenderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SurrenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SurrenderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.SurrenderButton.ForeColor = System.Drawing.Color.White;
            this.SurrenderButton.Location = new System.Drawing.Point(255, 395);
            this.SurrenderButton.Name = "SurrenderButton";
            this.SurrenderButton.Size = new System.Drawing.Size(75, 23);
            this.SurrenderButton.TabIndex = 4;
            this.SurrenderButton.Text = "Surrender";
            this.SurrenderButton.UseVisualStyleBackColor = false;
            this.SurrenderButton.Click += new System.EventHandler(this.SurrenderButton_Click);
            // 
            // SplitButton
            // 
            this.SplitButton.BackColor = System.Drawing.Color.Red;
            this.SplitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SplitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SplitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SplitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.SplitButton.ForeColor = System.Drawing.Color.White;
            this.SplitButton.Location = new System.Drawing.Point(336, 395);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(75, 23);
            this.SplitButton.TabIndex = 5;
            this.SplitButton.Text = "Split";
            this.SplitButton.UseVisualStyleBackColor = false;
            this.SplitButton.Click += new System.EventHandler(this.SplitButton_Click_1);
            // 
            // DoubleButton
            // 
            this.DoubleButton.BackColor = System.Drawing.Color.Red;
            this.DoubleButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DoubleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DoubleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoubleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.DoubleButton.ForeColor = System.Drawing.Color.White;
            this.DoubleButton.Location = new System.Drawing.Point(417, 395);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(92, 23);
            this.DoubleButton.TabIndex = 6;
            this.DoubleButton.Text = "Double Down";
            this.DoubleButton.UseVisualStyleBackColor = false;
            this.DoubleButton.Click += new System.EventHandler(this.DoubleButton_Click_1);
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.Location = new System.Drawing.Point(180, 230);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Size = new System.Drawing.Size(60, 92);
            this.PlayerCard3.TabIndex = 25;
            this.PlayerCard3.TabStop = false;
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.Location = new System.Drawing.Point(192, 244);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Size = new System.Drawing.Size(60, 92);
            this.PlayerCard4.TabIndex = 26;
            this.PlayerCard4.TabStop = false;
            // 
            // PlayerCard5
            // 
            this.PlayerCard5.Location = new System.Drawing.Point(203, 259);
            this.PlayerCard5.Name = "PlayerCard5";
            this.PlayerCard5.Size = new System.Drawing.Size(60, 92);
            this.PlayerCard5.TabIndex = 27;
            this.PlayerCard5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerCard5);
            this.Controls.Add(this.PlayerCard4);
            this.Controls.Add(this.PlayerCard3);
            this.Controls.Add(this.DoubleButton);
            this.Controls.Add(this.SplitButton);
            this.Controls.Add(this.SurrenderButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.hitMeButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DealerCard1);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.PlayerCard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DealerCard1;
        private System.Windows.Forms.PictureBox PlayerCard1;
        private System.Windows.Forms.PictureBox PlayerCard2;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button hitMeButton;
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button SurrenderButton;
        private System.Windows.Forms.Button SplitButton;
        private System.Windows.Forms.Button DoubleButton;
        private System.Windows.Forms.PictureBox PlayerCard3;
        private System.Windows.Forms.PictureBox PlayerCard4;
        private System.Windows.Forms.PictureBox PlayerCard5;
    }
}

