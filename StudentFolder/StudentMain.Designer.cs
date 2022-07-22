namespace LibraryManagementSystem.StudentFolder
{
    partial class frmStudentMain
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
            this.pnlStudentMain = new System.Windows.Forms.Panel();
            this.btnStudentAccount = new System.Windows.Forms.Button();
            this.btnStuMyIteims = new System.Windows.Forms.Button();
            this.btnStudentBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlStudentMain
            // 
            this.pnlStudentMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStudentMain.Location = new System.Drawing.Point(27, 58);
            this.pnlStudentMain.Name = "pnlStudentMain";
            this.pnlStudentMain.Size = new System.Drawing.Size(542, 292);
            this.pnlStudentMain.TabIndex = 0;
            // 
            // btnStudentAccount
            // 
            this.btnStudentAccount.Location = new System.Drawing.Point(27, 12);
            this.btnStudentAccount.Name = "btnStudentAccount";
            this.btnStudentAccount.Size = new System.Drawing.Size(75, 23);
            this.btnStudentAccount.TabIndex = 1;
            this.btnStudentAccount.Text = "Account";
            this.btnStudentAccount.UseVisualStyleBackColor = true;
            this.btnStudentAccount.Click += new System.EventHandler(this.btnStudentAccount_Click);
            // 
            // btnStuMyIteims
            // 
            this.btnStuMyIteims.Location = new System.Drawing.Point(108, 12);
            this.btnStuMyIteims.Name = "btnStuMyIteims";
            this.btnStuMyIteims.Size = new System.Drawing.Size(75, 23);
            this.btnStuMyIteims.TabIndex = 1;
            this.btnStuMyIteims.Text = "My Items";
            this.btnStuMyIteims.UseVisualStyleBackColor = true;
            // 
            // btnStudentBooks
            // 
            this.btnStudentBooks.Location = new System.Drawing.Point(494, 12);
            this.btnStudentBooks.Name = "btnStudentBooks";
            this.btnStudentBooks.Size = new System.Drawing.Size(75, 23);
            this.btnStudentBooks.TabIndex = 2;
            this.btnStudentBooks.Text = "Books";
            this.btnStudentBooks.UseVisualStyleBackColor = true;
            this.btnStudentBooks.Click += new System.EventHandler(this.btnStudentBooks_Click);
            // 
            // frmStudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 362);
            this.Controls.Add(this.btnStudentBooks);
            this.Controls.Add(this.btnStuMyIteims);
            this.Controls.Add(this.btnStudentAccount);
            this.Controls.Add(this.pnlStudentMain);
            this.Name = "frmStudentMain";
            this.Text = "Student Main Page";
            this.Load += new System.EventHandler(this.frmStudentMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudentMain;
        private System.Windows.Forms.Button btnStudentAccount;
        private System.Windows.Forms.Button btnStuMyIteims;
        private System.Windows.Forms.Button btnStudentBooks;
    }
}