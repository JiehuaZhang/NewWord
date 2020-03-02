﻿namespace NewWord.Windows
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
            this.lblNext = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.lblHidden = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.Label();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numDifficulty = new System.Windows.Forms.NumericUpDown();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblNewWord = new System.Windows.Forms.Label();
            this.txtNewWord = new System.Windows.Forms.TextBox();
            this.tabArrange = new System.Windows.Forms.TabPage();
            this.lblSplityByDifficulty = new System.Windows.Forms.Label();
            this.btnSplitByDifficulty = new System.Windows.Forms.Button();
            this.lblSplit = new System.Windows.Forms.Label();
            this.btnSplitWords = new System.Windows.Forms.Button();
            this.lblArrange1 = new System.Windows.Forms.Label();
            this.btnArrange1 = new System.Windows.Forms.Button();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.lblCurrentBook = new System.Windows.Forms.Label();
            this.treeBooks = new System.Windows.Forms.TreeView();
            this.lblCount = new System.Windows.Forms.Label();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 266);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCard
            // 
            this.tabCard.Controls.Add(this.lblCount);
            this.tabCard.Controls.Add(this.lblNext);
            this.tabCard.Controls.Add(this.lblPrevious);
            this.tabCard.Controls.Add(this.lblIndex);
            this.tabCard.Controls.Add(this.lblBookName);
            this.tabCard.Controls.Add(this.lblDifficulty);
            this.tabCard.Controls.Add(this.btnAgain);
            this.tabCard.Controls.Add(this.lblHidden);
            this.tabCard.Controls.Add(this.btnYes);
            this.tabCard.Controls.Add(this.btnNo);
            this.tabCard.Controls.Add(this.txtWord);
            this.tabCard.Location = new System.Drawing.Point(4, 25);
            this.tabCard.Margin = new System.Windows.Forms.Padding(4);
            this.tabCard.Name = "tabCard";
            this.tabCard.Padding = new System.Windows.Forms.Padding(4);
            this.tabCard.Size = new System.Drawing.Size(341, 237);
            this.tabCard.TabIndex = 0;
            this.tabCard.Text = "Card";
            this.tabCard.UseVisualStyleBackColor = true;
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(303, 49);
            this.lblNext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(20, 20);
            this.lblNext.TabIndex = 15;
            this.lblNext.Text = ">";
            this.lblNext.Click += new System.EventHandler(this.LblNext_Click);
            this.lblNext.MouseLeave += new System.EventHandler(this.LabelChangeColor_MouseLeave);
            this.lblNext.MouseHover += new System.EventHandler(this.LabelChangeColor_MouseHover);
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(8, 49);
            this.lblPrevious.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(20, 20);
            this.lblPrevious.TabIndex = 14;
            this.lblPrevious.Text = "<";
            this.lblPrevious.Click += new System.EventHandler(this.LblPrevious_Click);
            this.lblPrevious.MouseLeave += new System.EventHandler(this.LabelChangeColor_MouseLeave);
            this.lblPrevious.MouseHover += new System.EventHandler(this.LabelChangeColor_MouseHover);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndex.Location = new System.Drawing.Point(27, 196);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(35, 21);
            this.lblIndex.TabIndex = 13;
            this.lblIndex.Text = "n/a";
            // 
            // lblBookName
            // 
            this.lblBookName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBookName.Location = new System.Drawing.Point(187, 196);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(116, 28);
            this.lblBookName.TabIndex = 12;
            this.lblBookName.Text = "n/a";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(19, 10);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(112, 29);
            this.lblDifficulty.TabIndex = 11;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.Orange;
            this.btnAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgain.ForeColor = System.Drawing.Color.White;
            this.btnAgain.Location = new System.Drawing.Point(121, 129);
            this.btnAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(100, 49);
            this.btnAgain.TabIndex = 10;
            this.btnAgain.Text = "Again";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.BtnAgain_Click);
            // 
            // lblHidden
            // 
            this.lblHidden.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHidden.Location = new System.Drawing.Point(31, 89);
            this.lblHidden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(267, 25);
            this.lblHidden.TabIndex = 9;
            this.lblHidden.Text = "Hidden";
            this.lblHidden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHidden.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(203, 129);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(100, 49);
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
            this.btnNo.Location = new System.Drawing.Point(31, 129);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 49);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(31, 39);
            this.txtWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(272, 40);
            this.txtWord.TabIndex = 6;
            this.txtWord.Text = "label1ghp";
            this.txtWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(4);
            this.tabAdd.Size = new System.Drawing.Size(341, 237);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add";
            this.tabAdd.UseVisualStyleBackColor = true;
            this.tabAdd.Click += new System.EventHandler(this.TabAdd_Click);
            this.tabAdd.Enter += new System.EventHandler(this.TabAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(200, 176);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // numDifficulty
            // 
            this.numDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDifficulty.Location = new System.Drawing.Point(87, 119);
            this.numDifficulty.Margin = new System.Windows.Forms.Padding(4);
            this.numDifficulty.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDifficulty.Name = "numDifficulty";
            this.numDifficulty.Size = new System.Drawing.Size(213, 23);
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
            this.lblRate.Location = new System.Drawing.Point(11, 128);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(61, 17);
            this.lblRate.TabIndex = 4;
            this.lblRate.Text = "Difficulty";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.Location = new System.Drawing.Point(87, 74);
            this.txtMeaning.Margin = new System.Windows.Forms.Padding(4);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(212, 23);
            this.txtMeaning.TabIndex = 3;
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Location = new System.Drawing.Point(11, 78);
            this.lblMeaning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(62, 17);
            this.lblMeaning.TabIndex = 2;
            this.lblMeaning.Text = "Meaning";
            // 
            // lblNewWord
            // 
            this.lblNewWord.AutoSize = true;
            this.lblNewWord.Location = new System.Drawing.Point(11, 30);
            this.lblNewWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewWord.Name = "lblNewWord";
            this.lblNewWord.Size = new System.Drawing.Size(42, 17);
            this.lblNewWord.TabIndex = 1;
            this.lblNewWord.Text = "Word";
            // 
            // txtNewWord
            // 
            this.txtNewWord.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewWord.Location = new System.Drawing.Point(87, 21);
            this.txtNewWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewWord.Name = "txtNewWord";
            this.txtNewWord.Size = new System.Drawing.Size(212, 34);
            this.txtNewWord.TabIndex = 0;
            // 
            // tabArrange
            // 
            this.tabArrange.Controls.Add(this.lblSplityByDifficulty);
            this.tabArrange.Controls.Add(this.btnSplitByDifficulty);
            this.tabArrange.Controls.Add(this.lblSplit);
            this.tabArrange.Controls.Add(this.btnSplitWords);
            this.tabArrange.Controls.Add(this.lblArrange1);
            this.tabArrange.Controls.Add(this.btnArrange1);
            this.tabArrange.Location = new System.Drawing.Point(4, 25);
            this.tabArrange.Margin = new System.Windows.Forms.Padding(4);
            this.tabArrange.Name = "tabArrange";
            this.tabArrange.Padding = new System.Windows.Forms.Padding(4);
            this.tabArrange.Size = new System.Drawing.Size(341, 237);
            this.tabArrange.TabIndex = 2;
            this.tabArrange.Text = "Arrange";
            this.tabArrange.UseVisualStyleBackColor = true;
            // 
            // lblSplityByDifficulty
            // 
            this.lblSplityByDifficulty.AutoSize = true;
            this.lblSplityByDifficulty.Location = new System.Drawing.Point(49, 211);
            this.lblSplityByDifficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSplityByDifficulty.Name = "lblSplityByDifficulty";
            this.lblSplityByDifficulty.Size = new System.Drawing.Size(45, 17);
            this.lblSplityByDifficulty.TabIndex = 18;
            this.lblSplityByDifficulty.Text = "Done!";
            this.lblSplityByDifficulty.Visible = false;
            // 
            // btnSplitByDifficulty
            // 
            this.btnSplitByDifficulty.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSplitByDifficulty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSplitByDifficulty.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitByDifficulty.ForeColor = System.Drawing.Color.White;
            this.btnSplitByDifficulty.Location = new System.Drawing.Point(41, 156);
            this.btnSplitByDifficulty.Margin = new System.Windows.Forms.Padding(4);
            this.btnSplitByDifficulty.Name = "btnSplitByDifficulty";
            this.btnSplitByDifficulty.Size = new System.Drawing.Size(257, 52);
            this.btnSplitByDifficulty.TabIndex = 17;
            this.btnSplitByDifficulty.Text = "Split words by difficulty";
            this.btnSplitByDifficulty.UseVisualStyleBackColor = false;
            this.btnSplitByDifficulty.Click += new System.EventHandler(this.BtnSplitByDifficulty_Click);
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Location = new System.Drawing.Point(49, 135);
            this.lblSplit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(45, 17);
            this.lblSplit.TabIndex = 16;
            this.lblSplit.Text = "Done!";
            this.lblSplit.Visible = false;
            // 
            // btnSplitWords
            // 
            this.btnSplitWords.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSplitWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSplitWords.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitWords.ForeColor = System.Drawing.Color.White;
            this.btnSplitWords.Location = new System.Drawing.Point(41, 80);
            this.btnSplitWords.Margin = new System.Windows.Forms.Padding(4);
            this.btnSplitWords.Name = "btnSplitWords";
            this.btnSplitWords.Size = new System.Drawing.Size(257, 52);
            this.btnSplitWords.TabIndex = 15;
            this.btnSplitWords.Text = "Split words by read count";
            this.btnSplitWords.UseVisualStyleBackColor = false;
            this.btnSplitWords.Click += new System.EventHandler(this.BtnSplitWords_Click);
            // 
            // lblArrange1
            // 
            this.lblArrange1.AutoSize = true;
            this.lblArrange1.Location = new System.Drawing.Point(49, 60);
            this.lblArrange1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrange1.Name = "lblArrange1";
            this.lblArrange1.Size = new System.Drawing.Size(45, 17);
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
            this.btnArrange1.Location = new System.Drawing.Point(41, 7);
            this.btnArrange1.Margin = new System.Windows.Forms.Padding(4);
            this.btnArrange1.Name = "btnArrange1";
            this.btnArrange1.Size = new System.Drawing.Size(257, 49);
            this.btnArrange1.TabIndex = 13;
            this.btnArrange1.Text = "Remove Remembered Word";
            this.btnArrange1.UseVisualStyleBackColor = false;
            this.btnArrange1.Click += new System.EventHandler(this.BtnArrange1_Click);
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.lblCurrentBook);
            this.tabBooks.Controls.Add(this.treeBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 25);
            this.tabBooks.Margin = new System.Windows.Forms.Padding(4);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(4);
            this.tabBooks.Size = new System.Drawing.Size(341, 237);
            this.tabBooks.TabIndex = 3;
            this.tabBooks.Text = "Book";
            this.tabBooks.UseVisualStyleBackColor = true;
            this.tabBooks.Enter += new System.EventHandler(this.Book_Fresh);
            // 
            // lblCurrentBook
            // 
            this.lblCurrentBook.AutoSize = true;
            this.lblCurrentBook.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrentBook.Location = new System.Drawing.Point(187, 210);
            this.lblCurrentBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentBook.Name = "lblCurrentBook";
            this.lblCurrentBook.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentBook.TabIndex = 2;
            this.lblCurrentBook.Text = "label1";
            // 
            // treeBooks
            // 
            this.treeBooks.Location = new System.Drawing.Point(19, 7);
            this.treeBooks.Margin = new System.Windows.Forms.Padding(4);
            this.treeBooks.Name = "treeBooks";
            this.treeBooks.Size = new System.Drawing.Size(275, 198);
            this.treeBooks.TabIndex = 1;
            this.treeBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Book_Select);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCount.Location = new System.Drawing.Point(286, 20);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(28, 17);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "n/a";
            // 
            // CombinedWordCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 262);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CombinedWordCard";
            this.Text = "NewWord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Card_Closing);
            this.Load += new System.EventHandler(this.WordCard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCard.ResumeLayout(false);
            this.tabCard.PerformLayout();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDifficulty)).EndInit();
            this.tabArrange.ResumeLayout(false);
            this.tabArrange.PerformLayout();
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
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
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblCurrentBook;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblSplityByDifficulty;
        private System.Windows.Forms.Button btnSplitByDifficulty;
        private System.Windows.Forms.Label lblCount;
    }
}