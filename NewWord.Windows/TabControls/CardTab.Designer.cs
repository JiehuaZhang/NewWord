namespace NewWord.Windows.TabControls
{
    partial class CardTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCount = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblHidden = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCount.Location = new System.Drawing.Point(216, 16);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(24, 13);
            this.lblCount.TabIndex = 28;
            this.lblCount.Text = "n/a";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("NSimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(231, 43);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(20, 20);
            this.lblNext.TabIndex = 27;
            this.lblNext.Text = ">";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.Font = new System.Drawing.Font("NSimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevious.Location = new System.Drawing.Point(3, 43);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(20, 20);
            this.lblPrevious.TabIndex = 26;
            this.lblPrevious.Text = "<";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIndex.Location = new System.Drawing.Point(22, 159);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(24, 13);
            this.lblIndex.TabIndex = 25;
            this.lblIndex.Text = "n/a";
            // 
            // lblBookName
            // 
            this.lblBookName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBookName.Location = new System.Drawing.Point(133, 159);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(96, 25);
            this.lblBookName.TabIndex = 24;
            this.lblBookName.Text = "n/a";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(16, 8);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(87, 24);
            this.lblDifficulty.TabIndex = 23;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // lblHidden
            // 
            this.lblHidden.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHidden.Location = new System.Drawing.Point(25, 72);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(200, 20);
            this.lblHidden.TabIndex = 21;
            this.lblHidden.Text = "Hidden";
            this.lblHidden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHidden.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(154, 105);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 40);
            this.btnYes.TabIndex = 20;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.DarkRed;
            this.btnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(25, 105);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 40);
            this.btnNo.TabIndex = 19;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(25, 32);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(204, 32);
            this.txtWord.TabIndex = 18;
            this.txtWord.Text = "label1ghp";
            this.txtWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.txtWord);
            this.Name = "CardTab";
            this.Size = new System.Drawing.Size(255, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblHidden;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label txtWord;
    }
}
