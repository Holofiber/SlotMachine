namespace SlotMachine
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblCredit = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.bet = new System.Windows.Forms.Label();
            this.tbBet = new System.Windows.Forms.TextBox();
            this.tbCredit = new System.Windows.Forms.TextBox();
            this.tbWin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStatistic = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddCredit = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSpin = new System.Windows.Forms.Button();
            this.pbSlot2 = new System.Windows.Forms.PictureBox();
            this.pbSlot3 = new System.Windows.Forms.PictureBox();
            this.pbSlot1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCredit
            // 
            this.lblCredit.Location = new System.Drawing.Point(169, 18);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(50, 13);
            this.lblCredit.TabIndex = 3;
            this.lblCredit.Text = "Credit:";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Location = new System.Drawing.Point(323, 18);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(29, 13);
            this.win.TabIndex = 4;
            this.win.Text = "Win:";
            // 
            // bet
            // 
            this.bet.AutoSize = true;
            this.bet.Location = new System.Drawing.Point(15, 18);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(26, 13);
            this.bet.TabIndex = 5;
            this.bet.Text = "Bet:";
            // 
            // tbBet
            // 
            this.tbBet.Location = new System.Drawing.Point(47, 15);
            this.tbBet.MaxLength = 3;
            this.tbBet.Name = "tbBet";
            this.tbBet.Size = new System.Drawing.Size(68, 20);
            this.tbBet.TabIndex = 6;
            this.tbBet.Text = "5";
            this.tbBet.TextChanged += new System.EventHandler(this.tbBet_TextChanged);
            // 
            // tbCredit
            // 
            this.tbCredit.Location = new System.Drawing.Point(206, 15);
            this.tbCredit.Name = "tbCredit";
            this.tbCredit.ReadOnly = true;
            this.tbCredit.Size = new System.Drawing.Size(47, 20);
            this.tbCredit.TabIndex = 7;
            // 
            // tbWin
            // 
            this.tbWin.Location = new System.Drawing.Point(358, 11);
            this.tbWin.Name = "tbWin";
            this.tbWin.Size = new System.Drawing.Size(73, 20);
            this.tbWin.TabIndex = 8;
            this.tbWin.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "Bet x 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bet x 3";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 30;
            this.label4.Text = "Bet x 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Bet x 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Bet x 4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 36;
            this.label3.Text = "Bet x 1000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(769, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Win statistic";
            this.label7.Visible = false;
            // 
            // tbStatistic
            // 
            this.tbStatistic.AcceptsReturn = true;
            this.tbStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStatistic.Location = new System.Drawing.Point(772, 36);
            this.tbStatistic.Multiline = true;
            this.tbStatistic.Name = "tbStatistic";
            this.tbStatistic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStatistic.Size = new System.Drawing.Size(42, 133);
            this.tbStatistic.TabIndex = 41;
            this.tbStatistic.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.CausesValidation = false;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Image = global::SlotMachine.Properties.Resources.navigation_icons_67840;
            this.btnExit.Location = new System.Drawing.Point(326, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 155);
            this.btnExit.TabIndex = 38;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddCredit
            // 
            this.btnAddCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCredit.Image = global::SlotMachine.Properties.Resources.deposit;
            this.btnAddCredit.Location = new System.Drawing.Point(12, 202);
            this.btnAddCredit.Name = "btnAddCredit";
            this.btnAddCredit.Size = new System.Drawing.Size(152, 155);
            this.btnAddCredit.TabIndex = 37;
            this.btnAddCredit.Text = "Add 100 coins to Credit";
            this.btnAddCredit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCredit.UseVisualStyleBackColor = true;
            this.btnAddCredit.Click += new System.EventHandler(this.btnAddCredit_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SlotMachine.Properties.Resources._7;
            this.pictureBox10.Location = new System.Drawing.Point(636, 298);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(45, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 35;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::SlotMachine.Properties.Resources._2;
            this.pictureBox14.Location = new System.Drawing.Point(604, 242);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(50, 50);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 26;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SlotMachine.Properties.Resources._2;
            this.pictureBox6.Location = new System.Drawing.Point(660, 242);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SlotMachine.Properties.Resources._2;
            this.pictureBox5.Location = new System.Drawing.Point(716, 242);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.InitialImage = null;
            this.pictureBox13.Location = new System.Drawing.Point(604, 186);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(50, 50);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 23;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.InitialImage = null;
            this.pictureBox12.Location = new System.Drawing.Point(660, 186);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 50);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 22;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.InitialImage = null;
            this.pictureBox11.Location = new System.Drawing.Point(716, 186);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 50);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 21;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SlotMachine.Properties.Resources._2;
            this.pictureBox8.Location = new System.Drawing.Point(660, 130);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(660, 74);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = null;
            this.pictureBox7.Location = new System.Drawing.Point(604, 74);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(50, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SlotMachine.Properties.Resources._2;
            this.pictureBox3.Location = new System.Drawing.Point(604, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(604, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnSpin
            // 
            this.btnSpin.Image = ((System.Drawing.Image)(resources.GetObject("btnSpin.Image")));
            this.btnSpin.Location = new System.Drawing.Point(172, 202);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(150, 155);
            this.btnSpin.TabIndex = 9;
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // pbSlot2
            // 
            this.pbSlot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbSlot2.Location = new System.Drawing.Point(172, 46);
            this.pbSlot2.Name = "pbSlot2";
            this.pbSlot2.Size = new System.Drawing.Size(150, 150);
            this.pbSlot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlot2.TabIndex = 2;
            this.pbSlot2.TabStop = false;
            // 
            // pbSlot3
            // 
            this.pbSlot3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbSlot3.Location = new System.Drawing.Point(326, 46);
            this.pbSlot3.Name = "pbSlot3";
            this.pbSlot3.Size = new System.Drawing.Size(150, 150);
            this.pbSlot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlot3.TabIndex = 1;
            this.pbSlot3.TabStop = false;
            // 
            // pbSlot1
            // 
            this.pbSlot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbSlot1.Location = new System.Drawing.Point(14, 46);
            this.pbSlot1.Name = "pbSlot1";
            this.pbSlot1.Size = new System.Drawing.Size(150, 150);
            this.pbSlot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlot1.TabIndex = 0;
            this.pbSlot1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SlotMachine.Properties.Resources._7;
            this.pictureBox2.Location = new System.Drawing.Point(748, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SlotMachine.Properties.Resources._7;
            this.pictureBox9.Location = new System.Drawing.Point(692, 298);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 43;
            this.pictureBox9.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(838, 484);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbStatistic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddCredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.tbWin);
            this.Controls.Add(this.tbCredit);
            this.Controls.Add(this.tbBet);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.win);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.pbSlot2);
            this.Controls.Add(this.pbSlot3);
            this.Controls.Add(this.pbSlot1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlot1;
        private System.Windows.Forms.PictureBox pbSlot3;
        private System.Windows.Forms.PictureBox pbSlot2;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label bet;
        private System.Windows.Forms.TextBox tbBet;
        private System.Windows.Forms.TextBox tbCredit;
        private System.Windows.Forms.TextBox tbWin;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCredit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStatistic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

