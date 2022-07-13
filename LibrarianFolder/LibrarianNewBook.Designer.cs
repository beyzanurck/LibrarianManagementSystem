namespace LibraryManagementSystem.LibrarianFolder
{
    partial class frmLibrarianNewBook
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
            this.txtAddNewName = new System.Windows.Forms.TextBox();
            this.txtAddNewAuthorName = new System.Windows.Forms.TextBox();
            this.txtAddNewQuantity = new System.Windows.Forms.TextBox();
            this.txtAddNewBarcodeNo = new System.Windows.Forms.TextBox();
            this.btnNewBookSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddNewName
            // 
            this.txtAddNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddNewName.Location = new System.Drawing.Point(153, 29);
            this.txtAddNewName.Name = "txtAddNewName";
            this.txtAddNewName.Size = new System.Drawing.Size(200, 20);
            this.txtAddNewName.TabIndex = 0;
            this.txtAddNewName.Text = "Name";
            // 
            // txtAddNewAuthorName
            // 
            this.txtAddNewAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddNewAuthorName.Location = new System.Drawing.Point(153, 55);
            this.txtAddNewAuthorName.Name = "txtAddNewAuthorName";
            this.txtAddNewAuthorName.Size = new System.Drawing.Size(200, 20);
            this.txtAddNewAuthorName.TabIndex = 0;
            this.txtAddNewAuthorName.Text = "Author Name";
            // 
            // txtAddNewQuantity
            // 
            this.txtAddNewQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddNewQuantity.Location = new System.Drawing.Point(153, 107);
            this.txtAddNewQuantity.Name = "txtAddNewQuantity";
            this.txtAddNewQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtAddNewQuantity.TabIndex = 0;
            this.txtAddNewQuantity.Text = "Quantity";
            // 
            // txtAddNewBarcodeNo
            // 
            this.txtAddNewBarcodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddNewBarcodeNo.Location = new System.Drawing.Point(153, 133);
            this.txtAddNewBarcodeNo.Name = "txtAddNewBarcodeNo";
            this.txtAddNewBarcodeNo.Size = new System.Drawing.Size(200, 20);
            this.txtAddNewBarcodeNo.TabIndex = 0;
            this.txtAddNewBarcodeNo.Text = "Barcode No";
            // 
            // btnNewBookSave
            // 
            this.btnNewBookSave.Location = new System.Drawing.Point(278, 170);
            this.btnNewBookSave.Name = "btnNewBookSave";
            this.btnNewBookSave.Size = new System.Drawing.Size(75, 23);
            this.btnNewBookSave.TabIndex = 1;
            this.btnNewBookSave.Text = "Add";
            this.btnNewBookSave.UseVisualStyleBackColor = true;
            this.btnNewBookSave.Click += new System.EventHandler(this.btnNewBookSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Publication Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Barcode No:";
            // 
            // frmLibrarianNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 214);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnNewBookSave);
            this.Controls.Add(this.txtAddNewBarcodeNo);
            this.Controls.Add(this.txtAddNewQuantity);
            this.Controls.Add(this.txtAddNewAuthorName);
            this.Controls.Add(this.txtAddNewName);
            this.Name = "frmLibrarianNewBook";
            this.Text = "Add New Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddNewName;
        private System.Windows.Forms.TextBox txtAddNewAuthorName;
        private System.Windows.Forms.TextBox txtAddNewQuantity;
        private System.Windows.Forms.TextBox txtAddNewBarcodeNo;
        private System.Windows.Forms.Button btnNewBookSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}