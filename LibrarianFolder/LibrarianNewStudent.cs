using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.LibrarianFolder
{
    public partial class frmLibrarianNewStudent : Form
    {
        public frmLibrarianNewStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student.students.Add(new Student()
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                email = txtEmail.Text,
                adress = txtAdress.Text,
                password = Convert.ToInt32(txtPassword.Text),
                id = Convert.ToInt32(txtId.Text)
            });

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Clear();

            frmLibrarianStudentInfo frmStudentInfo = new frmLibrarianStudentInfo()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            ((Panel)Application.OpenForms["frmLibrarianMain"].Controls["pnlLibMain"]).Controls.Add(frmStudentInfo);
            frmStudentInfo.Show();
        }
    }
}
