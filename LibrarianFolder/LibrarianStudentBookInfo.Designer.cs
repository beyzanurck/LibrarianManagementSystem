namespace LibraryManagementSystem.LibrarianFolder
{
    partial class frmLibrarianStudentBookInfo
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
            this.dgvBookInfoOfStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfoOfStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookInfoOfStudent
            // 
            this.dgvBookInfoOfStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfoOfStudent.Location = new System.Drawing.Point(12, 12);
            this.dgvBookInfoOfStudent.Name = "dgvBookInfoOfStudent";
            this.dgvBookInfoOfStudent.Size = new System.Drawing.Size(476, 196);
            this.dgvBookInfoOfStudent.TabIndex = 0;
            // 
            // frmLibrarianStudentBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 220);
            this.Controls.Add(this.dgvBookInfoOfStudent);
            this.Name = "frmLibrarianStudentBookInfo";
            this.Text = "Book Information Of The Student";
            this.Load += new System.EventHandler(this.frmLibrarianStudentBookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfoOfStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookInfoOfStudent;
    }
}