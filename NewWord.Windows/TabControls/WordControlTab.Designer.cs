namespace NewWord.Windows.TabControls
{
    partial class WordControlTab
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
            this.lblSplityByDifficulty = new System.Windows.Forms.Label();
            this.btnSplitByDifficulty = new System.Windows.Forms.Button();
            this.lblSplit = new System.Windows.Forms.Label();
            this.btnSplitWords = new System.Windows.Forms.Button();
            this.lblArrange1 = new System.Windows.Forms.Label();
            this.btnArrange1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSplityByDifficulty
            // 
            this.lblSplityByDifficulty.AutoSize = true;
            this.lblSplityByDifficulty.Location = new System.Drawing.Point(37, 168);
            this.lblSplityByDifficulty.Name = "lblSplityByDifficulty";
            this.lblSplityByDifficulty.Size = new System.Drawing.Size(36, 13);
            this.lblSplityByDifficulty.TabIndex = 24;
            this.lblSplityByDifficulty.Text = "Done!";
            this.lblSplityByDifficulty.Visible = false;
            // 
            // btnSplitByDifficulty
            // 
            this.btnSplitByDifficulty.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSplitByDifficulty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSplitByDifficulty.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitByDifficulty.ForeColor = System.Drawing.Color.White;
            this.btnSplitByDifficulty.Location = new System.Drawing.Point(31, 124);
            this.btnSplitByDifficulty.Name = "btnSplitByDifficulty";
            this.btnSplitByDifficulty.Size = new System.Drawing.Size(193, 42);
            this.btnSplitByDifficulty.TabIndex = 23;
            this.btnSplitByDifficulty.Text = "Split words by difficulty";
            this.btnSplitByDifficulty.UseVisualStyleBackColor = false;
            this.btnSplitByDifficulty.Click += new System.EventHandler(this.BtnSplitByDifficulty_Click);
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Location = new System.Drawing.Point(37, 107);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(36, 13);
            this.lblSplit.TabIndex = 22;
            this.lblSplit.Text = "Done!";
            this.lblSplit.Visible = false;
            // 
            // btnSplitWords
            // 
            this.btnSplitWords.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSplitWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSplitWords.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitWords.ForeColor = System.Drawing.Color.White;
            this.btnSplitWords.Location = new System.Drawing.Point(31, 62);
            this.btnSplitWords.Name = "btnSplitWords";
            this.btnSplitWords.Size = new System.Drawing.Size(193, 42);
            this.btnSplitWords.TabIndex = 21;
            this.btnSplitWords.Text = "Split words by read count";
            this.btnSplitWords.UseVisualStyleBackColor = false;
            this.btnSplitWords.Click += new System.EventHandler(this.BtnSplitWords_Click);
            // 
            // lblArrange1
            // 
            this.lblArrange1.AutoSize = true;
            this.lblArrange1.Location = new System.Drawing.Point(37, 46);
            this.lblArrange1.Name = "lblArrange1";
            this.lblArrange1.Size = new System.Drawing.Size(36, 13);
            this.lblArrange1.TabIndex = 20;
            this.lblArrange1.Text = "Done!";
            this.lblArrange1.Visible = false;
            // 
            // btnArrange1
            // 
            this.btnArrange1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnArrange1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArrange1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrange1.ForeColor = System.Drawing.Color.White;
            this.btnArrange1.Location = new System.Drawing.Point(31, 3);
            this.btnArrange1.Name = "btnArrange1";
            this.btnArrange1.Size = new System.Drawing.Size(193, 40);
            this.btnArrange1.TabIndex = 19;
            this.btnArrange1.Text = "Remove Remembered Word";
            this.btnArrange1.UseVisualStyleBackColor = false;
            this.btnArrange1.Click += new System.EventHandler(this.BtnArrange1_Click);
            // 
            // WordControlTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSplityByDifficulty);
            this.Controls.Add(this.btnSplitByDifficulty);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.btnSplitWords);
            this.Controls.Add(this.lblArrange1);
            this.Controls.Add(this.btnArrange1);
            this.Name = "WordControlTab";
            this.Size = new System.Drawing.Size(255, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplityByDifficulty;
        private System.Windows.Forms.Button btnSplitByDifficulty;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.Button btnSplitWords;
        private System.Windows.Forms.Label lblArrange1;
        private System.Windows.Forms.Button btnArrange1;
    }
}
