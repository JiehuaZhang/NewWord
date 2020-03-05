namespace NewWord.Windows.TabControls
{
    partial class BooksTab
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
            this.lblCurrentBook = new System.Windows.Forms.Label();
            this.treeBooks = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblCurrentBook
            // 
            this.lblCurrentBook.AutoSize = true;
            this.lblCurrentBook.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrentBook.Location = new System.Drawing.Point(150, 168);
            this.lblCurrentBook.Name = "lblCurrentBook";
            this.lblCurrentBook.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentBook.TabIndex = 4;
            this.lblCurrentBook.Text = "label1";
            // 
            // treeBooks
            // 
            this.treeBooks.Location = new System.Drawing.Point(24, 3);
            this.treeBooks.Name = "treeBooks";
            this.treeBooks.Size = new System.Drawing.Size(207, 162);
            this.treeBooks.TabIndex = 3;
            this.treeBooks.Leave += new System.EventHandler(this.Book_Leave);
            this.treeBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Book_Select);
            // 
            // BooksTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCurrentBook);
            this.Controls.Add(this.treeBooks);
            this.Name = "BooksTab";
            this.Size = new System.Drawing.Size(255, 184);
            this.Load += new System.EventHandler(this.BooksTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentBook;
        private System.Windows.Forms.TreeView treeBooks;
    }
}
