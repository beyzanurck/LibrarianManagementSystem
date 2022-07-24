namespace LibraryManagementSystem.StudentFolder
{
    partial class frmStudentMyItemsPage
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
            this.dgvMyItemsList = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMyItemsList
            // 
            this.dgvMyItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyItemsList.Location = new System.Drawing.Point(12, 12);
            this.dgvMyItemsList.Name = "dgvMyItemsList";
            this.dgvMyItemsList.Size = new System.Drawing.Size(516, 237);
            this.dgvMyItemsList.TabIndex = 0;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(453, 255);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(372, 255);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(75, 23);
            this.btnRenew.TabIndex = 1;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // frmStudentMyItemsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 290);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvMyItemsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentMyItemsPage";
            this.Text = "StudentMyItemsPage";
            this.Load += new System.EventHandler(this.frmStudentMyItemsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyItemsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMyItemsList;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRenew;
    }
}