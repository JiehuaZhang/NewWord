namespace NewWord.Windows
{
    partial class MainWindow
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
            this.tabControls = new System.Windows.Forms.TabControl();
            this.tabCard = new System.Windows.Forms.TabPage();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.tabWordControl = new System.Windows.Forms.TabPage();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.tabCard);
            this.tabControls.Controls.Add(this.tabAdd);
            this.tabControls.Controls.Add(this.tabWordControl);
            this.tabControls.Controls.Add(this.tabBooks);
            this.tabControls.Location = new System.Drawing.Point(0, 0);
            this.tabControls.Name = "tabControls";
            this.tabControls.SelectedIndex = 0;
            this.tabControls.Size = new System.Drawing.Size(263, 213);
            this.tabControls.TabIndex = 0;
            // 
            // tabCard
            // 
            this.tabCard.Location = new System.Drawing.Point(4, 22);
            this.tabCard.Name = "tabCard";
            this.tabCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabCard.Size = new System.Drawing.Size(255, 187);
            this.tabCard.TabIndex = 0;
            this.tabCard.Text = "Card";
            this.tabCard.UseVisualStyleBackColor = true;
            // 
            // tabAdd
            // 
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(255, 187);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "New";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // tabWordControl
            // 
            this.tabWordControl.Location = new System.Drawing.Point(4, 22);
            this.tabWordControl.Name = "tabWordControl";
            this.tabWordControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabWordControl.Size = new System.Drawing.Size(255, 187);
            this.tabWordControl.TabIndex = 2;
            this.tabWordControl.Text = "Control";
            this.tabWordControl.UseVisualStyleBackColor = true;
            // 
            // tabBooks
            // 
            this.tabBooks.Location = new System.Drawing.Point(4, 22);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(255, 187);
            this.tabBooks.TabIndex = 3;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            this.tabBooks.Enter += new System.EventHandler(this.BookList_Fresh);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 211);
            this.Controls.Add(this.tabControls);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_Closing);
            this.Load += new System.EventHandler(this.Window_Load);
            this.tabControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControls;
        private System.Windows.Forms.TabPage tabCard;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabWordControl;
        private System.Windows.Forms.TabPage tabBooks;
    }
}