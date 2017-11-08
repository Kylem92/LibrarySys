namespace LibSYS
{
    partial class frmOverdue
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
            this.grdOverdue = new System.Windows.Forms.DataGridView();
            this.txtRentalId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdOverdue)).BeginInit();
            this.SuspendLayout();
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(178, 396);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(119, 28);
            this.butPrint.TabIndex = 61;
            this.butPrint.Text = "Print";
            this.butPrint.UseVisualStyleBackColor = true;
            this.butPrint.Click += new System.EventHandler(this.butPrint_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(335, 396);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(90, 27);
            this.butCancel.TabIndex = 62;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // grdOverdue
            // 
            this.grdOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOverdue.Location = new System.Drawing.Point(15, 66);
            this.grdOverdue.Name = "grdOverdue";
            this.grdOverdue.Size = new System.Drawing.Size(601, 250);
            this.grdOverdue.TabIndex = 63;
            this.grdOverdue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOverdue_CellContentClick);
            // 
            // txtRentalId
            // 
            this.txtRentalId.Location = new System.Drawing.Point(106, 342);
            this.txtRentalId.Name = "txtRentalId";
            this.txtRentalId.ReadOnly = true;
            this.txtRentalId.Size = new System.Drawing.Size(72, 20);
            this.txtRentalId.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Member_Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Rental_Id";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(533, 338);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(68, 20);
            this.txtBookId.TabIndex = 67;
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(323, 342);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.ReadOnly = true;
            this.txtMemId.Size = new System.Drawing.Size(71, 20);
            this.txtMemId.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Book_Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(22, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Overdue Rentals";
            // 
            // frmOverdue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemId);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtRentalId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdOverdue);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butPrint);
            this.Name = "frmOverdue";
            this.Text = "LibSys - [Overdue]";
            this.Load += new System.EventHandler(this.frmOverdue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOverdue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butPrint;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.DataGridView grdOverdue;
        private System.Windows.Forms.TextBox txtRentalId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}