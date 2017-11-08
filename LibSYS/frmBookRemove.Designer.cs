namespace LibSYS
{
    partial class frmBookRemove
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSrh = new System.Windows.Forms.Button();
            this.txtSrhName = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.dataGrdMem = new System.Windows.Forms.DataGridView();
            this.grpSearch.SuspendLayout();
            this.grpMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdMem)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(229, 332);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(81, 20);
            this.txtStatus.TabIndex = 43;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(114, 332);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(50, 20);
            this.txtBookId.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Book_Id";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(114, 304);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(144, 20);
            this.txtAuthor.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(114, 275);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(144, 20);
            this.txtTitle.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Title";
            // 
            // btnSrh
            // 
            this.btnSrh.Location = new System.Drawing.Point(214, 19);
            this.btnSrh.Name = "btnSrh";
            this.btnSrh.Size = new System.Drawing.Size(65, 22);
            this.btnSrh.TabIndex = 1;
            this.btnSrh.Text = "Search";
            this.btnSrh.UseVisualStyleBackColor = true;
            this.btnSrh.Click += new System.EventHandler(this.btnSrh_Click);
            // 
            // txtSrhName
            // 
            this.txtSrhName.Location = new System.Drawing.Point(46, 19);
            this.txtSrhName.Name = "txtSrhName";
            this.txtSrhName.Size = new System.Drawing.Size(141, 20);
            this.txtSrhName.TabIndex = 0;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSrh);
            this.grpSearch.Controls.Add(this.txtSrhName);
            this.grpSearch.Location = new System.Drawing.Point(12, 29);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(357, 46);
            this.grpSearch.TabIndex = 75;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Enter Book Title";
            // 
            // grpMembers
            // 
            this.grpMembers.Controls.Add(this.dataGrdMem);
            this.grpMembers.Location = new System.Drawing.Point(15, 93);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(354, 157);
            this.grpMembers.TabIndex = 76;
            this.grpMembers.TabStop = false;
            this.grpMembers.Text = "SELECT MEMBER TO AMEND";
            this.grpMembers.Visible = false;
            // 
            // dataGrdMem
            // 
            this.dataGrdMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdMem.Location = new System.Drawing.Point(9, 19);
            this.dataGrdMem.Name = "dataGrdMem";
            this.dataGrdMem.Size = new System.Drawing.Size(336, 132);
            this.dataGrdMem.TabIndex = 0;
            this.dataGrdMem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrdMem_CellContentClick);
            // 
            // frmBookRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 429);
            this.Controls.Add(this.grpMembers);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Name = "frmBookRemove";
            this.Text = "LibSys - [Remove Book]";
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdMem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSrh;
        private System.Windows.Forms.TextBox txtSrhName;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.DataGridView dataGrdMem;
    }
}