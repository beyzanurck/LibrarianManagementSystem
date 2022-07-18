namespace LibraryManagementSystem.LibrarianFolder
{
    partial class frmLibBookEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.txtEditAuthorNa = new System.Windows.Forms.TextBox();
            this.txtQuantityEdit = new System.Windows.Forms.TextBox();
            this.txtEditBarcode = new System.Windows.Forms.TextBox();
            this.dateTimeEdit = new System.Windows.Forms.DateTimePicker();
            this.btnSaveEditing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Publication Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantity: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barcode No:";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(189, 26);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(200, 20);
            this.txtEditName.TabIndex = 1;
            // 
            // txtEditAuthorNa
            // 
            this.txtEditAuthorNa.Location = new System.Drawing.Point(189, 52);
            this.txtEditAuthorNa.Name = "txtEditAuthorNa";
            this.txtEditAuthorNa.Size = new System.Drawing.Size(200, 20);
            this.txtEditAuthorNa.TabIndex = 1;
            // 
            // txtQuantityEdit
            // 
            this.txtQuantityEdit.Location = new System.Drawing.Point(189, 100);
            this.txtQuantityEdit.Name = "txtQuantityEdit";
            this.txtQuantityEdit.Size = new System.Drawing.Size(200, 20);
            this.txtQuantityEdit.TabIndex = 1;
            // 
            // txtEditBarcode
            // 
            this.txtEditBarcode.Location = new System.Drawing.Point(189, 126);
            this.txtEditBarcode.Name = "txtEditBarcode";
            this.txtEditBarcode.Size = new System.Drawing.Size(200, 20);
            this.txtEditBarcode.TabIndex = 1;
            // 
            // dateTimeEdit
            // 
            this.dateTimeEdit.Location = new System.Drawing.Point(189, 78);
            this.dateTimeEdit.Name = "dateTimeEdit";
            this.dateTimeEdit.Size = new System.Drawing.Size(200, 20);
            this.dateTimeEdit.TabIndex = 2;
            // 
            // btnSaveEditing
            // 
            this.btnSaveEditing.Location = new System.Drawing.Point(354, 159);
            this.btnSaveEditing.Name = "btnSaveEditing";
            this.btnSaveEditing.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEditing.TabIndex = 3;
            this.btnSaveEditing.Text = "Save";
            this.btnSaveEditing.UseVisualStyleBackColor = true;
            this.btnSaveEditing.Click += new System.EventHandler(this.btnSaveEditing_Click);
            // 
            // frmLibBookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 194);
            this.Controls.Add(this.btnSaveEditing);
            this.Controls.Add(this.dateTimeEdit);
            this.Controls.Add(this.txtEditBarcode);
            this.Controls.Add(this.txtQuantityEdit);
            this.Controls.Add(this.txtEditAuthorNa);
            this.Controls.Add(this.txtEditName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLibBookEdit";
            this.Text = "Edit Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEditName;
        public System.Windows.Forms.TextBox txtEditAuthorNa;
        public System.Windows.Forms.TextBox txtQuantityEdit;
        public System.Windows.Forms.TextBox txtEditBarcode;
        public System.Windows.Forms.DateTimePicker dateTimeEdit;
        private System.Windows.Forms.Button btnSaveEditing;
    }
}