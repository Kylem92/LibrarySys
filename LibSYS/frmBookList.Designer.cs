namespace LibSYS
{
    partial class frmBookList
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
            this.butPrint = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.grdBook = new System.Windows.Forms.DataGridView();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.optBookID = new System.Windows.Forms.RadioButton();
            this.optAuthor = new System.Windows.Forms.RadioButton();
            this.optTitle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).BeginInit();
            this.grpSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(97, 303);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(85, 28);
            this.butPrint.TabIndex = 5;
            this.butPrint.Text = "Print";
            this.butPrint.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(204, 303);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(90, 27);
            this.butCancel.TabIndex = 6;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // grdBook
            // 
            this.grdBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBook.Location = new System.Drawing.Point(26, 75);
            this.grdBook.Name = "grdBook";
            this.grdBook.Size = new System.Drawing.Size(331, 197);
            this.grdBook.TabIndex = 7;
            this.grdBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBook_CellContentClick);
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.optBookID);
            this.grpSort.Controls.Add(this.optAuthor);
            this.grpSort.Controls.Add(this.optTitle);
            this.grpSort.Location = new System.Drawing.Point(26, 11);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(337, 58);
            this.grpSort.TabIndex = 9;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Select Sort Order";
            // 
            // optBookID
            // 
            this.optBookID.AutoSize = true;
            this.optBookID.Checked = true;
            this.optBookID.Location = new System.Drawing.Point(56, 26);
            this.optBookID.Name = "optBookID";
            this.optBookID.Size = new System.Drawing.Size(62, 17);
            this.optBookID.TabIndex = 11;
            this.optBookID.TabStop = true;
            this.optBookID.Text = "Book Id";
            this.optBookID.UseVisualStyleBackColor = true;
            this.optBookID.Click += new System.EventHandler(this.optBookID_Click);
            // 
            // optAuthor
            // 
            this.optAuthor.AutoSize = true;
            this.optAuthor.Location = new System.Drawing.Point(224, 26);
            this.optAuthor.Name = "optAuthor";
            this.optAuthor.Size = new System.Drawing.Size(56, 17);
            this.optAuthor.TabIndex = 10;
            this.optAuthor.Text = "Author";
            this.optAuthor.UseVisualStyleBackColor = true;
            this.optAuthor.Click += new System.EventHandler(this.optAuthor_Click);
            // 
            // optTitle
            // 
            this.optTitle.AutoSize = true;
            this.optTitle.Location = new System.Drawing.Point(157, 26);
            this.optTitle.Name = "optTitle";
            this.optTitle.Size = new System.Drawing.Size(45, 17);
            this.optTitle.TabIndex = 9;
            this.optTitle.Text = "Title";
            this.optTitle.UseVisualStyleBackColor = true;
            this.optTitle.Click += new System.EventHandler(this.optTitle_Click);
            // 
            // frmBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 351);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.grdBook);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butPrint);
            this.Name = "frmBookList";
            this.Text = "LibSys - [List Books]";
            this.Load += new System.EventHandler(this.frmBookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).EndInit();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butPrint;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.DataGridView grdBook;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton optBookID;
        private System.Windows.Forms.RadioButton optAuthor;
        private System.Windows.Forms.RadioButton optTitle;
    }
}