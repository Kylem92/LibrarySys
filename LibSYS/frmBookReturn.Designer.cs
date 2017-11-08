namespace LibSYS
{
    partial class frmBookReturn
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtRentalId = new System.Windows.Forms.TextBox();
            this.grpRentals = new System.Windows.Forms.GroupBox();
            this.dataGrdRent = new System.Windows.Forms.DataGridView();
            this.grpRentSearch = new System.Windows.Forms.GroupBox();
            this.btnSrhRent = new System.Windows.Forms.Button();
            this.txtSrhRent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtLoan = new System.Windows.Forms.DateTimePicker();
            this.txtDue = new System.Windows.Forms.DateTimePicker();
            this.txtReturn = new System.Windows.Forms.DateTimePicker();
            this.grpRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdRent)).BeginInit();
            this.grpRentSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 107;
            this.label11.Text = "Rental_Id";
            // 
            // txtRentalId
            // 
            this.txtRentalId.Location = new System.Drawing.Point(104, 202);
            this.txtRentalId.Name = "txtRentalId";
            this.txtRentalId.ReadOnly = true;
            this.txtRentalId.Size = new System.Drawing.Size(61, 20);
            this.txtRentalId.TabIndex = 99;
            // 
            // grpRentals
            // 
            this.grpRentals.Controls.Add(this.dataGrdRent);
            this.grpRentals.Location = new System.Drawing.Point(34, 86);
            this.grpRentals.Name = "grpRentals";
            this.grpRentals.Size = new System.Drawing.Size(526, 96);
            this.grpRentals.TabIndex = 119;
            this.grpRentals.TabStop = false;
            this.grpRentals.Text = "SELECT RENTAL";
            this.grpRentals.Visible = false;
            // 
            // dataGrdRent
            // 
            this.dataGrdRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdRent.Location = new System.Drawing.Point(6, 19);
            this.dataGrdRent.Name = "dataGrdRent";
            this.dataGrdRent.Size = new System.Drawing.Size(514, 71);
            this.dataGrdRent.TabIndex = 0;
            this.dataGrdRent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrdRent_CellClick);
            this.dataGrdRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrdRent_CellContentClick);
            // 
            // grpRentSearch
            // 
            this.grpRentSearch.Controls.Add(this.btnSrhRent);
            this.grpRentSearch.Controls.Add(this.txtSrhRent);
            this.grpRentSearch.Location = new System.Drawing.Point(34, 28);
            this.grpRentSearch.Name = "grpRentSearch";
            this.grpRentSearch.Size = new System.Drawing.Size(357, 43);
            this.grpRentSearch.TabIndex = 118;
            this.grpRentSearch.TabStop = false;
            this.grpRentSearch.Text = "Enter Rental Id";
            // 
            // btnSrhRent
            // 
            this.btnSrhRent.Location = new System.Drawing.Point(181, 18);
            this.btnSrhRent.Name = "btnSrhRent";
            this.btnSrhRent.Size = new System.Drawing.Size(65, 19);
            this.btnSrhRent.TabIndex = 1;
            this.btnSrhRent.Text = "Search";
            this.btnSrhRent.UseVisualStyleBackColor = true;
            this.btnSrhRent.Click += new System.EventHandler(this.btnSrhMem_Click);
            // 
            // txtSrhRent
            // 
            this.txtSrhRent.Location = new System.Drawing.Point(11, 16);
            this.txtSrhRent.Name = "txtSrhRent";
            this.txtSrhRent.Size = new System.Drawing.Size(141, 20);
            this.txtSrhRent.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 120;
            this.label14.Text = "Loan Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(250, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 121;
            this.label16.Text = "Due Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(454, 243);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 122;
            this.label17.Text = "Return Date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 127;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(197, 315);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 126;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "Member_Id";
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(285, 202);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.ReadOnly = true;
            this.txtMemId.Size = new System.Drawing.Size(61, 20);
            this.txtMemId.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 131;
            this.label2.Text = "Book_Id";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(473, 202);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(61, 20);
            this.txtBookId.TabIndex = 130;
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(34, 259);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(136, 20);
            this.txtLoan.TabIndex = 132;
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(224, 259);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(145, 20);
            this.txtDue.TabIndex = 133;
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(417, 259);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(143, 20);
            this.txtReturn.TabIndex = 134;
            // 
            // frmBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 350);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.grpRentals);
            this.Controls.Add(this.grpRentSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRentalId);
            this.Name = "frmBookReturn";
            this.Text = "LibSys-[Return Book]";
            this.Load += new System.EventHandler(this.frmBookReturn_Load);
            this.grpRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdRent)).EndInit();
            this.grpRentSearch.ResumeLayout(false);
            this.grpRentSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRentalId;
        private System.Windows.Forms.GroupBox grpRentals;
        private System.Windows.Forms.DataGridView dataGrdRent;
        private System.Windows.Forms.GroupBox grpRentSearch;
        private System.Windows.Forms.Button btnSrhRent;
        private System.Windows.Forms.TextBox txtSrhRent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.DateTimePicker txtLoan;
        private System.Windows.Forms.DateTimePicker txtDue;
        private System.Windows.Forms.DateTimePicker txtReturn;

    }
}