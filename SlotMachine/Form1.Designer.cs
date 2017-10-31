namespace SlotMachine
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
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.credit = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.bet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            this.SuspendLayout();
            // 
            // slot1
            // 
            this.slot1.Location = new System.Drawing.Point(158, 99);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(150, 150);
            this.slot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slot1.TabIndex = 0;
            this.slot1.TabStop = false;
            // 
            // slot3
            // 
            this.slot3.Location = new System.Drawing.Point(470, 99);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(150, 150);
            this.slot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slot3.TabIndex = 1;
            this.slot3.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.Location = new System.Drawing.Point(314, 99);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(150, 150);
            this.slot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slot2.TabIndex = 2;
            this.slot2.TabStop = false;
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(155, 71);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(37, 13);
            this.credit.TabIndex = 3;
            this.credit.Text = "Credit:";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Location = new System.Drawing.Point(467, 71);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(29, 13);
            this.win.TabIndex = 4;
            this.win.Text = "Win:";
            // 
            // bet
            // 
            this.bet.AutoSize = true;
            this.bet.Location = new System.Drawing.Point(311, 71);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(26, 13);
            this.bet.TabIndex = 5;
            this.bet.Text = "Bet:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(502, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 20);
            this.textBox3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.win);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label bet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

