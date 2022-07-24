namespace LibraryManagementSystem.LibrarianFolder
{
    partial class frmLibBookInfo
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
            this.dgwBookInfo = new System.Windows.Forms.DataGridView();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBookInfo
            // 
            this.dgwBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookInfo.Location = new System.Drawing.Point(12, 12);
            this.dgwBookInfo.Name = "dgwBookInfo";
            this.dgwBookInfo.Size = new System.Drawing.Size(518, 227);
            this.dgwBookInfo.TabIndex = 0;
            this.dgwBookInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookInfo_CellDoubleClick);
            // 
            // btnNewBook
            // 
            this.btnNewBook.Location = new System.Drawing.Point(455, 257);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(75, 23);
            this.btnNewBook.TabIndex = 1;
            this.btnNewBook.Text = "New Book";
            this.btnNewBook.UseVisualStyleBackColor = true;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double click to edit the book.";
            // 
            // frmLibBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewBook);
            this.Controls.Add(this.dgwBookInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibBookInfo";
            this.Text = "LibrarianBookInfo";
            this.Load += new System.EventHandler(this.frmLibBookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgwBookInfo;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Label label1;
    }
}