namespace LibraryManagementSystem.StudentFolder
{
    partial class frmStudentEditing
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
            this.txtStuEditingFirstName = new System.Windows.Forms.TextBox();
            this.txtStuEdiLastNa = new System.Windows.Forms.TextBox();
            this.txtStuEditEmail = new System.Windows.Forms.TextBox();
            this.txtStuEditAdress = new System.Windows.Forms.TextBox();
            this.txtStuEditPassword = new System.Windows.Forms.TextBox();
            this.btnStudentEditingSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(143, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(143, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(143, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adress: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(143, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password: ";
            // 
            // txtStuEditingFirstName
            // 
            this.txtStuEditingFirstName.Location = new System.Drawing.Point(239, 44);
            this.txtStuEditingFirstName.Name = "txtStuEditingFirstName";
            this.txtStuEditingFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtStuEditingFirstName.TabIndex = 1;
            // 
            // txtStuEdiLastNa
            // 
            this.txtStuEdiLastNa.Location = new System.Drawing.Point(239, 77);
            this.txtStuEdiLastNa.Name = "txtStuEdiLastNa";
            this.txtStuEdiLastNa.Size = new System.Drawing.Size(100, 20);
            this.txtStuEdiLastNa.TabIndex = 1;
            // 
            // txtStuEditEmail
            // 
            this.txtStuEditEmail.Location = new System.Drawing.Point(239, 115);
            this.txtStuEditEmail.Name = "txtStuEditEmail";
            this.txtStuEditEmail.Size = new System.Drawing.Size(100, 20);
            this.txtStuEditEmail.TabIndex = 1;
            // 
            // txtStuEditAdress
            // 
            this.txtStuEditAdress.Location = new System.Drawing.Point(239, 150);
            this.txtStuEditAdress.Name = "txtStuEditAdress";
            this.txtStuEditAdress.Size = new System.Drawing.Size(100, 20);
            this.txtStuEditAdress.TabIndex = 1;
            // 
            // txtStuEditPassword
            // 
            this.txtStuEditPassword.Location = new System.Drawing.Point(239, 182);
            this.txtStuEditPassword.Name = "txtStuEditPassword";
            this.txtStuEditPassword.Size = new System.Drawing.Size(100, 20);
            this.txtStuEditPassword.TabIndex = 1;
            // 
            // btnStudentEditingSave
            // 
            this.btnStudentEditingSave.Location = new System.Drawing.Point(392, 215);
            this.btnStudentEditingSave.Name = "btnStudentEditingSave";
            this.btnStudentEditingSave.Size = new System.Drawing.Size(75, 23);
            this.btnStudentEditingSave.TabIndex = 2;
            this.btnStudentEditingSave.Text = "Save";
            this.btnStudentEditingSave.UseVisualStyleBackColor = true;
            this.btnStudentEditingSave.Click += new System.EventHandler(this.btnStudentEditingSave_Click);
            // 
            // frmStudentEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 250);
            this.Controls.Add(this.btnStudentEditingSave);
            this.Controls.Add(this.txtStuEditPassword);
            this.Controls.Add(this.txtStuEditAdress);
            this.Controls.Add(this.txtStuEditEmail);
            this.Controls.Add(this.txtStuEdiLastNa);
            this.Controls.Add(this.txtStuEditingFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentEditing";
            this.Text = "Student Editing";
            this.Load += new System.EventHandler(this.frmStudentEditing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStuEditingFirstName;
        private System.Windows.Forms.TextBox txtStuEdiLastNa;
        private System.Windows.Forms.TextBox txtStuEditEmail;
        private System.Windows.Forms.TextBox txtStuEditAdress;
        private System.Windows.Forms.TextBox txtStuEditPassword;
        private System.Windows.Forms.Button btnStudentEditingSave;
    }
}