namespace LibraryManagementSystem.StudentFolder
{
    partial class frmStudentBooksList
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
            this.dgvStudentBookList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudentBookList
            // 
            this.dgvStudentBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentBookList.Location = new System.Drawing.Point(12, 12);
            this.dgvStudentBookList.Name = "dgvStudentBookList";
            this.dgvStudentBookList.Size = new System.Drawing.Size(516, 243);
            this.dgvStudentBookList.TabIndex = 0;
            this.dgvStudentBookList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentBookList_CellDoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click to add the book to your account.\r\n";
            // 
            // frmStudentBooksList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudentBookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentBooksList";
            this.Text = "StudentBooksList";
            this.Load += new System.EventHandler(this.frmStudentBooksList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentBookList;
        private System.Windows.Forms.Label label1;
    }
}