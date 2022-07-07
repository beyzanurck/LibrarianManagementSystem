namespace LibraryManagementSystem
{
    partial class frmLibAccountEdit
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
            this.lblLibFirstEdit = new System.Windows.Forms.Label();
            this.lblLibLastEdit = new System.Windows.Forms.Label();
            this.lblLibEmailEdit = new System.Windows.Forms.Label();
            this.lblLibAdEdit = new System.Windows.Forms.Label();
            this.lblLibPassEdit = new System.Windows.Forms.Label();
            this.txtFirstEdit = new System.Windows.Forms.TextBox();
            this.txtLastEdit = new System.Windows.Forms.TextBox();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.txtAddEdit = new System.Windows.Forms.TextBox();
            this.txtPassEdit = new System.Windows.Forms.TextBox();
            this.btnLibEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLibFirstEdit
            // 
            this.lblLibFirstEdit.AutoSize = true;
            this.lblLibFirstEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLibFirstEdit.Location = new System.Drawing.Point(148, 24);
            this.lblLibFirstEdit.Name = "lblLibFirstEdit";
            this.lblLibFirstEdit.Size = new System.Drawing.Size(79, 16);
            this.lblLibFirstEdit.TabIndex = 0;
            this.lblLibFirstEdit.Text = "First Name: ";
            // 
            // lblLibLastEdit
            // 
            this.lblLibLastEdit.AutoSize = true;
            this.lblLibLastEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLibLastEdit.Location = new System.Drawing.Point(148, 54);
            this.lblLibLastEdit.Name = "lblLibLastEdit";
            this.lblLibLastEdit.Size = new System.Drawing.Size(79, 16);
            this.lblLibLastEdit.TabIndex = 0;
            this.lblLibLastEdit.Text = "Last Name: ";
            // 
            // lblLibEmailEdit
            // 
            this.lblLibEmailEdit.AutoSize = true;
            this.lblLibEmailEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLibEmailEdit.Location = new System.Drawing.Point(148, 93);
            this.lblLibEmailEdit.Name = "lblLibEmailEdit";
            this.lblLibEmailEdit.Size = new System.Drawing.Size(48, 16);
            this.lblLibEmailEdit.TabIndex = 0;
            this.lblLibEmailEdit.Text = "Email: ";
            // 
            // lblLibAdEdit
            // 
            this.lblLibAdEdit.AutoSize = true;
            this.lblLibAdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLibAdEdit.Location = new System.Drawing.Point(148, 126);
            this.lblLibAdEdit.Name = "lblLibAdEdit";
            this.lblLibAdEdit.Size = new System.Drawing.Size(57, 16);
            this.lblLibAdEdit.TabIndex = 0;
            this.lblLibAdEdit.Text = "Adress: ";
            // 
            // lblLibPassEdit
            // 
            this.lblLibPassEdit.AutoSize = true;
            this.lblLibPassEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLibPassEdit.Location = new System.Drawing.Point(148, 163);
            this.lblLibPassEdit.Name = "lblLibPassEdit";
            this.lblLibPassEdit.Size = new System.Drawing.Size(74, 16);
            this.lblLibPassEdit.TabIndex = 0;
            this.lblLibPassEdit.Text = "Password: ";
            // 
            // txtFirstEdit
            // 
            this.txtFirstEdit.Location = new System.Drawing.Point(255, 24);
            this.txtFirstEdit.Name = "txtFirstEdit";
            this.txtFirstEdit.Size = new System.Drawing.Size(100, 20);
            this.txtFirstEdit.TabIndex = 1;
            // 
            // txtLastEdit
            // 
            this.txtLastEdit.Location = new System.Drawing.Point(255, 54);
            this.txtLastEdit.Name = "txtLastEdit";
            this.txtLastEdit.Size = new System.Drawing.Size(100, 20);
            this.txtLastEdit.TabIndex = 1;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(255, 93);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEmailEdit.TabIndex = 1;
            // 
            // txtAddEdit
            // 
            this.txtAddEdit.Location = new System.Drawing.Point(255, 122);
            this.txtAddEdit.Name = "txtAddEdit";
            this.txtAddEdit.Size = new System.Drawing.Size(100, 20);
            this.txtAddEdit.TabIndex = 1;
            // 
            // txtPassEdit
            // 
            this.txtPassEdit.Location = new System.Drawing.Point(255, 159);
            this.txtPassEdit.Name = "txtPassEdit";
            this.txtPassEdit.Size = new System.Drawing.Size(100, 20);
            this.txtPassEdit.TabIndex = 1;
            // 
            // btnLibEdit
            // 
            this.btnLibEdit.Location = new System.Drawing.Point(399, 179);
            this.btnLibEdit.Name = "btnLibEdit";
            this.btnLibEdit.Size = new System.Drawing.Size(75, 23);
            this.btnLibEdit.TabIndex = 2;
            this.btnLibEdit.Text = "Save";
            this.btnLibEdit.UseVisualStyleBackColor = true;
            this.btnLibEdit.Click += new System.EventHandler(this.btnLibEdit_Click);
            // 
            // frmLibAccountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 214);
            this.Controls.Add(this.btnLibEdit);
            this.Controls.Add(this.txtPassEdit);
            this.Controls.Add(this.txtAddEdit);
            this.Controls.Add(this.txtEmailEdit);
            this.Controls.Add(this.txtLastEdit);
            this.Controls.Add(this.txtFirstEdit);
            this.Controls.Add(this.lblLibPassEdit);
            this.Controls.Add(this.lblLibAdEdit);
            this.Controls.Add(this.lblLibEmailEdit);
            this.Controls.Add(this.lblLibLastEdit);
            this.Controls.Add(this.lblLibFirstEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibAccountEdit";
            this.Text = "Librarian Account Edit";
            this.Load += new System.EventHandler(this.frmLibAccountEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibFirstEdit;
        private System.Windows.Forms.Label lblLibLastEdit;
        private System.Windows.Forms.Label lblLibEmailEdit;
        private System.Windows.Forms.Label lblLibAdEdit;
        private System.Windows.Forms.Label lblLibPassEdit;
        private System.Windows.Forms.TextBox txtFirstEdit;
        private System.Windows.Forms.TextBox txtLastEdit;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.TextBox txtAddEdit;
        private System.Windows.Forms.TextBox txtPassEdit;
        private System.Windows.Forms.Button btnLibEdit;
    }
}