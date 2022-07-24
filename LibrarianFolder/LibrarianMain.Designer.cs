namespace LibraryManagementSystem
{
    partial class frmLibrarianMain
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
            this.btnLibAccount = new System.Windows.Forms.Button();
            this.btnLibBook = new System.Windows.Forms.Button();
            this.btnLibStudent = new System.Windows.Forms.Button();
            this.pnlLibMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnLibAccount
            // 
            this.btnLibAccount.Location = new System.Drawing.Point(22, 12);
            this.btnLibAccount.Name = "btnLibAccount";
            this.btnLibAccount.Size = new System.Drawing.Size(75, 23);
            this.btnLibAccount.TabIndex = 0;
            this.btnLibAccount.Text = "Account";
            this.btnLibAccount.UseVisualStyleBackColor = true;
            this.btnLibAccount.Click += new System.EventHandler(this.btnLibAccount_Click);
            // 
            // btnLibBook
            // 
            this.btnLibBook.Location = new System.Drawing.Point(121, 12);
            this.btnLibBook.Name = "btnLibBook";
            this.btnLibBook.Size = new System.Drawing.Size(75, 23);
            this.btnLibBook.TabIndex = 0;
            this.btnLibBook.Text = "Books";
            this.btnLibBook.UseVisualStyleBackColor = true;
            this.btnLibBook.Click += new System.EventHandler(this.btnLibBook_Click);
            // 
            // btnLibStudent
            // 
            this.btnLibStudent.Location = new System.Drawing.Point(219, 12);
            this.btnLibStudent.Name = "btnLibStudent";
            this.btnLibStudent.Size = new System.Drawing.Size(75, 23);
            this.btnLibStudent.TabIndex = 0;
            this.btnLibStudent.Text = "Students";
            this.btnLibStudent.UseVisualStyleBackColor = true;
            this.btnLibStudent.Click += new System.EventHandler(this.btnLibStudent_Click);
            // 
            // pnlLibMain
            // 
            this.pnlLibMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLibMain.Location = new System.Drawing.Point(22, 58);
            this.pnlLibMain.Name = "pnlLibMain";
            this.pnlLibMain.Size = new System.Drawing.Size(542, 292);
            this.pnlLibMain.TabIndex = 1;
            // 
            // frmLibrarianMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 362);
            this.Controls.Add(this.pnlLibMain);
            this.Controls.Add(this.btnLibStudent);
            this.Controls.Add(this.btnLibBook);
            this.Controls.Add(this.btnLibAccount);
            this.Name = "frmLibrarianMain";
            this.Text = "Librarian Main Page";
            this.Load += new System.EventHandler(this.frmLibrarianMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLibAccount;
        private System.Windows.Forms.Button btnLibBook;
        private System.Windows.Forms.Button btnLibStudent;
        private System.Windows.Forms.Panel pnlLibMain;
    }
}