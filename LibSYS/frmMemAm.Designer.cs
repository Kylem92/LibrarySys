namespace LibSYS
{
    partial class frmMemAm
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSrh = new System.Windows.Forms.Button();
            this.txtSrhName = new System.Windows.Forms.TextBox();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.dataGrdMem = new System.Windows.Forms.DataGridView();
            this.grpMem = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtBooksOut = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdd3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegDate = new System.Windows.Forms.DateTimePicker();
            this.grpSearch.SuspendLayout();
            this.grpMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdMem)).BeginInit();
            this.grpMem.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 25);
            this.button2.TabIndex = 45;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSrh);
            this.grpSearch.Controls.Add(this.txtSrhName);
            this.grpSearch.Location = new System.Drawing.Point(36, 13);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(357, 43);
            this.grpSearch.TabIndex = 46;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Enter Member Surname";
            this.grpSearch.Enter += new System.EventHandler(this.grpSearch_Enter);
            // 
            // btnSrh
            // 
            this.btnSrh.Location = new System.Drawing.Point(179, 16);
            this.btnSrh.Name = "btnSrh";
            this.btnSrh.Size = new System.Drawing.Size(65, 19);
            this.btnSrh.TabIndex = 1;
            this.btnSrh.Text = "Search";
            this.btnSrh.UseVisualStyleBackColor = true;
            this.btnSrh.Click += new System.EventHandler(this.btnSrh_Click);
            // 
            // txtSrhName
            // 
            this.txtSrhName.Location = new System.Drawing.Point(11, 16);
            this.txtSrhName.Name = "txtSrhName";
            this.txtSrhName.Size = new System.Drawing.Size(141, 20);
            this.txtSrhName.TabIndex = 0;
            // 
            // grpMembers
            // 
            this.grpMembers.Controls.Add(this.dataGrdMem);
            this.grpMembers.Location = new System.Drawing.Point(38, 64);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(396, 96);
            this.grpMembers.TabIndex = 47;
            this.grpMembers.TabStop = false;
            this.grpMembers.Text = "SELECT MEMBER TO AMEND";
            this.grpMembers.Visible = false;
            this.grpMembers.Enter += new System.EventHandler(this.grpMembers_Enter);
            // 
            // dataGrdMem
            // 
            this.dataGrdMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdMem.Location = new System.Drawing.Point(9, 19);
            this.dataGrdMem.Name = "dataGrdMem";
            this.dataGrdMem.Size = new System.Drawing.Size(381, 71);
            this.dataGrdMem.TabIndex = 0;
            this.dataGrdMem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrdMem_CellContentClick);
            // 
            // grpMem
            // 
            this.grpMem.Controls.Add(this.txtRegDate);
            this.grpMem.Controls.Add(this.button1);
            this.grpMem.Controls.Add(this.txtStatus);
            this.grpMem.Controls.Add(this.txtBooksOut);
            this.grpMem.Controls.Add(this.txtId);
            this.grpMem.Controls.Add(this.label13);
            this.grpMem.Controls.Add(this.label12);
            this.grpMem.Controls.Add(this.label11);
            this.grpMem.Controls.Add(this.label10);
            this.grpMem.Controls.Add(this.txtEmail);
            this.grpMem.Controls.Add(this.label8);
            this.grpMem.Controls.Add(this.txtTel);
            this.grpMem.Controls.Add(this.label6);
            this.grpMem.Controls.Add(this.txtAdd3);
            this.grpMem.Controls.Add(this.label5);
            this.grpMem.Controls.Add(this.txtAdd2);
            this.grpMem.Controls.Add(this.label4);
            this.grpMem.Controls.Add(this.txtAdd1);
            this.grpMem.Controls.Add(this.label3);
            this.grpMem.Controls.Add(this.comGender);
            this.grpMem.Controls.Add(this.label9);
            this.grpMem.Controls.Add(this.txtSurname);
            this.grpMem.Controls.Add(this.label2);
            this.grpMem.Controls.Add(this.txtForename);
            this.grpMem.Controls.Add(this.label1);
            this.grpMem.Location = new System.Drawing.Point(36, 166);
            this.grpMem.Name = "grpMem";
            this.grpMem.Size = new System.Drawing.Size(406, 351);
            this.grpMem.TabIndex = 48;
            this.grpMem.TabStop = false;
            this.grpMem.Text = "Amend Details";
            this.grpMem.Visible = false;
            this.grpMem.Enter += new System.EventHandler(this.grpMem_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 26);
            this.button1.TabIndex = 70;
            this.button1.Text = "Amend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(284, 281);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(64, 20);
            this.txtStatus.TabIndex = 69;
            // 
            // txtBooksOut
            // 
            this.txtBooksOut.Enabled = false;
            this.txtBooksOut.Location = new System.Drawing.Point(165, 284);
            this.txtBooksOut.Name = "txtBooksOut";
            this.txtBooksOut.ReadOnly = true;
            this.txtBooksOut.Size = new System.Drawing.Size(41, 20);
            this.txtBooksOut.TabIndex = 68;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(16, 41);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(54, 20);
            this.txtId.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 64;
            this.label12.Text = "Books out";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "Registration Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Member_Id";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Email Address";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(110, 184);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 20);
            this.txtTel.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Telephone No.";
            // 
            // txtAdd3
            // 
            this.txtAdd3.Location = new System.Drawing.Point(110, 158);
            this.txtAdd3.Name = "txtAdd3";
            this.txtAdd3.Size = new System.Drawing.Size(185, 20);
            this.txtAdd3.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Address Line 3";
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(110, 128);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(185, 20);
            this.txtAdd2.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Address Line 2";
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(110, 102);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(185, 20);
            this.txtAdd1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Address Line 1";
            // 
            // comGender
            // 
            this.comGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGender.FormattingEnabled = true;
            this.comGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comGender.Location = new System.Drawing.Point(204, 64);
            this.comGender.MaxDropDownItems = 2;
            this.comGender.Name = "comGender";
            this.comGender.Size = new System.Drawing.Size(81, 21);
            this.comGender.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Gender";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(204, 38);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(122, 20);
            this.txtSurname.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Surname";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(204, 16);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(122, 20);
            this.txtForename.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Forename";
            // 
            // txtRegDate
            // 
            this.txtRegDate.Location = new System.Drawing.Point(133, 315);
            this.txtRegDate.Name = "txtRegDate";
            this.txtRegDate.Size = new System.Drawing.Size(123, 20);
            this.txtRegDate.TabIndex = 71;
            // 
            // frmMemAm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 555);
            this.Controls.Add(this.grpMem);
            this.Controls.Add(this.grpMembers);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.button2);
            this.Name = "frmMemAm";
            this.Text = "LibSys - [Amend Member]";
            this.Load += new System.EventHandler(this.frmMemAm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdMem)).EndInit();
            this.grpMem.ResumeLayout(false);
            this.grpMem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSrh;
        private System.Windows.Forms.TextBox txtSrhName;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.GroupBox grpMem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtBooksOut;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdd3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comGender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrdMem;
        private System.Windows.Forms.DateTimePicker txtRegDate;
    }
}