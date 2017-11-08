namespace LibSYS
{
    partial class frmMemList
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
            this.optMemId = new System.Windows.Forms.RadioButton();
            this.optSurname = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.optForename = new System.Windows.Forms.RadioButton();
            this.optDate = new System.Windows.Forms.RadioButton();
            this.butCancel = new System.Windows.Forms.Button();
            this.butPrint = new System.Windows.Forms.Button();
            this.GrdMemList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMemList)).BeginInit();
            this.SuspendLayout();
            // 
            // optMemId
            // 
            this.optMemId.AutoSize = true;
            this.optMemId.Location = new System.Drawing.Point(75, 68);
            this.optMemId.Name = "optMemId";
            this.optMemId.Size = new System.Drawing.Size(78, 17);
            this.optMemId.TabIndex = 0;
            this.optMemId.TabStop = true;
            this.optMemId.Text = "Member_Id";
            this.optMemId.UseVisualStyleBackColor = true;
            this.optMemId.CheckedChanged += new System.EventHandler(this.optMemId_CheckedChanged);
            this.optMemId.Click += new System.EventHandler(this.optMemId_Click);
            // 
            // optSurname
            // 
            this.optSurname.AutoSize = true;
            this.optSurname.Location = new System.Drawing.Point(177, 68);
            this.optSurname.Name = "optSurname";
            this.optSurname.Size = new System.Drawing.Size(67, 17);
            this.optSurname.TabIndex = 1;
            this.optSurname.TabStop = true;
            this.optSurname.Text = "Surname";
            this.optSurname.UseVisualStyleBackColor = true;
            this.optSurname.Click += new System.EventHandler(this.optSurname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort By:";
            // 
            // optForename
            // 
            this.optForename.AutoSize = true;
            this.optForename.Location = new System.Drawing.Point(269, 68);
            this.optForename.Name = "optForename";
            this.optForename.Size = new System.Drawing.Size(72, 17);
            this.optForename.TabIndex = 4;
            this.optForename.TabStop = true;
            this.optForename.Text = "Forename";
            this.optForename.UseVisualStyleBackColor = true;
            this.optForename.Click += new System.EventHandler(this.optForename_Click);
            // 
            // optDate
            // 
            this.optDate.AutoSize = true;
            this.optDate.Location = new System.Drawing.Point(372, 70);
            this.optDate.Name = "optDate";
            this.optDate.Size = new System.Drawing.Size(71, 17);
            this.optDate.TabIndex = 5;
            this.optDate.TabStop = true;
            this.optDate.Text = "Reg Date";
            this.optDate.UseVisualStyleBackColor = true;
            this.optDate.Click += new System.EventHandler(this.optDate_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(251, 289);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(90, 27);
            this.butCancel.TabIndex = 8;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(131, 289);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(85, 28);
            this.butPrint.TabIndex = 7;
            this.butPrint.Text = "Print";
            this.butPrint.UseVisualStyleBackColor = true;
            // 
            // GrdMemList
            // 
            this.GrdMemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMemList.Location = new System.Drawing.Point(29, 103);
            this.GrdMemList.Name = "GrdMemList";
            this.GrdMemList.Size = new System.Drawing.Size(457, 168);
            this.GrdMemList.TabIndex = 9;
            this.GrdMemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmMemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 364);
            this.Controls.Add(this.GrdMemList);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butPrint);
            this.Controls.Add(this.optDate);
            this.Controls.Add(this.optForename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optSurname);
            this.Controls.Add(this.optMemId);
            this.Name = "frmMemList";
            this.Text = "LibSys - [List Members]";
            this.Load += new System.EventHandler(this.frmMemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdMemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optMemId;
        private System.Windows.Forms.RadioButton optSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optForename;
        private System.Windows.Forms.RadioButton optDate;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butPrint;
        private System.Windows.Forms.DataGridView GrdMemList;
    }
}