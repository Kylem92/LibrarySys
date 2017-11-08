namespace LibSYS
{
    partial class frmMainMenu
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemAmd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemDereg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemList = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuNewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuLate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMembers,
            this.booksToolStripMenuItem,
            this.rentalsToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(356, 24);
            this.mnuMain.TabIndex = 18;
            this.mnuMain.Text = "menuStrip1";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // mnuMembers
            // 
            this.mnuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMemNew,
            this.mnuMemAmd,
            this.mnuMemDereg,
            this.mnuMemList});
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Size = new System.Drawing.Size(69, 20);
            this.mnuMembers.Text = "Members";
            this.mnuMembers.Click += new System.EventHandler(this.mnuMembers_Click);
            // 
            // mnuMemNew
            // 
            this.mnuMemNew.Name = "mnuMemNew";
            this.mnuMemNew.Size = new System.Drawing.Size(161, 22);
            this.mnuMemNew.Text = "New  Member";
            this.mnuMemNew.Click += new System.EventHandler(this.mnuMemNew_Click);
            // 
            // mnuMemAmd
            // 
            this.mnuMemAmd.Name = "mnuMemAmd";
            this.mnuMemAmd.Size = new System.Drawing.Size(161, 22);
            this.mnuMemAmd.Text = "Amend Member";
            this.mnuMemAmd.Click += new System.EventHandler(this.mnuMemAmd_Click);
            // 
            // mnuMemDereg
            // 
            this.mnuMemDereg.Name = "mnuMemDereg";
            this.mnuMemDereg.Size = new System.Drawing.Size(161, 22);
            this.mnuMemDereg.Text = "Deregister";
            this.mnuMemDereg.Click += new System.EventHandler(this.mnuMemDereg_Click);
            // 
            // mnuMemList
            // 
            this.mnuMemList.Name = "mnuMemList";
            this.mnuMemList.Size = new System.Drawing.Size(161, 22);
            this.mnuMemList.Text = "List Members";
            this.mnuMemList.Click += new System.EventHandler(this.mnuMemList_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuNewBook,
            this.toolStripMenuAmend,
            this.toolStripMenuRemove,
            this.toolStripMenuList});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // toolStripMenuNewBook
            // 
            this.toolStripMenuNewBook.Name = "toolStripMenuNewBook";
            this.toolStripMenuNewBook.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuNewBook.Text = "New Book";
            this.toolStripMenuNewBook.Click += new System.EventHandler(this.toolStripMenuNewBook_Click);
            // 
            // toolStripMenuAmend
            // 
            this.toolStripMenuAmend.Name = "toolStripMenuAmend";
            this.toolStripMenuAmend.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuAmend.Text = "Amend Book";
            this.toolStripMenuAmend.Click += new System.EventHandler(this.toolStripMenuAmend_Click);
            // 
            // toolStripMenuRemove
            // 
            this.toolStripMenuRemove.Name = "toolStripMenuRemove";
            this.toolStripMenuRemove.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuRemove.Text = "Remove Book";
            this.toolStripMenuRemove.Click += new System.EventHandler(this.toolStripMenuRemove_Click);
            // 
            // toolStripMenuList
            // 
            this.toolStripMenuList.Name = "toolStripMenuList";
            this.toolStripMenuList.Size = new System.Drawing.Size(147, 22);
            this.toolStripMenuList.Text = "List Books";
            this.toolStripMenuList.Click += new System.EventHandler(this.toolStripMenuList_Click);
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem1.Text = "Book Loan";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Book Return";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem3.Text = "Overdue Books";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuLate,
            this.toolStripMenuAnalysis,
            this.toolStripMenuItem4});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            this.analysisToolStripMenuItem.Click += new System.EventHandler(this.analysisToolStripMenuItem_Click);
            // 
            // toolStripMenuLate
            // 
            this.toolStripMenuLate.Name = "toolStripMenuLate";
            this.toolStripMenuLate.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuLate.Text = "Issue Late Notice";
            this.toolStripMenuLate.Click += new System.EventHandler(this.toolStripMenuLate_Click);
            // 
            // toolStripMenuAnalysis
            // 
            this.toolStripMenuAnalysis.Name = "toolStripMenuAnalysis";
            this.toolStripMenuAnalysis.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuAnalysis.Text = "Member Analysis";
            this.toolStripMenuAnalysis.Click += new System.EventHandler(this.toolStripMenuAnalysis_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem4.Text = "Rental Analysis";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibSYS.Properties.Resources.imagesQFBBFUFC;
            this.pictureBox1.Location = new System.Drawing.Point(1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuMemNew;
        private System.Windows.Forms.ToolStripMenuItem mnuMemAmd;
        private System.Windows.Forms.ToolStripMenuItem mnuMemDereg;
        private System.Windows.Forms.ToolStripMenuItem mnuMemList;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuNewBook;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAmend;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRemove;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuLate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAnalysis;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}