namespace LibSYS
{
    partial class frmBookAmend
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
            this.btn_Amend = new System.Windows.Forms.Button();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.grdBook = new System.Windows.Forms.DataGridView();
            this.radBtnTitle = new System.Windows.Forms.RadioButton();
            this.radBtnId = new System.Windows.Forms.RadioButton();
            this.radBtnAuthor = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Amend
            // 
            this.btn_Amend.Location = new System.Drawing.Point(72, 460);
            this.btn_Amend.Name = "btn_Amend";
            this.btn_Amend.Size = new System.Drawing.Size(75, 23);
            this.btn_Amend.TabIndex = 32;
            this.btn_Amend.Text = "Amend";
            this.btn_Amend.UseVisualStyleBackColor = true;
            this.btn_Amend.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(72, 429);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(41, 20);
            this.txtBookId.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Book_Id";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(72, 348);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(144, 20);
            this.txtGenre.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Genre";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(72, 313);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(144, 20);
            this.txtAuthor.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(72, 275);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(144, 20);
            this.txtTitle.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "ISBN";
            this.label6.UseMnemonic = false;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(72, 382);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(87, 20);
            this.txtISBN.TabIndex = 35;
            // 
            // grdBook
            // 
            this.grdBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBook.Location = new System.Drawing.Point(31, 99);
            this.grdBook.Name = "grdBook";
            this.grdBook.Size = new System.Drawing.Size(267, 151);
            this.grdBook.TabIndex = 36;
            this.grdBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radBtnTitle
            // 
            this.radBtnTitle.AutoSize = true;
            this.radBtnTitle.Location = new System.Drawing.Point(171, 63);
            this.radBtnTitle.Name = "radBtnTitle";
            this.radBtnTitle.Size = new System.Drawing.Size(45, 17);
            this.radBtnTitle.TabIndex = 37;
            this.radBtnTitle.TabStop = true;
            this.radBtnTitle.Text = "Title";
            this.radBtnTitle.UseVisualStyleBackColor = true;
            this.radBtnTitle.CheckedChanged += new System.EventHandler(this.radBtnTitle_CheckedChanged);
            // 
            // radBtnId
            // 
            this.radBtnId.AutoSize = true;
            this.radBtnId.Location = new System.Drawing.Point(100, 63);
            this.radBtnId.Name = "radBtnId";
            this.radBtnId.Size = new System.Drawing.Size(59, 17);
            this.radBtnId.TabIndex = 38;
            this.radBtnId.TabStop = true;
            this.radBtnId.Text = "BookId";
            this.radBtnId.UseVisualStyleBackColor = true;
            this.radBtnId.CheckedChanged += new System.EventHandler(this.radBtnId_CheckedChanged);
            // 
            // radBtnAuthor
            // 
            this.radBtnAuthor.AutoSize = true;
            this.radBtnAuthor.Location = new System.Drawing.Point(242, 63);
            this.radBtnAuthor.Name = "radBtnAuthor";
            this.radBtnAuthor.Size = new System.Drawing.Size(56, 17);
            this.radBtnAuthor.TabIndex = 39;
            this.radBtnAuthor.TabStop = true;
            this.radBtnAuthor.Text = "Author";
            this.radBtnAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radBtnAuthor.UseVisualStyleBackColor = true;
            this.radBtnAuthor.CheckedChanged += new System.EventHandler(this.radBtnAuthor_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Sort by:";
            // 
            // frmBookAmend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 513);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radBtnAuthor);
            this.Controls.Add(this.radBtnId);
            this.Controls.Add(this.radBtnTitle);
            this.Controls.Add(this.grdBook);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Amend);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.MinimizeBox = false;
            this.Name = "frmBookAmend";
            this.Text = "LibSys - [Amend Book]";
            this.Load += new System.EventHandler(this.frmBookAmend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Amend;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.DataGridView grdBook;
        private System.Windows.Forms.RadioButton radBtnTitle;
        private System.Windows.Forms.RadioButton radBtnId;
        private System.Windows.Forms.RadioButton radBtnAuthor;
        private System.Windows.Forms.Label label7;
    }
}