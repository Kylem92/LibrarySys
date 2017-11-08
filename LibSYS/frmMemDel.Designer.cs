namespace LibSYS
{
    partial class frmMemDel
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
            this.txtRegDate = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpMembers = new System.Windows.Forms.GroupBox();
            this.dataGrdMem = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSrh = new System.Windows.Forms.Button();
            this.txtSrhName = new System.Windows.Forms.TextBox();
            this.grpMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdMem)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 28);
            this.button2.TabIndex = 73;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 72;
            this.button1.Text = "Inactivate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(262, 254);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(64, 20);
            this.txtStatus.TabIndex = 71;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // txtRegDate
            // 
            this.txtRegDate.Location = new System.Drawing.Point(319, 213);
            this.txtRegDate.Name = "txtRegDate";
            this.txtRegDate.ReadOnly = true;
            this.txtRegDate.Size = new System.Drawing.Size(100, 20);
            this.txtRegDate.TabIndex = 69;
            this.txtRegDate.TextChanged += new System.EventHandler(this.txtRegDate_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(143, 213);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(49, 20);
            this.txtId.TabIndex = 68;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(213, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "Status";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Registration Date";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Member_Id No.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // grpMembers
            // 
            this.grpMembers.Controls.Add(this.dataGrdMem);
            this.grpMembers.Location = new System.Drawing.Point(44, 94);
            this.grpMembers.Name = "grpMembers";
            this.grpMembers.Size = new System.Drawing.Size(354, 94);
            this.grpMembers.TabIndex = 75;
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
            this.dataGrdMem.Size = new System.Drawing.Size(336, 64);
            this.dataGrdMem.TabIndex = 0;
            this.dataGrdMem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrdMem_CellContentClick);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSrh);
            this.grpSearch.Controls.Add(this.txtSrhName);
            this.grpSearch.Location = new System.Drawing.Point(42, 43);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(357, 46);
            this.grpSearch.TabIndex = 74;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Enter Member Surname";
            this.grpSearch.Enter += new System.EventHandler(this.grpSearch_Enter);
            // 
            // btnSrh
            // 
            this.btnSrh.Location = new System.Drawing.Point(179, 16);
            this.btnSrh.Name = "btnSrh";
            this.btnSrh.Size = new System.Drawing.Size(65, 22);
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
            this.txtSrhName.TextChanged += new System.EventHandler(this.txtSrhName_TextChanged);
            // 
            // frmMemDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 370);
            this.Controls.Add(this.grpMembers);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtRegDate);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "frmMemDel";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmMemDel_Load);
            this.grpMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdMem)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtRegDate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpMembers;
        private System.Windows.Forms.DataGridView dataGrdMem;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSrh;
        private System.Windows.Forms.TextBox txtSrhName;
    }
}