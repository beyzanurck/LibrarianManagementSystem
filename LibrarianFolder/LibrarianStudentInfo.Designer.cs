namespace LibraryManagementSystem.LibrarianFolder
{
    partial class frmLibrarianStudentInfo
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
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Location = new System.Drawing.Point(12, 12);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.Size = new System.Drawing.Size(515, 232);
            this.dgvStudentList.TabIndex = 0;
            this.dgvStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentList_CellDoubleClick);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(440, 250);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(87, 26);
            this.btnNewStudent.TabIndex = 1;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double click to see the books of student.\r\n";
            // 
            // frmLibrarianStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.dgvStudentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibrarianStudentInfo";
            this.Text = "LibrarianStudentInfo";
            this.Load += new System.EventHandler(this.frmLibrarianStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Label label1;
    }
}