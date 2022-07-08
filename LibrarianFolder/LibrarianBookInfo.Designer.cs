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
            // 
            // frmLibBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 292);
            this.Controls.Add(this.dgwBookInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibBookInfo";
            this.Text = "LibrarianBookInfo";
            this.Load += new System.EventHandler(this.frmLibBookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBookInfo;
    }
}