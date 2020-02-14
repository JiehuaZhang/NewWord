namespace NewWord.Windows
{
    partial class CombinedWordCard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCard = new System.Windows.Forms.TabPage();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.lblHidden = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.Label();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.numDifficulty = new System.Windows.Forms.NumericUpDown();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblNewWord = new System.Windows.Forms.Label();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.tabArrange = new System.Windows.Forms.TabPage();
            this.lblArrange1 = new System.Windows.Forms.Label();
            this.btnArrange1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSplitWords = new System.Windows.Forms.Button();
            this.lblSplit = new System.Windows.Forms.Label();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.treeBooks = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabCard.SuspendLayout();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficulty)).BeginInit();
            this.tabArrange.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCard);
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Controls.Add(this.tabArrange);
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(262, 216);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.TabAdd_Click);
            // 
            // tabCard
            // 
            this.tabCard.Controls.Add(this.lblDifficulty);
            this.tabCard.Controls.Add(this.btnAgain);
            this.tabCard.Controls.Add(this.lblHidden);
            this.tabCard.Controls.Add(this.btnYes);
            this.tabCard.Controls.Add(this.btnNo);
            this.tabCard.Controls.Add(this.txtWord);
            this.tabCard.Location = new System.Drawing.Point(4, 22);
            this.tabCard.Name = "tabCard";
            this.tabCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabCard.Size = new System.Drawing.Size(254, 190);
            this.tabCard.TabIndex = 0;
            this.tabCard.Text = "Card";
            this.tabCard.UseVisualStyleBackColor = true;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(11, 13);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(87, 24);
            this.lblDifficulty.TabIndex = 11;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.Orange;
            this.btnAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgain.ForeColor = System.Drawing.Color.White;
            this.btnAgain.Location = new System.Drawing.Point(91, 105);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 40);
            this.btnAgain.TabIndex = 10;
            this.btnAgain.Text = "Again";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.BtnAgain_Click);
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHidden.Location = new System.Drawing.Point(100, 56);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(41, 13);
            this.lblHidden.TabIndex = 9;
            this.lblHidden.Text = "Hidden";
            this.lblHidden.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(152, 105);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 40);
            this.btnYes.TabIndex = 8;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.DarkRed;
            this.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(23, 105);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 40);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // txtWord
            // 
            this.txtWord.AutoSize = true;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(87, 27);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(60, 24);
            this.txtWord.TabIndex = 6;
            this.txtWord.Text = "label1";
            this.txtWord.Click += new System.EventHandler(this.TxtWord_Click);
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.btnUpdate);
            this.tabAdd.Controls.Add(this.numDifficulty);
            this.tabAdd.Controls.Add(this.lblRate);
            this.tabAdd.Controls.Add(this.txtMeaning);
            this.tabAdd.Controls.Add(this.lblMeaning);
            this.tabAdd.Controls.Add(this.lblNewWord);
            this.tabAdd.Controls.Add(this.txtNewWord);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(254, 190);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            this.tabAdd.Click += new System.EventHandler(this.TabAdd_Click);
            // 
            // numDifficulty
            // 
            this.numDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDifficulty.Location = new System.Drawing.Point(65, 97);
            this.numDifficulty.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDifficulty.Name = "numDifficulty";
            this.numDifficulty.Size = new System.Drawing.Size(160, 20);
            this.numDifficulty.TabIndex = 7;
            this.numDifficulty.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDifficulty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Difficulty_OnKeyPress);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(8, 104);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(47, 13);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "Difficulty";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.Location = new System.Drawing.Point(65, 60);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(160, 20);
            this.txtMeaning.TabIndex = 3;
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Location = new System.Drawing.Point(8, 63);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(48, 13);
            this.lblMeaning.TabIndex = 2;
            this.lblMeaning.Text = "Meaning";
            // 
            // lblNewWord
            // 
            this.lblNewWord.AutoSize = true;
            this.lblNewWord.Location = new System.Drawing.Point(8, 24);
            this.lblNewWord.Name = "lblNewWord";
            this.lblNewWord.Size = new System.Drawing.Size(33, 13);
            this.lblNewWord.TabIndex = 1;
            this.lblNewWord.Text = "Word";
            // 
            // txtNewWord
            // 
            this.txtNewWord.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewWord.Location = new System.Drawing.Point(65, 17);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(160, 28);
            this.txtNewWord.TabIndex = 0;
            // 
            // tabArrange
            // 
            this.tabArrange.Controls.Add(this.lblSplit);
            this.tabArrange.Controls.Add(this.btnSplitWords);
            this.tabArrange.Controls.Add(this.lblArrange1);
            this.tabArrange.Controls.Add(this.btnArrange1);
            this.tabArrange.Location = new System.Drawing.Point(4, 22);
            this.tabArrange.Name = "tabArrange";
            this.tabArrange.Padding = new System.Windows.Forms.Padding(3);
            this.tabArrange.Size = new System.Drawing.Size(254, 190);
            this.tabArrange.TabIndex = 2;
            this.tabArrange.Text = "Arrange";
            this.tabArrange.UseVisualStyleBackColor = true;
            // 
            // lblArrange1
            // 
            this.lblArrange1.AutoSize = true;
            this.lblArrange1.Location = new System.Drawing.Point(37, 49);
            this.lblArrange1.Name = "lblArrange1";
            this.lblArrange1.Size = new System.Drawing.Size(36, 13);
            this.lblArrange1.TabIndex = 14;
            this.lblArrange1.Text = "Done!";
            this.lblArrange1.Visible = false;
            // 
            // btnArrange1
            // 
            this.btnArrange1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnArrange1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArrange1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrange1.ForeColor = System.Drawing.Color.White;
            this.btnArrange1.Location = new System.Drawing.Point(31, 6);
            this.btnArrange1.Name = "btnArrange1";
            this.btnArrange1.Size = new System.Drawing.Size(193, 40);
            this.btnArrange1.TabIndex = 13;
            this.btnArrange1.Text = "Remove Remembered Word";
            this.btnArrange1.UseVisualStyleBackColor = false;
            this.btnArrange1.Click += new System.EventHandler(this.BtnArrange1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(150, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSplitWords
            // 
            this.btnSplitWords.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSplitWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSplitWords.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitWords.ForeColor = System.Drawing.Color.White;
            this.btnSplitWords.Location = new System.Drawing.Point(31, 65);
            this.btnSplitWords.Name = "btnSplitWords";
            this.btnSplitWords.Size = new System.Drawing.Size(193, 42);
            this.btnSplitWords.TabIndex = 15;
            this.btnSplitWords.Text = "Split words";
            this.btnSplitWords.UseVisualStyleBackColor = false;
            this.btnSplitWords.Click += new System.EventHandler(this.BtnSplitWords_Click);
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Location = new System.Drawing.Point(37, 110);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(36, 13);
            this.lblSplit.TabIndex = 16;
            this.lblSplit.Text = "Done!";
            this.lblSplit.Visible = false;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.treeBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(254, 190);
            this.tabBooks.TabIndex = 3;
            this.tabBooks.Text = "Book";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // treeBooks
            // 
            this.treeBooks.Location = new System.Drawing.Point(31, 17);
            this.treeBooks.Name = "treeBooks";
            this.treeBooks.Size = new System.Drawing.Size(8, 8);
            this.treeBooks.TabIndex = 1;
            // 
            // CombinedWordCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 209);
            this.Controls.Add(this.tabControl1);
            this.Name = "CombinedWordCard";
            this.Text = "CombinedWordCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Card_Closing);
            this.tabControl1.ResumeLayout(false);
            this.tabCard.ResumeLayout(false);
            this.tabCard.PerformLayout();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficulty)).EndInit();
            this.tabArrange.ResumeLayout(false);
            this.tabArrange.PerformLayout();
            this.tabBooks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCard;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblNewWord;
        private System.Windows.Forms.TextBox txtNewWord;
        private System.Windows.Forms.TabPage tabArrange;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label txtWord;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.NumericUpDown numDifficulty;
        private System.Windows.Forms.Button btnArrange1;
        private System.Windows.Forms.Label lblArrange1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSplitWords;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TreeView treeBooks;
    }
}